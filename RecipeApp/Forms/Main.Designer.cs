namespace RecipeApp.Forms
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            tarifAdd = new Button();
            topPanel = new Panel();
            comboBoxSort = new ComboBox();
            searchbar = new TextBox();
            detailedSearch = new Button();
            malzemeAdd = new Button();
            searchResultPanel = new FlowLayoutPanel();
            topPanel.SuspendLayout();
            SuspendLayout();
            // 
            // tarifAdd
            // 
            tarifAdd.Location = new Point(155, 21);
            tarifAdd.Name = "tarifAdd";
            tarifAdd.Size = new Size(137, 51);
            tarifAdd.TabIndex = 0;
            tarifAdd.Text = "Tarif Ekle";
            tarifAdd.UseVisualStyleBackColor = true;
            tarifAdd.Click += button1_Click;
            // 
            // topPanel
            // 
            topPanel.BackColor = SystemColors.Control;
            topPanel.Controls.Add(comboBoxSort);
            topPanel.Controls.Add(searchbar);
            topPanel.Controls.Add(detailedSearch);
            topPanel.Controls.Add(malzemeAdd);
            topPanel.Controls.Add(tarifAdd);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(1509, 95);
            topPanel.TabIndex = 1;
            // 
            // comboBoxSort
            // 
            comboBoxSort.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSort.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            comboBoxSort.FormattingEnabled = true;
            comboBoxSort.Items.AddRange(new object[] { "Önerilen", "Fiyata Göre Artan", "Fiyata Göre Azalan", "Süreye Göre Artan", "Süreye Göre Azalan" });
            comboBoxSort.Location = new Point(1338, 28);
            comboBoxSort.Name = "comboBoxSort";
            comboBoxSort.Size = new Size(159, 33);
            comboBoxSort.TabIndex = 4;
            comboBoxSort.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // searchbar
            // 
            searchbar.AutoCompleteMode = AutoCompleteMode.Suggest;
            searchbar.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 162);
            searchbar.Location = new Point(298, 29);
            searchbar.Name = "searchbar";
            searchbar.PlaceholderText = "Arama Yapınız";
            searchbar.Size = new Size(891, 32);
            searchbar.TabIndex = 3;
            searchbar.TextChanged += searchbar_TextChanged;
            // 
            // detailedSearch
            // 
            detailedSearch.Location = new Point(1195, 20);
            detailedSearch.Name = "detailedSearch";
            detailedSearch.Size = new Size(137, 51);
            detailedSearch.TabIndex = 2;
            detailedSearch.Text = "Detaylı Arama";
            detailedSearch.UseVisualStyleBackColor = true;
            detailedSearch.Click += detailedSearch_Click;
            // 
            // malzemeAdd
            // 
            malzemeAdd.Location = new Point(12, 21);
            malzemeAdd.Name = "malzemeAdd";
            malzemeAdd.Size = new Size(137, 51);
            malzemeAdd.TabIndex = 1;
            malzemeAdd.Text = "Malzeme Ekle";
            malzemeAdd.UseVisualStyleBackColor = true;
            malzemeAdd.Click += malzemeAdd_Click;
            // 
            // searchResultPanel
            // 
            searchResultPanel.AutoScroll = true;
            searchResultPanel.BackColor = SystemColors.Control;
            searchResultPanel.BorderStyle = BorderStyle.Fixed3D;
            searchResultPanel.Dock = DockStyle.Fill;
            searchResultPanel.Location = new Point(0, 95);
            searchResultPanel.Name = "searchResultPanel";
            searchResultPanel.Size = new Size(1509, 678);
            searchResultPanel.TabIndex = 2;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1509, 773);
            Controls.Add(searchResultPanel);
            Controls.Add(topPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Main";
            Text = "Tarif Defterim";
            Activated += Form1_Activated;
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button tarifAdd;
        private Panel topPanel;
        private FlowLayoutPanel searchResultPanel;
        private TextBox searchbar;
        private Button detailedSearch;
        private Button malzemeAdd;
        private ComboBox comboBoxSort;
    }
}