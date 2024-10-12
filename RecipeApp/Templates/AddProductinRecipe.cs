using RecipeApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeApp.Templates
{
    public partial class AddProductinRecipe : UserControl
    {
        private List<Product> products = new List<Product>();
        public AddProductinRecipe(List<Product> productList)
        {
            InitializeComponent();
            foreach (Product p in productList)
            {
                comboBox1.Items.Add(p.Name);
            }
        }

        private void AddProductinRecipe_Load(object sender, EventArgs e)
        {
            numericUpDown1.DecimalPlaces = 2;
            numericUpDown1.Increment = 0.01M;
            numericUpDown1.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*products.Remove();
            numericUpDown1.Show();
            this.Parent.Controls.Add(new AddProductinRecipe());*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
            this.Dispose();
        }
    }
}
