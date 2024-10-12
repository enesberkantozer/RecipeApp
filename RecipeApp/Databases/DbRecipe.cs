using Microsoft.Data.SqlClient;
using RecipeApp.Models;

namespace RecipeApp.Databases
{
    public class DbRecipe
    {
        private readonly string connString = "Data Source=ENESBERKANT-PC\\SQLEXPRESS;Initial Catalog=TarifApp;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
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
        public List<Recipe> GetWithId(int id)
        {
            recipes.Clear();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string command = "SELECT * FROM Tarif Where TarifID=" + id.ToString();
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
        public List<Recipe> GetWithName(string name)
        {
            recipes.Clear();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string command = "SELECT * FROM Tarif Where TarifAdi=" + name;
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
        public List<Recipe> GetWithCategory(string category)
        {
            recipes.Clear();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string command = "SELECT * FROM Tarif Where Kategori=" + category;
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
        public List<Recipe> GetWithTime(int time)
        {
            recipes.Clear();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string command = "SELECT * FROM Tarif Where HazirlanmaSuresi=" + time.ToString();
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
        public List<Recipe> GetWithDescription(string description)
        {
            recipes.Clear();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string command = "SELECT * FROM Tarif Where Talimatlar=" + description;
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
    }
}
