namespace BasicFacebookFeatures
{
    partial class FormMyFavorites
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
            this.pictureBoxLikedPage = new System.Windows.Forms.PictureBox();
            this.listBoxLikedPages = new System.Windows.Forms.ListBox();
            this.pictureBoxGroup = new System.Windows.Forms.PictureBox();
            this.listBoxGroups = new System.Windows.Forms.ListBox();
            this.buttonShowLikedPages = new System.Windows.Forms.Button();
            this.buttonShowGroups = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLikedPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGroup)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLikedPage
            // 
            this.pictureBoxLikedPage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxLikedPage.InitialImage = null;
            this.pictureBoxLikedPage.Location = new System.Drawing.Point(185, 543);
            this.pictureBoxLikedPage.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.pictureBoxLikedPage.Name = "pictureBoxLikedPage";
            this.pictureBoxLikedPage.Size = new System.Drawing.Size(364, 348);
            this.pictureBoxLikedPage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLikedPage.TabIndex = 16;
            this.pictureBoxLikedPage.TabStop = false;
            // 
            // listBoxLikedPages
            // 
            this.listBoxLikedPages.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBoxLikedPages.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxLikedPages.FormattingEnabled = true;
            this.listBoxLikedPages.ItemHeight = 37;
            this.listBoxLikedPages.Location = new System.Drawing.Point(134, 142);
            this.listBoxLikedPages.Name = "listBoxLikedPages";
            this.listBoxLikedPages.Size = new System.Drawing.Size(456, 337);
            this.listBoxLikedPages.TabIndex = 15;
            this.listBoxLikedPages.SelectedIndexChanged += new System.EventHandler(this.listBoxLikedPages_SelectedIndexChanged);
            // 
            // pictureBoxGroup
            // 
            this.pictureBoxGroup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxGroup.InitialImage = null;
            this.pictureBoxGroup.Location = new System.Drawing.Point(690, 543);
            this.pictureBoxGroup.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.pictureBoxGroup.Name = "pictureBoxGroup";
            this.pictureBoxGroup.Size = new System.Drawing.Size(364, 348);
            this.pictureBoxGroup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxGroup.TabIndex = 18;
            this.pictureBoxGroup.TabStop = false;
            // 
            // listBoxGroups
            // 
            this.listBoxGroups.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBoxGroups.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxGroups.FormattingEnabled = true;
            this.listBoxGroups.ItemHeight = 37;
            this.listBoxGroups.Location = new System.Drawing.Point(643, 142);
            this.listBoxGroups.Name = "listBoxGroups";
            this.listBoxGroups.Size = new System.Drawing.Size(465, 337);
            this.listBoxGroups.TabIndex = 17;
            this.listBoxGroups.SelectedIndexChanged += new System.EventHandler(this.listBoxGroups_SelectedIndexChanged);
            // 
            // buttonShowLikedPages
            // 
            this.buttonShowLikedPages.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonShowLikedPages.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonShowLikedPages.FlatAppearance.BorderSize = 0;
            this.buttonShowLikedPages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowLikedPages.Font = new System.Drawing.Font("Aharoni", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowLikedPages.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonShowLikedPages.Location = new System.Drawing.Point(134, 62);
            this.buttonShowLikedPages.Name = "buttonShowLikedPages";
            this.buttonShowLikedPages.Size = new System.Drawing.Size(455, 54);
            this.buttonShowLikedPages.TabIndex = 20;
            this.buttonShowLikedPages.Text = "Show My Liked Pages";
            this.buttonShowLikedPages.UseVisualStyleBackColor = false;
            this.buttonShowLikedPages.Click += new System.EventHandler(this.buttonShowLikedPages_Click);
            // 
            // buttonShowGroups
            // 
            this.buttonShowGroups.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonShowGroups.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonShowGroups.FlatAppearance.BorderSize = 0;
            this.buttonShowGroups.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowGroups.Font = new System.Drawing.Font("Aharoni", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowGroups.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonShowGroups.Location = new System.Drawing.Point(643, 62);
            this.buttonShowGroups.Name = "buttonShowGroups";
            this.buttonShowGroups.Size = new System.Drawing.Size(465, 54);
            this.buttonShowGroups.TabIndex = 21;
            this.buttonShowGroups.Text = "Show My Groups";
            this.buttonShowGroups.UseVisualStyleBackColor = false;
            this.buttonShowGroups.Click += new System.EventHandler(this.buttonShowGroups_Click);
            // 
            // FormMyFavorites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 956);
            this.Controls.Add(this.buttonShowGroups);
            this.Controls.Add(this.buttonShowLikedPages);
            this.Controls.Add(this.pictureBoxGroup);
            this.Controls.Add(this.listBoxGroups);
            this.Controls.Add(this.pictureBoxLikedPage);
            this.Controls.Add(this.listBoxLikedPages);
            this.Name = "FormMyFavorites";
            this.Text = "FormMyFavorites";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLikedPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGroup)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxLikedPage;
        private System.Windows.Forms.ListBox listBoxLikedPages;
        private System.Windows.Forms.PictureBox pictureBoxGroup;
        private System.Windows.Forms.ListBox listBoxGroups;
        private System.Windows.Forms.Button buttonShowLikedPages;
        private System.Windows.Forms.Button buttonShowGroups;
    }
}