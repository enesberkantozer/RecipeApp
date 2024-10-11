namespace RecipeApp.Models
{
    public class RecipeProduct
    {
        public Recipe Tarif { get; set; }
        public Malzeme Malzeme { get; set; }
        public double MalzemeMiktar { get; set; }
        public RecipeProduct(Recipe tarif, Malzeme malzeme, double malzemeMiktar)
        {
            Tarif = tarif;
            Malzeme = malzeme;
            MalzemeMiktar = malzemeMiktar;
        }
    }
}
