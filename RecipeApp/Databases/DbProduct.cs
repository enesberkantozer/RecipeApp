using Microsoft.Data.SqlClient;
using RecipeApp.Models;

namespace RecipeApp.Databases
{
    public class DbProduct
    {
        private readonly string connString = "Data Source=ENESBERKANT-PC\\SQLEXPRESS;Initial Catalog=TarifApp;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
        List<Product> products = new List<Product>();
        public List<Product> GetAll()
        {
            products.Clear();
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
                            Product product = new Product((int)reader["MalzemeID"], (string)reader["MalzemeAdi"], (string)reader["ToplamMiktar"], (string)reader["MalzemeBirim"], (double)reader["BirimFiyat"]);
                            products.Add(product);
                        }
                    }
                }
            }
            return products;
        }
        public List<Product> GetWithId(int id)
        {
            products.Clear();
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
                            Product product = new Product((int)reader["MalzemeID"], (string)reader["MalzemeAdi"], (string)reader["ToplamMiktar"], (string)reader["MalzemeBirim"], (double)reader["BirimFiyat"]);
                            products.Add(product);
                        }
                    }
                }
            }
            return products;
        }
        public List<Product> GetWithName(string name)
        {
            products.Clear();
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
                            Product product = new Product((int)reader["MalzemeID"], (string)reader["MalzemeAdi"], (string)reader["ToplamMiktar"], (string)reader["MalzemeBirim"], (double)reader["BirimFiyat"]);
                            products.Add(product);
                        }
                    }
                }
            }
            return products;
        }
        public List<Product> GetWithTotal(string total)
        {
            products.Clear();
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
                            Product product = new Product((int)reader["MalzemeID"], (string)reader["MalzemeAdi"], (string)reader["ToplamMiktar"], (string)reader["MalzemeBirim"], (double)reader["BirimFiyat"]);
                            products.Add(product);
                        }
                    }
                }
            }
            return products;
        }
        public List<Product> GetWithUnit(string unit)
        {
            products.Clear();
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
                            Product product = new Product((int)reader["MalzemeID"], (string)reader["MalzemeAdi"], (string)reader["ToplamMiktar"], (string)reader["MalzemeBirim"], (double)reader["BirimFiyat"]);
                            products.Add(product);
                        }
                    }
                }
            }
            return products;
        }
        public List<Product> GetWithCostPer(double costper)
        {
            products.Clear();
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
                            Product product = new Product((int)reader["MalzemeID"], (string)reader["MalzemeAdi"], (string)reader["ToplamMiktar"], (string)reader["MalzemeBirim"], (double)reader["BirimFiyat"]);
                            products.Add(product);
                        }
                    }
                }
            }
            return products;
        }
        public bool Save(Product product)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string command = "INSERT INTO Malzeme (MalzemeAdi,ToplamMiktar,MalzemeBirim,BirimFiyat) VALUES (@MalzemeAdi,@ToplamMiktar,@MalzemeBirim,@BirimFiyat)";
                using (SqlCommand cmd = new SqlCommand(command, conn))
                {
                    cmd.Parameters.AddWithValue("@MalzemeAdi", product.Name);
                    cmd.Parameters.AddWithValue("@ToplamMiktar", product.Total);
                    cmd.Parameters.AddWithValue("@MalzemeBirim", product.Unit);
                    cmd.Parameters.AddWithValue("@BirimFiyat", Math.Round(product.CostPer, 2));
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
