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
            components = new System.ComponentModel.Container();
            flowLayoutPanel1 = new FlowLayoutPanel();
            recipeName = new TextBox();
            panel2 = new Panel();
            secondlbl = new Label();
            minutelbl = new Label();
            hourlbl = new Label();
            hourCombo = new NumericUpDown();
            minuteCombo = new NumericUpDown();
            secondCombo = new NumericUpDown();
            label3 = new Label();
            timelbl = new Label();
            label7 = new Label();
            label5 = new Label();
            label6 = new Label();
            addProductButton = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            productCombo = new ComboBox();
            label4 = new Label();
            category = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            description = new RichTextBox();
            toolStrip1 = new ToolStrip();
            fontSize = new ToolStripComboBox();
            toolStripSeparator1 = new ToolStripSeparator();
            boldButton = new ToolStripButton();
            italicButton = new ToolStripButton();
            underlineButton = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            fontFamily = new ToolStripComboBox();
            toolStripButton4 = new ToolStripButton();
            label8 = new Label();
            label9 = new Label();
            panel1 = new Panel();
            buttonClose = new Button();
            labelWarn = new Label();
            buttonCancel = new Button();
            buttonOk = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            flowLayoutPanel3 = new FlowLayoutPanel();
            addPictureButton = new Button();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hourCombo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minuteCombo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)secondCombo).BeginInit();
            panel3.SuspendLayout();
            toolStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(recipeName);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(977, 634);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // recipeName
            // 
            recipeName.BackColor = SystemColors.Control;
            recipeName.BorderStyle = BorderStyle.None;
            recipeName.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            recipeName.Location = new Point(3, 3);
            recipeName.Name = "recipeName";
            recipeName.PlaceholderText = "Tarif Adını Giriniz";
            recipeName.Size = new Size(938, 31);
            recipeName.TabIndex = 1;
            recipeName.TextAlign = HorizontalAlignment.Center;
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(secondlbl);
            panel2.Controls.Add(minutelbl);
            panel2.Controls.Add(hourlbl);
            panel2.Controls.Add(hourCombo);
            panel2.Controls.Add(minuteCombo);
            panel2.Controls.Add(secondCombo);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(timelbl);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(addProductButton);
            panel2.Controls.Add(flowLayoutPanel2);
            panel2.Controls.Add(productCombo);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(category);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(3, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(942, 185);
            panel2.TabIndex = 2;
            // 
            // secondlbl
            // 
            secondlbl.AutoSize = true;
            secondlbl.Location = new Point(828, 54);
            secondlbl.Name = "secondlbl";
            secondlbl.Size = new Size(52, 20);
            secondlbl.TabIndex = 20;
            secondlbl.Text = "Saniye";
            // 
            // minutelbl
            // 
            minutelbl.AutoSize = true;
            minutelbl.Location = new Point(731, 54);
            minutelbl.Name = "minutelbl";
            minutelbl.Size = new Size(54, 20);
            minutelbl.TabIndex = 19;
            minutelbl.Text = "Dakika";
            // 
            // hourlbl
            // 
            hourlbl.AutoSize = true;
            hourlbl.Location = new Point(641, 53);
            hourlbl.Name = "hourlbl";
            hourlbl.Size = new Size(38, 20);
            hourlbl.TabIndex = 18;
            hourlbl.Text = "Saat";
            // 
            // hourCombo
            // 
            hourCombo.Location = new Point(628, 76);
            hourCombo.Maximum = new decimal(new int[] { 23, 0, 0, 0 });
            hourCombo.Name = "hourCombo";
            hourCombo.Size = new Size(70, 27);
            hourCombo.TabIndex = 17;
            hourCombo.TextAlign = HorizontalAlignment.Center;
            // 
            // minuteCombo
            // 
            minuteCombo.Location = new Point(726, 76);
            minuteCombo.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            minuteCombo.Name = "minuteCombo";
            minuteCombo.Size = new Size(70, 27);
            minuteCombo.TabIndex = 16;
            minuteCombo.TextAlign = HorizontalAlignment.Center;
            // 
            // secondCombo
            // 
            secondCombo.Location = new Point(819, 76);
            secondCombo.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            secondCombo.Name = "secondCombo";
            secondCombo.Size = new Size(70, 27);
            secondCombo.TabIndex = 15;
            secondCombo.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label3.Location = new Point(703, 104);
            label3.Name = "label3";
            label3.Size = new Size(110, 34);
            label3.TabIndex = 6;
            label3.Text = "Kategori";
            // 
            // timelbl
            // 
            timelbl.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            timelbl.Location = new Point(726, 9);
            timelbl.Name = "timelbl";
            timelbl.Size = new Size(59, 34);
            timelbl.TabIndex = 13;
            timelbl.Text = "Süre";
            // 
            // label7
            // 
            label7.Location = new Point(582, 122);
            label7.Name = "label7";
            label7.Size = new Size(355, 27);
            label7.TabIndex = 14;
            label7.Text = "_________________________________________________________________________________________________________";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label5.Location = new Point(30, 97);
            label5.Name = "label5";
            label5.Size = new Size(107, 25);
            label5.TabIndex = 11;
            label5.Text = "Malzeme Adı";
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label6.Location = new Point(210, 97);
            label6.Name = "label6";
            label6.Size = new Size(107, 25);
            label6.TabIndex = 12;
            label6.Text = "Miktar";
            // 
            // addProductButton
            // 
            addProductButton.Location = new Point(371, 54);
            addProductButton.Name = "addProductButton";
            addProductButton.Size = new Size(94, 29);
            addProductButton.TabIndex = 10;
            addProductButton.Text = "Ekle";
            addProductButton.UseVisualStyleBackColor = true;
            addProductButton.Click += button3_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.Location = new Point(30, 125);
            flowLayoutPanel2.MaximumSize = new Size(650, 0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(435, 10);
            flowLayoutPanel2.TabIndex = 8;
            flowLayoutPanel2.Tag = "addRecipePanel";
            flowLayoutPanel2.ControlAdded += flowLayoutPanel2_Control;
            flowLayoutPanel2.ControlRemoved += flowLayoutPanel2_Control;
            // 
            // productCombo
            // 
            productCombo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            productCombo.AutoCompleteSource = AutoCompleteSource.ListItems;
            productCombo.FormattingEnabled = true;
            productCombo.Location = new Point(30, 54);
            productCombo.Name = "productCombo";
            productCombo.Size = new Size(287, 28);
            productCombo.TabIndex = 9;
            // 
            // label4
            // 
            label4.Location = new Point(582, 26);
            label4.Name = "label4";
            label4.Size = new Size(355, 27);
            label4.TabIndex = 7;
            label4.Text = "_________________________________________________________________________________________________________";
            // 
            // category
            // 
            category.DropDownStyle = ComboBoxStyle.DropDownList;
            category.FormattingEnabled = true;
            category.Items.AddRange(new object[] { "Ana Yemek", "Ara Öğün", "Tatlı", "Salata", "Çorba", "İçecek" });
            category.Location = new Point(663, 152);
            category.Name = "category";
            category.Size = new Size(179, 28);
            category.TabIndex = 5;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.Location = new Point(239, 9);
            label1.Name = "label1";
            label1.Size = new Size(129, 34);
            label1.TabIndex = 1;
            label1.Text = "Malzemeler";
            // 
            // label2
            // 
            label2.Location = new Point(3, 26);
            label2.Name = "label2";
            label2.Size = new Size(575, 27);
            label2.TabIndex = 3;
            label2.Text = "__________________________________________________________________________________________________________________________";
            // 
            // panel3
            // 
            panel3.Controls.Add(description);
            panel3.Controls.Add(toolStrip1);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label9);
            panel3.Location = new Point(3, 231);
            panel3.Name = "panel3";
            panel3.Size = new Size(942, 308);
            panel3.TabIndex = 3;
            // 
            // description
            // 
            description.HideSelection = false;
            description.Location = new Point(9, 76);
            description.Name = "description";
            description.Size = new Size(924, 226);
            description.TabIndex = 0;
            description.Text = "";
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { fontSize, toolStripSeparator1, boldButton, italicButton, underlineButton, toolStripSeparator2, fontFamily, toolStripButton4 });
            toolStrip1.Location = new Point(9, 42);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(924, 31);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // fontSize
            // 
            fontSize.Name = "fontSize";
            fontSize.Size = new Size(121, 31);
            fontSize.SelectedIndexChanged += descriptionText;
            fontSize.TextChanged += descriptionText;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 31);
            // 
            // boldButton
            // 
            boldButton.CheckOnClick = true;
            boldButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            boldButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            boldButton.ImageTransparentColor = Color.Magenta;
            boldButton.Name = "boldButton";
            boldButton.Size = new Size(29, 28);
            boldButton.Text = "K";
            boldButton.CheckedChanged += descriptionText;
            // 
            // italicButton
            // 
            italicButton.CheckOnClick = true;
            italicButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            italicButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 162);
            italicButton.ImageTransparentColor = Color.Magenta;
            italicButton.Name = "italicButton";
            italicButton.Size = new Size(29, 28);
            italicButton.Text = "T";
            italicButton.CheckedChanged += descriptionText;
            // 
            // underlineButton
            // 
            underlineButton.CheckOnClick = true;
            underlineButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            underlineButton.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 162);
            underlineButton.ImageTransparentColor = Color.Magenta;
            underlineButton.Name = "underlineButton";
            underlineButton.Size = new Size(29, 28);
            underlineButton.Text = "A";
            underlineButton.CheckedChanged += descriptionText;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 31);
            // 
            // fontFamily
            // 
            fontFamily.AutoCompleteMode = AutoCompleteMode.Suggest;
            fontFamily.AutoCompleteSource = AutoCompleteSource.ListItems;
            fontFamily.Name = "fontFamily";
            fontFamily.Size = new Size(250, 31);
            fontFamily.SelectedIndexChanged += descriptionText;
            fontFamily.TextChanged += descriptionText;
            // 
            // toolStripButton4
            // 
            toolStripButton4.Alignment = ToolStripItemAlignment.Right;
            toolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(64, 28);
            toolStripButton4.Text = "Temizle";
            toolStripButton4.Click += toolStripButton4_Click;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label8.Location = new Point(418, 4);
            label8.Name = "label8";
            label8.Size = new Size(120, 34);
            label8.TabIndex = 4;
            label8.Text = "Talimatlar";
            // 
            // label9
            // 
            label9.Location = new Point(12, 21);
            label9.Name = "label9";
            label9.Size = new Size(924, 27);
            label9.TabIndex = 5;
            label9.Text = "_________________________________________________________________________________________________________________________________________________________________________________________";
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonClose);
            panel1.Controls.Add(labelWarn);
            panel1.Controls.Add(buttonCancel);
            panel1.Controls.Add(buttonOk);
            panel1.Location = new Point(3, 545);
            panel1.Name = "panel1";
            panel1.Size = new Size(942, 86);
            panel1.TabIndex = 0;
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(12, 19);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(126, 53);
            buttonClose.TabIndex = 3;
            buttonClose.Text = "Kapat";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Visible = false;
            buttonClose.Click += buttonClose_Click;
            // 
            // labelWarn
            // 
            labelWarn.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            labelWarn.ForeColor = Color.Red;
            labelWarn.Location = new Point(20, 9);
            labelWarn.Name = "labelWarn";
            labelWarn.Size = new Size(424, 68);
            labelWarn.TabIndex = 2;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(660, 19);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(126, 53);
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "İptal";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += button2_Click;
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(807, 19);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(126, 53);
            buttonOk.TabIndex = 0;
            buttonOk.Text = "Kaydet";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += button1_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 5000;
            timer1.Tick += timer1_Tick;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.AutoScroll = true;
            flowLayoutPanel3.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel3.Location = new Point(983, 43);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(403, 591);
            flowLayoutPanel3.TabIndex = 1;
            // 
            // addPictureButton
            // 
            addPictureButton.Location = new Point(1138, 8);
            addPictureButton.Name = "addPictureButton";
            addPictureButton.Size = new Size(94, 29);
            addPictureButton.TabIndex = 2;
            addPictureButton.Text = "Resim Ekle";
            addPictureButton.UseVisualStyleBackColor = true;
            addPictureButton.Click += addPicture_Click;
            // 
            // AddRecipePanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1392, 634);
            ControlBox = false;
            Controls.Add(addPictureButton);
            Controls.Add(flowLayoutPanel3);
            Controls.Add(flowLayoutPanel1);
            Name = "AddRecipePanel";
            Text = "Tarif";
            Load += AddRecipePanel_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)hourCombo).EndInit();
            ((System.ComponentModel.ISupportInitialize)minuteCombo).EndInit();
            ((System.ComponentModel.ISupportInitialize)secondCombo).EndInit();
            panel3.ResumeLayout(false);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Button buttonCancel;
        private Button buttonOk;
        private TextBox recipeName;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Panel panel3;
        private RichTextBox description;
        private Label label3;
        private ComboBox category;
        private Label label4;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button addProductButton;
        private ComboBox productCombo;
        private Label label6;
        private Label label5;
        private Label labelWarn;
        private System.Windows.Forms.Timer timer1;
        private Label timelbl;
        private Label label7;
        private Label secondlbl;
        private Label minutelbl;
        private Label hourlbl;
        private NumericUpDown hourCombo;
        private NumericUpDown minuteCombo;
        private NumericUpDown secondCombo;
        private ToolStrip toolStrip1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton boldButton;
        private ToolStripButton italicButton;
        private ToolStripButton underlineButton;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton toolStripButton4;
        private ToolStripComboBox fontFamily;
        private ToolStripComboBox fontSize;
        private Label label8;
        private Label label9;
        private FlowLayoutPanel flowLayoutPanel3;
        private Button addPictureButton;
        private Button buttonClose;
    }
}