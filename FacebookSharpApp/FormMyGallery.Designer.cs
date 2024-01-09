using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    partial class FormMyGallery
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
            this.buttonPrev = new System.Windows.Forms.Button();
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            this.buttonShowAlbum = new System.Windows.Forms.Button();
            this.labelAlbumName = new System.Windows.Forms.Label();
            this.buttonBackToAlbums = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.labelShowingNowDetails = new System.Windows.Forms.Label();
            this.panelAlbumTitle = new System.Windows.Forms.Panel();
            this.panelAlbumsNevigation = new System.Windows.Forms.Panel();
            this.panelBackToAlbum = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            this.panelAlbumTitle.SuspendLayout();
            this.panelAlbumsNevigation.SuspendLayout();
            this.panelBackToAlbum.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPrev
            // 
            this.buttonPrev.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPrev.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonPrev.FlatAppearance.BorderSize = 0;
            this.buttonPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrev.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrev.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonPrev.Location = new System.Drawing.Point(66, 103);
            this.buttonPrev.Margin = new System.Windows.Forms.Padding(6);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(160, 83);
            this.buttonPrev.TabIndex = 1;
            this.buttonPrev.Text = "Previous";
            this.buttonPrev.UseVisualStyleBackColor = false;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // pictureBoxMain
            // 
            this.pictureBoxMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxMain.Location = new System.Drawing.Point(195, 159);
            this.pictureBoxMain.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(762, 553);
            this.pictureBoxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMain.TabIndex = 0;
            this.pictureBoxMain.TabStop = false;
            // 
            // buttonShowAlbum
            // 
            this.buttonShowAlbum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonShowAlbum.BackColor = System.Drawing.Color.MediumOrchid;
            this.buttonShowAlbum.FlatAppearance.BorderSize = 0;
            this.buttonShowAlbum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowAlbum.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowAlbum.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonShowAlbum.Location = new System.Drawing.Point(66, 7);
            this.buttonShowAlbum.Margin = new System.Windows.Forms.Padding(6);
            this.buttonShowAlbum.Name = "buttonShowAlbum";
            this.buttonShowAlbum.Size = new System.Drawing.Size(357, 74);
            this.buttonShowAlbum.TabIndex = 3;
            this.buttonShowAlbum.Text = "Show Album";
            this.buttonShowAlbum.UseVisualStyleBackColor = false;
            this.buttonShowAlbum.Click += new System.EventHandler(this.buttonShowAlbum_Click);
            // 
            // labelAlbumName
            // 
            this.labelAlbumName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelAlbumName.AutoSize = true;
            this.labelAlbumName.Font = new System.Drawing.Font("Aharoni", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlbumName.ForeColor = System.Drawing.Color.DarkViolet;
            this.labelAlbumName.Location = new System.Drawing.Point(241, 60);
            this.labelAlbumName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelAlbumName.Name = "labelAlbumName";
            this.labelAlbumName.Size = new System.Drawing.Size(254, 38);
            this.labelAlbumName.TabIndex = 5;
            this.labelAlbumName.Text = "Album Name";
            this.labelAlbumName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonBackToAlbums
            // 
            this.buttonBackToAlbums.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBackToAlbums.BackColor = System.Drawing.Color.DarkViolet;
            this.buttonBackToAlbums.FlatAppearance.BorderSize = 0;
            this.buttonBackToAlbums.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackToAlbums.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBackToAlbums.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonBackToAlbums.Location = new System.Drawing.Point(209, 1);
            this.buttonBackToAlbums.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBackToAlbums.Name = "buttonBackToAlbums";
            this.buttonBackToAlbums.Size = new System.Drawing.Size(357, 74);
            this.buttonBackToAlbums.TabIndex = 18;
            this.buttonBackToAlbums.Text = "Back To Albums";
            this.buttonBackToAlbums.UseVisualStyleBackColor = false;
            this.buttonBackToAlbums.Click += new System.EventHandler(this.buttonBackToAlbums_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonNext.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonNext.FlatAppearance.BorderSize = 0;
            this.buttonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNext.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNext.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonNext.Location = new System.Drawing.Point(256, 103);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(168, 83);
            this.buttonNext.TabIndex = 19;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // labelShowingNowDetails
            // 
            this.labelShowingNowDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelShowingNowDetails.Font = new System.Drawing.Font("Aharoni", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShowingNowDetails.ForeColor = System.Drawing.Color.DarkViolet;
            this.labelShowingNowDetails.Location = new System.Drawing.Point(115, 15);
            this.labelShowingNowDetails.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelShowingNowDetails.Name = "labelShowingNowDetails";
            this.labelShowingNowDetails.Size = new System.Drawing.Size(516, 36);
            this.labelShowingNowDetails.TabIndex = 20;
            this.labelShowingNowDetails.Text = "Cover photo of album:";
            this.labelShowingNowDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelAlbumTitle
            // 
            this.panelAlbumTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelAlbumTitle.Controls.Add(this.labelShowingNowDetails);
            this.panelAlbumTitle.Controls.Add(this.labelAlbumName);
            this.panelAlbumTitle.Location = new System.Drawing.Point(195, 25);
            this.panelAlbumTitle.Name = "panelAlbumTitle";
            this.panelAlbumTitle.Size = new System.Drawing.Size(760, 110);
            this.panelAlbumTitle.TabIndex = 21;
            // 
            // panelAlbumsNevigation
            // 
            this.panelAlbumsNevigation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelAlbumsNevigation.Controls.Add(this.buttonPrev);
            this.panelAlbumsNevigation.Controls.Add(this.buttonShowAlbum);
            this.panelAlbumsNevigation.Controls.Add(this.buttonNext);
            this.panelAlbumsNevigation.Location = new System.Drawing.Point(338, 732);
            this.panelAlbumsNevigation.Name = "panelAlbumsNevigation";
            this.panelAlbumsNevigation.Size = new System.Drawing.Size(488, 188);
            this.panelAlbumsNevigation.TabIndex = 22;
            // 
            // panelBackToAlbum
            // 
            this.panelBackToAlbum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelBackToAlbum.Controls.Add(this.buttonBackToAlbums);
            this.panelBackToAlbum.Location = new System.Drawing.Point(195, 739);
            this.panelBackToAlbum.Name = "panelBackToAlbum";
            this.panelBackToAlbum.Size = new System.Drawing.Size(760, 77);
            this.panelBackToAlbum.TabIndex = 23;
            // 
            // FormMyGallery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 932);
            this.Controls.Add(this.panelBackToAlbum);
            this.Controls.Add(this.panelAlbumsNevigation);
            this.Controls.Add(this.panelAlbumTitle);
            this.Controls.Add(this.pictureBoxMain);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormMyGallery";
            this.Text = "My Gallery";
            this.Load += new System.EventHandler(this.formMyGallery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            this.panelAlbumTitle.ResumeLayout(false);
            this.panelAlbumTitle.PerformLayout();
            this.panelAlbumsNevigation.ResumeLayout(false);
            this.panelBackToAlbum.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMain;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonShowAlbum;
        private System.Windows.Forms.Label labelAlbumName;
        private Button buttonBackToAlbums;
        private Button buttonNext;
        private Label labelShowingNowDetails;
        private Panel panelAlbumTitle;
        private Panel panelAlbumsNevigation;
        private Panel panelBackToAlbum;
    }
}