using Microsoft.IdentityModel.Tokens;
using RecipeApp.Databases;
using RecipeApp.Models;
using RecipeApp.Templates;
using System.Data;

namespace RecipeApp.Forms
{
    public partial class AddRecipePanel : Form
    {
        private Recipe? recipe = null;
        private bool isInıt = true;

        public static List<Product> products = new List<Product>();
        public static List<string> deleteImages = new List<string>();
        public static Dictionary<Product, double> addedProducts = new Dictionary<Product, double>();
        public static List<string> imgPaths = new List<string>();

        public AddRecipePanel(Recipe r)
        {
            InitializeComponent();
            imgPaths.Clear();
            deleteImages.Clear();
            addedProducts.Clear();
            products.Clear();
            this.recipe = r;
            DbProduct dbProduct = new DbProduct();
            products = dbProduct.GetAll();
            if (products.Count == 0)
            {
                DialogResult message = MessageBox.Show("Malzeme verisi çekilemedi", "Uyarı", MessageBoxButtons.OK);
                if (message == DialogResult.OK)
                {
                    this.Close();
                    this.Dispose();
                }
            }
            LoadWithRecipe();
            this.StartPosition = FormStartPosition.CenterParent;
        }

        public AddRecipePanel()
        {
            InitializeComponent();
            imgPaths.Clear();
            deleteImages.Clear();
            addedProducts.Clear();
            products.Clear();
            DbProduct dbProduct = new DbProduct();
            products = dbProduct.GetAll();
            if (products.Count == 0)
            {
                DialogResult message = MessageBox.Show("Malzeme verisi çekilemedi", "Uyarı", MessageBoxButtons.OK);
                if (message == DialogResult.OK)
                {
                    this.Close();
                    this.Dispose();
                }
            }
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void AddRecipePanel_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.VerticalScroll.Value = 0;
            UpdateComboBox();
            int i = 8;
            while (i <= 72)
            {
                if (i < 12)
                {
                    fontSize.Items.Add(i.ToString());
                    i++;
                }
                else if (i < 36)
                {
                    fontSize.Items.Add(i.ToString());
                    i = (i == 30) ? 36 : i + 2;
                }
                else
                {
                    fontSize.Items.Add(i.ToString());
                    i += 12;
                }
            }
            fontSize.ComboBox.SelectedItem = "9";
            foreach (FontFamily fontFam in FontFamily.Families)
            {
                fontFamily.Items.Add(fontFam.Name);
            }
            fontFamily.ComboBox.SelectedItem = "Segoe UI";
            isInıt = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Text.Equals("İptal"))
            {
                this.Close();
                this.Dispose();
            }
            else if (((Button)sender).Text.Equals("Düzenle"))
            {
                buttonClose.Visible = false;
                hourCombo.Enabled = true;
                minuteCombo.Enabled = true;
                secondCombo.Enabled = true;
                recipeName.ReadOnly = false;
                category.Enabled = true;
                toolStrip1.Visible = true;
                description.ReadOnly = false;
                buttonCancel.Text = "İptal";
                buttonOk.Text = "Güncelle";
                productCombo.Visible = true;
                addProductButton.Visible = true;
                addPictureButton.Visible = true;
                foreach (AddProductinRecipe item in flowLayoutPanel2.Controls.OfType<AddProductinRecipe>())
                {
                    item.numericUpDown1.Enabled = true;
                    item.button1.Visible = true;
                }
                foreach(PictureBoxes boxes in flowLayoutPanel3.Controls.OfType<PictureBoxes>())
                {
                    boxes.AddDoubleClick();
                }
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Text.Equals("Sil") == false)
            {
                int time = Convert.ToInt32((hourCombo.Value * 3600) + (minuteCombo.Value * 60) + secondCombo.Value);
                if (recipeName.Text.IsNullOrEmpty())
                {
                    labelWarn.Text = "UYARI:\nTarif adı boş olamaz.";
                    timer1.Start();
                    return;
                }
                else if (category.SelectedIndex == -1)
                {
                    labelWarn.Text = "UYARI:\nKategori boş olamaz.";
                    timer1.Start();
                    return;
                }
                else if (flowLayoutPanel2.Controls.Count < 2)
                {
                    labelWarn.Text = "UYARI:\nTarif için en az 2 malzeme ekli olmalı.";
                    timer1.Start();
                    return;
                }
                else if (description.Text.IsNullOrEmpty())
                {
                    labelWarn.Text = "UYARI:\nTalimat boş olamaz.";
                    timer1.Start();
                    return;
                }
                else if (time == 0)
                {
                    labelWarn.Text = "UYARI:\nZaman boş olamaz.";
                    timer1.Start();
                    return;
                }
                DialogResult dialog = MessageBox.Show("Kayıt tamamlanacaktır.\nOnaylıyor musunuz?", "Emin Misiniz?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    List<AddProductinRecipe> l = flowLayoutPanel2.Controls.OfType<AddProductinRecipe>().ToList();
                    l.ForEach(x => addedProducts[x.Product]=x.GetNumericValue());
                    DbRecipePhoto dbRecipePhoto = new DbRecipePhoto();
                    DbRecipe dbRecipe = new DbRecipe();
                    bool isSavedRecipe = false;
                    if (((Button)sender).Text.Equals("Kaydet"))
                    {
                        recipe = new Recipe(recipeName.Text, category.SelectedItem.ToString(), time, description.Rtf);
                        isSavedRecipe = await dbRecipe.Save(recipe);
                    }
                    else if (((Button)sender).Text.Equals("Güncelle"))
                    {
                        recipe.Name=recipeName.Text;
                        recipe.Category = category.SelectedItem.ToString();
                        recipe.Time = time;
                        recipe.Description = description.Rtf;
                        isSavedRecipe = await dbRecipe.Update(recipe);
                        foreach (string s in deleteImages)
                        {
                            File.Delete(s);
                        }
                    }
                    List<Recipe> recipes = new List<Recipe>();
                    recipes = dbRecipe.GetWithName(recipeName.Text);
                    foreach (Recipe r in recipes)
                    {
                        if (r.Name.Equals(recipe.Name) && r.Category.Equals(recipe.Category) && r.Time == recipe.Time && r.Description.Equals(recipe.Description))
                        {
                            recipe.Id = r.Id;
                            break;
                        }
                    }
                    DbRecipeProduct dbRecipeProduct = new DbRecipeProduct();
                    await dbRecipeProduct.Delete(recipe);
                    int savedProductCount = 0;
                    foreach (Product p in addedProducts.Keys)
                    {
                        if(isSavedRecipe)
                        {
                            bool isSavedRecipeProduct = await dbRecipeProduct.Save(recipe, p, addedProducts[p]);
                            if (isSavedRecipeProduct)
                            {
                                savedProductCount++;
                            }
                        }
                    }
                    int savedPhotoCount = 0;
                    if (flowLayoutPanel3.Controls.Count > 0)
                    {
                        await dbRecipePhoto.Delete(recipe);
                        string saveDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "UserData", "img", "Recipes", recipe.Id.ToString());
                        if (!Directory.Exists(saveDir))
                        {
                            Directory.CreateDirectory(saveDir);
                        }
                        savedPhotoCount=Directory.GetFiles(saveDir).Length;
                        for (int i = 0; i < imgPaths.Count; i++)
                        {
                            string destFile = Path.Combine(saveDir, (i.ToString() + Path.GetExtension(imgPaths[i])));
                            File.Copy(imgPaths[i], destFile, true);
                            RecipePhoto recipePhoto = new RecipePhoto(recipe, destFile);
                            if(isSavedRecipe)
                            {
                                bool sucess = await dbRecipePhoto.Save(recipePhoto);
                                if (sucess)
                                {
                                    savedPhotoCount++;
                                }
                            }
                        }
                    }
                    if (isSavedRecipe && 
                        savedProductCount == flowLayoutPanel2.Controls.Count && 
                        savedPhotoCount == flowLayoutPanel3.Controls.Count)
                    {
                        MessageBox.Show("Başarıyla Kaydedildi");
                        this.Close();
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Veritabanına kaydedilirken bir hata ile karşılaşıldı");
                    }
                }
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Kayıt tamamen silinecektir.\nOnaylıyor musunuz?", "Emin Misiniz?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    DbRecipePhoto dbRecipePhoto = new DbRecipePhoto();
                    dbRecipePhoto.Delete(recipe);
                    try
                    {
                        string delDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "UserData", "img", "Recipes", recipe.Id.ToString());
                        if(Directory.Exists(delDir))
                        {
                            Directory.Delete(delDir, true);
                        }
                    }catch (Exception) { }
                    DbRecipeProduct dbRecipeProduct = new DbRecipeProduct();
                    bool is0 = await dbRecipeProduct.Delete(recipe);
                    DbRecipe dbRecipe = new DbRecipe();
                    bool is1 = await dbRecipe.Delete(recipe);
                    if (is0 && is1)
                    {
                        MessageBox.Show("Başarıyla Silindi");
                        this.Close();
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Kayıt silinirken bir hata oluştu");
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (productCombo.SelectedItem is Product p)
            {
                AddProductinRecipe panel = new AddProductinRecipe(p, 0.01);
                flowLayoutPanel2.Controls.Add(panel);
                products.Remove(p);
                UpdateComboBox();
            }
        }

        private void flowLayoutPanel2_Control(object sender, ControlEventArgs e)
        {
            UpdateComboBox();
        }

        private void UpdateComboBox()
        {
            productCombo.DataSource = products.OrderBy(x => x.Name).ToArray();
            productCombo.DisplayMember = "Name";
            productCombo.ValueMember = "Id";
            productCombo.SelectedIndex = -1;
            productCombo.Text = "Malzeme Seçiniz";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelWarn.Text = "";
            timer1.Stop();
        }

        private void descriptionText(object sender, EventArgs e)
        {
            if (isInıt) return;
            try
            {
                int a = -1;
                int.TryParse(fontSize.ComboBox.Text, out a);
                if (fontFamily.ComboBox.SelectedItem is null)
                    throw new NullReferenceException();
            }
            catch (NullReferenceException)
            {
                fontFamily.ComboBox.SelectedItem = description.Font.FontFamily.Name;
            }
            catch (Exception)
            {
                fontSize.ComboBox.SelectedText = description.Font.Size.ToString();
            }
            FontStyle fontStyle = FontStyle.Regular;
            if (boldButton.Checked)
                fontStyle |= FontStyle.Bold;
            if (italicButton.Checked)
                fontStyle |= FontStyle.Italic;
            if (underlineButton.Checked)
                fontStyle |= FontStyle.Underline;
            description.SelectionFont = new Font(fontFamily.ComboBox.SelectedItem.ToString(), int.Parse(fontSize.ComboBox.Text), fontStyle);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            description.Text = "";
        }

        private void addPicture_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFiles = new OpenFileDialog())
            {
                openFiles.Multiselect = true;
                openFiles.Title = "Resim seçiniz";
                openFiles.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFiles.ShowDialog() == DialogResult.OK)
                {
                    foreach (string s in openFiles.FileNames)
                    {
                        PictureBoxes picture = new PictureBoxes(s);
                        flowLayoutPanel3.Controls.Add(picture);
                        imgPaths.Add(s);
                    }
                }
            }
        }

        private void LoadWithRecipe()
        {
            int hour = recipe.Time / 3600;
            int minute = recipe.Time / 60 % 60;
            int second = recipe.Time % 60;
            hourCombo.Value = hour;
            hourCombo.Enabled = false;
            minuteCombo.Value = minute;
            minuteCombo.Enabled = false;
            secondCombo.Value = second;
            secondCombo.Enabled = false;
            recipeName.Text = recipe.Name;
            recipeName.ReadOnly = true;
            category.SelectedItem = recipe.Category;
            category.Enabled = false;
            toolStrip1.Visible = false;
            description.Rtf = recipe.Description;
            description.ReadOnly = true;
            buttonCancel.Text = "Düzenle";
            buttonOk.Text = "Sil";
            productCombo.Visible = false;
            addProductButton.Visible = false;
            addPictureButton.Visible = false;
            buttonClose.Visible = true;
            string imgDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "UserData", "img", "Recipes", recipe.Id.ToString());
            if (Directory.Exists(imgDir))
            {
                foreach (string s in Directory.GetFiles(imgDir))
                {
                    string tempPath=Path.GetTempFileName();
                    File.Copy(s, tempPath,true);
                    PictureBoxes picture = new PictureBoxes(tempPath,s);
                    picture.RemoveDoubleClick();
                    flowLayoutPanel3.Controls.Add(picture);
                }
            }
            DbRecipeProduct dbRecipeProduct = new DbRecipeProduct();
            foreach (RecipeProduct item in dbRecipeProduct.GetWithRecipeId(recipe.Id))
            {
                AddProductinRecipe panel = new AddProductinRecipe(item.Product, item.ProductCost);
                panel.numericUpDown1.Enabled = false;
                panel.button1.Visible = false;
                flowLayoutPanel2.Controls.Add(panel);
                addedProducts[item.Product] = item.ProductCost;
                products.Remove(item.Product);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
