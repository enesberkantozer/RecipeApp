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
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(173, 13);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(79, 27);
            numericUpDown1.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.FlatAppearance.BorderSize = 0;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.White;
            button1.Location = new Point(349, 11);
            button1.Name = "button1";
            button1.Size = new Size(76, 29);
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
            labelUnit.Location = new Point(258, 0);
            labelUnit.Name = "labelUnit";
            labelUnit.Size = new Size(85, 57);
            labelUnit.TabIndex = 4;
            labelUnit.Text = "Litre";
            labelUnit.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelName
            // 
            labelName.AutoEllipsis = true;
            labelName.Location = new Point(3, 0);
            labelName.Name = "labelName";
            labelName.Size = new Size(164, 57);
            labelName.TabIndex = 5;
            labelName.Tag = "";
            labelName.Text = "label1";
            labelName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // AddProductinRecipe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(button1);
            Controls.Add(labelName);
            Controls.Add(labelUnit);
            Controls.Add(labelWarn);
            Controls.Add(numericUpDown1);
            Margin = new Padding(0);
            Name = "AddProductinRecipe";
            Size = new Size(428, 57);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public NumericUpDown numericUpDown1;
        public Button button1;
        private Label labelWarn;
        private Label labelUnit;
        private Label labelName;
    }
}
