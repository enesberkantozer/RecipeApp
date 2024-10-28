using RecipeApp.Databases;
using RecipeApp.Models;

namespace RecipeApp.Forms
{
    public partial class AddProductPanel : Form
    {
        public AddProductPanel()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            DbProduct db = new DbProduct();
            List<Product> products = db.GetAll();
            comboBox1.SelectedIndexChanged -= comboBox1_SelectedIndexChanged;
            comboBox1.DataSource = products;
            comboBox1.DisplayMember = "Name";
            comboBox1.SelectedIndex = -1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int test = int.Parse(textBoxProductTotal.Text);
                labelWarnTotal.Text = "";
            }
            catch (Exception)
            {
                labelWarnTotal.Text = "Sayı girişi yapınız";
                textBoxProductTotal.Text = "";
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (textBoxProductName.Text.Length > 0 && textBoxProductTotal.Text.Length > 0 &&
                comboBoxProductUnit.SelectedIndex != -1 && textBoxProductCostPer.Text.Length > 0)
            {
                DialogResult dialog = MessageBox.Show("Kayıt tamamlanacaktır.\nOnaylıyor musunuz?", "Emin Misiniz?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    this.Hide();
                    bool isSaved = false;
                    DbProduct db = new DbProduct();
                    if (((Button)sender).Text.Equals("Kaydet"))
                    {
                        Product p = new Product(textBoxProductName.Text, textBoxProductTotal.Text, comboBoxProductUnit.SelectedItem.ToString(), double.Parse(textBoxProductCostPer.Text));
                        isSaved = await db.Save(p);
                    }
                    else if (((Button)sender).Text.Equals("Güncelle"))
                    {
                        Product p = new Product(((Product)comboBox1.SelectedItem).Id,textBoxProductName.Text, textBoxProductTotal.Text, comboBoxProductUnit.SelectedItem.ToString(), double.Parse(textBoxProductCostPer.Text));
                        isSaved = db.Update(p);
                    }
                    if (isSaved)
                    {
                        Main.srchAllProducts.Clear();
                        Main.srchAllProducts=db.GetAll();
                        Main.srchAllProducts.ForEach(x => {
                            if (Main.srchProducts.ContainsKey(x))
                                Main.srchAllProducts.Remove(x);
                        });
                        this.Close();
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Kayıt Başarısız. Tekrar kaydetmeye çalış.");
                        this.Show();
                    }
                }
            }
            else
            {
                labelWarnCostPer.Text = "Boş alan bırakmayınız.";
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBoxProductCostPer.Text.Contains('.'))
                {
                    labelWarnCostPer.Text = "deneme";
                    throw new Exception(".");
                }
                float test = float.Parse(textBoxProductCostPer.Text);
                labelWarnCostPer.Text = "";
            }
            catch (Exception ex)
            {
                if (ex.Message.Equals("."))
                { labelWarnCostPer.Text = "Ondalıklı değer için . (nokta) yerine , (virgül) kullanınız."; }
                else
                { labelWarnCostPer.Text = "Geçerli bir değer giriniz."; }
                textBoxProductCostPer.Text = "";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem is Product)
            {
                textBoxProductName.Text= ((Product)comboBox1.SelectedItem).Name;
                textBoxProductTotal.Text= ((Product)comboBox1.SelectedItem).Total;
                textBoxProductCostPer.Text=((Product)comboBox1.SelectedItem).CostPer.ToString();
                comboBoxProductUnit.SelectedItem=((Product)comboBox1.SelectedItem).Unit.ToString();
                buttonSave.Text = "Güncelle";
            } 
        }
    }
}
