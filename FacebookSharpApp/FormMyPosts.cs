using System;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class FormMyPosts : Form
    {
        private readonly AppEngine r_AppEngine = AppEngine.Instance;
        private readonly GeoChallengeLogic r_GeoChallengeLogic = AppEngine.Instance.GetFeatureLogicByType<GeoChallengeLogic>();
        private Post m_SelectedPost;

        public FormMyPosts()
        {
            InitializeComponent();
        }

        private void formMyPosts_Load(object sender, EventArgs e)
        {
            r_GeoChallengeLogic.GameInitialized += geoChallengeLogic_GameInitialized;
            r_GeoChallengeLogic.AnswerChecked += geoChallengeLogic_AnswerChecked;
            buttonShowMyPosts.PerformClick();
            updateGeoChallengeShareDetails();
        }

        protected virtual void geoChallengeLogic_GameInitialized()
        {
            panelGeoChallengeShare.Controls.EnableAll();
            updateGeoChallengeShareDetails();
        }

        protected virtual void geoChallengeLogic_AnswerChecked()
        {
            updateGeoChallengeShareDetails();
        }

        private void updateGeoChallengeShareDetails()
        {
            if (r_GeoChallengeLogic.GamesCounter > 0)
            {
                panelGeoChallengeShare.Controls.EnableAll();
            }

            labelPointsCounter.Invoke(new Action(() => labelPointsCounter.Text = string.Format(
                "{0}/{1}",
                r_GeoChallengeLogic.PointsGained.ToString(),
                r_GeoChallengeLogic.MaximumQuestions.ToString())));
            labelScore.Invoke(new Action(() => labelScore.Text = string.Format("{0}%", r_GeoChallengeLogic.ScorePercentage.ToString())));
        }

        private void ftechPosts()
        {
            try
            {
                ListBoxQuickView.PopulateListBox(listBoxPosts, r_AppEngine.LoggedInUser.Posts);
                panelQuickView.Invoke(new Action(() => panelQuickView.Visible = true));
            }
            catch (Exception)
            {
                MessageBox.Show("Can't load Posts");
            }
            finally
            {
                loadingAnimation.Invoke(new Action(() => loadingAnimation.Visible = false));
                buttonShowMyPosts.Invoke(new Action(() => buttonShowMyPosts.Enabled = true));
                buttonShowMyPosts.Invoke(new Action(() => buttonShowMyPosts.Text = "Reload My Posts"));
            }
        }

        private void listBoxPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBoxQuickView.LoadImageOfSelectedItem(sender as ListBox, pictureBoxPostPicture);
            ListBoxQuickView.BindDataOfSelectedItem(sender as ListBox, postBindingSource);
            panelPostDetails.Visible = true;
            if (postBindingSource.Current != null)
            {
                m_SelectedPost = postBindingSource.Current as Post;
                updateLikesCounterOfSelectedPost();
                updateCommentCounterOfSelectedPost();
            }
        }

        private void updateCommentCounterOfSelectedPost()
        {
            labelCommentsTitle.Visible = true;
            try
            {
                if (commentsBindingSource.DataSource != null)
                {
                    labelCommentsTitle.Text = string.Format("You've got {0} comments on this post", commentsBindingSource.Count);
                    commentsListBox.Visible = commentsBindingSource.Count > 0;
                }
                else
                {
                    labelCommentsTitle.Text = "No comments to show :(";
                    commentsListBox.Visible = false;
                }
            }
            catch (Exception)
            {
                labelCommentsTitle.Text = "No comments to show :(";
                commentsListBox.Visible = false;
            }
        }

        private void updateLikesCounterOfSelectedPost()
        {
            labelLikeCounter.Visible = true;
            try
            {
                labelLikeCounter.Text = m_SelectedPost.LikedBy != null ? string.Format("{0}", m_SelectedPost.LikedBy.Count) : "Likes number is unkown";
            }
            catch (Exception)
            {
                labelLikeCounter.Text = "Likes number is unkown";
            }
        }

        private void buttonPostNewPost_Click(object sender, EventArgs e)
        {
            new Thread(postNewPost).Start();
        }

        private void postNewPost()
        {
            try
            {
                Status postedStatus = r_AppEngine.LoggedInUser.PostStatus(richTextBoxNewPost.Text);
                MessageBox.Show("Your post was posted! :)");
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to post, try again later");
            }
        }

        private void buttonShowMyPosts_Click(object sender, EventArgs e)
        {
            (sender as Button).Enabled = false;
            panelPostDetails.Visible = false;
            panelQuickView.Visible = false;
            loadingAnimation.Visible = true;
            new Thread(ftechPosts).Start();
        }

        private void buttonShareGeoChallengeStatus_Click(object sender, EventArgs e)
        {
            string messageToShare = string.Format(
                "I've got a score of {0}% in Geo Challenge by gaining {1}/{2} points!!",
                r_GeoChallengeLogic.ScorePercentage.ToString(),
                r_GeoChallengeLogic.PointsGained.ToString(),
                r_GeoChallengeLogic.MaximumQuestions.ToString());

            richTextBoxNewPost.Invoke(new Action(() => richTextBoxNewPost.Text = messageToShare));
        }
    }
}