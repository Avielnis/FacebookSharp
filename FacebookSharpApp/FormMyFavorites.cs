using System;
using System.Threading;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class FormMyFavorites : Form
    {
        private readonly AppEngine r_AppEngine = AppEngine.Instance;

        public FormMyFavorites()
        {
            InitializeComponent();
        }

        private void buttonShowLikedPages_Click(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                try
                {
                    ListBoxQuickView.PopulateListBox(listBoxLikedPages, r_AppEngine.LoggedInUser.LikedPages);
                }
                catch
                {
                    MessageBox.Show("Can't load Pages");
                }
            }).Start();
        }

        private void buttonShowGroups_Click(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                try
                {
                    ListBoxQuickView.PopulateListBox(listBoxGroups, r_AppEngine.LoggedInUser.Groups);
                }
                catch
                {
                    MessageBox.Show("Can't load Groups");
                }
            }).Start();
        }

        private void listBoxLikedPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBoxQuickView.LoadImageOfSelectedItem(sender as ListBox, pictureBoxLikedPage);
        }

        private void listBoxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBoxQuickView.LoadImageOfSelectedItem(sender as ListBox, pictureBoxGroup);
        }
    }
}