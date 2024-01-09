namespace BasicFacebookFeatures
{
    partial class FormPostTips
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartLikesOnPostsPerHour = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.listViewBirthdays = new System.Windows.Forms.ListView();
            this.UserName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Birthday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewBestFriends = new System.Windows.Forms.ListView();
            this.UserNameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NumLikesCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lableBirthdayTitle = new System.Windows.Forms.Label();
            this.labelSortedPostsTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelBestFriend = new System.Windows.Forms.Label();
            this.labelPostByHourTip = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listViewMostLikedPosts = new System.Windows.Forms.ListView();
            this.postMessage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LikesCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelMostLikedPost = new System.Windows.Forms.Label();
            this.labelTitleMessage = new System.Windows.Forms.Label();
            this.loadingAnimation = new BasicFacebookFeatures.LoadingAnimation();
            ((System.ComponentModel.ISupportInitialize)(this.chartLikesOnPostsPerHour)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartLikesOnPostsPerHour
            // 
            this.chartLikesOnPostsPerHour.Anchor = System.Windows.Forms.AnchorStyles.None;
            chartArea1.Name = "ChartArea1";
            this.chartLikesOnPostsPerHour.ChartAreas.Add(chartArea1);
            this.chartLikesOnPostsPerHour.Cursor = System.Windows.Forms.Cursors.Arrow;
            legend1.Name = "Legend1";
            this.chartLikesOnPostsPerHour.Legends.Add(legend1);
            this.chartLikesOnPostsPerHour.Location = new System.Drawing.Point(33, 105);
            this.chartLikesOnPostsPerHour.Margin = new System.Windows.Forms.Padding(6);
            this.chartLikesOnPostsPerHour.Name = "chartLikesOnPostsPerHour";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Likes";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chartLikesOnPostsPerHour.Series.Add(series1);
            this.chartLikesOnPostsPerHour.Size = new System.Drawing.Size(678, 882);
            this.chartLikesOnPostsPerHour.TabIndex = 1;
            this.chartLikesOnPostsPerHour.Text = "Post Times Vs Likes";
            title1.Name = "chartTitleLikesPerHourRange";
            title1.Text = "Likes Per Hour Range";
            this.chartLikesOnPostsPerHour.Titles.Add(title1);
            // 
            // listViewBirthdays
            // 
            this.listViewBirthdays.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listViewBirthdays.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.UserName,
            this.Birthday});
            this.listViewBirthdays.HideSelection = false;
            this.listViewBirthdays.Location = new System.Drawing.Point(915, 136);
            this.listViewBirthdays.Margin = new System.Windows.Forms.Padding(6);
            this.listViewBirthdays.Name = "listViewBirthdays";
            this.listViewBirthdays.Size = new System.Drawing.Size(876, 310);
            this.listViewBirthdays.TabIndex = 2;
            this.listViewBirthdays.UseCompatibleStateImageBehavior = false;
            this.listViewBirthdays.View = System.Windows.Forms.View.Details;
            // 
            // UserName
            // 
            this.UserName.Text = "Name";
            this.UserName.Width = 100;
            // 
            // Birthday
            // 
            this.Birthday.Text = "Birthday";
            this.Birthday.Width = 2000;
            // 
            // listViewBestFriends
            // 
            this.listViewBestFriends.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listViewBestFriends.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.UserNameCol,
            this.NumLikesCol});
            this.listViewBestFriends.HideSelection = false;
            this.listViewBestFriends.Location = new System.Drawing.Point(915, 935);
            this.listViewBestFriends.Margin = new System.Windows.Forms.Padding(6);
            this.listViewBestFriends.Name = "listViewBestFriends";
            this.listViewBestFriends.Size = new System.Drawing.Size(876, 252);
            this.listViewBestFriends.TabIndex = 5;
            this.listViewBestFriends.UseCompatibleStateImageBehavior = false;
            this.listViewBestFriends.View = System.Windows.Forms.View.Details;
            // 
            // UserNameCol
            // 
            this.UserNameCol.Text = "Name";
            this.UserNameCol.Width = 335;
            // 
            // NumLikesCol
            // 
            this.NumLikesCol.Text = "#Likes";
            this.NumLikesCol.Width = 2000;
            // 
            // lableBirthdayTitle
            // 
            this.lableBirthdayTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lableBirthdayTitle.AutoSize = true;
            this.lableBirthdayTitle.Font = new System.Drawing.Font("Aharoni", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableBirthdayTitle.ForeColor = System.Drawing.Color.Teal;
            this.lableBirthdayTitle.Location = new System.Drawing.Point(959, 105);
            this.lableBirthdayTitle.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.lableBirthdayTitle.Name = "lableBirthdayTitle";
            this.lableBirthdayTitle.Size = new System.Drawing.Size(705, 27);
            this.lableBirthdayTitle.TabIndex = 14;
            this.lableBirthdayTitle.Text = "Friends Who Have Birthday at the Same Month As You";
            // 
            // labelSortedPostsTitle
            // 
            this.labelSortedPostsTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSortedPostsTitle.AutoSize = true;
            this.labelSortedPostsTitle.Font = new System.Drawing.Font("Aharoni", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSortedPostsTitle.ForeColor = System.Drawing.Color.Teal;
            this.labelSortedPostsTitle.Location = new System.Drawing.Point(959, 465);
            this.labelSortedPostsTitle.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.labelSortedPostsTitle.Name = "labelSortedPostsTitle";
            this.labelSortedPostsTitle.Size = new System.Drawing.Size(350, 27);
            this.labelSortedPostsTitle.TabIndex = 15;
            this.labelSortedPostsTitle.Text = "Posts Sorted by Most Likes";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Aharoni", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(959, 902);
            this.label1.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(532, 27);
            this.label1.TabIndex = 16;
            this.label1.Text = "How Much Your Friends Liked Your Posts";
            // 
            // labelBestFriend
            // 
            this.labelBestFriend.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelBestFriend.AutoSize = true;
            this.labelBestFriend.Font = new System.Drawing.Font("Aharoni", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBestFriend.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.labelBestFriend.Location = new System.Drawing.Point(959, 1196);
            this.labelBestFriend.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.labelBestFriend.Name = "labelBestFriend";
            this.labelBestFriend.Size = new System.Drawing.Size(363, 27);
            this.labelBestFriend.TabIndex = 17;
            this.labelBestFriend.Text = "Cannot retreive best friends";
            // 
            // labelPostByHourTip
            // 
            this.labelPostByHourTip.AutoSize = true;
            this.labelPostByHourTip.Font = new System.Drawing.Font("Aharoni", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPostByHourTip.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.labelPostByHourTip.Location = new System.Drawing.Point(12, 49);
            this.labelPostByHourTip.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.labelPostByHourTip.Name = "labelPostByHourTip";
            this.labelPostByHourTip.Size = new System.Drawing.Size(577, 27);
            this.labelPostByHourTip.TabIndex = 18;
            this.labelPostByHourTip.Text = "Cannot retrieve likes by hour range statistics";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.labelPostByHourTip);
            this.panel1.Location = new System.Drawing.Point(33, 1031);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(678, 192);
            this.panel1.TabIndex = 19;
            // 
            // listViewMostLikedPosts
            // 
            this.listViewMostLikedPosts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listViewMostLikedPosts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.postMessage,
            this.LikesCount});
            this.listViewMostLikedPosts.HideSelection = false;
            this.listViewMostLikedPosts.Location = new System.Drawing.Point(924, 498);
            this.listViewMostLikedPosts.Margin = new System.Windows.Forms.Padding(6);
            this.listViewMostLikedPosts.Name = "listViewMostLikedPosts";
            this.listViewMostLikedPosts.Size = new System.Drawing.Size(876, 310);
            this.listViewMostLikedPosts.TabIndex = 21;
            this.listViewMostLikedPosts.UseCompatibleStateImageBehavior = false;
            this.listViewMostLikedPosts.View = System.Windows.Forms.View.Details;
            // 
            // postMessage
            // 
            this.postMessage.DisplayIndex = 1;
            this.postMessage.Text = "Post Message";
            this.postMessage.Width = 1000;
            // 
            // LikesCount
            // 
            this.LikesCount.DisplayIndex = 0;
            this.LikesCount.Text = "Likes";
            this.LikesCount.Width = 100;
            // 
            // labelMostLikedPost
            // 
            this.labelMostLikedPost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMostLikedPost.AutoSize = true;
            this.labelMostLikedPost.Font = new System.Drawing.Font("Aharoni", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMostLikedPost.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.labelMostLikedPost.Location = new System.Drawing.Point(959, 823);
            this.labelMostLikedPost.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.labelMostLikedPost.Name = "labelMostLikedPost";
            this.labelMostLikedPost.Size = new System.Drawing.Size(422, 27);
            this.labelMostLikedPost.TabIndex = 22;
            this.labelMostLikedPost.Text = "Cannot retreive most liked posts";
            // 
            // labelTitleMessage
            // 
            this.labelTitleMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitleMessage.AutoSize = true;
            this.labelTitleMessage.Font = new System.Drawing.Font("Aharoni", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleMessage.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.labelTitleMessage.Location = new System.Drawing.Point(791, 44);
            this.labelTitleMessage.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.labelTitleMessage.Name = "labelTitleMessage";
            this.labelTitleMessage.Size = new System.Drawing.Size(141, 27);
            this.labelTitleMessage.TabIndex = 23;
            this.labelTitleMessage.Text = "[Message]";
            // 
            // loadingAnimation
            // 
            this.loadingAnimation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loadingAnimation.BackColor = System.Drawing.Color.PowderBlue;
            this.loadingAnimation.Location = new System.Drawing.Point(649, 386);
            this.loadingAnimation.Margin = new System.Windows.Forms.Padding(2);
            this.loadingAnimation.Name = "loadingAnimation";
            this.loadingAnimation.Size = new System.Drawing.Size(344, 181);
            this.loadingAnimation.TabIndex = 20;
            // 
            // FormPostTips
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1858, 1264);
            this.Controls.Add(this.labelTitleMessage);
            this.Controls.Add(this.loadingAnimation);
            this.Controls.Add(this.labelMostLikedPost);
            this.Controls.Add(this.listViewMostLikedPosts);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelBestFriend);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelSortedPostsTitle);
            this.Controls.Add(this.lableBirthdayTitle);
            this.Controls.Add(this.listViewBestFriends);
            this.Controls.Add(this.listViewBirthdays);
            this.Controls.Add(this.chartLikesOnPostsPerHour);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormPostTips";
            this.Text = "FormPostTips";
            this.Load += new System.EventHandler(this.formPostTips_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartLikesOnPostsPerHour)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chartLikesOnPostsPerHour;
        private System.Windows.Forms.ListView listViewBirthdays;
        private System.Windows.Forms.ColumnHeader UserName;
        private System.Windows.Forms.ColumnHeader Birthday;
        private System.Windows.Forms.ListView listViewBestFriends;
        private System.Windows.Forms.ColumnHeader UserNameCol;
        private System.Windows.Forms.ColumnHeader NumLikesCol;
        private System.Windows.Forms.Label lableBirthdayTitle;
        private System.Windows.Forms.Label labelSortedPostsTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelBestFriend;
        private System.Windows.Forms.Label labelPostByHourTip;
        private System.Windows.Forms.Panel panel1;
        private LoadingAnimation loadingAnimation;
        private System.Windows.Forms.ListView listViewMostLikedPosts;
        private System.Windows.Forms.ColumnHeader LikesCount;
        private System.Windows.Forms.ColumnHeader postMessage;
        private System.Windows.Forms.Label labelMostLikedPost;
        private System.Windows.Forms.Label labelTitleMessage;
    }
}