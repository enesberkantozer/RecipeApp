using Microsoft.Data.SqlClient;
using RecipeApp.Forms;
using RecipeApp.Models;

namespace RecipeApp.Databases
{
    public class DbProduct
    {
        private readonly string connString = Main.connString;
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
        public Product GetWithId(int id)
        {
            products.Clear();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string command = "SELECT * FROM Malzeme Where MalzemeID=@id";
                using (SqlCommand cmd = new SqlCommand(command, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Product product = new Product((int)reader["MalzemeID"], (string)reader["MalzemeAdi"], (string)reader["ToplamMiktar"], (string)reader["MalzemeBirim"], (double)reader["BirimFiyat"]);
                            return product;
                        }
                    }
                }
            }
            return null;
        }
        public List<Product> GetWithName(string name)
        {
            products.Clear();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string command = "SELECT * FROM Malzeme Where MalzemeAdi=@name";
                using (SqlCommand cmd = new SqlCommand(command, conn))
                {
                    cmd.Parameters.AddWithValue("@name", name);
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
                string command = "SELECT * FROM Malzeme Where ToplamMiktar=@total";
                using (SqlCommand cmd = new SqlCommand(command, conn))
                {
                    cmd.Parameters.AddWithValue("@total", total);
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
                string command = "SELECT * FROM Malzeme Where MalzemeBirim=@unit";
                using (SqlCommand cmd = new SqlCommand(command, conn))
                {
                    cmd.Parameters.AddWithValue("@unit", unit);
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
                string command = "SELECT * FROM Malzeme Where BirimFiyat=@costper";
                using (SqlCommand cmd = new SqlCommand(command, conn))
                {
                    cmd.Parameters.AddWithValue("@costper", costper);
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
        public bool Update(Product product)
        {
            using(SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string command = "UPDATE Malzeme SET MalzemeAdi=@MalzemeAdi, ToplamMiktar=@ToplamMiktar, MalzemeBirim=@MalzemeBirim, BirimFiyat=@BirimFiyat WHERE MalzemeID=@Id";
                using(SqlCommand cmd = new SqlCommand(command,conn))
                {
                    cmd.Parameters.AddWithValue("@MalzemeAdi",product.Name);
                    cmd.Parameters.AddWithValue("@ToplamMiktar",product.Total);
                    cmd.Parameters.AddWithValue("@MalzemeBirim", product.Unit);
                    cmd.Parameters.AddWithValue("@BirimFiyat",product.CostPer);
                    cmd.Parameters.AddWithValue("@Id", product.Id);
                    int isSuccess=cmd.ExecuteNonQuery();
                    if(isSuccess == 1)
                        return true;
                    else
                        return false;
                }
            }
        }
    }
}
