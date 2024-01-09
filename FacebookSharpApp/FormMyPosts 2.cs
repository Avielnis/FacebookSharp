using System;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class FormMyPosts : Form
    {
        private readonly AppEngine r_AppEngine = AppEngine.Instance;
        private Post m_SelectedPost;

        public FormMyPosts()
        {
            InitializeComponent();
        }

        private void FormMyPosts_Load(object sender, EventArgs e)
        {
            buttonShowMyPosts.PerformClick();
        }

        private void ftechPosts()
        {
            try
            {
                ListBoxQuickView.PopulateListBox(listBoxPosts, r_AppEngine.LoggedInUser.Posts);
                panelQuickView.Invoke(new Action(() => panelQuickView.Visible = true));
            }
            catch (Exception i_Exception)
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
            catch (Exception i_Exception)
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
            catch (Exception i_Exception)
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
            catch (Exception i_Exception)
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
    }
}