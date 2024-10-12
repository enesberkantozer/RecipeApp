namespace RecipeApp.Models
{
    public class RecipeProduct
    {
        public Recipe Recipe { get; set; }
        public Product Product { get; set; }
        public double ProductCost { get; set; }
        public RecipeProduct(Recipe recipe, Product product, double productCost)
        {
            this.Recipe = recipe;
            this.Product = product;
            this.ProductCost = productCost;
        }
    }
}
