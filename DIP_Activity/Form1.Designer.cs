namespace DIP_Activity
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            moveToForm2ToolStripMenuItem = new ToolStripMenuItem();
            dIPToolStripMenuItem = new ToolStripMenuItem();
            pixelCopyToolStripMenuItem = new ToolStripMenuItem();
            grayscalingToolStripMenuItem = new ToolStripMenuItem();
            inversionToolStripMenuItem = new ToolStripMenuItem();
            mirrorHorizontalToolStripMenuItem = new ToolStripMenuItem();
            mirrorVerticalToolStripMenuItem = new ToolStripMenuItem();
            sepiaToolStripMenuItem = new ToolStripMenuItem();
            histogramToolStripMenuItem = new ToolStripMenuItem();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            panelContainer = new Panel();
            label4 = new Label();
            trackBar2 = new TrackBar();
            label3 = new Label();
            trackBar1 = new TrackBar();
            label2 = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            menuStrip2 = new MenuStrip();
            fileToolStripMenuItem1 = new ToolStripMenuItem();
            saveToolStripMenuItem1 = new ToolStripMenuItem();
            switchToForm1ToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, dIPToolStripMenuItem });
            menuStrip1.Location = new Point(0, 28);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(924, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem, moveToForm2ToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(199, 26);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(199, 26);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // moveToForm2ToolStripMenuItem
            // 
            moveToForm2ToolStripMenuItem.Name = "moveToForm2ToolStripMenuItem";
            moveToForm2ToolStripMenuItem.Size = new Size(199, 26);
            moveToForm2ToolStripMenuItem.Text = "Switch to Form2";
            moveToForm2ToolStripMenuItem.Click += moveToForm2ToolStripMenuItem_Click;
            // 
            // dIPToolStripMenuItem
            // 
            dIPToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pixelCopyToolStripMenuItem, grayscalingToolStripMenuItem, inversionToolStripMenuItem, mirrorHorizontalToolStripMenuItem, mirrorVerticalToolStripMenuItem, sepiaToolStripMenuItem, histogramToolStripMenuItem });
            dIPToolStripMenuItem.Name = "dIPToolStripMenuItem";
            dIPToolStripMenuItem.Size = new Size(46, 24);
            dIPToolStripMenuItem.Text = "DIP";
            // 
            // pixelCopyToolStripMenuItem
            // 
            pixelCopyToolStripMenuItem.Name = "pixelCopyToolStripMenuItem";
            pixelCopyToolStripMenuItem.Size = new Size(207, 26);
            pixelCopyToolStripMenuItem.Text = "Pixel Copy";
            pixelCopyToolStripMenuItem.Click += pixelCopyToolStripMenuItem_Click;
            // 
            // grayscalingToolStripMenuItem
            // 
            grayscalingToolStripMenuItem.Name = "grayscalingToolStripMenuItem";
            grayscalingToolStripMenuItem.Size = new Size(207, 26);
            grayscalingToolStripMenuItem.Text = "Grayscaling";
            grayscalingToolStripMenuItem.Click += grayscalingToolStripMenuItem_Click;
            // 
            // inversionToolStripMenuItem
            // 
            inversionToolStripMenuItem.Name = "inversionToolStripMenuItem";
            inversionToolStripMenuItem.Size = new Size(207, 26);
            inversionToolStripMenuItem.Text = "Inversion";
            inversionToolStripMenuItem.Click += inversionToolStripMenuItem_Click;
            // 
            // mirrorHorizontalToolStripMenuItem
            // 
            mirrorHorizontalToolStripMenuItem.Name = "mirrorHorizontalToolStripMenuItem";
            mirrorHorizontalToolStripMenuItem.Size = new Size(207, 26);
            mirrorHorizontalToolStripMenuItem.Text = "Mirror Horizontal";
            mirrorHorizontalToolStripMenuItem.Click += mirrorHorizontalToolStripMenuItem_Click;
            // 
            // mirrorVerticalToolStripMenuItem
            // 
            mirrorVerticalToolStripMenuItem.Name = "mirrorVerticalToolStripMenuItem";
            mirrorVerticalToolStripMenuItem.Size = new Size(207, 26);
            mirrorVerticalToolStripMenuItem.Text = "Mirror Vertical";
            mirrorVerticalToolStripMenuItem.Click += mirrorVerticalToolStripMenuItem_Click;
            // 
            // sepiaToolStripMenuItem
            // 
            sepiaToolStripMenuItem.Name = "sepiaToolStripMenuItem";
            sepiaToolStripMenuItem.Size = new Size(207, 26);
            sepiaToolStripMenuItem.Text = "Sepia";
            sepiaToolStripMenuItem.Click += sepiaToolStripMenuItem_Click;
            // 
            // histogramToolStripMenuItem
            // 
            histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            histogramToolStripMenuItem.Size = new Size(207, 26);
            histogramToolStripMenuItem.Text = "Histogram";
            histogramToolStripMenuItem.Click += histogramToolStripMenuItem_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.FileOk += saveFileDialog1_FileOk;
            // 
            // panelContainer
            // 
            panelContainer.Controls.Add(label4);
            panelContainer.Controls.Add(trackBar2);
            panelContainer.Controls.Add(label3);
            panelContainer.Controls.Add(trackBar1);
            panelContainer.Controls.Add(label2);
            panelContainer.Controls.Add(label1);
            panelContainer.Controls.Add(pictureBox2);
            panelContainer.Controls.Add(pictureBox1);
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(0, 56);
            panelContainer.Name = "panelContainer";
            panelContainer.RightToLeft = RightToLeft.No;
            panelContainer.Size = new Size(924, 499);
            panelContainer.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 0);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 12;
            label4.Text = "Contrast:";
            // 
            // trackBar2
            // 
            trackBar2.Location = new Point(35, 23);
            trackBar2.Maximum = 100;
            trackBar2.Minimum = 1;
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new Size(400, 56);
            trackBar2.TabIndex = 11;
            trackBar2.Value = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(490, 0);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 10;
            label3.Text = "Brightness:";
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(490, 23);
            trackBar1.Maximum = 50;
            trackBar1.Minimum = -50;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(400, 56);
            trackBar1.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(654, 74);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 8;
            label2.Text = "Processed";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(197, 74);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 7;
            label1.Text = "Loaded";
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(500, 97);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(390, 390);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(35, 97);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(390, 390);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem1 });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(924, 28);
            menuStrip2.TabIndex = 10;
            menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem1
            // 
            fileToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { saveToolStripMenuItem1, switchToForm1ToolStripMenuItem });
            fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            fileToolStripMenuItem1.Size = new Size(46, 24);
            fileToolStripMenuItem1.Text = "File";
            // 
            // saveToolStripMenuItem1
            // 
            saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            saveToolStripMenuItem1.Size = new Size(224, 26);
            saveToolStripMenuItem1.Text = "Save";
            saveToolStripMenuItem1.Click += saveToolStripMenuItem1_Click;
            // 
            // switchToForm1ToolStripMenuItem
            // 
            switchToForm1ToolStripMenuItem.Name = "switchToForm1ToolStripMenuItem";
            switchToForm1ToolStripMenuItem.Size = new Size(224, 26);
            switchToForm1ToolStripMenuItem.Text = "Switch to Form1";
            switchToForm1ToolStripMenuItem.Click += switchToForm1ToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(924, 555);
            Controls.Add(panelContainer);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panelContainer.ResumeLayout(false);
            panelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem dIPToolStripMenuItem;
        private ToolStripMenuItem pixelCopyToolStripMenuItem;
        private ToolStripMenuItem grayscalingToolStripMenuItem;
        private ToolStripMenuItem inversionToolStripMenuItem;
        private ToolStripMenuItem mirrorHorizontalToolStripMenuItem;
        private ToolStripMenuItem mirrorVerticalToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private ToolStripMenuItem sepiaToolStripMenuItem;
        private ToolStripMenuItem histogramToolStripMenuItem;
        private ToolStripMenuItem moveToForm2ToolStripMenuItem;
        private Panel panelContainer;
        private Label label4;
        private TrackBar trackBar2;
        private Label label3;
        private TrackBar trackBar1;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem fileToolStripMenuItem1;
        private ToolStripMenuItem switchToForm1ToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem1;
    }
}
