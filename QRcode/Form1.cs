using System.Drawing;
using System.Windows.Forms;
using MessagingToolkit.QRCode.Codec.Data;
using MessagingToolkit.QRCode.Codec;


namespace QRcode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BCreate_MouseClick(object sender, MouseEventArgs e)
        {

            string qrtext = input.Text;
            QRCodeEncoder encoder = new QRCodeEncoder();
            Bitmap qrcode = encoder.Encode(qrtext);
            picture.Image = qrcode as Image;
        }

        private void BSave_MouseClick(object sender, MouseEventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "PNG|*.png|JPEG|*.jpg|GIF|*.gif|BMP|*.bmp";
            if (save.ShowDialog() == DialogResult.OK)
            {
                picture.Image.Save(save.FileName);
            }
        }

        private void bDownload_MouseClick(object sender, MouseEventArgs e)
        {

            OpenFileDialog load = new OpenFileDialog();
            if (load.ShowDialog() == DialogResult.OK)
            {
                picture.ImageLocation = load.FileName;
            }
        }

        private void bRecognize_MouseClick(object sender, MouseEventArgs e)
        {
            QRCodeDecoder decoder = new QRCodeDecoder();
            MessageBox.Show(decoder.Decode(new QRCodeBitmapImage(picture.Image as Bitmap)));
        }
    }
}
