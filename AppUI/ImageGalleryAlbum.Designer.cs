namespace AppUI
{
    public partial class ImageGalleryAlbum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageGalleryAlbum));
            this.labelInstruction = new System.Windows.Forms.Label();
            this.pictureBoxInstruction = new System.Windows.Forms.PictureBox();
            this.pictureBoxCover = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInstruction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInstruction
            // 
            this.labelInstruction.AutoSize = true;
            this.labelInstruction.Location = new System.Drawing.Point(45, 82);
            this.labelInstruction.Name = "labelInstruction";
            this.labelInstruction.Size = new System.Drawing.Size(275, 20);
            this.labelInstruction.TabIndex = 9;
            this.labelInstruction.Text = "Add To Favorite By Checking The Box";
            // 
            // pictureBoxInstruction
            // 
            this.pictureBoxInstruction.BackgroundImage = global::A21_Ex01_Tal_313489288_Neta_313245177.Properties.Resources.checkSymbol1;
            this.pictureBoxInstruction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxInstruction.Location = new System.Drawing.Point(12, 75);
            this.pictureBoxInstruction.Name = "pictureBoxInstruction";
            this.pictureBoxInstruction.Size = new System.Drawing.Size(27, 27);
            this.pictureBoxInstruction.TabIndex = 8;
            this.pictureBoxInstruction.TabStop = false;
            // 
            // pictureBoxCover
            // 
            this.pictureBoxCover.BackgroundImage = global::A21_Ex01_Tal_313489288_Neta_313245177.Properties.Resources.FacebookTitle1;
            this.pictureBoxCover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxCover.Location = new System.Drawing.Point(-2, 0);
            this.pictureBoxCover.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxCover.Name = "pictureBoxCover";
            this.pictureBoxCover.Size = new System.Drawing.Size(2500, 67);
            this.pictureBoxCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCover.TabIndex = 7;
            this.pictureBoxCover.TabStop = false;
            // 
            // ImageGalleryAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1200, 1050);
            this.Controls.Add(this.labelInstruction);
            this.Controls.Add(this.pictureBoxInstruction);
            this.Controls.Add(this.pictureBoxCover);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ImageGalleryAlbum";
            this.Text = "PhotosInCurrentAlbum";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.imageGalleryAlbum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInstruction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxCover;
        private System.Windows.Forms.PictureBox pictureBoxInstruction;
        private System.Windows.Forms.Label labelInstruction;
    }
}