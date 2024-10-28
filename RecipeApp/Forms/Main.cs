using RecipeApp.Databases;
using RecipeApp.Library;
using RecipeApp.Models;
using RecipeApp.Templates;

namespace RecipeApp.Forms
{
    public partial class Main : Form
    {
        public static readonly string connString= $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"UserData","Database","Database.mdf")};Integrated Security=True;";
        private MainLoad load = new MainLoad();
        private DetailedSearch detailedSearchForm;

        public static string? srchName = null;
        public static int? srchMinTime = 0, srchMaxTime = int.MaxValue;
        public static double? srchMinCost = 0, srchMaxCost = double.MaxValue;
        public static List<Product> srchAllProducts = new List<Product>();
        public static Dictionary<Product, double>? srchProducts = new Dictionary<Product, double>();
        public static List<string>? srchCategory = new List<string>();
        public Main()
        {
            InitializeComponent();
            MainLoad.InıtDatabase();
            this.StartPosition = FormStartPosition.CenterScreen;
            srchAllProducts = new DbProduct().GetAll();
            detailedSearchForm = new DetailedSearch();
            detailedSearchForm.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddRecipePanel addRecipePanel = new AddRecipePanel();
            addRecipePanel.ShowDialog(this);
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            searchbar.TextChanged -= searchbar_TextChanged;
            searchbar.Text = srchName;
            searchbar.TextChanged += searchbar_TextChanged;
            searchResultPanel.Controls.Clear();
            List<PanelTemp> panels = load.LoadResults(
                name: srchName,
                category: srchCategory,
                minTime: srchMinTime,
                maxTime: srchMaxTime,
                minCost: srchMinCost,
                maxCost: srchMaxCost,
                products: srchProducts);
            panels.ForEach(p => { searchResultPanel.Controls.Add(p); });
        }

        private void malzemeAdd_Click(object sender, EventArgs e)
        {
            AddProductPanel malzemeAdd = new AddProductPanel();
            malzemeAdd.ShowDialog();
        }

        private void searchbar_TextChanged(object sender, EventArgs e)
        {
            searchResultPanel.Controls.Clear();
            srchName = searchbar.Text;
            List<PanelTemp> panels = load.LoadResults(
                name: srchName,
                category: srchCategory,
                minTime: srchMinTime,
                maxTime: srchMaxTime,
                minCost: srchMinCost,
                maxCost: srchMaxCost,
                products: srchProducts
                );
            foreach (PanelTemp panel in panels)
            {
                searchResultPanel.Controls.Add(panel);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<PanelTemp> controls = new List<PanelTemp>();
            for (int i = 0; i < searchResultPanel.Controls.Count; i++)
            {
                controls = searchResultPanel.Controls.OfType<PanelTemp>().ToList();
            }
            if (comboBoxSort.SelectedIndex == 0)
            {
                controls = controls.OrderByDescending(x => x.Percent).ToList();
            }
            else if (comboBoxSort.SelectedIndex == 1)
            {
                controls = controls.OrderBy(x => x.Cost).ToList();
            }
            else if (comboBoxSort.SelectedIndex == 2)
            {
                controls = controls.OrderByDescending(x => x.Cost).ToList();
            }
            else if (comboBoxSort.SelectedIndex == 3)
            {
                controls = controls.OrderBy(x => x.Time).ToList();
            }
            else if (comboBoxSort.SelectedIndex == 4)
            {
                controls = controls.OrderByDescending(x => x.Time).ToList();
            }
            searchResultPanel.Controls.Clear();
            controls.ForEach(x => { searchResultPanel.Controls.Add(x); });
        }

        private void detailedSearch_Click(object sender, EventArgs e)
        {
            detailedSearchForm.Show(this);
        }
    }
}
