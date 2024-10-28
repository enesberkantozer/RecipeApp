using Microsoft.Data.SqlClient;
using RecipeApp.Forms;
using RecipeApp.Models;

namespace RecipeApp.Databases
{
    public class DbRecipePhoto
    {
        private readonly string connString = Main.connString;
        List<RecipePhoto> recipePhotos = new List<RecipePhoto>();

        public List<RecipePhoto> Get(Recipe recipe)
        {
            recipePhotos.Clear();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string command = "SELECT * FROM Foto WHERE TarifID=@id";
                using (SqlCommand cmd = new SqlCommand(command, conn))
                {
                    cmd.Parameters.AddWithValue("@id", recipe.Id);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            RecipePhoto recipePhoto = new RecipePhoto(recipe, (string)reader["Foto"]);
                            recipePhotos.Add(recipePhoto);
                        }
                    }
                }
            }
            return recipePhotos;
        }

        public bool Save(RecipePhoto recipePhoto)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string command = "INSERT INTO Foto (TarifID, Foto) VALUES (@TarifId, @Foto)";
                using (SqlCommand cmd = new SqlCommand(command, conn))
                {
                    cmd.Parameters.AddWithValue("@TarifId", recipePhoto.Recipe.Id);
                    cmd.Parameters.AddWithValue("@Foto", recipePhoto.Path);
                    int success = cmd.ExecuteNonQuery();
                    if (success == 1)
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
                string command = "DELETE FROM Foto WHERE TarifID=@Id";
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
    }
}
