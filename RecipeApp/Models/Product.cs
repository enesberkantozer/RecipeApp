using System.Diagnostics;

namespace RecipeApp.Models
{
    public class Malzeme
    {
        public int Id { get; set; }
        public string Name { get; }
        public string Total { get; set; }
        public string Unit { get; set; }
        public double CostPer { get; set; }
        public Malzeme(int id, string name, string total, string unit, double costper)
        {
            Id = id;
            Name = name;
            Total = total;
            Unit = unit;
            CostPer = costper;
        }
    }
}
