using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using RecipeApp.Forms;
using RecipeApp.Library;
using RecipeApp.Models;

namespace RecipeApp.Databases
{
    public class DbRecipe
    {
        private readonly string connString = Main.connString;
        List<Recipe> recipes = new List<Recipe>();
        public List<Recipe> GetAll()
        {
            recipes.Clear();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string command = "SELECT * FROM Tarif";
                using (SqlCommand cmd = new SqlCommand(command, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Recipe recipe = new Recipe((int)reader["TarifID"], (string)reader["TarifAdi"], (string)reader["Kategori"], (int)reader["HazirlanmaSuresi"], (string)reader["Talimatlar"]);
                            recipes.Add(recipe);
                        }
                    }
                }
            }
            return recipes;
        }
        public Recipe GetWithId(int id)
        {
            recipes.Clear();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string command = "SELECT * FROM Tarif Where TarifID=@id";
                using (SqlCommand cmd = new SqlCommand(command, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Recipe recipe = new Recipe((int)reader["TarifID"], (string)reader["TarifAdi"], (string)reader["Kategori"], (int)reader["HazirlanmaSuresi"], (string)reader["Talimatlar"]);
                            return recipe;
                        }
                    }
                }
            }
            return null;
        }
        public List<Recipe> GetWithName(string name)
        {
            recipes.Clear();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string command = "SELECT * FROM Tarif Where TarifAdi=@name";
                using (SqlCommand cmd = new SqlCommand(command, conn))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Recipe recipe = new Recipe((int)reader["TarifID"], (string)reader["TarifAdi"], (string)reader["Kategori"], (int)reader["HazirlanmaSuresi"], (string)reader["Talimatlar"]);
                            recipes.Add(recipe);
                        }
                    }
                }
            }
            return recipes;
        }
        public List<Recipe> GetWithCategory(string category)
        {
            recipes.Clear();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string command = "SELECT * FROM Tarif Where Kategori=@category";
                using (SqlCommand cmd = new SqlCommand(command, conn))
                {
                    cmd.Parameters.AddWithValue("@category", category);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Recipe recipe = new Recipe((int)reader["TarifID"], (string)reader["TarifAdi"], (string)reader["Kategori"], (int)reader["HazirlanmaSuresi"], (string)reader["Talimatlar"]);
                            recipes.Add(recipe);
                        }
                    }
                }
            }
            return recipes;
        }
        public List<Recipe> GetWithTime(int time)
        {
            recipes.Clear();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string command = "SELECT * FROM Tarif Where HazirlanmaSuresi=@time";
                using (SqlCommand cmd = new SqlCommand(command, conn))
                {
                    cmd.Parameters.AddWithValue("@time", time);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Recipe recipe = new Recipe((int)reader["TarifID"], (string)reader["TarifAdi"], (string)reader["Kategori"], (int)reader["HazirlanmaSuresi"], (string)reader["Talimatlar"]);
                            recipes.Add(recipe);
                        }
                    }
                }
            }
            return recipes;
        }
        public List<Recipe> GetWithDescription(string description)
        {
            recipes.Clear();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string command = "SELECT * FROM Tarif Where Talimatlar=@desc";
                using (SqlCommand cmd = new SqlCommand(command, conn))
                {
                    cmd.Parameters.AddWithValue("@desc", description);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Recipe recipe = new Recipe((int)reader["TarifID"], (string)reader["TarifAdi"], (string)reader["Kategori"], (int)reader["HazirlanmaSuresi"], (string)reader["Talimatlar"]);
                            recipes.Add(recipe);
                        }
                    }
                }
            }
            return recipes;
        }
        public List<string> GetCategoryList()
        {
            List<string> list = new List<string>();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string command = "SELECT Kategori FROM Tarif";
                using (SqlCommand cmd = new SqlCommand(command, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string str = (string)reader["Kategori"];
                            list.Add(str);
                        }
                    }
                }
            }
            return list;
        }
        public bool Save(Recipe recipe)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string command = "INSERT INTO Tarif (TarifAdi,Kategori,HazirlanmaSuresi,Talimatlar) VALUES (@TarifAdi,@Kategori,@HazirlanmaSuresi,@Talimatlar)";
                using (SqlCommand cmd = new SqlCommand(command, conn))
                {
                    cmd.Parameters.AddWithValue("@TarifAdi", recipe.Name);
                    cmd.Parameters.AddWithValue("@Kategori", recipe.Category);
                    cmd.Parameters.AddWithValue("@HazirlanmaSuresi", recipe.Time);
                    cmd.Parameters.AddWithValue("@Talimatlar", recipe.Description);
                    int isSucess = cmd.ExecuteNonQuery();
                    if (isSucess == 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
        public bool Update(Recipe recipe)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string command = "UPDATE Tarif SET TarifAdi=@TarifAdi, Kategori=@Kategori, HazirlanmaSuresi=@HazirlanmaSuresi,Talimatlar=@Talimatlar WHERE TarifID=@Id";
                using (SqlCommand cmd = new SqlCommand(command, conn))
                {
                    cmd.Parameters.AddWithValue("@TarifAdi", recipe.Name);
                    cmd.Parameters.AddWithValue("@Kategori", recipe.Category);
                    cmd.Parameters.AddWithValue("@HazirlanmaSuresi", recipe.Time);
                    cmd.Parameters.AddWithValue("@Talimatlar", recipe.Description);
                    cmd.Parameters.AddWithValue("@Id", recipe.Id);
                    int isSucess = cmd.ExecuteNonQuery();
                    if (isSucess == 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
        public bool Delete(Recipe recipe)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string command = "DELETE FROM Tarif WHERE TarifID=@Id";
                using (SqlCommand cmd = new SqlCommand(command, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", recipe.Id);
                    int sucess = cmd.ExecuteNonQuery();
                    if (sucess >= 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
        public List<Recipe> SearchRecipe(string? name=null, List<string>? category=null, int? minTime=0, int? maxTime=int.MaxValue,
            double? minCost=0, double? maxCost=int.MaxValue, List<Product>? products=null)
        {
            if(products.IsNullOrEmpty())
                products=new List<Product>();
            if(category.IsNullOrEmpty())
                category=new List<string>();
            recipes.Clear();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string command = "SELECT * " +
                    "FROM Tarif " +
                    "WHERE HazirlanmaSuresi BETWEEN @minTime AND @maxTime";
                if(name != null)
                {
                    command += " AND TarifAdi LIKE @name";
                }
                if(!(category.IsNullOrEmpty()))
                {
                    command += " AND Kategori IN (";
                    for(int i=0; i<category.Count; i++)
                    {
                        command += $"@category{i}";
                        if (i < category.Count - 1)
                            command += ", ";
                    }
                    command += ")";
                }
                using (SqlCommand cmd = new SqlCommand(command, conn))
                {
                    cmd.Parameters.AddWithValue("@minTime", minTime);
                    cmd.Parameters.AddWithValue("@maxTime", maxTime);
                    if(name !=null)
                        cmd.Parameters.AddWithValue("@name", "%" + name + "%");
                    if (!(category.IsNullOrEmpty()))
                    {
                        int c = 0;
                        category.ForEach(x => { cmd.Parameters.AddWithValue($"@category{c}", x); c++; });
                    }
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Recipe recipe = new Recipe((int)reader["TarifID"], (string)reader["TarifAdi"], (string)reader["Kategori"], (int)reader["HazirlanmaSuresi"], (string)reader["Talimatlar"]);
                            recipes.Add(recipe);
                        }
                    }
                }
            }
            List<Recipe> removeList= new List<Recipe>();
            foreach (Recipe r in recipes)
            {
                MainLoad mainLoad = new MainLoad();
                double cost=mainLoad.GetCost(r);
                if(!(cost >=minCost && cost <= maxCost))
                {
                    removeList.Add(r);
                    continue;
                }
                DbRecipeProduct dbRecipeProduct = new DbRecipeProduct();
                List<RecipeProduct> recipeProducts = dbRecipeProduct.GetWithRecipeId(r.Id);
                int productControlCounter = 0;
                foreach (Product p in products)
                {
                    foreach (RecipeProduct rp in recipeProducts)
                    {
                        if(rp.Product.Equals(p))
                        {
                            productControlCounter++;
                            break;
                        }
                    }
                }
                if (!(productControlCounter == products.Count))
                {
                    removeList.Add(r);
                }
            }
            recipes.RemoveAll(x => removeList.Select(y => y.Id).ToList().Contains(x.Id));
            return recipes;
        }
    }
}
