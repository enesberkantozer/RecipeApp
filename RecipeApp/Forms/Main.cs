using RecipeApp.Library;
using RecipeApp.Templates;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RecipeApp.Forms;

namespace RecipeApp.Forms
{
    public partial class Main : Form
    {

        private MainLoad load = new MainLoad();
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddRecipePanel addRecipePanel = new AddRecipePanel(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);
            addRecipePanel.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            searchResultPanel.Controls.Clear();
            List<PanelTemplate> panels = load.LoadResults();
            foreach (PanelTemplate panel in panels)
            {
                searchResultPanel.Controls.Add(panel);
            }
        }

        private void malzemeAdd_Click(object sender, EventArgs e)
        {
            AddProductPanel malzemeAdd = new AddProductPanel(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);
            malzemeAdd.ShowDialog();
        }

        private void searchbar_TextChanged(object sender, EventArgs e)
        {
            searchResultPanel.Controls.Clear();
            List<PanelTemplate> panels=load.LoadResultFromSearch(searchbar.Text);
            foreach (PanelTemplate panel in panels)
            {
                searchResultPanel.Controls.Add(panel);
            }
        }
    }
}
