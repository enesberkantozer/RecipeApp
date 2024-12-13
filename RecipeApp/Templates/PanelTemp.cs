using Microsoft.IdentityModel.Tokens;
using RecipeApp.Databases;
using RecipeApp.Forms;
using RecipeApp.Library;
using RecipeApp.Models;

namespace RecipeApp.Templates
{
    public partial class PanelTemp : UserControl
    {
        private MainLoad mainLoad = new MainLoad();
        public Recipe Recipe { get; set; }
        public double Cost { get; set; }
        public double MissingCost { get; set; }
        public double Percent { get; set; }
        public int Time {  get; set; }
        
        public PanelTemp(Recipe recipe, Dictionary<Product,double>? products)
        {
            InitializeComponent();
            this.Recipe = recipe;
            this.Time = recipe.Time;
            this.Cost = mainLoad.GetCost(recipe);
            this.Percent=mainLoad.GetPercent(recipe, products);
            this.MissingCost=mainLoad.GetMissingCost(recipe, products);
            this.Tag = recipe.Id;

            try
            {
                string pathDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "UserData", "img", "Recipes", Recipe.Id.ToString());
                if (Directory.Exists(pathDir))
                {
                    string path = Directory.GetFiles(pathDir).First();
                    string tempPath = Path.GetTempFileName();
                    File.Copy(path, tempPath, true);
                    pictureBox1.Image = Image.FromFile(tempPath);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            catch (Exception ex) { }

            labelName.Text = Recipe.Name;
            labelTime.Text = "";
            if (Recipe.Time >= 3600)
            {
                labelTime.Text += (Recipe.Time / 3600).ToString() + " Saat ";
            }
            if (Recipe.Time >= 60)
            {
                labelTime.Text += (Recipe.Time / 60 % 60).ToString() + " Dakika ";
            }
            labelTime.Text += (Recipe.Time % 60).ToString() + " Saniye";
            labelTotalCost.Text = "Toplam Maliyet\n" + Cost.ToString() + " TL";
            double percent = Percent;
            labelPercent.Text = "%" + percent.ToString();
            if (percent == 100.0)
            {
                labelPercent.Text = "✓";
                labelPercent.Font = new Font(labelPercent.Font.FontFamily, 30, FontStyle.Bold);
                //labelPercent.ForeColor = Color.White;
                labelPercent.BackColor = Color.Green;
            }
            if (percent > 75)
            {
                labelPercent.ForeColor = Color.FromArgb(0, 255, 0);
            }
            else if (percent > 50)
            {
                labelPercent.ForeColor = Color.FromArgb(127, 255, 0);
            }
            else if (percent > 25)
            {
                labelPercent.ForeColor = Color.FromArgb(255, 127, 0);
            }
            else
            {
                labelPercent.ForeColor = Color.FromArgb(255, 0, 0);
            }
            if (MissingCost > 0)
            {
                labelMissingCost.Text = "Eksik Maliyet\n" + MissingCost.ToString() + " TL";
                foreach (RecipeProduct item in mainLoad.missingProducts.Keys)
                {
                    dataGridView1.Rows.Add(item.Product.Name, mainLoad.missingProducts[item], item.Product.Unit);
                }
            }
            else
            {
                labelMissingCost.Visible = false;
            }
        }

        private void PanelTemp_DoubleClick(object sender, EventArgs e)
        {
            AddRecipePanel panel = new AddRecipePanel(Recipe);
            panel.ShowDialog();
        }
    }
}
