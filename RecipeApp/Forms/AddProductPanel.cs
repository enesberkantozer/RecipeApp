using Microsoft.Data.SqlClient;
using RecipeApp.Databases;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RecipeApp.Forms
{
    public partial class AddProductPanel : Form
    {
        private int locationX,locationY,sizeX,sizeY;
        public AddProductPanel(int locationX,int locationY, int sizeX, int sizeY)
        {
            InitializeComponent();
            this.locationX = locationX;
            this.locationY = locationY;
            this.sizeX = sizeX;
            this.sizeY = sizeY;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int test = int.Parse(textBoxProductTotal.Text);
                labelWarnTotal.Text = "";
            }
            catch (Exception ex)
            {
                labelWarnTotal.Text = "Sayı girişi yapınız";
                textBoxProductTotal.Text = "";
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBoxProductName.Text.Length > 0 && textBoxProductTotal.Text.Length > 0 &&
                comboBoxProductUnit.SelectedIndex != -1 && textBoxProductCostPer.Text.Length > 0)
            {
                this.Hide();
                Product p = new Product(textBoxProductName.Text, textBoxProductTotal.Text, comboBoxProductUnit.SelectedItem.ToString(), double.Parse(textBoxProductCostPer.Text));
                DbProduct db = new DbProduct();
                if (db.Save(p))
                {
                    this.Close();
                }
                else
                {
                    this.Show();
                    labelWarnCostPer.Text = "Kayıt Başarısız. Tekrar kaydetmeye çalış.";
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

        private void AddProductPanel_Load(object sender, EventArgs e)
        {
            this.Location = new Point(locationX + (sizeX - this.Size.Width)/2,locationY+(sizeY-this.Size.Height)/2);
        }
    }
}
