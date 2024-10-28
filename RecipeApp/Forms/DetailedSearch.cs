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
    public partial class DetailedSearch : Form
    {
        public DetailedSearch()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            comboBox1.DataSource = Main.srchAllProducts.ToArray();
            comboBox1.DisplayMember = "Name";
            comboBox1.SelectedIndex = -1;
            DbRecipe dbRecipe = new DbRecipe();
            List<string> list = dbRecipe.GetCategoryList();
            list.ForEach(item =>
            {
                CheckBox cbox = new CheckBox();
                cbox.Text = item.ToString();
                cbox.Size = new Size(216, 25);
                cbox.CheckedChanged += (sender, e) =>
                {
                    if (cbox.Checked)
                        Main.srchCategory.Add(cbox.Text.ToString());
                    else
                        Main.srchCategory.Remove(cbox.Text.ToString());
                };
                categoryFlowLayoutPanel.Controls.Add(cbox);
            });
            minCost.Maximum=decimal.MaxValue;
            maxCost.Maximum = decimal.MaxValue;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem is Product)
            {
                AddProductinRecipe r = new AddProductinRecipe((Product)comboBox1.SelectedItem, 0.01);
                r.Tag = (Product)comboBox1.SelectedItem;
                searchFlowProduct.Controls.Add(r);
                Main.srchAllProducts.Remove((Product)comboBox1.SelectedItem);
                comboBox1.DataSource = Main.srchAllProducts.ToArray();
                comboBox1.DisplayMember = "Name";
                comboBox1.Text = "";
                comboBox1.SelectedIndex = -1;
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void DetailedSearch_Activated(object sender, EventArgs e)
        {
            textBox1.Text = Main.srchName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main.srchName = null;
            Main.srchMinTime = 0;
            Main.srchMaxTime = int.MaxValue;
            Main.srchMinCost = 0;
            Main.srchMaxCost = double.MaxValue;
            Main.srchAllProducts = new DbProduct().GetAll();
            Main.srchProducts = new Dictionary<Product, double>();
            Main.srchCategory = new List<string>();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main.srchProducts.Clear();
            Main.srchCategory.Clear();

            Main.srchName = textBox1.Text;
            if (checkBox2.Checked)
            {
                Main.srchMinCost = Convert.ToDouble(minCost.Value);
                Main.srchMaxCost = Convert.ToDouble(maxCost.Value);
            }
            if (checkBox3.Checked)
            {
                int mintime = Convert.ToInt32((3600 * minHour.Value) + (60 * minMinute.Value) + minSecond.Value);
                int maxtime = Convert.ToInt32((3600 * maxHour.Value) + (60 * maxMinute.Value) + maxSecond.Value);
                Main.srchMinTime = mintime;
                Main.srchMaxTime = maxtime;
            }
            List<AddProductinRecipe> productlist = searchFlowProduct.Controls.OfType<AddProductinRecipe>().ToList();
            foreach (AddProductinRecipe item in productlist)
            {
                Main.srchProducts.Add(item.Product, item.GetNumericValue());
            }
            List<string> list = categoryFlowLayoutPanel.Controls.OfType<CheckBox>().Where(x => x.Checked).Select(x => x.Text).ToList();
            list.ForEach(x => Main.srchCategory.Add(x));
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                checkBox1.Checked = true;
            }
            else
            {
                checkBox1.Checked = false;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (minCost.Value > 0 || maxCost.Value > 0)
                checkBox2.Checked = true;
            else
                checkBox2.Checked = false;
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown[] list = new NumericUpDown[] { minHour, minMinute,
                minSecond,maxSecond,maxMinute,maxHour};
            bool check = false;
            foreach (NumericUpDown item in list)
            {
                if (item.Value > 0)
                    check = true;
            }
            checkBox3.Checked = check;
        }

        private void searchFlowProduct_ControlRemoved(object sender, ControlEventArgs e)
        {
            comboBox1.DataSource = Main.srchAllProducts.ToArray();
            comboBox1.DisplayMember = "Name";
            comboBox1.Text = "";
            comboBox1.SelectedIndex = -1;
        }
    }
}
