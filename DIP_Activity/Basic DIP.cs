using System.Runtime.Intrinsics.X86;
using System.Windows.Forms;
using WebCamLib;
using ImageProcess2;

namespace DIP_Activity
{
    public partial class Form1 : Form
    {
        Bitmap loaded, processed;
        UserControlForm2 form2Control;
        CoinForm coinForm;
        Device[] devices;

        public Form1()
        {
            InitializeComponent();
            menuStrip2.Visible = false;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            loaded = new Bitmap(openFileDialog1.FileName);
            pictureBox1.Image = loaded;
        }

        private void pixelCopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loaded == null) return;

            processed = new Bitmap(loaded.Width, loaded.Height);
            Color pixel;
            for (int x = 0; x < loaded.Width; x++)
                for (int y = 0; y < loaded.Height; y++)
                {
                    pixel = loaded.GetPixel(x, y);
                    processed.SetPixel(x, y, pixel);
                }
            pictureBox2.Image = processed;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            processed.Save(saveFileDialog1.FileName + ".png");
        }

        private void grayscalingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loaded == null) return;

            processed = new Bitmap(loaded);
            BitmapFilter.GrayScale(processed);

            //processed = new Bitmap(loaded.Width, loaded.Height);
            //Color pixel;
            //int avg;
            //for (int x = 0; x < loaded.Width; x++)
            //    for (int y = 0; y < loaded.Height; y++)
            //    {
            //        pixel = loaded.GetPixel(x, y);
            //        avg = (int)(pixel.R + pixel.G + pixel.B) / 3;
            //        Color gray = Color.FromArgb(avg, avg, avg);
            //        processed.SetPixel(x, y, gray);
            //    }
            pictureBox2.Image = processed;

        }

        private void inversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loaded == null) return;

            processed = new Bitmap(loaded);
            BitmapFilter.Invert(processed);

            //processed = new Bitmap(loaded.Width, loaded.Height);
            //Color pixel;
            //for (int x = 0; x < loaded.Width; x++)
            //    for (int y = 0; y < loaded.Height; y++)
            //    {
            //        pixel = loaded.GetPixel(x, y);
            //        Color inv = Color.FromArgb(255 - pixel.R, 255 - pixel.G, 255 - pixel.B);
            //        processed.SetPixel(x, y, inv);
            //    }
            pictureBox2.Image = processed;
        }

        private void mirrorHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loaded == null) return;

            processed = new Bitmap(loaded.Width, loaded.Height);
            Color pixel;
            for (int x = 0; x < loaded.Width; x++)
                for (int y = 0; y < loaded.Height; y++)
                {
                    pixel = loaded.GetPixel(x, y);
                    processed.SetPixel((loaded.Width - 1) - x, y, pixel);
                }
            pictureBox2.Image = processed;
        }

        private void mirrorVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loaded == null) return;

            processed = new Bitmap(loaded.Width, loaded.Height);
            Color pixel;
            for (int x = 0; x < loaded.Width; x++)
                for (int y = 0; y < loaded.Height; y++)
                {
                    pixel = loaded.GetPixel(x, y);
                    processed.SetPixel(x, (loaded.Height - 1) - y, pixel);
                }
            pictureBox2.Image = processed;
        }

        private void sepiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loaded == null) return;

            processed = new Bitmap(loaded.Width, loaded.Height);
            Color pixel;
            int r, g, b;
            for (int x = 0; x < loaded.Width; x++)
                for (int y = 0; y < loaded.Height; y++)
                {
                    pixel = loaded.GetPixel(x, y);
                    r = (int)Math.Min((pixel.R * 0.393) + (pixel.G * 0.769) + (pixel.B * 0.189) * 1.2, 255);
                    g = (int)Math.Min((pixel.R * 0.349) + (pixel.G * 0.686) + (pixel.B * 0.168) * 1.2, 255);
                    b = (int)Math.Min((pixel.R * 0.272) + (pixel.G * 0.534) + (pixel.B * 0.131) * 1.2, 255);
                    Color sepia = Color.FromArgb(r, g, b);
                    processed.SetPixel(x, y, sepia);
                }
            pictureBox2.Image = processed;
        }

        private void histogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loaded == null) return;

            BasicDIP.Hist(ref loaded, ref processed);
            pictureBox2.Image = processed;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (loaded == null) return;

            processed = (Bitmap)loaded.Clone();
            BitmapFilter.Brightness(processed, trackBar1.Value);

            //BasicDIP.Brightness(ref loaded, ref processed, trackBar1.Value);
            pictureBox2.Image = processed;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            if (loaded == null) return;

            BasicDIP.Equalisation(ref loaded, ref processed, trackBar2.Value / 100);
            pictureBox2.Image = processed;
        }

        private void moveToForm2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            pictureBox2.Image = null;

            panelContainer.Controls.Clear();

            if (form2Control == null)
                form2Control = new UserControlForm2();

            form2Control.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(form2Control);

            menuStrip1.Visible = false;
            menuStrip2.Visible = true;
            devices[0].Stop();
        }

        private void switchToForm1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form2Control.ClearImages();

            panelContainer.Controls.Clear();

            panelContainer.Controls.Add(pictureBox1);
            panelContainer.Controls.Add(pictureBox2);
            panelContainer.Controls.Add(trackBar1);
            panelContainer.Controls.Add(trackBar2);
            panelContainer.Controls.Add(label1);
            panelContainer.Controls.Add(label2);

            menuStrip2.Visible = false;
            menuStrip1.Visible = true;
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            form2Control.SaveImage();
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {
            devices = DeviceManager.GetAllDevices();
        }

        private void onToolStripMenuItem_Click(object sender, EventArgs e)
        {
            devices[0].ShowWindow(pictureBox1);
        }

        private void offToolStripMenuItem_Click(object sender, EventArgs e)
        {
            devices[0].Stop();
        }

        private void grayscaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Get 1 frame
            IDataObject data;
            Image bmap;
            devices[0].Sendmessage();
            data = Clipboard.GetDataObject();
            bmap = (Image)(data.GetData("System.Drawing.Bitmap", true));
            Bitmap b = new Bitmap(bmap);

            //Ensures bmap exists
            if (bmap != null)
                BitmapFilter.GrayScale(b);
            pictureBox2.Image = b;
        }

        private void inversionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            // Get 1 frame
            IDataObject data;
            Image bmap;
            devices[0].Sendmessage();
            data = Clipboard.GetDataObject();
            bmap = (Image)(data.GetData("System.Drawing.Bitmap", true));
            Bitmap b = new Bitmap(bmap);

            //Ensures bmap exists
            if (bmap != null)
                BitmapFilter.Invert(b);
            pictureBox2.Image = b;
        }

        private void sepiaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            timer3.Enabled = true;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            // Get 1 frame
            IDataObject data;
            Image bmap;
            devices[0].Sendmessage();
            data = Clipboard.GetDataObject();
            bmap = (Image)(data.GetData("System.Drawing.Bitmap", true));
            Bitmap b1 = new Bitmap(bmap);

            //Ensures bmap exists
            if (bmap != null)
                processed = new Bitmap(b1.Width, b1.Height);
            Color pixel;
            int r, g, b;
            for (int x = 0; x < b1.Width; x++)
                for (int y = 0; y < b1.Height; y++)
                {
                    pixel = b1.GetPixel(x, y);
                    r = (int)Math.Min((pixel.R * 0.393) + (pixel.G * 0.769) + (pixel.B * 0.189) * 1.2, 255);
                    g = (int)Math.Min((pixel.R * 0.349) + (pixel.G * 0.686) + (pixel.B * 0.168) * 1.2, 255);
                    b = (int)Math.Min((pixel.R * 0.272) + (pixel.G * 0.534) + (pixel.B * 0.131) * 1.2, 255);
                    Color sepia = Color.FromArgb(r, g, b);
                    processed.SetPixel(x, y, sepia);
                }
            pictureBox2.Image = processed;
        }

        private void onToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            devices[0].ShowWindow(form2Control.getPictureBox1());
        }

        private void offToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            devices[0].Stop();
        }

        private void trackBar1_Scroll_1(object sender, EventArgs e)
        {
            if (loaded == null) return;

            processed = (Bitmap)loaded.Clone();
            BitmapFilter.Brightness(processed, trackBar1.Value);
            pictureBox2.Image = processed;
        }

        private void trackBar2_Scroll_1(object sender, EventArgs e)
        {
            if (loaded == null) return;

            processed = (Bitmap)loaded.Clone();
            BitmapFilter.Contrast(processed, (sbyte)trackBar2.Value);
            pictureBox2.Image = processed;
        }

        private void smoothingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loaded == null) return;

            processed = new Bitmap(loaded);
            BitmapFilter.Smooth(processed);
            pictureBox2.Image = processed;
        }

        private void gaussianBlurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loaded == null) return;

            processed = new Bitmap(loaded);
            BitmapFilter.GaussianBlur(processed);
            pictureBox2.Image = processed;
        }

        private void sharpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loaded == null) return;

            processed = new Bitmap(loaded);
            BitmapFilter.Sharpen(processed);
            pictureBox2.Image = processed;
        }

        private void meanRemovalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loaded == null) return;

            processed = new Bitmap(loaded);
            BitmapFilter.MeanRemoval(processed);
            pictureBox2.Image = processed;
        }

        private void embossLaplacianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loaded == null) return;

            processed = new Bitmap(loaded);
            BitmapFilter.EmbossLaplacian(processed);
            pictureBox2.Image = processed;
        }

        private void horizontalVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loaded == null) return;

            processed = new Bitmap(loaded);
            CustomEmbossFilter.EmbossHorzVert(processed);
            pictureBox2.Image = processed;
        }

        private void horizontalOnlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loaded == null) return;

            processed = new Bitmap(loaded);
            CustomEmbossFilter.EmbossHorizontal(processed);
            pictureBox2.Image = processed;
        }

        private void verticalOnlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loaded == null) return;

            processed = new Bitmap(loaded);
            CustomEmbossFilter.EmbossVertical(processed);
            pictureBox2.Image = processed;
        }

        private void allDirectionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loaded == null) return;

            processed = new Bitmap(loaded);
            CustomEmbossFilter.EmbossAllDirections(processed);
            pictureBox2.Image = processed;
        }

        private void lossyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loaded == null) return;

            processed = new Bitmap(loaded);
            CustomEmbossFilter.EmbossLossy(processed);
            pictureBox2.Image = processed;
        }

        private void switchToCoinFormsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            pictureBox2.Image = null;

            panelContainer.Controls.Clear();

            if (coinForm == null)
                coinForm = new CoinForm(this);
                coinForm.Show();
                this.Hide();
        }
    }
}
