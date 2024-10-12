namespace RecipeApp.Forms
{
    partial class AddRecipePanel
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            textBox1 = new TextBox();
            panel2 = new Panel();
            label3 = new Label();
            label4 = new Label();
            comboBox3 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            richTextBox1 = new RichTextBox();
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(textBox1);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1064, 508);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            textBox1.Location = new Point(3, 3);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Tarif Adını Giriniz";
            textBox1.Size = new Size(1037, 31);
            textBox1.TabIndex = 1;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.Controls.Add(flowLayoutPanel2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(comboBox3);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(3, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(1037, 147);
            panel2.TabIndex = 2;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label3.Location = new Point(762, 9);
            label3.Name = "label3";
            label3.Size = new Size(110, 34);
            label3.TabIndex = 6;
            label3.Text = "Kategori";
            // 
            // label4
            // 
            label4.Location = new Point(567, 26);
            label4.Name = "label4";
            label4.Size = new Size(467, 27);
            label4.TabIndex = 7;
            label4.Text = "_________________________________________________________________________________________________________";
            // 
            // comboBox3
            // 
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(725, 56);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(179, 28);
            comboBox3.TabIndex = 5;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(1031, 34);
            label1.TabIndex = 1;
            label1.Text = "Malzemeler";
            // 
            // label2
            // 
            label2.Location = new Point(3, 26);
            label2.Name = "label2";
            label2.Size = new Size(547, 27);
            label2.TabIndex = 3;
            label2.Text = "_________________________________________________________________________________________________________";
            // 
            // panel3
            // 
            panel3.AutoSize = true;
            panel3.Controls.Add(richTextBox1);
            panel3.Location = new Point(3, 193);
            panel3.Name = "panel3";
            panel3.Size = new Size(939, 234);
            panel3.TabIndex = 3;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(91, 5);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(845, 226);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(3, 433);
            panel1.Name = "panel1";
            panel1.Size = new Size(1037, 105);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(725, 19);
            button2.Name = "button2";
            button2.Size = new Size(126, 68);
            button2.TabIndex = 1;
            button2.Text = "İptal";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(873, 19);
            button1.Name = "button1";
            button1.Size = new Size(126, 68);
            button1.TabIndex = 0;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Location = new Point(34, 58);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(489, 86);
            flowLayoutPanel2.TabIndex = 8;
            // 
            // AddRecipePanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 508);
            ControlBox = false;
            Controls.Add(flowLayoutPanel1);
            Name = "AddRecipePanel";
            Text = "AddRecipePanel";
            Load += AddRecipePanel_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Button button2;
        private Button button1;
        private TextBox textBox1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Panel panel3;
        private RichTextBox richTextBox1;
        private Label label3;
        private ComboBox comboBox3;
        private Label label4;
        private FlowLayoutPanel flowLayoutPanel2;
    }
}