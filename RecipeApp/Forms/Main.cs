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
            MainLoad load = new MainLoad();
            List<PanelTemplate> panels = load.LoadResults();
            for (int i = 0; i < panels.Count; i++)
            {
                searchResultPanel.Controls.Add(panels[i]);
            }
        }

        private void malzemeAdd_Click(object sender, EventArgs e)
        {
            AddProductPanel malzemeAdd = new AddProductPanel(this.Location.X,this.Location.Y,this.Size.Width,this.Size.Height);
            malzemeAdd.ShowDialog();
        }
    }
}
