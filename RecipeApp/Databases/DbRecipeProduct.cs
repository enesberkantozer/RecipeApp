using Microsoft.Data.SqlClient;
using RecipeApp.Models;

namespace RecipeApp.Databases
{
    public class DbRecipeProduct
    {
        private readonly string connString = "Data Source=ENESBERKANT-PC\\SQLEXPRESS;Initial Catalog=TarifApp;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
        List<RecipeProduct> recipeProducts = new List<RecipeProduct>();
        public List<RecipeProduct> GetWithRecipeId(int recipeId)
        {
            recipeProducts.Clear();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string command = "SELECT MalzemeId, MalzemeMiktar FROM TarifMalzeme WHERE TarifId=@id";
                using (SqlCommand cmd = new SqlCommand(command, conn))
                {
                    cmd.Parameters.AddWithValue("@id", recipeId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DbRecipe dbTarif = new DbRecipe();
                            Recipe tarif = dbTarif.GetWithId(recipeId);
                            DbProduct dbMalzeme = new DbProduct();
                            Product malzeme = dbMalzeme.GetWithId((int)reader["MalzemeId"]);
                            RecipeProduct tarifMalzeme = new RecipeProduct(tarif, malzeme, (double)reader["MalzemeMiktar"]);
                            recipeProducts.Add(tarifMalzeme);
                        }
                    }
                }
            }
            return recipeProducts;
        }
        public List<RecipeProduct> GetWithProductId(int productId)
        {
            recipeProducts.Clear();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string command = "SELECT TarifId, MalzemeMiktar FROM TarifMalzeme WHERE MalzemeId=@id";
                using (SqlCommand cmd = new SqlCommand(command, conn))
                {
                    cmd.Parameters.AddWithValue("@id", productId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DbRecipe dbTarif = new DbRecipe();
                            Recipe tarif = dbTarif.GetWithId((int)reader["TarifId"]);
                            DbProduct dbMalzeme = new DbProduct();
                            Product malzeme = dbMalzeme.GetWithId(productId);
                            RecipeProduct tarifMalzeme = new RecipeProduct(tarif, malzeme, (double)reader["MalzemeMiktar"]);
                            recipeProducts.Add(tarifMalzeme);
                        }
                    }
                }
            }
            return recipeProducts;
        }
        public bool Save(Recipe tarif, Product malzeme, double malzemeMiktar)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string command = "INSERT INTO TarifMalzeme (TarifId,MalzemeId,MalzemeMiktar) VALUES (@TarifId,@MalzemeId,@MalzemeMiktar)";
                using (SqlCommand cmd = new SqlCommand(command, conn))
                {
                    cmd.Parameters.AddWithValue("@TarifId", tarif.Id);
                    cmd.Parameters.AddWithValue("@MalzemeId", malzeme.Id);
                    cmd.Parameters.AddWithValue("@MalzemeMiktar", Math.Round(malzemeMiktar, 2));
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
    }
}
