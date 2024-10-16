using RecipeApp.Databases;
using RecipeApp.Models;
using RecipeApp.Templates;

namespace RecipeApp.Library
{
    public class MainLoad
    {

        private List<PanelTemplate> panels = new List<PanelTemplate>();
        private DbRecipe dbRecipe = new DbRecipe();
        private DbRecipeProduct dbRecipeProduct = new DbRecipeProduct();
        private double cost = 0;
        public List<PanelTemplate> LoadResults()
        {
            panels.Clear();
            List<Recipe> recipes = dbRecipe.GetAll();
            for (int i = 0; i < recipes.Count; i++)
            {
                cost = 0;
                Recipe t = recipes[i];
                List<RecipeProduct> recipeProducts = dbRecipeProduct.GetWithRecipeId(t.Id);
                for (int j = 0; j < recipeProducts.Count; j++)
                {
                    cost += recipeProducts[j].Product.CostPer * recipeProducts[j].ProductCost;
                }
                PanelTemplate panel = new PanelTemplate(t.Id, t.Name, (float)Math.Round(cost, 2), t.Time);
                panels.Add(panel);
            }
            return panels;
        }

        public List<PanelTemplate> LoadResultFromSearch(string search)
        {
            panels.Clear();
            List<Recipe> recipes = dbRecipe.SearchRecipe(search);
            for (int i = 0; i < recipes.Count; i++)
            {
                cost = 0;
                Recipe t = recipes[i];
                List<RecipeProduct> recipeProducts=dbRecipeProduct.GetWithRecipeId(t.Id);
                for(int j = 0;j < recipeProducts.Count; j++)
                {
                    cost += recipeProducts[j].Product.CostPer * recipeProducts[j].ProductCost;
                }
                PanelTemplate panel = new PanelTemplate(t.Id, t.Name, (float)Math.Round(cost, 2), t.Time);
                panels.Add(panel);
            }
            return panels;
        }
    }
}
