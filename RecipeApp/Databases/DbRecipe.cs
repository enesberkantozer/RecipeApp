using Microsoft.Data.SqlClient;
using RecipeApp.Models;

namespace RecipeApp.Databases
{
    public class DbRecipe
    {
        private readonly string connString = "Data Source=ENESBERKANT-PC\\SQLEXPRESS;Initial Catalog=TarifApp;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
        List<Recipe> tarifs = new List<Recipe>();
        public List<Recipe> GetAll()
        {
            tarifs.Clear();
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
                            Recipe tarif = new Recipe((int)reader["TarifID"], (string)reader["TarifAdi"], (string)reader["Kategori"], (int)reader["HazirlanmaSuresi"], (string)reader["Talimatlar"]);
                            tarifs.Add(tarif);
                        }
                    }
                }
            }
            return tarifs;
        }
        public List<Recipe> GetWithId(int id)
        {
            tarifs.Clear();
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
                            Recipe tarif = new Recipe((int)reader["TarifID"], (string)reader["TarifAdi"], (string)reader["Kategori"], (int)reader["HazirlanmaSuresi"], (string)reader["Talimatlar"]);
                            tarifs.Add(tarif);
                        }
                    }
                }
            }
            return tarifs;
        }
        public List<Recipe> GetWithName(string name)
        {
            tarifs.Clear();
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
                            Recipe tarif = new Recipe((int)reader["TarifID"], (string)reader["TarifAdi"], (string)reader["Kategori"], (int)reader["HazirlanmaSuresi"], (string)reader["Talimatlar"]);
                            tarifs.Add(tarif);
                        }
                    }
                }
            }
            return tarifs;
        }
        public List<Recipe> GetWithCategory(string category)
        {
            tarifs.Clear();
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
                            Recipe tarif = new Recipe((int)reader["TarifID"], (string)reader["TarifAdi"], (string)reader["Kategori"], (int)reader["HazirlanmaSuresi"], (string)reader["Talimatlar"]);
                            tarifs.Add(tarif);
                        }
                    }
                }
            }
            return tarifs;
        }
        public List<Recipe> GetWithTime(int time)
        {
            tarifs.Clear();
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
                            Recipe tarif = new Recipe((int)reader["TarifID"], (string)reader["TarifAdi"], (string)reader["Kategori"], (int)reader["HazirlanmaSuresi"], (string)reader["Talimatlar"]);
                            tarifs.Add(tarif);
                        }
                    }
                }
            }
            return tarifs;
        }
        public List<Recipe> GetWithDescription(string description)
        {
            tarifs.Clear();
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
                            Recipe tarif = new Recipe((int)reader["TarifID"], (string)reader["TarifAdi"], (string)reader["Kategori"], (int)reader["HazirlanmaSuresi"], (string)reader["Talimatlar"]);
                            tarifs.Add(tarif);
                        }
                    }
                }
            }
            return tarifs;
        }
        public bool Save(Recipe tarif)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string command = "INSERT INTO Tarif (TarifAdi,Kategori,HazirlanmaSuresi,Talimatlar) VALUES (@TarifAdi,@Kategori,@HazirlanmaSuresi,@Talimatlar)";
                using (SqlCommand cmd = new SqlCommand(command, conn))
                {
                    cmd.Parameters.AddWithValue("@TarifAdi", tarif.Name);
                    cmd.Parameters.AddWithValue("@Kategori", tarif.Category);
                    cmd.Parameters.AddWithValue("@HazirlanmaSuresi", tarif.Time);
                    cmd.Parameters.AddWithValue("@Talimatlar", tarif.Description);
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
