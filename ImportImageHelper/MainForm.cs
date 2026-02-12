using System.Drawing.Imaging;

namespace ImportImageHelper
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tsbPaste.Enabled = tsmiPaste.Enabled = Clipboard.ContainsImage();
            tsbCopy.Enabled = tsmiCopy.Enabled = !string.IsNullOrWhiteSpace(tbString.Text);
            tsbSaveAs.Enabled = tsmiSaveAs.Enabled = pbImage.Image != null || !string.IsNullOrWhiteSpace(tbString.Text);
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsmiPaste_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject() is DataObject retrievedData && retrievedData.ContainsImage())
            {
                var image = retrievedData.GetImage();
                if (image != null)
                {
                    pbImage.Image = image;
                    tbString.Text = ConvertImageToBase64String(image);
                    tbString.SelectAll();
                }
            }
        }

        private void tsmiCopy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbString.Text))
            {
                Clipboard.SetText(tbString.Text);
            }
        }

        private static string ConvertImageToBase64String(System.Drawing.Image image)
        {
            var imageStream = new MemoryStream();
            image.Save(imageStream, ImageFormat.Png);
            imageStream.Position = 0;
            var imageBytes = imageStream.ToArray();
            return Convert.ToBase64String(imageBytes);
        }

        private void tsmiOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pbImage.Load(openFileDialog1.FileName);
                    tbString.Text = ConvertImageToBase64String(pbImage.Image);
                    tbString.SelectAll();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Загрузка графического файла", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tsmiSaveAs_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
