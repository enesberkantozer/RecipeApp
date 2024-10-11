using Microsoft.Data.SqlClient;
using RecipeApp.Models;

namespace RecipeApp.Databases
{
    public class DbRecipeProduct
    {
        private readonly string connString = "Data Source=ENESBERKANT-PC\\SQLEXPRESS;Initial Catalog=TarifApp;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
        List<RecipeProduct> tarifmalzemes = new List<RecipeProduct>();
        public List<RecipeProduct> GetWithTarifId(int tarifId)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string command = "SELECT MalzemeId, MalzemeMiktar FROM TarifMalzeme WHERE TarifId=" + tarifId.ToString();
                using (SqlCommand cmd = new SqlCommand(command, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DbRecipe dbTarif = new DbRecipe();
                            Recipe tarif = dbTarif.GetWithId(tarifId).First();
                            DbProduct dbMalzeme = new DbProduct();
                            Malzeme malzeme = dbMalzeme.GetWithId((int)reader["MalzemeId"]).First();
                            RecipeProduct tarifMalzeme = new RecipeProduct(tarif, malzeme, (double)reader["MalzemeMiktar"]);
                            tarifmalzemes.Add(tarifMalzeme);
                        }
                    }
                }
            }
            return tarifmalzemes;
        }
        public List<RecipeProduct> GetWithMalzemeId(int malzemeId)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string command = "SELECT TarifId, MalzemeMiktar FROM TarifMalzeme WHERE MalzemeId=" + malzemeId.ToString();
                using (SqlCommand cmd = new SqlCommand(command, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DbRecipe dbTarif = new DbRecipe();
                            Recipe tarif = dbTarif.GetWithId((int)reader["TarifId"]).First();
                            DbProduct dbMalzeme = new DbProduct();
                            Malzeme malzeme = dbMalzeme.GetWithId(malzemeId).First();
                            RecipeProduct tarifMalzeme = new RecipeProduct(tarif, malzeme, (double)reader["MalzemeMiktar"]);
                            tarifmalzemes.Add(tarifMalzeme);
                        }
                    }
                }
            }
            return tarifmalzemes;
        }
        public bool Save(Recipe tarif, Malzeme malzeme, double malzemeMiktar)
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
