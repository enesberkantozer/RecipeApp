namespace RecipeApp.Templates
{
    partial class AddProductinRecipe
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            numericUpDown1 = new NumericUpDown();
            button1 = new Button();
            labelWarn = new Label();
            labelUnit = new Label();
            labelName = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(236, 18);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(90, 27);
            numericUpDown1.TabIndex = 1;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.FlatAppearance.BorderSize = 0;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.White;
            button1.Location = new Point(397, 16);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Sil";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // labelWarn
            // 
            labelWarn.AutoSize = true;
            labelWarn.Location = new Point(19, 39);
            labelWarn.Name = "labelWarn";
            labelWarn.Size = new Size(0, 20);
            labelWarn.TabIndex = 3;
            // 
            // labelUnit
            // 
            labelUnit.Location = new Point(332, 18);
            labelUnit.Name = "labelUnit";
            labelUnit.Size = new Size(52, 25);
            labelUnit.TabIndex = 4;
            labelUnit.Text = "Litre";
            // 
            // labelName
            // 
            labelName.AutoEllipsis = true;
            labelName.Location = new Point(19, 20);
            labelName.Name = "labelName";
            labelName.Size = new Size(197, 20);
            labelName.TabIndex = 5;
            labelName.Tag = "";
            labelName.Text = "label1";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1, 63);
            panel1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Location = new Point(229, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1, 63);
            panel2.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaptionText;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(498, 1);
            panel3.TabIndex = 7;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaptionText;
            panel4.Location = new Point(0, 62);
            panel4.Name = "panel4";
            panel4.Size = new Size(498, 1);
            panel4.TabIndex = 8;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ActiveCaptionText;
            panel5.Location = new Point(497, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(1, 63);
            panel5.TabIndex = 8;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ActiveCaptionText;
            panel6.Location = new Point(390, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(1, 63);
            panel6.TabIndex = 9;
            // 
            // AddProductinRecipe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(button1);
            Controls.Add(labelName);
            Controls.Add(labelUnit);
            Controls.Add(labelWarn);
            Controls.Add(numericUpDown1);
            Margin = new Padding(0);
            Name = "AddProductinRecipe";
            Size = new Size(500, 63);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private NumericUpDown numericUpDown1;
        private Button button1;
        private Label labelWarn;
        private Label labelUnit;
        private Label labelName;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
    }
}
