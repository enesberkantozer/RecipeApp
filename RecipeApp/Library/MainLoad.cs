using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using RecipeApp.Databases;
using RecipeApp.Forms;
using RecipeApp.Models;
using RecipeApp.Templates;
using System.Xml.Linq;

namespace RecipeApp.Library
{
    public class MainLoad
    {

        private List<PanelTemp> panels = new List<PanelTemp>();
        private DbRecipe dbRecipe = new DbRecipe();
        private DbRecipeProduct dbRecipeProduct = new DbRecipeProduct();
        private DbProduct dbProduct = new DbProduct();
        public Dictionary<RecipeProduct, double> missingProducts = new Dictionary<RecipeProduct, double>();
        public List<PanelTemp> LoadResults(string? name = null, List<string>? category = null, int? minTime = 0, int? maxTime = int.MaxValue,
            double? minCost = 0, double? maxCost = double.MaxValue, Dictionary<Product,double>? products = null)
        {
            if (products.IsNullOrEmpty())
                products = new Dictionary<Product, double>();
            panels.Clear();
            List<Recipe> recipes = dbRecipe.SearchRecipe(
                name: name,
                category: category,
                minTime: minTime,
                maxTime: maxTime,
                minCost: minCost,
                maxCost: maxCost,
                products: products.Keys.ToList()
                );
            for (int i = 0; i < recipes.Count; i++)
            {
                Recipe t = recipes[i];
                PanelTemp panel = new PanelTemp(t,products);
                panels.Add(panel);
            }
            panels= panels.OrderByDescending(x => x.Percent).ToList();
            return panels;
        }

        public double GetCost(Recipe recipe)
        {
            double cost = 0;
            List<RecipeProduct> recipeProducts = dbRecipeProduct.GetWithRecipeId(recipe.Id);
            for (int i = 0; i < recipeProducts.Count; i++)
            {
                cost += recipeProducts[i].Product.CostPer * recipeProducts[i].ProductCost;
            }
            return Math.Round(cost, 2);
        }
        public double GetMissingCost(Recipe recipe, Dictionary<Product,double>? products)
        {
            if (products.IsNullOrEmpty())
            {
                products = new Dictionary<Product, double>();
                foreach (Product p in dbProduct.GetAll())
                {
                    double.TryParse(p.Total, out double d);
                    products.Add(p, d);
                }
            }
            double missingCost = 0;
            List<RecipeProduct> recipeProducts=dbRecipeProduct.GetWithRecipeId(recipe.Id);
            for(int i = 0; i < recipeProducts.Count; i++)
            {
                double data= products.Where(p => p.Key.Id == recipeProducts[i].Product.Id).Select(p => p.Value).FirstOrDefault();
                if (data!=0)
                {
                    missingCost += (recipeProducts[i].ProductCost - data) * recipeProducts[i].Product.CostPer;
                }
            }
            return Math.Round(missingCost, 2);
        }
        public double GetPercent(Recipe recipe, Dictionary<Product, double>? products)
        {
            missingProducts = new Dictionary<RecipeProduct, double>();
            if (products.IsNullOrEmpty())
            {
                products = new Dictionary<Product, double>();
                foreach (Product p in dbProduct.GetAll())
                {
                    double.TryParse(p.Total, out double d);
                    products.Add(p, d);
                }
            }
            double containsProductinRecipe = 0, totalProductinRecipe = 0;
            foreach (RecipeProduct rp in dbRecipeProduct.GetWithRecipeId(recipe.Id))
            {
                missingProducts.Add(rp, rp.ProductCost);
                totalProductinRecipe += rp.ProductCost;
                foreach (Product p in products.Keys.ToList())
                {
                    if (rp.Product.Equals(p))
                    {
                        if (rp.ProductCost <= products[p])
                        {
                            containsProductinRecipe += rp.ProductCost;
                            missingProducts.Remove(rp);
                        }
                        else
                        {
                            containsProductinRecipe += products[p];
                            missingProducts[rp] -= products[p];
                        }
                    }
                }
            }
            if (containsProductinRecipe > 0 && totalProductinRecipe > 0)
            {
                double result = (containsProductinRecipe / totalProductinRecipe) * 100;
                return Math.Round(result, 2);
            }
            return 0;
        }

        public static void InıtDatabase()
        {
            string dbPathDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "UserData", "Database");
            string dbPath = Path.Combine(dbPathDir, "Database.mdf");
            string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string detachString = @"
                    IF DB_ID('Database') IS NOT NULL
                    BEGIN
                        ALTER DATABASE [Database] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
                        EXEC sp_detach_db 'Database';
                    END";
                using (SqlCommand command = new SqlCommand(detachString, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
            if (!File.Exists(dbPath))
            {
                Directory.CreateDirectory(Path.Combine(dbPathDir));
                using(SqlConnection connection=new SqlConnection(connectionString))
                {
                    connection.Open();
                    string createDbCommandText = $@"
                    IF DB_ID('Database') IS NULL
                    BEGIN
                        CREATE DATABASE [Database]
                        ON (NAME = N'Database', FILENAME = '{dbPath}')
                        LOG ON (NAME = N'Database_log', FILENAME = '{Path.Combine(dbPathDir, "Database.ldf")}')
                    END";
                    using(SqlCommand cmd = new SqlCommand(createDbCommandText, connection))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
                string createTables = @"
                IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Malzeme' AND xtype='U')
                CREATE TABLE Malzeme (
                    MalzemeID INT PRIMARY KEY IDENTITY,
                    MalzemeAdi VARCHAR(100) NOT NULL UNIQUE,
                    ToplamMiktar VARCHAR(100) NOT NULL,
                    MalzemeBirim VARCHAR(20) NOT NULL,
                    BirimFiyat FLOAT NOT NULL
                );

                IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Tarif' AND xtype='U')
                CREATE TABLE Tarif (
                    TarifID INT PRIMARY KEY IDENTITY,
                    TarifAdi VARCHAR(100) NOT NULL,
                    Kategori VARCHAR(50) NOT NULL,
                    HazirlanmaSuresi INT NOT NULL,
                    Talimatlar TEXT NOT NULL
                );

                IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='TarifMalzeme' AND xtype='U')
                CREATE TABLE TarifMalzeme (
                    TarifID INT,
                    MalzemeID INT,
                    MalzemeMiktar FLOAT NOT NULL,
                    PRIMARY KEY (TarifID, MalzemeID),
                    FOREIGN KEY (TarifID) REFERENCES Tarif(TarifID),
                    FOREIGN KEY (MalzemeID) REFERENCES Malzeme(MalzemeID)
                );

                IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Foto' AND xtype='U')
                CREATE TABLE Foto (
                    TarifID INT,
                    Foto TEXT
                );
            ";
                using (SqlConnection connection1=new SqlConnection(Main.connString))
                {
                    connection1.Open();
                    using (SqlCommand cmd1 = new SqlCommand(createTables, connection1))
                    {
                        cmd1.ExecuteNonQuery();
                    }
                }
            }
            else
            {
                return;
            }
        }
    }
}
