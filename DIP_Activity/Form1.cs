using System.Runtime.Intrinsics.X86;
using System.Windows.Forms;

namespace DIP_Activity
{
    public partial class Form1 : Form
    {
        Bitmap loaded, processed;
        UserControlForm2 form2Control;

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
            processed = new Bitmap(loaded.Width, loaded.Height);
            Color pixel;
            int avg;
            for (int x = 0; x < loaded.Width; x++)
                for (int y = 0; y < loaded.Height; y++)
                {
                    pixel = loaded.GetPixel(x, y);
                    avg = (int)(pixel.R + pixel.G + pixel.B) / 3;
                    Color gray = Color.FromArgb(avg, avg, avg);
                    processed.SetPixel(x, y, gray);
                }
            pictureBox2.Image = processed;
        }

        private void inversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processed = new Bitmap(loaded.Width, loaded.Height);
            Color pixel;
            for (int x = 0; x < loaded.Width; x++)
                for (int y = 0; y < loaded.Height; y++)
                {
                    pixel = loaded.GetPixel(x, y);
                    Color inv = Color.FromArgb(255 - pixel.R, 255 - pixel.G, 255 - pixel.B);
                    processed.SetPixel(x, y, inv);
                }
            pictureBox2.Image = processed;
        }

        private void mirrorHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
            BasicDIP.Hist(ref loaded, ref processed);
            pictureBox2.Image = processed;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            BasicDIP.Brightness(ref loaded, ref processed, trackBar1.Value);
            pictureBox2.Image = processed;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
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
    }
}
