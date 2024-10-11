namespace RecipeApp.Templates
{
    public class PanelTemplate : Panel
    {
        private int id, sure;
        private string tarif;
        private float maliyet;
        private Label label1 = new Label();
        private Label label2 = new Label();
        private Label label3 = new Label();
        public PanelTemplate(int id, string tarif, float maliyet, int sure)
        {
            this.id = id;
            this.tarif = tarif;
            this.maliyet = maliyet;
            this.sure = sure;
            //
            // Panel Özellikleri
            //
            SuspendLayout();
            Name = "panel_" + id;
            BorderStyle = BorderStyle.FixedSingle;
            Location = new Point(5, 5);
            Margin = new Padding(5);
            Name = "panelTemplate";
            Padding = new Padding(3);
            Size = new Size(425, 300);
            TabIndex = 3;
            // 
            // label1
            // 
            label1.Name = "tarifAdi_" + id;
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Padding = new Padding(10);
            label1.Size = new Size(417, 182);
            label1.TabIndex = 0;
            label1.Text = tarif;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Name = "sure_" + id;
            label2.Dock = DockStyle.Top;
            label2.Location = new Point(3, 185);
            label2.Name = "label2";
            label2.Size = new Size(417, 55);
            label2.TabIndex = 1;
            if (sure > 3600)
            {
                sure %= 3600;
                label2.Text = sure.ToString() + " saat ";
            }
            if (sure > 60)
            {
                sure %= 60;
                label2.Text = sure.ToString() + " dakika ";
            }
            label2.Text = sure.ToString() + " saniye";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Name = "maliyet_" + id;
            label3.Dock = DockStyle.Top;
            label3.Location = new Point(3, 240);
            label3.Name = "label3";
            label3.Size = new Size(417, 55);
            label3.TabIndex = 2;
            label3.Text = maliyet.ToString() + " TL";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            //
            // Ekleme
            //
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);

            ResumeLayout(false);

            Click += Clicked;
            label1.Click += Clicked;
            label2.Click += Clicked;
            label3.Click += Clicked;
        }

        private void Clicked(object sender, EventArgs e)
        {
            MessageBox.Show(id.ToString());
        }
    }
}
