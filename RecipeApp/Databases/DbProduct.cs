using Microsoft.Data.SqlClient;
using RecipeApp.Models;

namespace RecipeApp.Databases
{
    public class DbProduct
    {
        private readonly string connString = "Data Source=ENESBERKANT-PC\\SQLEXPRESS;Initial Catalog=TarifApp;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
        List<Malzeme> malzemes = new List<Malzeme>();
        public List<Malzeme> GetAll()
        {
            malzemes.Clear();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string command = "SELECT * FROM Malzeme";
                using (SqlCommand cmd = new SqlCommand(command, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Malzeme malzeme = new Malzeme((int)reader["MalzemeID"], (string)reader["MalzemeAdi"], (string)reader["ToplamMiktar"], (string)reader["MalzemeBirim"], (double)reader["BirimFiyat"]);
                            malzemes.Add(malzeme);
                        }
                    }
                }
            }
            return malzemes;
        }
        public List<Malzeme> GetWithId(int id)
        {
            malzemes.Clear();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string command = "SELECT * FROM Malzeme Where MalzemeID=" + id.ToString();
                using (SqlCommand cmd = new SqlCommand(command, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Malzeme malzeme = new Malzeme((int)reader["MalzemeID"], (string)reader["MalzemeAdi"], (string)reader["ToplamMiktar"], (string)reader["MalzemeBirim"], (double)reader["BirimFiyat"]);
                            malzemes.Add(malzeme);
                        }
                    }
                }
            }
            return malzemes;
        }
        public List<Malzeme> GetWithName(string name)
        {
            malzemes.Clear();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string command = "SELECT * FROM Malzeme Where MalzemeAdi=" + name;
                using (SqlCommand cmd = new SqlCommand(command, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Malzeme malzeme = new Malzeme((int)reader["MalzemeID"], (string)reader["MalzemeAdi"], (string)reader["ToplamMiktar"], (string)reader["MalzemeBirim"], (double)reader["BirimFiyat"]);
                            malzemes.Add(malzeme);
                        }
                    }
                }
            }
            return malzemes;
        }
        public List<Malzeme> GetWithTotal(string total)
        {
            malzemes.Clear();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string command = "SELECT * FROM Malzeme Where ToplamMiktar=" + total;
                using (SqlCommand cmd = new SqlCommand(command, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Malzeme malzeme = new Malzeme((int)reader["MalzemeID"], (string)reader["MalzemeAdi"], (string)reader["ToplamMiktar"], (string)reader["MalzemeBirim"], (double)reader["BirimFiyat"]);
                            malzemes.Add(malzeme);
                        }
                    }
                }
            }
            return malzemes;
        }
        public List<Malzeme> GetWithUnit(string unit)
        {
            malzemes.Clear();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string command = "SELECT * FROM Malzeme Where MalzemeBirim=" + unit;
                using (SqlCommand cmd = new SqlCommand(command, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Malzeme malzeme = new Malzeme((int)reader["MalzemeID"], (string)reader["MalzemeAdi"], (string)reader["ToplamMiktar"], (string)reader["MalzemeBirim"], (double)reader["BirimFiyat"]);
                            malzemes.Add(malzeme);
                        }
                    }
                }
            }
            return malzemes;
        }
        public List<Malzeme> GetWithCostPer(double costper)
        {
            malzemes.Clear();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string command = "SELECT * FROM Malzeme Where BirimFiyat=" + costper.ToString();
                using (SqlCommand cmd = new SqlCommand(command, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Malzeme malzeme = new Malzeme((int)reader["MalzemeID"], (string)reader["MalzemeAdi"], (string)reader["ToplamMiktar"], (string)reader["MalzemeBirim"], (double)reader["BirimFiyat"]);
                            malzemes.Add(malzeme);
                        }
                    }
                }
            }
            return malzemes;
        }
        public bool Save(Malzeme malzeme)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string command = "INSERT INTO Malzeme (MalzemeAdi,ToplamMiktar,MalzemeBirim,BirimFiyat) VALUES (@MalzemeAdi,@ToplamMiktar,@MalzemeBirim,@BirimFiyat)";
                using (SqlCommand cmd = new SqlCommand(command, conn))
                {
                    cmd.Parameters.AddWithValue("@MalzemeAdi", malzeme.Name);
                    cmd.Parameters.AddWithValue("@ToplamMiktar", malzeme.Total);
                    cmd.Parameters.AddWithValue("@MalzemeBirim", malzeme.Unit);
                    cmd.Parameters.AddWithValue("@BirimFiyat", Math.Round(malzeme.CostPer, 2));
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
