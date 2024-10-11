using RecipeApp.Databases;
using RecipeApp.Models;
using RecipeApp.Templates;

namespace RecipeApp.Library
{
    public class MainLoad
    {
        public List<PanelTemplate> LoadResults()
        {
            List<PanelTemplate> panels = new List<PanelTemplate>();
            DbRecipe dbTarif = new DbRecipe();
            List<Recipe> tarifs = dbTarif.GetAll();
            for (int i = 0; i < tarifs.Count; i++)
            {
                double cost = 0;
                Recipe t = tarifs[i];
                DbRecipeProduct dbTarifMalzeme = new DbRecipeProduct();
                List<RecipeProduct> tarifMalzemes = dbTarifMalzeme.GetWithTarifId(t.Id);
                for (int j = 0; j < tarifMalzemes.Count; j++)
                {
                    cost += tarifMalzemes[j].Malzeme.CostPer * tarifMalzemes[j].MalzemeMiktar;
                }
                PanelTemplate panel = new PanelTemplate(t.Id, t.Name, (float)Math.Round(cost, 2), t.Time);
                panels.Add(panel);
            }
            return panels;
        }
    }
}
