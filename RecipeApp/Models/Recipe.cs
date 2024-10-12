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
            this.Id = id;
            this.Name = name;
            this.Category = category;
            this.Time = time;
            this.Description = description;
        }
        public Recipe(string name, string category, int time, string description)
        {
            this.Name = name;
            this.Category = category;
            this.Time = time;
            this.Description = description;
        }
    }
}
