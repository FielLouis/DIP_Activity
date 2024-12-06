using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImageProcess2;

namespace DIP_Activity
{
    public partial class CoinForm : Form
    {
        Bitmap loaded, processed;
        Form1 form1;
        List<List<Point>> coins;
        bool[,] visited;
        int p5, p1, c5, c10, c25;
        float scalingFactor;

        public CoinForm(Form1 form1)
        {
            this.form1 = form1;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;  // Set SizeMode to Zoom to preserve aspect ratio in PictureBox
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            loaded = new Bitmap(openFileDialog1.FileName);
            pictureBox1.Image = loaded;
        }

        private void switchToForm1ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            this.Hide();
            form1.Show();
        }

        private async void countToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loaded == null)
                return;

            // Resize the image for processing while preserving the aspect ratio
            processed = ResizeImage(new Bitmap(loaded), 800, 800); // Resize to 800x800 or another preferred size
            ResetVisited();

            // Calculate the scaling factor
            scalingFactor = (float)loaded.Width / processed.Width;  // or processed.Height, depending on which dimension is more relevant

            // Offload image processing to a background task
            await Task.Run(() =>
            {
                Threshold(ref processed, 200);

                this.Invoke(new Action(() =>
                {
                    pictureBox2.Image = processed;  // Show thresholded image
                    CountCoins(processed);  // Perform coin counting on the resized image
                }));
            });
        }

        // Reset the visited array to a fresh state
        private void ResetVisited()
        {
            if (processed == null)
                return; 

            visited = new bool[processed.Width, processed.Height];  // Initialize visited array
        }

        // Resize the image while preserving the aspect ratio
        private Bitmap ResizeImage(Bitmap originalImage, int width, int height)
        {
            float aspectRatio = (float)originalImage.Width / originalImage.Height;
            if (width / (float)height > aspectRatio)
            {
                width = (int)(height * aspectRatio);  // Adjust width to maintain aspect ratio
            }
            else
            {
                height = (int)(width / aspectRatio);  // Adjust height to maintain aspect ratio
            }

            Bitmap resizedImage = new Bitmap(originalImage, width, height);
            return resizedImage;
        }

        public static void Threshold(ref Bitmap a, int thresholdNum)
        {
            // Apply Grayscale to image
            BitmapFilter.GrayScale(a);

            if (thresholdNum < 0 || thresholdNum > 255)
                return;

            int dstHeight = a.Height;
            int dstWidth = a.Width;

            BitmapData bmA = a.LockBits(
                new Rectangle(0, 0, dstWidth, dstHeight),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb
            );

            unsafe
            {
                int paddingA = bmA.Stride - dstWidth * 3;
                byte* pA = (byte*)bmA.Scan0;

                for (int i = 0; i < a.Height; i++, pA += paddingA)
                {
                    for (int j = 0; j < a.Width; j++, pA += 3)
                    {
                        pA[0] = pA[1] = pA[2] = (byte)(pA[0] < thresholdNum ? 0 : 255);
                    }
                }
            }

            a.UnlockBits(bmA);
        }

        private void CountCoins(Bitmap a)
        {
            // Initialize lists
            coins = new List<List<Point>>();
            visited = new bool[processed.Width, processed.Height];

            // Storing count and total value of coins
            int coinCount = 0;
            int totalValue = 0;
            p5 = p1 = c5 = c10 = c25 = 0;

            // Go through image, if the pixel is black, do BFS
            for (int x = 0; x < processed.Width; x++)
            {
                for (int y = 0; y < processed.Height; y++)
                {
                    // Get pixel
                    Color pixel = processed.GetPixel(x, y);

                    if (pixel.R == 0 && !visited[x, y])
                    {
                        // If the point is not yet visited, we've encountered a coin
                        // We have to get the entire coin through BFS and store them in the list
                        List<Point> coin;
                        int coinSize;

                        (coin, coinSize) = GetCoin(x, y);

                        if (coinSize < 20)
                        {
                            continue; // Do not count small dots
                        }

                        coins.Add(coin);
                        coinCount++;
                        int coinValue = GetCoinValue(coinSize);
                        totalValue += coinValue;

                        // Display the total count and value in the label
                        label1.Text = "Total Count: P" + (totalValue / 100).ToString("D2") + "." + (totalValue % 100).ToString("D2");
                    }
                }
            }

            // Optionally update the UI with the total count and value
            // tbNumCoins.Text = coinCount.ToString();
            // tbTotalValue.Text = (totalValue / 100) + "." + totalValue % 100;
        }

        private (List<Point>, int) GetCoin(int x, int y)
        {
            List<Point> coinPoints = new List<Point>();
            Bitmap img = (Bitmap)processed.Clone();  // Clone the image for BFS

            int coinSize = 0;
            int width = img.Width;
            int height = img.Height;

            Queue<Point> queue = new Queue<Point>();
            queue.Enqueue(new Point(x, y));

            while (queue.Count > 0)
            {
                Point currPoint = queue.Dequeue();
                coinPoints.Add(currPoint);
                int px = currPoint.X;
                int py = currPoint.Y;

                if (visited[px, py])
                    continue;

                coinSize++;

                visited[px, py] = true;

                Color pixel = img.GetPixel(px, py);

                // To visit a Point, it must be color black and has not been visited
                // Left
                if (px - 1 >= 0 && pixel.R == 0 && !visited[px - 1, py])
                {
                    queue.Enqueue(new Point(px - 1, py));
                }

                // Right
                if (px + 1 < width && pixel.R == 0 && !visited[px + 1, py])
                {
                    queue.Enqueue(new Point(px + 1, py));
                }

                // Up
                if (py - 1 >= 0 && pixel.R == 0 && !visited[px, py - 1])
                {
                    queue.Enqueue(new Point(px, py - 1));
                }

                // Down
                if (py + 1 < height && pixel.R == 0 && !visited[px, py + 1])
                {
                    queue.Enqueue(new Point(px, py + 1));
                }
            }

            return (coinPoints, coinSize);
        }

        private int GetCoinValue(int coinSize)
        {
            // Adjust the coin size based on the scaling factor
            coinSize = (int)(coinSize * scalingFactor);

            if (coinSize > 8000)
            {
                p5++;
                return 500; // 5 peso
            }

            if (coinSize > 6000)
            {
                p1++;
                return 100; // 1 peso
            }

            if (coinSize > 4000)
            {
                c25++;
                return 25; // 25 cents
            }

            if (coinSize > 3500)
            {
                c10++;
                return 10; // 10 cents
            }

            c5++;
            return 5; // 5 cents
        }
    }
}
