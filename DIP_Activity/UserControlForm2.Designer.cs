namespace DIP_Activity
{
    partial class UserControlForm2
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            openFileDialog1 = new OpenFileDialog();
            openFileDialog2 = new OpenFileDialog();
            trackBar1 = new TrackBar();
            label3 = new Label();
            saveFileDialog1 = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(13, 141);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(280, 280);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(326, 141);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(280, 280);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.Location = new Point(633, 141);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(280, 280);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(115, 424);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 6;
            label1.Text = "imageB";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(434, 424);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 7;
            label2.Text = "imageA";
            // 
            // button1
            // 
            button1.Location = new Point(71, 462);
            button1.Name = "button1";
            button1.Size = new Size(140, 52);
            button1.TabIndex = 8;
            button1.Text = "Load Image";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(392, 462);
            button2.Name = "button2";
            button2.Size = new Size(140, 52);
            button2.TabIndex = 9;
            button2.Text = "Load Background";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(709, 462);
            button3.Name = "button3";
            button3.Size = new Size(140, 52);
            button3.TabIndex = 10;
            button3.Text = "Subtract";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // openFileDialog2
            // 
            openFileDialog2.FileName = "openFileDialog2";
            openFileDialog2.FileOk += openFileDialog2_FileOk;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(71, 54);
            trackBar1.Maximum = 100;
            trackBar1.Minimum = 1;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(778, 56);
            trackBar1.TabIndex = 11;
            trackBar1.Value = 50;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(71, 31);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 12;
            label3.Text = "Threshold:";
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.FileOk += saveFileDialog1_FileOk;
            // 
            // UserControlForm2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label3);
            Controls.Add(trackBar1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "UserControlForm2";
            Size = new Size(924, 602);
            Load += UserFormControl_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private OpenFileDialog openFileDialog1;
        private OpenFileDialog openFileDialog2;
        private TrackBar trackBar1;
        private Label label3;
        private SaveFileDialog saveFileDialog1;
    }
}
