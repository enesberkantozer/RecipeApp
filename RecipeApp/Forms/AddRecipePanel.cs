using Microsoft.IdentityModel.Tokens;
using RecipeApp.Databases;
using RecipeApp.Models;
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

namespace RecipeApp.Forms
{
    public partial class AddRecipePanel : Form
    {
        private bool isBold = false, isItalic = false, isUnderline = false, isInıt = true;

        public static List<Product> products = new List<Product>();
        public static Dictionary<Product, float> addedProducts = new Dictionary<Product, float>();
        private int locationX, locationY, sizeX, sizeY;
        public AddRecipePanel(int locationX, int locationY, int sizeX, int sizeY)
        {
            InitializeComponent();
            addedProducts.Clear();
            products.Clear();
            this.locationX = locationX;
            this.locationY = locationY;
            this.sizeX = sizeX;
            this.sizeY = sizeY;
        }

        private void AddRecipePanel_Load(object sender, EventArgs e)
        {
            this.Location = new Point(locationX + (sizeX - this.Size.Width) / 2, locationY + (sizeY - this.Size.Height) / 2);
            flowLayoutPanel1.VerticalScroll.Value = 0;
            DbProduct dbProduct = new DbProduct();
            products = dbProduct.GetAll();
            if (products.Count == 0)
            {
                DialogResult message = MessageBox.Show("Malzeme verisi çekilemedi", "Uyarı", MessageBoxButtons.OK);
                if (message == DialogResult.OK)
                {
                    this.Close();
                    this.Dispose();
                }
            }
            UpdateComboBox();
            int i = 8;
            while (i <= 72)
            {
                if (i < 12)
                {
                    fontSize.Items.Add(i.ToString());
                    i++;
                }
                else if (i < 36)
                {
                    fontSize.Items.Add(i.ToString());
                    i = (i == 30) ? 36 : i + 2;
                }
                else
                {
                    fontSize.Items.Add(i.ToString());
                    i += 12;
                }
            }
            fontSize.ComboBox.SelectedItem = "9";
            foreach (FontFamily fontFam in FontFamily.Families)
            {
                fontFamily.Items.Add(fontFam.Name);
            }
            fontFamily.ComboBox.SelectedItem = "Segoe UI";
            isInıt = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int time = Convert.ToInt32((hour.Value * 3600) + (minute.Value * 60) + second.Value);
            if (recipeName.Text.IsNullOrEmpty())
            {
                labelWarn.Text = "UYARI:\nTarif adı boş olamaz.";
                timer1.Start();
                return;
            }
            else if (category.SelectedIndex == -1)
            {
                labelWarn.Text = "UYARI:\nKategori boş olamaz.";
                timer1.Start();
                return;
            }
            else if (flowLayoutPanel2.Controls.Count < 2)
            {
                labelWarn.Text = "UYARI:\nTarif için en az 2 malzeme ekli olmalı.";
                timer1.Start();
                return;
            }
            else if (description.Text.IsNullOrEmpty())
            {
                labelWarn.Text = "UYARI:\nTalimat boş olamaz.";
                timer1.Start();
                return;
            }
            else if (time == 0)
            {
                labelWarn.Text = "UYARI:\nZaman boş olamaz.";
                timer1.Start();
                return;
            }
            DialogResult dialog = MessageBox.Show("Kayıt tamamlanacaktır.\nOnaylıyor musunuz?", "Emin Misiniz?", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Recipe recipe = new Recipe(recipeName.Text, category.SelectedItem.ToString(), time, description.Rtf);
                DbRecipe dbRecipe = new DbRecipe();
                bool isSavedRecipe = dbRecipe.Save(recipe);
                List<Recipe> recipes = new List<Recipe>();
                recipes = dbRecipe.GetWithName(recipeName.Text);
                foreach (Recipe r in recipes)
                {
                    if (r.Name.Equals(recipe.Name) && r.Category.Equals(recipe.Category) && r.Time == recipe.Time && r.Description.Equals(recipe.Description))
                    {
                        recipe.Id = r.Id;
                        break;
                    }
                }
                DbRecipeProduct dbRecipeProduct = new DbRecipeProduct();
                int savedProduct = 0;
                foreach (Product p in addedProducts.Keys)
                {

                    bool isSavedRecipeProduct = dbRecipeProduct.Save(recipe, p, addedProducts[p]);
                    if (isSavedRecipeProduct)
                    {
                        savedProduct++;
                    }
                }
                if (isSavedRecipe && savedProduct == flowLayoutPanel2.Controls.Count)
                {
                    MessageBox.Show("Başarıyla Kaydedildi");
                    this.Close();
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Veritabanına kaydedilirken bir hata ile karşılaşıldı");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem is Product p)
            {
                AddProductinRecipe panel = new AddProductinRecipe(p);
                flowLayoutPanel2.Controls.Add(panel);
                addedProducts[p] = 0.01f;
                products.Remove(p);
                UpdateComboBox();
            }
        }

        private void flowLayoutPanel2_Control(object sender, ControlEventArgs e)
        {
            UpdateComboBox();
        }

        private void UpdateComboBox()
        {
            comboBox1.DataSource = products.OrderBy(x => x.Name).ToArray();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";
            comboBox1.SelectedIndex = -1;
            comboBox1.Text = "Malzeme Seçiniz";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelWarn.Text = "";
            timer1.Stop();
        }

        private void descriptionText(object sender, EventArgs e)
        {
            if (isInıt) return;
            try
            {
                int a = int.Parse(fontSize.ComboBox.Text)==null ? -1: int.Parse(fontSize.ComboBox.Text);
                if (fontFamily.ComboBox.SelectedItem is null)
                    throw new NullReferenceException();
            }
            catch (NullReferenceException)
            {
                fontFamily.ComboBox.SelectedItem = description.Font.FontFamily.Name;
            }
            catch (Exception)
            {
                fontSize.ComboBox.SelectedText=description.Font.Size.ToString();
            }
            FontStyle fontStyle = FontStyle.Regular;
            if (boldButton.Checked)
                fontStyle |= FontStyle.Bold;
            if (italicButton.Checked)
                fontStyle |= FontStyle.Italic;
            if (underlineButton.Checked)
                fontStyle |= FontStyle.Underline;
            if (description.SelectionLength > 0)
                description.SelectionFont = new Font(fontFamily.ComboBox.SelectedItem.ToString(), int.Parse(fontSize.ComboBox.Text), fontStyle);
            else
                description.Font = new Font(fontFamily.ComboBox.SelectedItem.ToString(), int.Parse(fontSize.ComboBox.Text), fontStyle);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            description.Text = "";
        }
    }
}
