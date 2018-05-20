namespace DrawBot
{
    partial class GANmain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainTabCtrl = new System.Windows.Forms.TabControl();
            this.HomePage = new System.Windows.Forms.TabPage();
            this.BitmapPoolingPage = new System.Windows.Forms.TabPage();
            this.TestDataListBox = new System.Windows.Forms.ListBox();
            this.SourceImage = new System.Windows.Forms.PictureBox();
            this.ShowSizeLabel = new System.Windows.Forms.Label();
            this.PoolBtn = new System.Windows.Forms.Button();
            this.PooledImage = new System.Windows.Forms.PictureBox();
            this.ShowNewSizeLabel = new System.Windows.Forms.Label();
            this.MainTabCtrl.SuspendLayout();
            this.HomePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SourceImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PooledImage)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTabCtrl
            // 
            this.MainTabCtrl.Controls.Add(this.HomePage);
            this.MainTabCtrl.Controls.Add(this.BitmapPoolingPage);
            this.MainTabCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabCtrl.Location = new System.Drawing.Point(0, 0);
            this.MainTabCtrl.Name = "MainTabCtrl";
            this.MainTabCtrl.SelectedIndex = 0;
            this.MainTabCtrl.Size = new System.Drawing.Size(1025, 641);
            this.MainTabCtrl.TabIndex = 0;
            // 
            // HomePage
            // 
            this.HomePage.Controls.Add(this.ShowNewSizeLabel);
            this.HomePage.Controls.Add(this.PooledImage);
            this.HomePage.Controls.Add(this.PoolBtn);
            this.HomePage.Controls.Add(this.ShowSizeLabel);
            this.HomePage.Controls.Add(this.SourceImage);
            this.HomePage.Controls.Add(this.TestDataListBox);
            this.HomePage.Location = new System.Drawing.Point(4, 22);
            this.HomePage.Name = "HomePage";
            this.HomePage.Padding = new System.Windows.Forms.Padding(3);
            this.HomePage.Size = new System.Drawing.Size(1017, 615);
            this.HomePage.TabIndex = 0;
            this.HomePage.Text = "HomePage";
            this.HomePage.UseVisualStyleBackColor = true;
            // 
            // BitmapPoolingPage
            // 
            this.BitmapPoolingPage.Location = new System.Drawing.Point(4, 22);
            this.BitmapPoolingPage.Name = "BitmapPoolingPage";
            this.BitmapPoolingPage.Padding = new System.Windows.Forms.Padding(3);
            this.BitmapPoolingPage.Size = new System.Drawing.Size(1017, 615);
            this.BitmapPoolingPage.TabIndex = 1;
            this.BitmapPoolingPage.Text = "BitmapPoolingPage";
            this.BitmapPoolingPage.UseVisualStyleBackColor = true;
            // 
            // TestDataListBox
            // 
            this.TestDataListBox.FormattingEnabled = true;
            this.TestDataListBox.Location = new System.Drawing.Point(12, 14);
            this.TestDataListBox.Name = "TestDataListBox";
            this.TestDataListBox.Size = new System.Drawing.Size(138, 303);
            this.TestDataListBox.TabIndex = 0;
            this.TestDataListBox.SelectedIndexChanged += new System.EventHandler(this.TestDataListBox_SelectedIndexChanged);
            // 
            // SourceImage
            // 
            this.SourceImage.Location = new System.Drawing.Point(164, 15);
            this.SourceImage.Name = "SourceImage";
            this.SourceImage.Size = new System.Drawing.Size(300, 300);
            this.SourceImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SourceImage.TabIndex = 1;
            this.SourceImage.TabStop = false;
            // 
            // ShowSizeLabel
            // 
            this.ShowSizeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(219)))), ((int)(((byte)(207)))));
            this.ShowSizeLabel.Location = new System.Drawing.Point(164, 296);
            this.ShowSizeLabel.Name = "ShowSizeLabel";
            this.ShowSizeLabel.Size = new System.Drawing.Size(297, 18);
            this.ShowSizeLabel.TabIndex = 2;
            this.ShowSizeLabel.Text = "ShowSize";
            this.ShowSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PoolBtn
            // 
            this.PoolBtn.Location = new System.Drawing.Point(463, 146);
            this.PoolBtn.Name = "PoolBtn";
            this.PoolBtn.Size = new System.Drawing.Size(51, 27);
            this.PoolBtn.TabIndex = 3;
            this.PoolBtn.Text = "Pool";
            this.PoolBtn.UseVisualStyleBackColor = true;
            this.PoolBtn.Click += new System.EventHandler(this.PoolBtn_Click);
            // 
            // PooledImage
            // 
            this.PooledImage.Location = new System.Drawing.Point(511, 14);
            this.PooledImage.Name = "PooledImage";
            this.PooledImage.Size = new System.Drawing.Size(300, 300);
            this.PooledImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PooledImage.TabIndex = 4;
            this.PooledImage.TabStop = false;
            // 
            // ShowNewSizeLabel
            // 
            this.ShowNewSizeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(219)))), ((int)(((byte)(207)))));
            this.ShowNewSizeLabel.Location = new System.Drawing.Point(514, 296);
            this.ShowNewSizeLabel.Name = "ShowNewSizeLabel";
            this.ShowNewSizeLabel.Size = new System.Drawing.Size(297, 18);
            this.ShowNewSizeLabel.TabIndex = 5;
            this.ShowNewSizeLabel.Text = "ShowNewSize";
            this.ShowNewSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GANmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 641);
            this.Controls.Add(this.MainTabCtrl);
            this.Name = "GANmain";
            this.Text = "GANmain";
            this.Load += new System.EventHandler(this.GANmain_Load);
            this.MainTabCtrl.ResumeLayout(false);
            this.HomePage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SourceImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PooledImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabCtrl;
        private System.Windows.Forms.TabPage HomePage;
        private System.Windows.Forms.TabPage BitmapPoolingPage;
        private System.Windows.Forms.ListBox TestDataListBox;
        private System.Windows.Forms.PictureBox SourceImage;
        private System.Windows.Forms.Label ShowSizeLabel;
        private System.Windows.Forms.Label ShowNewSizeLabel;
        private System.Windows.Forms.PictureBox PooledImage;
        private System.Windows.Forms.Button PoolBtn;
    }
}