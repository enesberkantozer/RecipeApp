namespace RecipeApp.Models
{
    public class RecipePhoto
    {
        public Recipe Recipe { get; set; }
        public string Path { get; set; }
        public RecipePhoto(Recipe recipe, string path)
        {
            this.Recipe = recipe;
            this.Path = path;
        }
    }
}
