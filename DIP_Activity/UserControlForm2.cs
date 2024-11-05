using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DIP_Activity
{
    public partial class UserControlForm2 : UserControl
    {
        Bitmap imageB, imageA, resultImage;
        public UserControlForm2()
        {
            InitializeComponent();
        }

        public void ClearImages()
        {
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            imageB = null;
            imageA = null;
            resultImage = null;
        }

        public void SaveImage()
        {
            saveFileDialog1.ShowDialog();
        }

        public PictureBox getPictureBox1()
        {
            return pictureBox1;
        }

        private void UserFormControl_Load(object sender, EventArgs e)
        {
            ClearImages();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            imageB = new Bitmap(openFileDialog1.FileName);
            pictureBox1.Image = imageB;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            imageA = new Bitmap(openFileDialog2.FileName);
            pictureBox2.Image = imageA;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Color mygreen = Color.FromArgb(0, 255, 0);
            int threshold = trackBar1.Value;

            resultImage = new Bitmap(imageA.Width, imageA.Height);

            for (int x = 0; x < imageB.Width; x++)
                for (int y = 0; y < imageB.Height; y++)
                {
                    Color pixel = imageB.GetPixel(x, y);
                    Color backpixel = imageA.GetPixel(x, y);

                    int diffR = Math.Abs(pixel.R - mygreen.R);
                    int diffG = Math.Abs(pixel.G - mygreen.G);
                    int diffB = Math.Abs(pixel.B - mygreen.B);

                    if (diffR < threshold && diffG < threshold && diffB < threshold)
                        resultImage.SetPixel(x, y, backpixel);
                    else
                        resultImage.SetPixel(x, y, pixel);
                }
            pictureBox3.Image = resultImage;
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            pictureBox3.Image.Save(saveFileDialog1.FileName + ".png");
        }
    }
}
