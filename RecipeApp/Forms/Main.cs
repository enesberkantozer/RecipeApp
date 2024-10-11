using RecipeApp.Library;
using RecipeApp.Templates;
using TarifApp.Forms;

namespace TarifApp
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tarif Eklendi");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            searchResultPanel.Controls.Clear();
            MainLoad load=new MainLoad();
            List<PanelTemplate> panels = load.LoadResults();
            for (int i = 0; i < panels.Count; i++) 
            {
                searchResultPanel.Controls.Add(panels[i]);
            }
        }

        private void malzemeAdd_Click(object sender, EventArgs e)
        {
            ProductAddPanel malzemeAdd=new ProductAddPanel();
            malzemeAdd.ShowDialog();
        }
    }
}
