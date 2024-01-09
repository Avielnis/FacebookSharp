namespace BasicFacebookFeatures
{
    partial class FormMyFriends
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
            System.Windows.Forms.Label birthdayLabelTitle;
            System.Windows.Forms.Label emailLabelTitle;
            System.Windows.Forms.Label nameLabelTitle;
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.pictureBoxFriendPicture = new System.Windows.Forms.PictureBox();
            this.panelFriendDetails = new System.Windows.Forms.Panel();
            this.emailLabel = new System.Windows.Forms.Label();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.birthdayLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.buttonShowMyFriends = new System.Windows.Forms.Button();
            birthdayLabelTitle = new System.Windows.Forms.Label();
            emailLabelTitle = new System.Windows.Forms.Label();
            nameLabelTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendPicture)).BeginInit();
            this.panelFriendDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // birthdayLabelTitle
            // 
            birthdayLabelTitle.AutoSize = true;
            birthdayLabelTitle.Font = new System.Drawing.Font("Aharoni", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            birthdayLabelTitle.ForeColor = System.Drawing.Color.LightSeaGreen;
            birthdayLabelTitle.Location = new System.Drawing.Point(12, 80);
            birthdayLabelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            birthdayLabelTitle.Name = "birthdayLabelTitle";
            birthdayLabelTitle.Size = new System.Drawing.Size(144, 30);
            birthdayLabelTitle.TabIndex = 0;
            birthdayLabelTitle.Text = "Birthday:";
            // 
            // emailLabelTitle
            // 
            emailLabelTitle.AutoSize = true;
            emailLabelTitle.Font = new System.Drawing.Font("Aharoni", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailLabelTitle.ForeColor = System.Drawing.Color.LightSeaGreen;
            emailLabelTitle.Location = new System.Drawing.Point(12, 135);
            emailLabelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            emailLabelTitle.Name = "emailLabelTitle";
            emailLabelTitle.Size = new System.Drawing.Size(97, 30);
            emailLabelTitle.TabIndex = 2;
            emailLabelTitle.Text = "Email:";
            // 
            // nameLabelTitle
            // 
            nameLabelTitle.AutoSize = true;
            nameLabelTitle.Font = new System.Drawing.Font("Aharoni", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameLabelTitle.ForeColor = System.Drawing.Color.LightSeaGreen;
            nameLabelTitle.Location = new System.Drawing.Point(12, 25);
            nameLabelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nameLabelTitle.Name = "nameLabelTitle";
            nameLabelTitle.Size = new System.Drawing.Size(107, 30);
            nameLabelTitle.TabIndex = 6;
            nameLabelTitle.Text = "Name:";
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBoxFriends.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 37;
            this.listBoxFriends.Location = new System.Drawing.Point(28, 130);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(495, 337);
            this.listBoxFriends.TabIndex = 9;
            this.listBoxFriends.SelectedIndexChanged += new System.EventHandler(this.listBoxFriends_SelectedIndexChanged);
            // 
            // pictureBoxFriendPicture
            // 
            this.pictureBoxFriendPicture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxFriendPicture.InitialImage = null;
            this.pictureBoxFriendPicture.Location = new System.Drawing.Point(550, 130);
            this.pictureBoxFriendPicture.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.pictureBoxFriendPicture.Name = "pictureBoxFriendPicture";
            this.pictureBoxFriendPicture.Size = new System.Drawing.Size(348, 368);
            this.pictureBoxFriendPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFriendPicture.TabIndex = 12;
            this.pictureBoxFriendPicture.TabStop = false;
            // 
            // panelFriendDetails
            // 
            this.panelFriendDetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelFriendDetails.Controls.Add(this.emailLabel);
            this.panelFriendDetails.Controls.Add(birthdayLabelTitle);
            this.panelFriendDetails.Controls.Add(this.birthdayLabel);
            this.panelFriendDetails.Controls.Add(emailLabelTitle);
            this.panelFriendDetails.Controls.Add(nameLabelTitle);
            this.panelFriendDetails.Controls.Add(this.nameLabel);
            this.panelFriendDetails.Location = new System.Drawing.Point(28, 526);
            this.panelFriendDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelFriendDetails.Name = "panelFriendDetails";
            this.panelFriendDetails.Size = new System.Drawing.Size(872, 265);
            this.panelFriendDetails.TabIndex = 17;
            this.panelFriendDetails.Visible = false;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Email", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.emailLabel.Font = new System.Drawing.Font("Aharoni", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.Color.Teal;
            this.emailLabel.Location = new System.Drawing.Point(173, 137);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(96, 27);
            this.emailLabel.TabIndex = 8;
            this.emailLabel.Text = "[Email]";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // birthdayLabel
            // 
            this.birthdayLabel.AutoSize = true;
            this.birthdayLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Birthday", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.birthdayLabel.Font = new System.Drawing.Font("Aharoni", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdayLabel.ForeColor = System.Drawing.Color.Teal;
            this.birthdayLabel.Location = new System.Drawing.Point(173, 82);
            this.birthdayLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.birthdayLabel.Name = "birthdayLabel";
            this.birthdayLabel.Size = new System.Drawing.Size(138, 27);
            this.birthdayLabel.TabIndex = 1;
            this.birthdayLabel.Text = "[Birthday]";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.nameLabel.Font = new System.Drawing.Font("Aharoni", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.Teal;
            this.nameLabel.Location = new System.Drawing.Point(173, 28);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(106, 27);
            this.nameLabel.TabIndex = 7;
            this.nameLabel.Text = "[Name]";
            // 
            // buttonShowMyFriends
            // 
            this.buttonShowMyFriends.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonShowMyFriends.BackColor = System.Drawing.Color.LightSeaGreen;
            this.buttonShowMyFriends.FlatAppearance.BorderSize = 0;
            this.buttonShowMyFriends.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowMyFriends.Font = new System.Drawing.Font("Aharoni", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowMyFriends.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonShowMyFriends.Location = new System.Drawing.Point(28, 55);
            this.buttonShowMyFriends.Name = "buttonShowMyFriends";
            this.buttonShowMyFriends.Size = new System.Drawing.Size(494, 54);
            this.buttonShowMyFriends.TabIndex = 21;
            this.buttonShowMyFriends.Text = "Show My Friends";
            this.buttonShowMyFriends.UseVisualStyleBackColor = false;
            this.buttonShowMyFriends.Click += new System.EventHandler(this.buttonShowMyFriends_Click);
            // 
            // FormMyFriends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 820);
            this.Controls.Add(this.buttonShowMyFriends);
            this.Controls.Add(this.panelFriendDetails);
            this.Controls.Add(this.pictureBoxFriendPicture);
            this.Controls.Add(this.listBoxFriends);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FormMyFriends";
            this.Text = "My Friends";
            this.Load += new System.EventHandler(this.formMyFriends_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendPicture)).EndInit();
            this.panelFriendDetails.ResumeLayout(false);
            this.panelFriendDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.PictureBox pictureBoxFriendPicture;
        private System.Windows.Forms.Panel panelFriendDetails;
        private System.Windows.Forms.Label birthdayLabel;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Button buttonShowMyFriends;
    }
}