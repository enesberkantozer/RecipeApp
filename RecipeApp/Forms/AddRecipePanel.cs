using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeApp.Forms
{
    public partial class AddRecipePanel : Form
    {
        private int locationX, locationY, sizeX, sizeY;
        public AddRecipePanel(int locationX, int locationY, int sizeX, int sizeY)
        {
            InitializeComponent();
            this.locationX = locationX;
            this.locationY = locationY;
            this.sizeX = sizeX;
            this.sizeY = sizeY;
        }

        private void AddRecipePanel_Load(object sender, EventArgs e)
        {
            this.Location = new Point(locationX + (sizeX - this.Size.Width) / 2, locationY + (sizeY - this.Size.Height) / 2);
            flowLayoutPanel1.VerticalScroll.Value = 0;
            numericUpDown1.DecimalPlaces = 2;
            numericUpDown1.Increment = 0.01M;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
