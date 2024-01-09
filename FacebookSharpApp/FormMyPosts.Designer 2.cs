namespace BasicFacebookFeatures
{
    partial class FormMyPosts
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label labelCreatedTimeTitle;
            System.Windows.Forms.Label labelPlaceTitle;
            System.Windows.Forms.Label labelLikesTitle;
            this.labelLikeCounter = new System.Windows.Forms.Label();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.labelPostTitile = new System.Windows.Forms.Label();
            this.labelCommentsTitle = new System.Windows.Forms.Label();
            this.pictureBoxComments = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxLocationIcon = new System.Windows.Forms.PictureBox();
            this.pictureBoxPostPicture = new System.Windows.Forms.PictureBox();
            this.labelWhatsOnYourMind = new System.Windows.Forms.Label();
            this.richTextBoxNewPost = new System.Windows.Forms.RichTextBox();
            this.buttonPostNewPost = new System.Windows.Forms.Button();
            this.panelMyPosts = new System.Windows.Forms.Panel();
            this.buttonShowMyPosts = new System.Windows.Forms.Button();
            this.loadingAnimation = new BasicFacebookFeatures.LoadingAnimation();
            this.panelPostDetails = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.commentsListBox = new System.Windows.Forms.ListBox();
            this.commentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelPlace = new System.Windows.Forms.Label();
            this.createdTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.panelQuickView = new System.Windows.Forms.Panel();
            labelCreatedTimeTitle = new System.Windows.Forms.Label();
            labelPlaceTitle = new System.Windows.Forms.Label();
            labelLikesTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxComments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLocationIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPostPicture)).BeginInit();
            this.panelMyPosts.SuspendLayout();
            this.panelPostDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            this.panelQuickView.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCreatedTimeTitle
            // 
            labelCreatedTimeTitle.AutoSize = true;
            labelCreatedTimeTitle.Location = new System.Drawing.Point(38, 85);
            labelCreatedTimeTitle.Name = "labelCreatedTimeTitle";
            labelCreatedTimeTitle.Size = new System.Drawing.Size(77, 13);
            labelCreatedTimeTitle.TabIndex = 6;
            labelCreatedTimeTitle.Text = "Created Time:";
            // 
            // labelPlaceTitle
            // 
            labelPlaceTitle.AutoSize = true;
            labelPlaceTitle.Location = new System.Drawing.Point(45, 58);
            labelPlaceTitle.Name = "labelPlaceTitle";
            labelPlaceTitle.Size = new System.Drawing.Size(36, 13);
            labelPlaceTitle.TabIndex = 7;
            labelPlaceTitle.Text = "Place:";
            // 
            // labelLikesTitle
            // 
            labelLikesTitle.AutoSize = true;
            labelLikesTitle.Location = new System.Drawing.Point(41, 19);
            labelLikesTitle.Name = "labelLikesTitle";
            labelLikesTitle.Size = new System.Drawing.Size(35, 13);
            labelLikesTitle.TabIndex = 13;
            labelLikesTitle.Text = "Likes:";
            // 
            // labelLikeCounter
            // 
            this.labelLikeCounter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLikeCounter.AutoSize = true;
            this.labelLikeCounter.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLikeCounter.Location = new System.Drawing.Point(74, 19);
            this.labelLikeCounter.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelLikeCounter.Name = "labelLikeCounter";
            this.labelLikeCounter.Size = new System.Drawing.Size(83, 13);
            this.labelLikeCounter.TabIndex = 4;
            this.labelLikeCounter.Text = "[Likes Counter]";
            this.labelLikeCounter.Visible = false;
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBoxPosts.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 17;
            this.listBoxPosts.Location = new System.Drawing.Point(33, 3);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(500, 174);
            this.listBoxPosts.TabIndex = 8;
            this.listBoxPosts.SelectedIndexChanged += new System.EventHandler(this.listBoxPosts_SelectedIndexChanged);
            // 
            // labelPostTitile
            // 
            this.labelPostTitile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPostTitile.AutoSize = true;
            this.labelPostTitile.Font = new System.Drawing.Font("Aharoni", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPostTitile.ForeColor = System.Drawing.Color.Teal;
            this.labelPostTitile.Location = new System.Drawing.Point(-233, -112);
            this.labelPostTitile.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelPostTitile.Name = "labelPostTitile";
            this.labelPostTitile.Size = new System.Drawing.Size(204, 14);
            this.labelPostTitile.TabIndex = 10;
            this.labelPostTitile.Text = "Select a post for more details";
            // 
            // labelCommentsTitle
            // 
            this.labelCommentsTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCommentsTitle.AutoSize = true;
            this.labelCommentsTitle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCommentsTitle.Location = new System.Drawing.Point(45, 127);
            this.labelCommentsTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelCommentsTitle.Name = "labelCommentsTitle";
            this.labelCommentsTitle.Size = new System.Drawing.Size(64, 13);
            this.labelCommentsTitle.TabIndex = 11;
            this.labelCommentsTitle.Text = "Comments:";
            // 
            // pictureBoxComments
            // 
            this.pictureBoxComments.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxComments.Image = global::BasicFacebookFeatures.Properties.Resources.IconComments;
            this.pictureBoxComments.Location = new System.Drawing.Point(12, 127);
            this.pictureBoxComments.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.pictureBoxComments.Name = "pictureBoxComments";
            this.pictureBoxComments.Size = new System.Drawing.Size(29, 24);
            this.pictureBoxComments.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxComments.TabIndex = 12;
            this.pictureBoxComments.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::BasicFacebookFeatures.Properties.Resources.IconLike;
            this.pictureBox1.Location = new System.Drawing.Point(12, 19);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxLocationIcon
            // 
            this.pictureBoxLocationIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxLocationIcon.Image = global::BasicFacebookFeatures.Properties.Resources.IconLocation;
            this.pictureBoxLocationIcon.Location = new System.Drawing.Point(12, 49);
            this.pictureBoxLocationIcon.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.pictureBoxLocationIcon.Name = "pictureBoxLocationIcon";
            this.pictureBoxLocationIcon.Size = new System.Drawing.Size(30, 22);
            this.pictureBoxLocationIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLocationIcon.TabIndex = 6;
            this.pictureBoxLocationIcon.TabStop = false;
            // 
            // pictureBoxPostPicture
            // 
            this.pictureBoxPostPicture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxPostPicture.InitialImage = null;
            this.pictureBoxPostPicture.Location = new System.Drawing.Point(557, 3);
            this.pictureBoxPostPicture.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.pictureBoxPostPicture.Name = "pictureBoxPostPicture";
            this.pictureBoxPostPicture.Size = new System.Drawing.Size(202, 174);
            this.pictureBoxPostPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPostPicture.TabIndex = 2;
            this.pictureBoxPostPicture.TabStop = false;
            // 
            // labelWhatsOnYourMind
            // 
            this.labelWhatsOnYourMind.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelWhatsOnYourMind.AutoSize = true;
            this.labelWhatsOnYourMind.Font = new System.Drawing.Font("Aharoni", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWhatsOnYourMind.ForeColor = System.Drawing.Color.Teal;
            this.labelWhatsOnYourMind.Location = new System.Drawing.Point(48, 80);
            this.labelWhatsOnYourMind.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelWhatsOnYourMind.Name = "labelWhatsOnYourMind";
            this.labelWhatsOnYourMind.Size = new System.Drawing.Size(153, 14);
            this.labelWhatsOnYourMind.TabIndex = 13;
            this.labelWhatsOnYourMind.Text = "What\'s on your mind?";
            // 
            // richTextBoxNewPost
            // 
            this.richTextBoxNewPost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.richTextBoxNewPost.Location = new System.Drawing.Point(51, 97);
            this.richTextBoxNewPost.Name = "richTextBoxNewPost";
            this.richTextBoxNewPost.Size = new System.Drawing.Size(497, 44);
            this.richTextBoxNewPost.TabIndex = 15;
            this.richTextBoxNewPost.Text = "";
            // 
            // buttonPostNewPost
            // 
            this.buttonPostNewPost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPostNewPost.BackColor = System.Drawing.Color.Teal;
            this.buttonPostNewPost.FlatAppearance.BorderSize = 0;
            this.buttonPostNewPost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPostNewPost.Font = new System.Drawing.Font("Aharoni", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPostNewPost.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonPostNewPost.Location = new System.Drawing.Point(572, 97);
            this.buttonPostNewPost.Name = "buttonPostNewPost";
            this.buttonPostNewPost.Size = new System.Drawing.Size(62, 44);
            this.buttonPostNewPost.TabIndex = 16;
            this.buttonPostNewPost.Text = "Post!";
            this.buttonPostNewPost.UseVisualStyleBackColor = false;
            this.buttonPostNewPost.Click += new System.EventHandler(this.buttonPostNewPost_Click);
            // 
            // panelMyPosts
            // 
            this.panelMyPosts.Controls.Add(this.buttonShowMyPosts);
            this.panelMyPosts.Controls.Add(this.buttonPostNewPost);
            this.panelMyPosts.Controls.Add(this.loadingAnimation);
            this.panelMyPosts.Controls.Add(this.richTextBoxNewPost);
            this.panelMyPosts.Controls.Add(this.panelPostDetails);
            this.panelMyPosts.Controls.Add(this.labelWhatsOnYourMind);
            this.panelMyPosts.Controls.Add(this.panelQuickView);
            this.panelMyPosts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMyPosts.Location = new System.Drawing.Point(0, 0);
            this.panelMyPosts.Name = "panelMyPosts";
            this.panelMyPosts.Size = new System.Drawing.Size(852, 595);
            this.panelMyPosts.TabIndex = 17;
            // 
            // buttonShowMyPosts
            // 
            this.buttonShowMyPosts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonShowMyPosts.BackColor = System.Drawing.Color.LightSeaGreen;
            this.buttonShowMyPosts.FlatAppearance.BorderSize = 0;
            this.buttonShowMyPosts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowMyPosts.Font = new System.Drawing.Font("Aharoni", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowMyPosts.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonShowMyPosts.Location = new System.Drawing.Point(283, 31);
            this.buttonShowMyPosts.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.buttonShowMyPosts.Name = "buttonShowMyPosts";
            this.buttonShowMyPosts.Size = new System.Drawing.Size(265, 38);
            this.buttonShowMyPosts.TabIndex = 22;
            this.buttonShowMyPosts.Text = "Show My Posts";
            this.buttonShowMyPosts.UseVisualStyleBackColor = false;
            this.buttonShowMyPosts.Click += new System.EventHandler(this.buttonShowMyPosts_Click);
            // 
            // loadingAnimation
            // 
            this.loadingAnimation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loadingAnimation.BackColor = System.Drawing.Color.Teal;
            this.loadingAnimation.Location = new System.Drawing.Point(339, 276);
            this.loadingAnimation.Margin = new System.Windows.Forms.Padding(5);
            this.loadingAnimation.Name = "loadingAnimation";
            this.loadingAnimation.Size = new System.Drawing.Size(173, 94);
            this.loadingAnimation.TabIndex = 17;
            this.loadingAnimation.Visible = false;
            // 
            // panelPostDetails
            // 
            this.panelPostDetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelPostDetails.Controls.Add(this.pictureBox2);
            this.panelPostDetails.Controls.Add(labelLikesTitle);
            this.panelPostDetails.Controls.Add(this.commentsListBox);
            this.panelPostDetails.Controls.Add(this.pictureBoxComments);
            this.panelPostDetails.Controls.Add(labelPlaceTitle);
            this.panelPostDetails.Controls.Add(this.labelPlace);
            this.panelPostDetails.Controls.Add(this.labelCommentsTitle);
            this.panelPostDetails.Controls.Add(labelCreatedTimeTitle);
            this.panelPostDetails.Controls.Add(this.createdTimeDateTimePicker);
            this.panelPostDetails.Controls.Add(this.pictureBoxLocationIcon);
            this.panelPostDetails.Controls.Add(this.pictureBox1);
            this.panelPostDetails.Controls.Add(this.labelLikeCounter);
            this.panelPostDetails.Location = new System.Drawing.Point(3, 352);
            this.panelPostDetails.Name = "panelPostDetails";
            this.panelPostDetails.Size = new System.Drawing.Size(846, 231);
            this.panelPostDetails.TabIndex = 10;
            this.panelPostDetails.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::BasicFacebookFeatures.Properties.Resources.IconCalendar;
            this.pictureBox2.Location = new System.Drawing.Point(12, 78);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // commentsListBox
            // 
            this.commentsListBox.DataSource = this.commentsBindingSource;
            this.commentsListBox.DisplayMember = "Message";
            this.commentsListBox.FormattingEnabled = true;
            this.commentsListBox.Location = new System.Drawing.Point(121, 150);
            this.commentsListBox.Name = "commentsListBox";
            this.commentsListBox.Size = new System.Drawing.Size(653, 69);
            this.commentsListBox.TabIndex = 12;
            this.commentsListBox.ValueMember = "Comments";
            // 
            // commentsBindingSource
            // 
            this.commentsBindingSource.DataMember = "Comments";
            this.commentsBindingSource.DataSource = this.postBindingSource;
            // 
            // postBindingSource
            // 
            this.postBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Post);
            // 
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postBindingSource, "Place.Name", true, System.Windows.Forms.DataSourceUpdateMode.Never, "No Place"));
            this.labelPlace.Location = new System.Drawing.Point(87, 58);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(39, 13);
            this.labelPlace.TabIndex = 8;
            this.labelPlace.Text = "[Place]";
            // 
            // createdTimeDateTimePicker
            // 
            this.createdTimeDateTimePicker.CalendarTrailingForeColor = System.Drawing.Color.RosyBrown;
            this.createdTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.postBindingSource, "CreatedTime", true, System.Windows.Forms.DataSourceUpdateMode.Never, null, "D"));
            this.createdTimeDateTimePicker.Location = new System.Drawing.Point(121, 78);
            this.createdTimeDateTimePicker.Name = "createdTimeDateTimePicker";
            this.createdTimeDateTimePicker.Size = new System.Drawing.Size(292, 22);
            this.createdTimeDateTimePicker.TabIndex = 7;
            // 
            // panelQuickView
            // 
            this.panelQuickView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelQuickView.Controls.Add(this.labelPostTitile);
            this.panelQuickView.Controls.Add(this.pictureBoxPostPicture);
            this.panelQuickView.Controls.Add(this.listBoxPosts);
            this.panelQuickView.Location = new System.Drawing.Point(15, 147);
            this.panelQuickView.Name = "panelQuickView";
            this.panelQuickView.Size = new System.Drawing.Size(812, 187);
            this.panelQuickView.TabIndex = 18;
            this.panelQuickView.Visible = false;
            // 
            // FormMyPosts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(852, 595);
            this.Controls.Add(this.panelMyPosts);
            this.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "FormMyPosts";
            this.Text = "My Posts";
            this.Load += new System.EventHandler(this.FormMyPosts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxComments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLocationIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPostPicture)).EndInit();
            this.panelMyPosts.ResumeLayout(false);
            this.panelMyPosts.PerformLayout();
            this.panelPostDetails.ResumeLayout(false);
            this.panelPostDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
            this.panelQuickView.ResumeLayout(false);
            this.panelQuickView.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxPostPicture;
        private System.Windows.Forms.Label labelLikeCounter;
        private System.Windows.Forms.PictureBox pictureBoxLocationIcon;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelPostTitile;
        private System.Windows.Forms.Label labelCommentsTitle;
        private System.Windows.Forms.PictureBox pictureBoxComments;
        private System.Windows.Forms.Label labelWhatsOnYourMind;
        private System.Windows.Forms.RichTextBox richTextBoxNewPost;
        private System.Windows.Forms.Button buttonPostNewPost;
        private System.Windows.Forms.Panel panelMyPosts;
        private System.Windows.Forms.Panel panelPostDetails;
        private System.Windows.Forms.BindingSource postBindingSource;
        private System.Windows.Forms.ListBox commentsListBox;
        private System.Windows.Forms.BindingSource commentsBindingSource;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.DateTimePicker createdTimeDateTimePicker;
        private System.Windows.Forms.PictureBox pictureBox2;
        private LoadingAnimation loadingAnimation;
        private System.Windows.Forms.Panel panelQuickView;
        private System.Windows.Forms.Button buttonShowMyPosts;
    }
}