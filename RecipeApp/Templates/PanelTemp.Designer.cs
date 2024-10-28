namespace RecipeApp.Templates
{
    partial class PanelTemp
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
            labelName = new Label();
            labelTime = new Label();
            label2 = new Label();
            labelTotalCost = new Label();
            labelMissingCost = new Label();
            labelPercent = new Label();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            ColumnNamee = new DataGridViewTextBoxColumn();
            ColumnValue = new DataGridViewTextBoxColumn();
            ColumnUnit = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.BackColor = Color.Transparent;
            labelName.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            labelName.Location = new Point(-1, 0);
            labelName.Name = "labelName";
            labelName.Size = new Size(332, 53);
            labelName.TabIndex = 0;
            labelName.Text = "Recipe Name";
            labelName.TextAlign = ContentAlignment.TopCenter;
            labelName.DoubleClick += PanelTemp_DoubleClick;
            // 
            // labelTime
            // 
            labelTime.BackColor = Color.Transparent;
            labelTime.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelTime.Location = new Point(-1, 53);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(332, 25);
            labelTime.TabIndex = 1;
            labelTime.Text = "Time";
            labelTime.TextAlign = ContentAlignment.TopCenter;
            labelTime.DoubleClick += PanelTemp_DoubleClick;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(8, 78);
            label2.Name = "label2";
            label2.Size = new Size(315, 25);
            label2.TabIndex = 6;
            label2.Text = "Eksik Malzemeler";
            label2.TextAlign = ContentAlignment.TopCenter;
            label2.DoubleClick += PanelTemp_DoubleClick;
            // 
            // labelTotalCost
            // 
            labelTotalCost.BackColor = Color.Transparent;
            labelTotalCost.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelTotalCost.Location = new Point(-1, 329);
            labelTotalCost.Name = "labelTotalCost";
            labelTotalCost.Size = new Size(158, 60);
            labelTotalCost.TabIndex = 7;
            labelTotalCost.Text = "Maliyet";
            labelTotalCost.TextAlign = ContentAlignment.MiddleCenter;
            labelTotalCost.DoubleClick += PanelTemp_DoubleClick;
            // 
            // labelMissingCost
            // 
            labelMissingCost.BackColor = Color.Transparent;
            labelMissingCost.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelMissingCost.ForeColor = Color.Red;
            labelMissingCost.Location = new Point(-1, 273);
            labelMissingCost.Name = "labelMissingCost";
            labelMissingCost.Size = new Size(158, 56);
            labelMissingCost.TabIndex = 8;
            labelMissingCost.Text = "Maliyet";
            labelMissingCost.TextAlign = ContentAlignment.MiddleCenter;
            labelMissingCost.DoubleClick += PanelTemp_DoubleClick;
            // 
            // labelPercent
            // 
            labelPercent.BackColor = Color.Transparent;
            labelPercent.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelPercent.Location = new Point(163, 273);
            labelPercent.Name = "labelPercent";
            labelPercent.Size = new Size(161, 116);
            labelPercent.TabIndex = 9;
            labelPercent.Text = "Percent Value";
            labelPercent.TextAlign = ContentAlignment.MiddleCenter;
            labelPercent.DoubleClick += PanelTemp_DoubleClick;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(330, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(403, 391);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.DoubleClick += PanelTemp_DoubleClick;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnNamee, ColumnValue, ColumnUnit });
            dataGridView1.Location = new Point(3, 106);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.ScrollBars = ScrollBars.None;
            dataGridView1.Size = new Size(321, 164);
            dataGridView1.TabIndex = 11;
            dataGridView1.DoubleClick += PanelTemp_DoubleClick;
            // 
            // ColumnNamee
            // 
            ColumnNamee.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            ColumnNamee.HeaderText = "Malzeme Adı";
            ColumnNamee.MinimumWidth = 6;
            ColumnNamee.Name = "ColumnNamee";
            ColumnNamee.ReadOnly = true;
            ColumnNamee.Width = 126;
            // 
            // ColumnValue
            // 
            ColumnValue.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            ColumnValue.HeaderText = "Eksik Miktar";
            ColumnValue.MinimumWidth = 6;
            ColumnValue.Name = "ColumnValue";
            ColumnValue.ReadOnly = true;
            ColumnValue.Width = 116;
            // 
            // ColumnUnit
            // 
            ColumnUnit.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            ColumnUnit.HeaderText = "Birim";
            ColumnUnit.MinimumWidth = 6;
            ColumnUnit.Name = "ColumnUnit";
            ColumnUnit.ReadOnly = true;
            ColumnUnit.Resizable = DataGridViewTriState.False;
            ColumnUnit.Width = 73;
            // 
            // PanelTemp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Controls.Add(labelPercent);
            Controls.Add(labelMissingCost);
            Controls.Add(labelTotalCost);
            Controls.Add(label2);
            Controls.Add(labelTime);
            Controls.Add(labelName);
            Name = "PanelTemp";
            Size = new Size(734, 389);
            DoubleClick += PanelTemp_DoubleClick;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label labelName;
        private Label labelTime;
        private Label label2;
        private Label labelTotalCost;
        private Label labelMissingCost;
        private Label labelPercent;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColumnNamee;
        private DataGridViewTextBoxColumn ColumnValue;
        private DataGridViewTextBoxColumn ColumnUnit;
    }
}
