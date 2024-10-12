namespace RecipeApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; }
        public string Total { get; set; }
        public string Unit { get; set; }
        public double CostPer { get; set; }
        public Product(int id, string name, string total, string unit, double costper)
        {
            this.Id = id;
            this.Name = name;
            this.Total = total;
            this.Unit = unit;
            this.CostPer = costper;
        }
        public Product(string name, string total, string unit, double costper)
        {
            this.Name = name;
            this.Total = total;
            this.Unit = unit;
            this.CostPer = costper;
        }
    }
}
