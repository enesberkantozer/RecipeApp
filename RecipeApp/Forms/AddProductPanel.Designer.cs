using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Drawing;
using Font = System.Drawing.Font;

namespace RecipeApp.Forms
{
    partial class AddProductPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxProductName = new TextBox();
            labelProductName = new Label();
            textBoxProductTotal = new TextBox();
            comboBoxProductUnit = new ComboBox();
            labelProductTotal = new Label();
            labelWarnTotal = new Label();
            labelProductCostPer = new Label();
            textBoxProductCostPer = new TextBox();
            buttonCancel = new Button();
            buttonSave = new Button();
            labelWarnCostPer = new Label();
            labelWarnUnit = new Label();
            SuspendLayout();
            // 
            // textBoxProductName
            // 
            textBoxProductName.Font = new Font("Segoe UI", 12F);
            textBoxProductName.Location = new Point(165, 45);
            textBoxProductName.Name = "textBoxProductName";
            textBoxProductName.Size = new Size(310, 34);
            textBoxProductName.TabIndex = 0;
            // 
            // labelProductName
            // 
            labelProductName.AutoSize = true;
            labelProductName.Font = new Font("Segoe UI", 12F);
            labelProductName.Location = new Point(24, 45);
            labelProductName.Name = "labelProductName";
            labelProductName.Size = new Size(135, 28);
            labelProductName.TabIndex = 1;
            labelProductName.Text = "Malzeme Adı :";
            // 
            // textBoxProductTotal
            // 
            textBoxProductTotal.Font = new Font("Segoe UI", 12F);
            textBoxProductTotal.Location = new Point(165, 113);
            textBoxProductTotal.Name = "textBoxProductTotal";
            textBoxProductTotal.Size = new Size(215, 34);
            textBoxProductTotal.TabIndex = 2;
            textBoxProductTotal.TextChanged += textBox2_TextChanged;
            // 
            // comboBoxProductUnit
            // 
            comboBoxProductUnit.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxProductUnit.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxProductUnit.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxProductUnit.Font = new Font("Segoe UI", 12F);
            comboBoxProductUnit.FormattingEnabled = true;
            comboBoxProductUnit.Items.AddRange(new object[] { "kg", "litre", "mg", "ml", "gram", "bardak", "çay bardağı", "kaşık", "tatlı kaşığı" });
            comboBoxProductUnit.Location = new Point(386, 111);
            comboBoxProductUnit.Name = "comboBoxProductUnit";
            comboBoxProductUnit.Size = new Size(89, 36);
            comboBoxProductUnit.TabIndex = 3;
            // 
            // labelProductTotal
            // 
            labelProductTotal.AutoSize = true;
            labelProductTotal.Font = new Font("Segoe UI", 12F);
            labelProductTotal.Location = new Point(12, 113);
            labelProductTotal.Name = "labelProductTotal";
            labelProductTotal.Size = new Size(147, 28);
            labelProductTotal.TabIndex = 4;
            labelProductTotal.Text = "Toplam Miktar :";
            // 
            // labelWarnTotal
            // 
            labelWarnTotal.AutoSize = true;
            labelWarnTotal.Location = new Point(165, 150);
            labelWarnTotal.Name = "labelWarnTotal";
            labelWarnTotal.Size = new Size(0, 20);
            labelWarnTotal.TabIndex = 5;
            // 
            // labelProductCostPer
            // 
            labelProductCostPer.AutoSize = true;
            labelProductCostPer.Font = new Font("Segoe UI", 12F);
            labelProductCostPer.Location = new Point(46, 181);
            labelProductCostPer.Name = "labelProductCostPer";
            labelProductCostPer.Size = new Size(113, 28);
            labelProductCostPer.TabIndex = 6;
            labelProductCostPer.Text = "Birim Fiyat :";
            // 
            // textBoxProductCostPer
            // 
            textBoxProductCostPer.Font = new Font("Segoe UI", 12F);
            textBoxProductCostPer.Location = new Point(165, 181);
            textBoxProductCostPer.Name = "textBoxProductCostPer";
            textBoxProductCostPer.Size = new Size(310, 34);
            textBoxProductCostPer.TabIndex = 7;
            textBoxProductCostPer.TextChanged += textBox3_TextChanged;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(60, 257);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(133, 56);
            buttonCancel.TabIndex = 8;
            buttonCancel.Text = "İptal";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += button1_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(294, 257);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(133, 56);
            buttonSave.TabIndex = 9;
            buttonSave.Text = "Kaydet";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += button2_Click;
            // 
            // labelWarnCostPer
            // 
            labelWarnCostPer.AutoSize = true;
            labelWarnCostPer.Location = new Point(165, 218);
            labelWarnCostPer.Name = "labelWarnCostPer";
            labelWarnCostPer.Size = new Size(0, 20);
            labelWarnCostPer.TabIndex = 10;
            // 
            // labelWarnUnit
            // 
            labelWarnUnit.AutoSize = true;
            labelWarnUnit.Location = new Point(386, 150);
            labelWarnUnit.Name = "labelWarnUnit";
            labelWarnUnit.Size = new Size(0, 20);
            labelWarnUnit.TabIndex = 11;
            // 
            // AddProductPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 342);
            ControlBox = false;
            Controls.Add(labelWarnUnit);
            Controls.Add(labelWarnCostPer);
            Controls.Add(buttonSave);
            Controls.Add(buttonCancel);
            Controls.Add(textBoxProductCostPer);
            Controls.Add(labelProductCostPer);
            Controls.Add(labelWarnTotal);
            Controls.Add(labelProductTotal);
            Controls.Add(comboBoxProductUnit);
            Controls.Add(textBoxProductTotal);
            Controls.Add(labelProductName);
            Controls.Add(textBoxProductName);
            Name = "AddProductPanel";
            Text = "MalzemeAddPanel";
            Load += AddProductPanel_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxProductName;
        private Label labelProductName;
        private TextBox textBoxProductTotal;
        private ComboBox comboBoxProductUnit;
        private Label labelProductTotal;
        private Label labelWarnTotal;
        private Label labelProductCostPer;
        private TextBox textBoxProductCostPer;
        private Button buttonCancel;
        private Button buttonSave;
        private Label labelWarnCostPer;
        private Label labelWarnUnit;
    }
}