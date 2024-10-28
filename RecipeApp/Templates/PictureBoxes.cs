using RecipeApp.Forms;

namespace RecipeApp.Templates
{
    public partial class PictureBoxes : UserControl
    {
        private string filePath;
        private ToolTip toolTip = new ToolTip();
        public PictureBoxes(string tempFilePath, string sourceFile)
        {
            InitializeComponent();
            this.filePath = tempFilePath;
            pictureBox1.Image = Image.FromFile(filePath);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.WaitOnLoad = true;
            toolTip.SetToolTip(pictureBox1, "Resmi silmek için çift tıklayın");
            this.Tag=sourceFile;
        }

        public PictureBoxes(string filePath)
        {
            InitializeComponent();
            this.filePath = filePath;
            pictureBox1.Image = Image.FromFile(filePath);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.WaitOnLoad = true;
            toolTip.SetToolTip(pictureBox1, "Resmi silmek için çift tıklayın");
            this.Tag = "";
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            if (this.Tag.Equals("")==false)
            {
                AddRecipePanel.imgPaths.Remove(filePath);
            }
            else
            {
                AddRecipePanel.deleteImages.Add(this.Tag.ToString());
            }
            this.Parent.Controls.Remove(this);
            this.Dispose();
        }

        public void AddDoubleClick()
        {
            pictureBox1.DoubleClick += pictureBox1_DoubleClick;
            toolTip.Active = true;
        }

        public void RemoveDoubleClick()
        {
            pictureBox1.DoubleClick -= pictureBox1_DoubleClick;
            toolTip.Active = false;
        }
    }
}
