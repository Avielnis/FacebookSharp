using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class FormPostTips : Form
    {
        private readonly PostTipsLogic r_PostTipsLogic = AppEngine.Instance.GetFeatureLogicByType<PostTipsLogic>();
        private PostLikesPerHour[] m_LikesPerHourRangeArray;

        public FormPostTips()
        {
            InitializeComponent();
        }

        private void formPostTips_Load(object sender, EventArgs e)
        {
            new Thread(loadAllPostTips).Start();
        }

        private void handleControlsForLoading()
        {
            Controls.HideAll();
            loadingAnimation.Invoke(new Action(() => loadingAnimation.Visible = true));
        }

        private void handleControlsAfterLoading()
        {
            Controls.ShowAll();
            loadingAnimation.Invoke(new Action(() => loadingAnimation.Visible = false));
        }

        private void loadAllPostTips()
        {
            LinkedList<Exception> exceptions = new LinkedList<Exception>();
            List<Thread> threads;

            handleControlsForLoading();
            threads = new List<Thread>()
            {
                new Thread(() => exceptions.AddLast(AppEngine.Instance.SafeThreadExecute(loadBirthdays))),
                new Thread(() => exceptions.AddLast(AppEngine.Instance.SafeThreadExecute(loadBestFriends))),
                new Thread(() => exceptions.AddLast(AppEngine.Instance.SafeThreadExecute(loadMostLikedPosts))),
                new Thread(() => exceptions.AddLast(AppEngine.Instance.SafeThreadExecute(loadPostLikesPerHourStatistics))),
            };

            foreach (Thread thread in threads)
            {
                thread.Start();
            }

            foreach (Thread thread in threads)
            {
                thread.Join();
            }

            foreach (Exception exception in exceptions)
            {
                if (exception != null)
                {
                    MessageBox.Show(exception.Message);
                }
            }

            labelTitleMessage.Invoke(new Action(() => labelTitleMessage.Text = string.Format("Welcome to {0}", r_PostTipsLogic.Name)));
            handleControlsAfterLoading();
        }

        private void loadBirthdays()
        {
            Dictionary<string, string> friendsWithSameBirthdatMonth = r_PostTipsLogic.CreateFriendsWithSameBirthdatMonthDictionary();

            populateListViewFromDictionary(listViewBirthdays, friendsWithSameBirthdatMonth);
        }

        private void loadMostLikedPosts()
        {
            Dictionary<string, int> sortedPostsByLikesCount = r_PostTipsLogic.SortPostsByLikesCount();
            string mostLikedPostMessage = string.Format("You should post more posts with content similar to{0}", Environment.NewLine);

            displayPostTipFromDictionary(sortedPostsByLikesCount, listViewMostLikedPosts, Color.LightPink, labelMostLikedPost, mostLikedPostMessage);
        }

        private void loadBestFriends()
        {
            Dictionary<string, int> sortedFriendsByLikes = r_PostTipsLogic.SortFriendsByLikes();
            string bestFriendMessage = "Your best friens, who made the most likes is";

            displayPostTipFromDictionary(sortedFriendsByLikes, listViewBestFriends, Color.Yellow, labelBestFriend, bestFriendMessage);
        }

        private void displayPostTipFromDictionary<TKey, TValue>(Dictionary<TKey, TValue> i_Dictionary, ListView i_ListView, Color i_MarkColor, Label i_LabelMessage, string i_MessageTitle)
        {
            if (i_Dictionary.Count() > 0)
            {
                string bestEntryKeyString = i_Dictionary.First().Key.ToString();

                populateListViewFromDictionary(i_ListView, i_Dictionary);
                i_ListView.Invoke(new Action(() => i_ListView.Items[0].BackColor = i_MarkColor));
                i_LabelMessage.Invoke(new Action(() => i_LabelMessage.Text = string.Format("{0} {1}", i_MessageTitle, bestEntryKeyString)));
            }
        }

        private void populateListViewFromDictionary<TKey, TValue>(ListView i_ListView, Dictionary<TKey, TValue> i_Dictionary)
        {
            foreach (KeyValuePair<TKey, TValue> entry in i_Dictionary)
            {
                ListViewItem item = new ListViewItem(entry.Key.ToString());

                item.SubItems.Add(entry.Value.ToString());
                i_ListView.Invoke(new Action(() => i_ListView.Items.Add(item)));
            }
        }

        private void loadPostLikesPerHourStatistics()
        {
            PostLikesPerHour hourWithMaxLikes;

            m_LikesPerHourRangeArray = r_PostTipsLogic.CalculateLikesAveragePerHourRange();
            hourWithMaxLikes = m_LikesPerHourRangeArray[0];
            foreach (PostLikesPerHour timesAndLikes in m_LikesPerHourRangeArray)
            {
                chartLikesOnPostsPerHour.Invoke(new Action(() => chartLikesOnPostsPerHour.Series["Likes"].Points.AddXY(string.Format("{0}", timesAndLikes.Hour), timesAndLikes.Average)));
                if (hourWithMaxLikes.Average < timesAndLikes.Average)
                {
                    hourWithMaxLikes = timesAndLikes;
                }
            }

            labelPostByHourTip.Invoke(new Action(() => labelPostByHourTip.Text = string.Format(
@"By this chart we reccomand you
to upload your post arround {0}. 
You got {1} likes in averege
at this time slot.",
hourWithMaxLikes.Hour,
hourWithMaxLikes.Average)));
        }
    }
}