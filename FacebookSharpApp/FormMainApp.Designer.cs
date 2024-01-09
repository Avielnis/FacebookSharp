namespace BasicFacebookFeatures
{
    partial class FormMainApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainApp));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonMyGallery = new System.Windows.Forms.Button();
            this.buttonGeoChallenge = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonPostTips = new System.Windows.Forms.Button();
            this.buttonMyFavorites = new System.Windows.Forms.Button();
            this.buttonMyFriends = new System.Windows.Forms.Button();
            this.buttonMyEvents = new System.Windows.Forms.Button();
            this.buttonMyPosts = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonAboutMe = new System.Windows.Forms.Button();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelFeatureDisplay = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(80)))));
            this.panelMenu.Controls.Add(this.buttonMyGallery);
            this.panelMenu.Controls.Add(this.buttonGeoChallenge);
            this.panelMenu.Controls.Add(this.buttonLogout);
            this.panelMenu.Controls.Add(this.buttonPostTips);
            this.panelMenu.Controls.Add(this.buttonMyFavorites);
            this.panelMenu.Controls.Add(this.buttonMyFriends);
            this.panelMenu.Controls.Add(this.buttonMyEvents);
            this.panelMenu.Controls.Add(this.buttonMyPosts);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Controls.Add(this.buttonAboutMe);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(374, 1454);
            this.panelMenu.TabIndex = 3;
            // 
            // buttonMyGallery
            // 
            this.buttonMyGallery.FlatAppearance.BorderSize = 0;
            this.buttonMyGallery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMyGallery.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMyGallery.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonMyGallery.Image = global::BasicFacebookFeatures.Properties.Resources.IconMyGallery;
            this.buttonMyGallery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMyGallery.Location = new System.Drawing.Point(6, 472);
            this.buttonMyGallery.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMyGallery.Name = "buttonMyGallery";
            this.buttonMyGallery.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.buttonMyGallery.Size = new System.Drawing.Size(364, 134);
            this.buttonMyGallery.TabIndex = 6;
            this.buttonMyGallery.Text = "   My Gallery";
            this.buttonMyGallery.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMyGallery.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonMyGallery.UseVisualStyleBackColor = true;
            this.buttonMyGallery.Click += new System.EventHandler(this.buttonMyAlbums_Click);
            // 
            // buttonGeoChallenge
            // 
            this.buttonGeoChallenge.FlatAppearance.BorderSize = 0;
            this.buttonGeoChallenge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGeoChallenge.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGeoChallenge.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonGeoChallenge.Image = global::BasicFacebookFeatures.Properties.Resources.IconGeoChallenge;
            this.buttonGeoChallenge.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGeoChallenge.Location = new System.Drawing.Point(2, 1170);
            this.buttonGeoChallenge.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGeoChallenge.Name = "buttonGeoChallenge";
            this.buttonGeoChallenge.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.buttonGeoChallenge.Size = new System.Drawing.Size(364, 134);
            this.buttonGeoChallenge.TabIndex = 13;
            this.buttonGeoChallenge.Text = "   Geo-Challenge";
            this.buttonGeoChallenge.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonGeoChallenge.UseVisualStyleBackColor = true;
            this.buttonGeoChallenge.Click += new System.EventHandler(this.buttonGeoChallenge_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonLogout.FlatAppearance.BorderSize = 0;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonLogout.Image = global::BasicFacebookFeatures.Properties.Resources.IconLogout;
            this.buttonLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogout.Location = new System.Drawing.Point(0, 1366);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.buttonLogout.Size = new System.Drawing.Size(374, 88);
            this.buttonLogout.TabIndex = 12;
            this.buttonLogout.Text = "   Logout";
            this.buttonLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonPostTips
            // 
            this.buttonPostTips.FlatAppearance.BorderSize = 0;
            this.buttonPostTips.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPostTips.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPostTips.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonPostTips.Image = global::BasicFacebookFeatures.Properties.Resources.IconPostTips;
            this.buttonPostTips.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPostTips.Location = new System.Drawing.Point(2, 1032);
            this.buttonPostTips.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPostTips.Name = "buttonPostTips";
            this.buttonPostTips.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.buttonPostTips.Size = new System.Drawing.Size(364, 134);
            this.buttonPostTips.TabIndex = 11;
            this.buttonPostTips.Text = "   Posts Tips";
            this.buttonPostTips.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonPostTips.UseVisualStyleBackColor = true;
            this.buttonPostTips.Click += new System.EventHandler(this.buttonPostTips_Click);
            // 
            // buttonMyFavorites
            // 
            this.buttonMyFavorites.FlatAppearance.BorderSize = 0;
            this.buttonMyFavorites.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMyFavorites.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMyFavorites.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonMyFavorites.Image = global::BasicFacebookFeatures.Properties.Resources.IconMyFavorites;
            this.buttonMyFavorites.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMyFavorites.Location = new System.Drawing.Point(6, 894);
            this.buttonMyFavorites.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMyFavorites.Name = "buttonMyFavorites";
            this.buttonMyFavorites.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.buttonMyFavorites.Size = new System.Drawing.Size(364, 134);
            this.buttonMyFavorites.TabIndex = 9;
            this.buttonMyFavorites.Text = "   My Favorites";
            this.buttonMyFavorites.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonMyFavorites.UseVisualStyleBackColor = true;
            this.buttonMyFavorites.Click += new System.EventHandler(this.buttonMyFavorites_Click);
            // 
            // buttonMyFriends
            // 
            this.buttonMyFriends.FlatAppearance.BorderSize = 0;
            this.buttonMyFriends.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMyFriends.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMyFriends.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonMyFriends.Image = global::BasicFacebookFeatures.Properties.Resources.IconMyFriends;
            this.buttonMyFriends.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMyFriends.Location = new System.Drawing.Point(6, 756);
            this.buttonMyFriends.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMyFriends.Name = "buttonMyFriends";
            this.buttonMyFriends.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.buttonMyFriends.Size = new System.Drawing.Size(364, 134);
            this.buttonMyFriends.TabIndex = 8;
            this.buttonMyFriends.Text = "   My Friends";
            this.buttonMyFriends.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonMyFriends.UseVisualStyleBackColor = true;
            this.buttonMyFriends.Click += new System.EventHandler(this.buttonMyFriends_Click);
            // 
            // buttonMyEvents
            // 
            this.buttonMyEvents.FlatAppearance.BorderSize = 0;
            this.buttonMyEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMyEvents.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMyEvents.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonMyEvents.Image = global::BasicFacebookFeatures.Properties.Resources.IconMyEvents;
            this.buttonMyEvents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMyEvents.Location = new System.Drawing.Point(6, 618);
            this.buttonMyEvents.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMyEvents.Name = "buttonMyEvents";
            this.buttonMyEvents.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.buttonMyEvents.Size = new System.Drawing.Size(364, 134);
            this.buttonMyEvents.TabIndex = 7;
            this.buttonMyEvents.Text = "   My Events";
            this.buttonMyEvents.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonMyEvents.UseVisualStyleBackColor = true;
            this.buttonMyEvents.Click += new System.EventHandler(this.buttonMyEvents_Click);
            // 
            // buttonMyPosts
            // 
            this.buttonMyPosts.FlatAppearance.BorderSize = 0;
            this.buttonMyPosts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMyPosts.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMyPosts.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonMyPosts.Image = global::BasicFacebookFeatures.Properties.Resources.IconMyPostsGainsboro;
            this.buttonMyPosts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMyPosts.Location = new System.Drawing.Point(6, 336);
            this.buttonMyPosts.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMyPosts.Name = "buttonMyPosts";
            this.buttonMyPosts.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.buttonMyPosts.Size = new System.Drawing.Size(364, 134);
            this.buttonMyPosts.TabIndex = 5;
            this.buttonMyPosts.Text = "   My Posts";
            this.buttonMyPosts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonMyPosts.UseVisualStyleBackColor = true;
            this.buttonMyPosts.Click += new System.EventHandler(this.buttonMyPosts_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(374, 190);
            this.panelLogo.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.pictureBox1.Image = global::BasicFacebookFeatures.Properties.Resources.FacebookSharpLogoGray;
            this.pictureBox1.Location = new System.Drawing.Point(20, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(332, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // buttonAboutMe
            // 
            this.buttonAboutMe.FlatAppearance.BorderSize = 0;
            this.buttonAboutMe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAboutMe.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonAboutMe.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonAboutMe.Image = global::BasicFacebookFeatures.Properties.Resources.IconAboutMe;
            this.buttonAboutMe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAboutMe.Location = new System.Drawing.Point(6, 204);
            this.buttonAboutMe.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAboutMe.Name = "buttonAboutMe";
            this.buttonAboutMe.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.buttonAboutMe.Size = new System.Drawing.Size(364, 134);
            this.buttonAboutMe.TabIndex = 2;
            this.buttonAboutMe.Text = "   About Me";
            this.buttonAboutMe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAboutMe.UseCompatibleTextRendering = true;
            this.buttonAboutMe.UseVisualStyleBackColor = true;
            this.buttonAboutMe.Click += new System.EventHandler(this.buttonAboutMe_Click);
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(80)))));
            this.panelTitle.Controls.Add(this.labelTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(374, 0);
            this.panelTitle.Margin = new System.Windows.Forms.Padding(2);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1403, 194);
            this.panelTitle.TabIndex = 4;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(553, 70);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(217, 57);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Welcome";
            // 
            // panelFeatureDisplay
            // 
            this.panelFeatureDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFeatureDisplay.Location = new System.Drawing.Point(374, 194);
            this.panelFeatureDisplay.Margin = new System.Windows.Forms.Padding(2);
            this.panelFeatureDisplay.Name = "panelFeatureDisplay";
            this.panelFeatureDisplay.Size = new System.Drawing.Size(1403, 1260);
            this.panelFeatureDisplay.TabIndex = 5;
            // 
            // FormMainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1777, 1454);
            this.Controls.Add(this.panelFeatureDisplay);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMainApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook#";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.formMain_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonAboutMe;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button buttonMyPosts;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonPostTips;
        private System.Windows.Forms.Button buttonMyFavorites;
        private System.Windows.Forms.Button buttonMyFriends;
        private System.Windows.Forms.Button buttonMyEvents;
        private System.Windows.Forms.Button buttonMyGallery;
        private System.Windows.Forms.Button buttonGeoChallenge;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelFeatureDisplay;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}