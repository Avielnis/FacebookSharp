namespace BasicFacebookFeatures
{
    partial class FormGeoChallenge
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
            this.labelMessageToUser = new System.Windows.Forms.Label();
            this.buttonNextQuestion = new System.Windows.Forms.Button();
            this.listBoxPlacesOptions = new System.Windows.Forms.ListBox();
            this.buttonCheckAnswer = new System.Windows.Forms.Button();
            this.labelPointsTitle = new System.Windows.Forms.Label();
            this.labelBar = new System.Windows.Forms.Label();
            this.labelUserPoints = new System.Windows.Forms.Label();
            this.buttonStartGame = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelGameStatusDisplay = new System.Windows.Forms.Panel();
            this.labelRoundNumberTitle = new System.Windows.Forms.Label();
            this.labelQuestionsAnsweredTitle = new System.Windows.Forms.Label();
            this.labelRoundNumber = new System.Windows.Forms.Label();
            this.labelScoreTitle = new System.Windows.Forms.Label();
            this.labelQuestionsAnswered = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.buttonReload = new System.Windows.Forms.Button();
            this.pictureBoxGeoChallenge = new System.Windows.Forms.PictureBox();
            this.panelTitles = new System.Windows.Forms.Panel();
            this.panelPointsStatus = new System.Windows.Forms.Panel();
            this.loadingAnimation = new BasicFacebookFeatures.LoadingAnimation();
            this.panelContent.SuspendLayout();
            this.panelGameStatusDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGeoChallenge)).BeginInit();
            this.panelTitles.SuspendLayout();
            this.panelPointsStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelMessageToUser
            // 
            this.labelMessageToUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelMessageToUser.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessageToUser.Location = new System.Drawing.Point(0, 0);
            this.labelMessageToUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMessageToUser.Name = "labelMessageToUser";
            this.labelMessageToUser.Padding = new System.Windows.Forms.Padding(68, 17, 68, 17);
            this.labelMessageToUser.Size = new System.Drawing.Size(1467, 156);
            this.labelMessageToUser.TabIndex = 0;
            this.labelMessageToUser.Text = "[Message]";
            this.labelMessageToUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMessageToUser.Visible = false;
            // 
            // buttonNextQuestion
            // 
            this.buttonNextQuestion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonNextQuestion.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonNextQuestion.FlatAppearance.BorderSize = 0;
            this.buttonNextQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNextQuestion.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNextQuestion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonNextQuestion.Location = new System.Drawing.Point(809, 162);
            this.buttonNextQuestion.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonNextQuestion.Name = "buttonNextQuestion";
            this.buttonNextQuestion.Size = new System.Drawing.Size(148, 85);
            this.buttonNextQuestion.TabIndex = 2;
            this.buttonNextQuestion.Text = "Next Question";
            this.buttonNextQuestion.UseVisualStyleBackColor = false;
            this.buttonNextQuestion.Visible = false;
            this.buttonNextQuestion.Click += new System.EventHandler(this.buttonNextQuestion_Click);
            // 
            // listBoxPlacesOptions
            // 
            this.listBoxPlacesOptions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBoxPlacesOptions.BackColor = System.Drawing.Color.Lavender;
            this.listBoxPlacesOptions.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPlacesOptions.FormattingEnabled = true;
            this.listBoxPlacesOptions.ItemHeight = 30;
            this.listBoxPlacesOptions.Location = new System.Drawing.Point(809, 272);
            this.listBoxPlacesOptions.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.listBoxPlacesOptions.Name = "listBoxPlacesOptions";
            this.listBoxPlacesOptions.Size = new System.Drawing.Size(518, 154);
            this.listBoxPlacesOptions.TabIndex = 4;
            this.listBoxPlacesOptions.Visible = false;
            // 
            // buttonCheckAnswer
            // 
            this.buttonCheckAnswer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCheckAnswer.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonCheckAnswer.Enabled = false;
            this.buttonCheckAnswer.FlatAppearance.BorderSize = 0;
            this.buttonCheckAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCheckAnswer.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheckAnswer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonCheckAnswer.Location = new System.Drawing.Point(973, 162);
            this.buttonCheckAnswer.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonCheckAnswer.Name = "buttonCheckAnswer";
            this.buttonCheckAnswer.Size = new System.Drawing.Size(134, 85);
            this.buttonCheckAnswer.TabIndex = 10;
            this.buttonCheckAnswer.Text = "Check Answer";
            this.buttonCheckAnswer.UseVisualStyleBackColor = false;
            this.buttonCheckAnswer.Visible = false;
            this.buttonCheckAnswer.Click += new System.EventHandler(this.buttonCheckAnswer_Click);
            // 
            // labelPointsTitle
            // 
            this.labelPointsTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPointsTitle.AutoSize = true;
            this.labelPointsTitle.BackColor = System.Drawing.Color.Purple;
            this.labelPointsTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPointsTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.labelPointsTitle.Location = new System.Drawing.Point(632, 14);
            this.labelPointsTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPointsTitle.Name = "labelPointsTitle";
            this.labelPointsTitle.Size = new System.Drawing.Size(186, 37);
            this.labelPointsTitle.TabIndex = 12;
            this.labelPointsTitle.Text = "Points Gained";
            this.labelPointsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPointsTitle.Visible = false;
            // 
            // labelBar
            // 
            this.labelBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBar.BackColor = System.Drawing.Color.Purple;
            this.labelBar.Location = new System.Drawing.Point(-5, 73);
            this.labelBar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBar.Name = "labelBar";
            this.labelBar.Size = new System.Drawing.Size(1467, 10);
            this.labelBar.TabIndex = 15;
            this.labelBar.Visible = false;
            // 
            // labelUserPoints
            // 
            this.labelUserPoints.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelUserPoints.BackColor = System.Drawing.Color.Purple;
            this.labelUserPoints.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserPoints.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelUserPoints.Location = new System.Drawing.Point(600, 14);
            this.labelUserPoints.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUserPoints.Name = "labelUserPoints";
            this.labelUserPoints.Padding = new System.Windows.Forms.Padding(26, 25, 26, 25);
            this.labelUserPoints.Size = new System.Drawing.Size(245, 101);
            this.labelUserPoints.TabIndex = 11;
            this.labelUserPoints.Text = "[Points]";
            this.labelUserPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelUserPoints.Visible = false;
            // 
            // buttonStartGame
            // 
            this.buttonStartGame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonStartGame.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonStartGame.FlatAppearance.BorderSize = 0;
            this.buttonStartGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStartGame.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStartGame.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonStartGame.Location = new System.Drawing.Point(639, 147);
            this.buttonStartGame.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonStartGame.Name = "buttonStartGame";
            this.buttonStartGame.Size = new System.Drawing.Size(148, 85);
            this.buttonStartGame.TabIndex = 17;
            this.buttonStartGame.Text = "Start Game";
            this.buttonStartGame.UseVisualStyleBackColor = false;
            this.buttonStartGame.Visible = false;
            this.buttonStartGame.Click += new System.EventHandler(this.buttonStartGame_Click);
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.panelGameStatusDisplay);
            this.panelContent.Controls.Add(this.buttonReload);
            this.panelContent.Controls.Add(this.pictureBoxGeoChallenge);
            this.panelContent.Controls.Add(this.listBoxPlacesOptions);
            this.panelContent.Controls.Add(this.buttonCheckAnswer);
            this.panelContent.Controls.Add(this.buttonNextQuestion);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 371);
            this.panelContent.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1467, 779);
            this.panelContent.TabIndex = 17;
            // 
            // panelGameStatusDisplay
            // 
            this.panelGameStatusDisplay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelGameStatusDisplay.Controls.Add(this.labelRoundNumberTitle);
            this.panelGameStatusDisplay.Controls.Add(this.labelQuestionsAnsweredTitle);
            this.panelGameStatusDisplay.Controls.Add(this.labelRoundNumber);
            this.panelGameStatusDisplay.Controls.Add(this.labelScoreTitle);
            this.panelGameStatusDisplay.Controls.Add(this.labelQuestionsAnswered);
            this.panelGameStatusDisplay.Controls.Add(this.labelScore);
            this.panelGameStatusDisplay.Location = new System.Drawing.Point(312, 534);
            this.panelGameStatusDisplay.Name = "panelGameStatusDisplay";
            this.panelGameStatusDisplay.Size = new System.Drawing.Size(858, 134);
            this.panelGameStatusDisplay.TabIndex = 24;
            // 
            // labelRoundNumberTitle
            // 
            this.labelRoundNumberTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelRoundNumberTitle.AutoSize = true;
            this.labelRoundNumberTitle.BackColor = System.Drawing.Color.MediumOrchid;
            this.labelRoundNumberTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoundNumberTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.labelRoundNumberTitle.Location = new System.Drawing.Point(606, 13);
            this.labelRoundNumberTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRoundNumberTitle.Name = "labelRoundNumberTitle";
            this.labelRoundNumberTitle.Size = new System.Drawing.Size(205, 37);
            this.labelRoundNumberTitle.TabIndex = 22;
            this.labelRoundNumberTitle.Text = "Round Number";
            this.labelRoundNumberTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelRoundNumberTitle.Visible = false;
            // 
            // labelQuestionsAnsweredTitle
            // 
            this.labelQuestionsAnsweredTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelQuestionsAnsweredTitle.AutoSize = true;
            this.labelQuestionsAnsweredTitle.BackColor = System.Drawing.Color.MediumOrchid;
            this.labelQuestionsAnsweredTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuestionsAnsweredTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.labelQuestionsAnsweredTitle.Location = new System.Drawing.Point(24, 13);
            this.labelQuestionsAnsweredTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuestionsAnsweredTitle.Name = "labelQuestionsAnsweredTitle";
            this.labelQuestionsAnsweredTitle.Size = new System.Drawing.Size(267, 37);
            this.labelQuestionsAnsweredTitle.TabIndex = 16;
            this.labelQuestionsAnsweredTitle.Text = "Questions Answered";
            this.labelQuestionsAnsweredTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelQuestionsAnsweredTitle.Visible = false;
            // 
            // labelRoundNumber
            // 
            this.labelRoundNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelRoundNumber.BackColor = System.Drawing.Color.MediumOrchid;
            this.labelRoundNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoundNumber.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelRoundNumber.Location = new System.Drawing.Point(573, 13);
            this.labelRoundNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRoundNumber.Name = "labelRoundNumber";
            this.labelRoundNumber.Padding = new System.Windows.Forms.Padding(26, 25, 26, 25);
            this.labelRoundNumber.Size = new System.Drawing.Size(266, 104);
            this.labelRoundNumber.TabIndex = 23;
            this.labelRoundNumber.Text = "[Round Number]";
            this.labelRoundNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelRoundNumber.Visible = false;
            // 
            // labelScoreTitle
            // 
            this.labelScoreTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelScoreTitle.AutoSize = true;
            this.labelScoreTitle.BackColor = System.Drawing.Color.MediumOrchid;
            this.labelScoreTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScoreTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.labelScoreTitle.Location = new System.Drawing.Point(389, 13);
            this.labelScoreTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelScoreTitle.Name = "labelScoreTitle";
            this.labelScoreTitle.Size = new System.Drawing.Size(85, 37);
            this.labelScoreTitle.TabIndex = 20;
            this.labelScoreTitle.Text = "Score";
            this.labelScoreTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelScoreTitle.Visible = false;
            // 
            // labelQuestionsAnswered
            // 
            this.labelQuestionsAnswered.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelQuestionsAnswered.BackColor = System.Drawing.Color.MediumOrchid;
            this.labelQuestionsAnswered.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuestionsAnswered.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelQuestionsAnswered.Location = new System.Drawing.Point(25, 13);
            this.labelQuestionsAnswered.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuestionsAnswered.Name = "labelQuestionsAnswered";
            this.labelQuestionsAnswered.Padding = new System.Windows.Forms.Padding(26, 25, 26, 25);
            this.labelQuestionsAnswered.Size = new System.Drawing.Size(266, 104);
            this.labelQuestionsAnswered.TabIndex = 16;
            this.labelQuestionsAnswered.Text = "[Answered]";
            this.labelQuestionsAnswered.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelQuestionsAnswered.Visible = false;
            // 
            // labelScore
            // 
            this.labelScore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelScore.BackColor = System.Drawing.Color.MediumOrchid;
            this.labelScore.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelScore.Location = new System.Drawing.Point(299, 13);
            this.labelScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelScore.Name = "labelScore";
            this.labelScore.Padding = new System.Windows.Forms.Padding(26, 25, 26, 25);
            this.labelScore.Size = new System.Drawing.Size(266, 104);
            this.labelScore.TabIndex = 21;
            this.labelScore.Text = "[Score]";
            this.labelScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelScore.Visible = false;
            // 
            // buttonReload
            // 
            this.buttonReload.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonReload.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonReload.FlatAppearance.BorderSize = 0;
            this.buttonReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReload.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReload.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonReload.Location = new System.Drawing.Point(670, 673);
            this.buttonReload.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonReload.Name = "buttonReload";
            this.buttonReload.Size = new System.Drawing.Size(148, 85);
            this.buttonReload.TabIndex = 19;
            this.buttonReload.Text = "Reload";
            this.buttonReload.UseVisualStyleBackColor = false;
            this.buttonReload.Visible = false;
            this.buttonReload.Click += new System.EventHandler(this.buttonReload_Click);
            // 
            // pictureBoxGeoChallenge
            // 
            this.pictureBoxGeoChallenge.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxGeoChallenge.Location = new System.Drawing.Point(297, 137);
            this.pictureBoxGeoChallenge.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pictureBoxGeoChallenge.Name = "pictureBoxGeoChallenge";
            this.pictureBoxGeoChallenge.Size = new System.Drawing.Size(398, 377);
            this.pictureBoxGeoChallenge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxGeoChallenge.TabIndex = 3;
            this.pictureBoxGeoChallenge.TabStop = false;
            this.pictureBoxGeoChallenge.Visible = false;
            // 
            // panelTitles
            // 
            this.panelTitles.Controls.Add(this.buttonStartGame);
            this.panelTitles.Controls.Add(this.panelPointsStatus);
            this.panelTitles.Controls.Add(this.loadingAnimation);
            this.panelTitles.Controls.Add(this.labelMessageToUser);
            this.panelTitles.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitles.Location = new System.Drawing.Point(0, 0);
            this.panelTitles.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panelTitles.Name = "panelTitles";
            this.panelTitles.Size = new System.Drawing.Size(1467, 371);
            this.panelTitles.TabIndex = 16;
            // 
            // panelPointsStatus
            // 
            this.panelPointsStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPointsStatus.Controls.Add(this.labelPointsTitle);
            this.panelPointsStatus.Controls.Add(this.labelUserPoints);
            this.panelPointsStatus.Controls.Add(this.labelBar);
            this.panelPointsStatus.Location = new System.Drawing.Point(0, 247);
            this.panelPointsStatus.Name = "panelPointsStatus";
            this.panelPointsStatus.Size = new System.Drawing.Size(1467, 119);
            this.panelPointsStatus.TabIndex = 21;
            // 
            // loadingAnimation
            // 
            this.loadingAnimation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loadingAnimation.BackColor = System.Drawing.Color.BlueViolet;
            this.loadingAnimation.Location = new System.Drawing.Point(554, 51);
            this.loadingAnimation.Name = "loadingAnimation";
            this.loadingAnimation.Size = new System.Drawing.Size(344, 181);
            this.loadingAnimation.TabIndex = 20;
            // 
            // FormGeoChallenge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 1150);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelTitles);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "FormGeoChallenge";
            this.Text = "Geo Challenge";
            this.Load += new System.EventHandler(this.formGeoChallenge_Load);
            this.panelContent.ResumeLayout(false);
            this.panelGameStatusDisplay.ResumeLayout(false);
            this.panelGameStatusDisplay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGeoChallenge)).EndInit();
            this.panelTitles.ResumeLayout(false);
            this.panelPointsStatus.ResumeLayout(false);
            this.panelPointsStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelMessageToUser;
        private System.Windows.Forms.Button buttonNextQuestion;
        private System.Windows.Forms.PictureBox pictureBoxGeoChallenge;
        private System.Windows.Forms.ListBox listBoxPlacesOptions;
        private System.Windows.Forms.Button buttonCheckAnswer;
        private System.Windows.Forms.Label labelPointsTitle;
        private System.Windows.Forms.Label labelBar;
        private System.Windows.Forms.Label labelUserPoints;
        private System.Windows.Forms.Button buttonStartGame;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panelTitles;
        private System.Windows.Forms.Button buttonReload;
        private LoadingAnimation loadingAnimation;
        private System.Windows.Forms.Panel panelPointsStatus;
        private System.Windows.Forms.Label labelQuestionsAnswered;
        private System.Windows.Forms.Label labelQuestionsAnsweredTitle;
        private System.Windows.Forms.Label labelScoreTitle;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelRoundNumberTitle;
        private System.Windows.Forms.Label labelRoundNumber;
        private System.Windows.Forms.Panel panelGameStatusDisplay;
    }
}