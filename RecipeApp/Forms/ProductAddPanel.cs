using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TarifApp.Forms
{
    public partial class ProductAddPanel : Form
    {
        public ProductAddPanel()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int test = int.Parse(textBox2.Text);
                label3.Text = "";
            }
            catch (Exception ex)
            {
                label3.Text = "Sayı girişi yapınız";
                textBox2.Text = "";
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            string connectionString = "Data Source=ENESBERKANT-PC\\SQLEXPRESS;Initial Catalog=TarifApp;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
            using (SqlConnection connection=new SqlConnection(connectionString))
            {
                connection.Open();
                string command = "INSERT INTO Malzeme (MalzemeAdi,ToplamMiktar,MalzemeBirim,BirimFiyat) VALUES (@MalzemeAdi,@ToplamMiktar,@MalzemeBirim,@BirimFiyat)";
                using (SqlCommand sqlCommand = new SqlCommand(command, connection)) 
                {
                    sqlCommand.Parameters.AddWithValue("@MalzemeAdi",textBox1.Text);
                    sqlCommand.Parameters.AddWithValue("@ToplamMiktar",textBox2.Text);
                    sqlCommand.Parameters.AddWithValue("@MalzemeBirim",comboBox1.SelectedItem.ToString());
                    sqlCommand.Parameters.AddWithValue("@BirimFiyat", float.Parse(textBox3.Text));
                    int isSucess= sqlCommand.ExecuteNonQuery();
                    if (isSucess == 1) {
                        MessageBox.Show("Başarıyla Kaydedildi");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Kaydedilemedi, tekrar deneyin.");
                        this.ShowDialog();
                    }
                }
                
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox3.Text.Contains('.'))
                {
                    label5.Text = "deneme";
                    throw new Exception(".");
                }
                float test = float.Parse(textBox3.Text);
                label5.Text = "";
            }
            catch (Exception ex) 
            { 
                if(ex.Message.Equals("."))
                { label5.Text = "Ondalıklı değer için . (nokta) yerine , (virgül) kullanınız."; }
                else
                { label5.Text = "Geçerli bir değer giriniz."; }
                textBox3.Text = "";
            }
        }
    }
}
