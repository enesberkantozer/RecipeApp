using RecipeApp.Forms;
using RecipeApp.Models;
using static System.Windows.Forms.ComboBox;

namespace RecipeApp.Templates
{
    public partial class AddProductinRecipe : UserControl
    {
        private Product Product { get; set; }
        public AddProductinRecipe(Product product)
        {
            InitializeComponent();
            this.Product = product;
            labelUnit.Text = product.Unit;
            labelName.Text = product.Name;
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(labelName, labelName.Text);
            numericUpDown1.DecimalPlaces = 2;
            numericUpDown1.Increment = 0.01M;
            numericUpDown1.Minimum = 0.01M;
            numericUpDown1.Maximum = decimal.Parse(product.Total);
            numericUpDown1.Tag = product.Id;
            button1.Name = product.Id.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddRecipePanel.addedProducts.Remove(Product);
            AddRecipePanel.products.Add(Product);
            this.Parent.Controls.Remove(this);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            AddRecipePanel.addedProducts[Product] = Convert.ToSingle(numericUpDown1.Value);
        }
    }
}
