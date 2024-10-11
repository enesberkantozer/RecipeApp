namespace TarifApp
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
            tarifAdd = new Button();
            topPanel = new Panel();
            button1 = new Button();
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
            topPanel.Controls.Add(button1);
            topPanel.Controls.Add(searchbar);
            topPanel.Controls.Add(detailedSearch);
            topPanel.Controls.Add(malzemeAdd);
            topPanel.Controls.Add(tarifAdd);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(1332, 95);
            topPanel.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(1237, 21);
            button1.Name = "button1";
            button1.Size = new Size(83, 51);
            button1.TabIndex = 4;
            button1.Text = "Sırala";
            button1.UseVisualStyleBackColor = true;
            // 
            // searchbar
            // 
            searchbar.AutoCompleteMode = AutoCompleteMode.Suggest;
            searchbar.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 162);
            searchbar.Location = new Point(298, 29);
            searchbar.Name = "searchbar";
            searchbar.PlaceholderText = "Arama Yapınız";
            searchbar.Size = new Size(790, 32);
            searchbar.TabIndex = 3;
            // 
            // detailedSearch
            // 
            detailedSearch.Location = new Point(1094, 21);
            detailedSearch.Name = "detailedSearch";
            detailedSearch.Size = new Size(137, 51);
            detailedSearch.TabIndex = 2;
            detailedSearch.Text = "Detaylı Arama";
            detailedSearch.UseVisualStyleBackColor = true;
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
            searchResultPanel.Dock = DockStyle.Fill;
            searchResultPanel.Location = new Point(0, 95);
            searchResultPanel.Name = "searchResultPanel";
            searchResultPanel.Size = new Size(1332, 608);
            searchResultPanel.TabIndex = 2;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1332, 703);
            Controls.Add(searchResultPanel);
            Controls.Add(topPanel);
            Name = "Main";
            Text = "Tarif Defterim";
            Load += Form1_Load;
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
        private Button button1;
    }
}
