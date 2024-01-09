using System;
using System.Threading;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class FormMyFriends : Form
    {
        private readonly AppEngine r_AppEngine = AppEngine.Instance;

        public FormMyFriends()
        {
            InitializeComponent();
        }

        private void formMyFriends_Load(object sender, EventArgs e)
        {
            buttonShowMyFriends.PerformClick();
        }

        private void loadFriends()
        {
            try
            {
                ListBoxQuickView.PopulateListBox(listBoxFriends, r_AppEngine.LoggedInUser.Friends);
            }
            catch (Exception)
            {
                MessageBox.Show("Can't load friends");
            }
        }

        private void listBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBoxQuickView.LoadImageOfSelectedItem(sender as ListBox, pictureBoxFriendPicture);
            ListBoxQuickView.BindDataOfSelectedItem(sender as ListBox, userBindingSource);
            panelFriendDetails.Visible = true;
        }

        private void buttonShowMyFriends_Click(object sender, EventArgs e)
        {
            buttonShowMyFriends.Enabled = false;
            panelFriendDetails.Visible = false;
            new Thread(() =>
            {
                loadFriends();
                buttonShowMyFriends.Invoke(new Action(() => buttonShowMyFriends.Enabled = true));
            }).Start();
        }
    }
}