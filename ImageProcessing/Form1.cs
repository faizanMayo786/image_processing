using Patagames.Ocr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcessing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public delegate void ImagePut(OpenFileDialog ofg);
        public delegate void PutText(string text);
        public void TextHere(string text)
        {
            richTextBox1.Text = text;
        }
        public void PutItHere(OpenFileDialog o)
        {
            pbxOriginal.Image = new Bitmap(o.FileName);
            pbxOriginal.ImageLocation = o.FileName;

        }
        private async void  BtnSelectPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image File (*.bmp,*.jpg)|*.bmp;*.jpg";
            if (DialogResult.OK == openFileDialog.ShowDialog())
            {
                await Task.Run(() =>
                 {
                     ImagePut imagePut = new ImagePut(PutItHere);
                     imagePut(openFileDialog);
                    

                 }
                 );
                lblStatus.Text = "";
            }
        }

        private async void BtnGrey_Click(object sender, EventArgs e)
        {
            btnGrey.Enabled = false;
            lblStatus.Text = "Image is being Processing...";
            await Task.Run(() =>
             {
                 Bitmap copy = new Bitmap((Bitmap)pbxOriginal.Image);

                 Processing.ConvertToGrey(copy);
                 pbcGrey.Image = copy;
                 using (var objOcr = OcrApi.Create())
                 {
                     objOcr.Init(Patagames.Ocr.Enums.Languages.English);
                     PutText put = new PutText(TextHere);
                     put(objOcr.GetTextFromImage(pbxOriginal.ImageLocation));


                 }
             });
            lblStatus.Text = "";
            
          
            btnGrey.Enabled = true;

        }
    }
}
