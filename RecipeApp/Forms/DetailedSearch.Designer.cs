namespace RecipeApp.Forms
{
    partial class DetailedSearch
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
            panel2 = new Panel();
            label9 = new Label();
            label8 = new Label();
            label5 = new Label();
            minSecond = new NumericUpDown();
            minMinute = new NumericUpDown();
            minHour = new NumericUpDown();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            maxSecond = new NumericUpDown();
            maxMinute = new NumericUpDown();
            maxHour = new NumericUpDown();
            button4 = new Button();
            comboBox1 = new ComboBox();
            searchFlowProduct = new FlowLayoutPanel();
            label2 = new Label();
            categoryFlowLayoutPanel = new FlowLayoutPanel();
            label1 = new Label();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            textBox1 = new TextBox();
            checkBox1 = new CheckBox();
            label7 = new Label();
            label6 = new Label();
            maxCost = new NumericUpDown();
            minCost = new NumericUpDown();
            label4 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)minSecond).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minMinute).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minHour).BeginInit();
            ((System.ComponentModel.ISupportInitialize)maxSecond).BeginInit();
            ((System.ComponentModel.ISupportInitialize)maxMinute).BeginInit();
            ((System.ComponentModel.ISupportInitialize)maxHour).BeginInit();
            ((System.ComponentModel.ISupportInitialize)maxCost).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minCost).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(731, 427);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(minSecond);
            panel2.Controls.Add(minMinute);
            panel2.Controls.Add(minHour);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(maxSecond);
            panel2.Controls.Add(maxMinute);
            panel2.Controls.Add(maxHour);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(searchFlowProduct);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(categoryFlowLayoutPanel);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(checkBox3);
            panel2.Controls.Add(checkBox2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(checkBox1);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(maxCost);
            panel2.Controls.Add(minCost);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(699, 334);
            panel2.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(234, 234);
            label9.Name = "label9";
            label9.Size = new Size(52, 20);
            label9.TabIndex = 26;
            label9.Text = "Saniye";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(176, 234);
            label8.Name = "label8";
            label8.Size = new Size(54, 20);
            label8.TabIndex = 25;
            label8.Text = "Dakika";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(117, 234);
            label5.Name = "label5";
            label5.Size = new Size(38, 20);
            label5.TabIndex = 24;
            label5.Text = "Saat";
            // 
            // minSecond
            // 
            minSecond.Location = new Point(234, 204);
            minSecond.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            minSecond.Name = "minSecond";
            minSecond.Size = new Size(52, 27);
            minSecond.TabIndex = 12;
            minSecond.Tag = "Time";
            minSecond.ValueChanged += numericUpDown3_ValueChanged;
            // 
            // minMinute
            // 
            minMinute.Location = new Point(176, 204);
            minMinute.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            minMinute.Name = "minMinute";
            minMinute.Size = new Size(52, 27);
            minMinute.TabIndex = 11;
            minMinute.Tag = "Time";
            minMinute.ValueChanged += numericUpDown3_ValueChanged;
            // 
            // minHour
            // 
            minHour.Location = new Point(117, 204);
            minHour.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            minHour.Name = "minHour";
            minHour.Size = new Size(52, 27);
            minHour.TabIndex = 10;
            minHour.Tag = "Time";
            minHour.ValueChanged += numericUpDown3_ValueChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(471, 234);
            label10.Name = "label10";
            label10.Size = new Size(52, 20);
            label10.TabIndex = 29;
            label10.Text = "Saniye";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(413, 234);
            label11.Name = "label11";
            label11.Size = new Size(54, 20);
            label11.TabIndex = 28;
            label11.Text = "Dakika";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(354, 234);
            label12.Name = "label12";
            label12.Size = new Size(38, 20);
            label12.TabIndex = 27;
            label12.Text = "Saat";
            // 
            // maxSecond
            // 
            maxSecond.Location = new Point(471, 204);
            maxSecond.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            maxSecond.Name = "maxSecond";
            maxSecond.Size = new Size(52, 27);
            maxSecond.TabIndex = 15;
            maxSecond.Tag = "Time";
            maxSecond.ValueChanged += numericUpDown3_ValueChanged;
            // 
            // maxMinute
            // 
            maxMinute.Location = new Point(413, 204);
            maxMinute.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            maxMinute.Name = "maxMinute";
            maxMinute.Size = new Size(52, 27);
            maxMinute.TabIndex = 14;
            maxMinute.Tag = "Time";
            maxMinute.ValueChanged += numericUpDown3_ValueChanged;
            // 
            // maxHour
            // 
            maxHour.Location = new Point(354, 204);
            maxHour.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            maxHour.Name = "maxHour";
            maxHour.Size = new Size(52, 27);
            maxHour.TabIndex = 13;
            maxHour.Tag = "Time";
            maxHour.ValueChanged += numericUpDown3_ValueChanged;
            // 
            // button4
            // 
            button4.Location = new Point(291, 294);
            button4.Name = "button4";
            button4.Size = new Size(77, 29);
            button4.TabIndex = 23;
            button4.Text = "Ekle";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(18, 294);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(267, 28);
            comboBox1.TabIndex = 22;
            // 
            // searchFlowProduct
            // 
            searchFlowProduct.AutoSize = true;
            searchFlowProduct.BorderStyle = BorderStyle.FixedSingle;
            searchFlowProduct.Location = new Point(18, 329);
            searchFlowProduct.MaximumSize = new Size(440, 99999);
            searchFlowProduct.MinimumSize = new Size(440, 0);
            searchFlowProduct.Name = "searchFlowProduct";
            searchFlowProduct.Size = new Size(440, 2);
            searchFlowProduct.TabIndex = 21;
            searchFlowProduct.Tag = "searchFlowProduct";
            searchFlowProduct.ControlRemoved += searchFlowProduct_ControlRemoved;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline);
            label2.Location = new Point(21, 263);
            label2.Name = "label2";
            label2.Size = new Size(134, 28);
            label2.TabIndex = 21;
            label2.Text = "Malzemeler :";
            // 
            // categoryFlowLayoutPanel
            // 
            categoryFlowLayoutPanel.AutoSize = true;
            categoryFlowLayoutPanel.BorderStyle = BorderStyle.FixedSingle;
            categoryFlowLayoutPanel.Location = new Point(480, 294);
            categoryFlowLayoutPanel.MaximumSize = new Size(216, 99999);
            categoryFlowLayoutPanel.MinimumSize = new Size(216, 0);
            categoryFlowLayoutPanel.Name = "categoryFlowLayoutPanel";
            categoryFlowLayoutPanel.Size = new Size(216, 2);
            categoryFlowLayoutPanel.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline);
            label1.Location = new Point(480, 263);
            label1.Name = "label1";
            label1.Size = new Size(104, 28);
            label1.TabIndex = 19;
            label1.Text = "Kategori :";
            // 
            // checkBox3
            // 
            checkBox3.AutoCheck = false;
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline);
            checkBox3.Location = new Point(13, 166);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(178, 32);
            checkBox3.TabIndex = 18;
            checkBox3.Text = "Zaman Aralığı :";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoCheck = false;
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline);
            checkBox2.Location = new Point(13, 87);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(186, 32);
            checkBox2.TabIndex = 17;
            checkBox2.Text = "Maliyet Aralığı :";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 11F);
            textBox1.Location = new Point(68, 38);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Tarif ismi ile aratın";
            textBox1.Size = new Size(439, 32);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoCheck = false;
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline);
            checkBox1.Location = new Point(13, 3);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(126, 32);
            checkBox1.TabIndex = 16;
            checkBox1.Text = "Tarif Adı :";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label7.Location = new Point(301, 201);
            label7.Name = "label7";
            label7.Size = new Size(59, 25);
            label7.TabIndex = 9;
            label7.Text = "Max : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label6.Location = new Point(66, 201);
            label6.Name = "label6";
            label6.Size = new Size(56, 25);
            label6.TabIndex = 8;
            label6.Text = "Min : ";
            // 
            // maxCost
            // 
            maxCost.DecimalPlaces = 2;
            maxCost.Location = new Point(354, 127);
            maxCost.Name = "maxCost";
            maxCost.Size = new Size(111, 27);
            maxCost.TabIndex = 4;
            maxCost.Tag = "Cost";
            maxCost.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // minCost
            // 
            minCost.DecimalPlaces = 2;
            minCost.Location = new Point(117, 125);
            minCost.Name = "minCost";
            minCost.Size = new Size(111, 27);
            minCost.TabIndex = 3;
            minCost.Tag = "Cost";
            minCost.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(301, 127);
            label4.Name = "label4";
            label4.Size = new Size(59, 25);
            label4.TabIndex = 6;
            label4.Text = "Max : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(66, 125);
            label3.Name = "label3";
            label3.Size = new Size(56, 25);
            label3.TabIndex = 5;
            label3.Text = "Min : ";
            // 
            // panel1
            // 
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 427);
            panel1.Name = "panel1";
            panel1.Size = new Size(731, 80);
            panel1.TabIndex = 1;
            // 
            // button3
            // 
            button3.Location = new Point(18, 20);
            button3.Name = "button3";
            button3.Size = new Size(98, 38);
            button3.TabIndex = 2;
            button3.Text = "Kapat";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(463, 20);
            button2.Name = "button2";
            button2.Size = new Size(124, 38);
            button2.TabIndex = 1;
            button2.Text = "Filtre Temizle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(601, 20);
            button1.Name = "button1";
            button1.Size = new Size(98, 38);
            button1.TabIndex = 0;
            button1.Text = "Ara";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // DetailedSearch
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(731, 507);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Name = "DetailedSearch";
            Text = "Detaylı Arama ve Filtreleme";
            Activated += DetailedSearch_Activated;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)minSecond).EndInit();
            ((System.ComponentModel.ISupportInitialize)minMinute).EndInit();
            ((System.ComponentModel.ISupportInitialize)minHour).EndInit();
            ((System.ComponentModel.ISupportInitialize)maxSecond).EndInit();
            ((System.ComponentModel.ISupportInitialize)maxMinute).EndInit();
            ((System.ComponentModel.ISupportInitialize)maxHour).EndInit();
            ((System.ComponentModel.ISupportInitialize)maxCost).EndInit();
            ((System.ComponentModel.ISupportInitialize)minCost).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel2;
        private TextBox textBox1;
        private Panel panel1;
        private NumericUpDown minCost;
        private Label label4;
        private Label label3;
        private NumericUpDown maxCost;
        private NumericUpDown minSecond;
        private NumericUpDown minMinute;
        private NumericUpDown minHour;
        private Label label7;
        private Label label6;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private NumericUpDown maxSecond;
        private NumericUpDown maxMinute;
        private NumericUpDown maxHour;
        private CheckBox checkBox3;
        private Label label1;
        private FlowLayoutPanel categoryFlowLayoutPanel;
        private Button button2;
        private Button button1;
        private Button button3;
        private FlowLayoutPanel searchFlowProduct;
        private Label label2;
        private Button button4;
        private ComboBox comboBox1;
        private Label label9;
        private Label label8;
        private Label label5;
        private Label label10;
        private Label label11;
        private Label label12;
    }
}