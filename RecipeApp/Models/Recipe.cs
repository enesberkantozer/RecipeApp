namespace RecipeApp.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int Time { get; set; }
        public string Description { get; set; }
        public Recipe(int id, string name, string category, int time, string description)
        {
            Id = id;
            Name = name;
            Category = category;
            Time = time;
            Description = description;
        }
    }
}
