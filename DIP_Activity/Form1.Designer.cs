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
            components = new System.ComponentModel.Container();
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
            onToolStripMenuItem = new ToolStripMenuItem();
            offToolStripMenuItem = new ToolStripMenuItem();
            videoToolStripMenuItem = new ToolStripMenuItem();
            grayscaleToolStripMenuItem = new ToolStripMenuItem();
            inversionToolStripMenuItem1 = new ToolStripMenuItem();
            sepiaToolStripMenuItem1 = new ToolStripMenuItem();
            matrixToolStripMenuItem = new ToolStripMenuItem();
            smoothingToolStripMenuItem = new ToolStripMenuItem();
            gaussianBlurToolStripMenuItem = new ToolStripMenuItem();
            sharpenToolStripMenuItem = new ToolStripMenuItem();
            meanRemovalToolStripMenuItem = new ToolStripMenuItem();
            embossingToolStripMenuItem = new ToolStripMenuItem();
            embossLaplacianToolStripMenuItem = new ToolStripMenuItem();
            horizontalVerticalToolStripMenuItem = new ToolStripMenuItem();
            horizontalOnlyToolStripMenuItem = new ToolStripMenuItem();
            verticalOnlyToolStripMenuItem = new ToolStripMenuItem();
            allDirectionsToolStripMenuItem = new ToolStripMenuItem();
            lossyToolStripMenuItem = new ToolStripMenuItem();
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
            onToolStripMenuItem1 = new ToolStripMenuItem();
            offToolStripMenuItem1 = new ToolStripMenuItem();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            timer3 = new System.Windows.Forms.Timer(components);
            switchToCoinFormsToolStripMenuItem = new ToolStripMenuItem();
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
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, dIPToolStripMenuItem, onToolStripMenuItem, offToolStripMenuItem, videoToolStripMenuItem, matrixToolStripMenuItem });
            menuStrip1.Location = new Point(0, 28);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(924, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem, moveToForm2ToolStripMenuItem, switchToCoinFormsToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(231, 26);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(231, 26);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // moveToForm2ToolStripMenuItem
            // 
            moveToForm2ToolStripMenuItem.Name = "moveToForm2ToolStripMenuItem";
            moveToForm2ToolStripMenuItem.Size = new Size(231, 26);
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
            // onToolStripMenuItem
            // 
            onToolStripMenuItem.Name = "onToolStripMenuItem";
            onToolStripMenuItem.Size = new Size(42, 24);
            onToolStripMenuItem.Text = "On";
            onToolStripMenuItem.Click += onToolStripMenuItem_Click;
            // 
            // offToolStripMenuItem
            // 
            offToolStripMenuItem.Name = "offToolStripMenuItem";
            offToolStripMenuItem.Size = new Size(44, 24);
            offToolStripMenuItem.Text = "Off";
            offToolStripMenuItem.Click += offToolStripMenuItem_Click;
            // 
            // videoToolStripMenuItem
            // 
            videoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { grayscaleToolStripMenuItem, inversionToolStripMenuItem1, sepiaToolStripMenuItem1 });
            videoToolStripMenuItem.Name = "videoToolStripMenuItem";
            videoToolStripMenuItem.Size = new Size(62, 24);
            videoToolStripMenuItem.Text = "Video";
            // 
            // grayscaleToolStripMenuItem
            // 
            grayscaleToolStripMenuItem.Name = "grayscaleToolStripMenuItem";
            grayscaleToolStripMenuItem.Size = new Size(155, 26);
            grayscaleToolStripMenuItem.Text = "Grayscale";
            grayscaleToolStripMenuItem.Click += grayscaleToolStripMenuItem_Click;
            // 
            // inversionToolStripMenuItem1
            // 
            inversionToolStripMenuItem1.Name = "inversionToolStripMenuItem1";
            inversionToolStripMenuItem1.Size = new Size(155, 26);
            inversionToolStripMenuItem1.Text = "Inversion";
            inversionToolStripMenuItem1.Click += inversionToolStripMenuItem1_Click;
            // 
            // sepiaToolStripMenuItem1
            // 
            sepiaToolStripMenuItem1.Name = "sepiaToolStripMenuItem1";
            sepiaToolStripMenuItem1.Size = new Size(155, 26);
            sepiaToolStripMenuItem1.Text = "Sepia";
            sepiaToolStripMenuItem1.Click += sepiaToolStripMenuItem1_Click;
            // 
            // matrixToolStripMenuItem
            // 
            matrixToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { smoothingToolStripMenuItem, gaussianBlurToolStripMenuItem, sharpenToolStripMenuItem, meanRemovalToolStripMenuItem, embossingToolStripMenuItem });
            matrixToolStripMenuItem.Name = "matrixToolStripMenuItem";
            matrixToolStripMenuItem.Size = new Size(65, 24);
            matrixToolStripMenuItem.Text = "Matrix";
            // 
            // smoothingToolStripMenuItem
            // 
            smoothingToolStripMenuItem.Name = "smoothingToolStripMenuItem";
            smoothingToolStripMenuItem.Size = new Size(224, 26);
            smoothingToolStripMenuItem.Text = "Smoothing";
            smoothingToolStripMenuItem.Click += smoothingToolStripMenuItem_Click;
            // 
            // gaussianBlurToolStripMenuItem
            // 
            gaussianBlurToolStripMenuItem.Name = "gaussianBlurToolStripMenuItem";
            gaussianBlurToolStripMenuItem.Size = new Size(224, 26);
            gaussianBlurToolStripMenuItem.Text = "Gaussian Blur";
            gaussianBlurToolStripMenuItem.Click += gaussianBlurToolStripMenuItem_Click;
            // 
            // sharpenToolStripMenuItem
            // 
            sharpenToolStripMenuItem.Name = "sharpenToolStripMenuItem";
            sharpenToolStripMenuItem.Size = new Size(224, 26);
            sharpenToolStripMenuItem.Text = "Sharpen";
            sharpenToolStripMenuItem.Click += sharpenToolStripMenuItem_Click;
            // 
            // meanRemovalToolStripMenuItem
            // 
            meanRemovalToolStripMenuItem.Name = "meanRemovalToolStripMenuItem";
            meanRemovalToolStripMenuItem.Size = new Size(224, 26);
            meanRemovalToolStripMenuItem.Text = "Mean Removal";
            meanRemovalToolStripMenuItem.Click += meanRemovalToolStripMenuItem_Click;
            // 
            // embossingToolStripMenuItem
            // 
            embossingToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { embossLaplacianToolStripMenuItem, horizontalVerticalToolStripMenuItem, horizontalOnlyToolStripMenuItem, verticalOnlyToolStripMenuItem, allDirectionsToolStripMenuItem, lossyToolStripMenuItem });
            embossingToolStripMenuItem.Name = "embossingToolStripMenuItem";
            embossingToolStripMenuItem.Size = new Size(224, 26);
            embossingToolStripMenuItem.Text = "Embossing";
            // 
            // embossLaplacianToolStripMenuItem
            // 
            embossLaplacianToolStripMenuItem.Name = "embossLaplacianToolStripMenuItem";
            embossLaplacianToolStripMenuItem.Size = new Size(224, 26);
            embossLaplacianToolStripMenuItem.Text = "Emboss Laplacian";
            embossLaplacianToolStripMenuItem.Click += embossLaplacianToolStripMenuItem_Click;
            // 
            // horizontalVerticalToolStripMenuItem
            // 
            horizontalVerticalToolStripMenuItem.Name = "horizontalVerticalToolStripMenuItem";
            horizontalVerticalToolStripMenuItem.Size = new Size(224, 26);
            horizontalVerticalToolStripMenuItem.Text = "Horizontal/Vertical";
            horizontalVerticalToolStripMenuItem.Click += horizontalVerticalToolStripMenuItem_Click;
            // 
            // horizontalOnlyToolStripMenuItem
            // 
            horizontalOnlyToolStripMenuItem.Name = "horizontalOnlyToolStripMenuItem";
            horizontalOnlyToolStripMenuItem.Size = new Size(224, 26);
            horizontalOnlyToolStripMenuItem.Text = "Horizontal Only";
            horizontalOnlyToolStripMenuItem.Click += horizontalOnlyToolStripMenuItem_Click;
            // 
            // verticalOnlyToolStripMenuItem
            // 
            verticalOnlyToolStripMenuItem.Name = "verticalOnlyToolStripMenuItem";
            verticalOnlyToolStripMenuItem.Size = new Size(224, 26);
            verticalOnlyToolStripMenuItem.Text = "Vertical Only";
            verticalOnlyToolStripMenuItem.Click += verticalOnlyToolStripMenuItem_Click;
            // 
            // allDirectionsToolStripMenuItem
            // 
            allDirectionsToolStripMenuItem.Name = "allDirectionsToolStripMenuItem";
            allDirectionsToolStripMenuItem.Size = new Size(224, 26);
            allDirectionsToolStripMenuItem.Text = "All Directions";
            allDirectionsToolStripMenuItem.Click += allDirectionsToolStripMenuItem_Click;
            // 
            // lossyToolStripMenuItem
            // 
            lossyToolStripMenuItem.Name = "lossyToolStripMenuItem";
            lossyToolStripMenuItem.Size = new Size(224, 26);
            lossyToolStripMenuItem.Text = "Lossy";
            lossyToolStripMenuItem.Click += lossyToolStripMenuItem_Click;
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
            panelContainer.Paint += panelContainer_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 2);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 12;
            label4.Text = "Contrast:";
            // 
            // trackBar2
            // 
            trackBar2.Location = new Point(35, 25);
            trackBar2.Maximum = 50;
            trackBar2.Minimum = -50;
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new Size(400, 56);
            trackBar2.TabIndex = 11;
            trackBar2.Scroll += trackBar2_Scroll_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(490, 2);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 10;
            label3.Text = "Brightness:";
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(490, 25);
            trackBar1.Maximum = 50;
            trackBar1.Minimum = -50;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(400, 56);
            trackBar1.TabIndex = 9;
            trackBar1.Scroll += trackBar1_Scroll_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(654, 474);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 8;
            label2.Text = "Processed";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(197, 474);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 7;
            label1.Text = "Loaded";
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(500, 81);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(390, 385);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(35, 81);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(390, 385);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem1, onToolStripMenuItem1, offToolStripMenuItem1 });
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
            saveToolStripMenuItem1.Size = new Size(199, 26);
            saveToolStripMenuItem1.Text = "Save";
            saveToolStripMenuItem1.Click += saveToolStripMenuItem1_Click;
            // 
            // switchToForm1ToolStripMenuItem
            // 
            switchToForm1ToolStripMenuItem.Name = "switchToForm1ToolStripMenuItem";
            switchToForm1ToolStripMenuItem.Size = new Size(199, 26);
            switchToForm1ToolStripMenuItem.Text = "Switch to Form1";
            switchToForm1ToolStripMenuItem.Click += switchToForm1ToolStripMenuItem_Click;
            // 
            // onToolStripMenuItem1
            // 
            onToolStripMenuItem1.Name = "onToolStripMenuItem1";
            onToolStripMenuItem1.Size = new Size(42, 24);
            onToolStripMenuItem1.Text = "On";
            onToolStripMenuItem1.Click += onToolStripMenuItem1_Click;
            // 
            // offToolStripMenuItem1
            // 
            offToolStripMenuItem1.Name = "offToolStripMenuItem1";
            offToolStripMenuItem1.Size = new Size(44, 24);
            offToolStripMenuItem1.Text = "Off";
            offToolStripMenuItem1.Click += offToolStripMenuItem1_Click;
            // 
            // timer1
            // 
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Interval = 10;
            timer2.Tick += timer2_Tick;
            // 
            // timer3
            // 
            timer3.Interval = 10;
            timer3.Tick += timer3_Tick;
            // 
            // switchToCoinFormsToolStripMenuItem
            // 
            switchToCoinFormsToolStripMenuItem.Name = "switchToCoinFormsToolStripMenuItem";
            switchToCoinFormsToolStripMenuItem.Size = new Size(231, 26);
            switchToCoinFormsToolStripMenuItem.Text = "Switch to Coin Forms";
            switchToCoinFormsToolStripMenuItem.Click += switchToCoinFormsToolStripMenuItem_Click;
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
        private ToolStripMenuItem onToolStripMenuItem;
        private ToolStripMenuItem offToolStripMenuItem;
        private ToolStripMenuItem videoToolStripMenuItem;
        private ToolStripMenuItem grayscaleToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private ToolStripMenuItem inversionToolStripMenuItem1;
        private ToolStripMenuItem sepiaToolStripMenuItem1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private ToolStripMenuItem onToolStripMenuItem1;
        private ToolStripMenuItem offToolStripMenuItem1;
        private ToolStripMenuItem matrixToolStripMenuItem;
        private ToolStripMenuItem smoothingToolStripMenuItem;
        private ToolStripMenuItem gaussianBlurToolStripMenuItem;
        private ToolStripMenuItem sharpenToolStripMenuItem;
        private ToolStripMenuItem meanRemovalToolStripMenuItem;
        private ToolStripMenuItem embossingToolStripMenuItem;
        private ToolStripMenuItem embossLaplacianToolStripMenuItem;
        private ToolStripMenuItem horizontalVerticalToolStripMenuItem;
        private ToolStripMenuItem horizontalOnlyToolStripMenuItem;
        private ToolStripMenuItem verticalOnlyToolStripMenuItem;
        private ToolStripMenuItem allDirectionsToolStripMenuItem;
        private ToolStripMenuItem lossyToolStripMenuItem;
        private ToolStripMenuItem switchToCoinFormsToolStripMenuItem;
    }
}
