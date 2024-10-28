using RecipeApp.Forms;
using RecipeApp.Models;

namespace RecipeApp.Templates
{
    public partial class AddProductinRecipe : UserControl
    {
        public Product Product { get; set; }
        public AddProductinRecipe(Product product, double value)
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
            numericUpDown1.Maximum = decimal.MaxValue;
            numericUpDown1.Tag = product.Id;
            numericUpDown1.Value = (decimal)value;
            button1.Name = product.Id.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (this.Parent.Tag.Equals("searchFlowProduct"))
            {
                Main.srchAllProducts.Add(Product);
            }
            else
            {
                AddRecipePanel.addedProducts.Remove(Product);
                AddRecipePanel.products.Add(Product);
            }
            this.Parent.Controls.Remove(this);
        }
        
        public double GetNumericValue()
        {
            double value = Convert.ToDouble(numericUpDown1.Value);
            return value;
        }
    }
}
