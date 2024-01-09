using System;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class FormMyEvents : Form
    {
        private FacebookObjectCollection<Event> m_Events;

        public FormMyEvents()
        {
            InitializeComponent();
        }

        private void formMyEvents_Load(object sender, EventArgs e)
        {
            buttonShowMyEvents.PerformClick();
        }

        private void loadEvents()
        {
            try
            {
                m_Events = AppEngine.Instance.LoggedInUser.Events;
                if (m_Events.Count > 0)
                {
                    foreach (Event facebookEvent in m_Events)
                    {
                        ListViewItem item = new ListViewItem(facebookEvent.Name);

                        item.SubItems.Add(facebookEvent.Place.Name);
                        item.SubItems.Add(facebookEvent.Description.ToString());
                        item.SubItems.Add(facebookEvent.StartTime.ToString());
                        item.SubItems.Add(facebookEvent.LinkToFacebook);
                        item.SubItems.Add(facebookEvent.AttendingCount.ToString());
                        listViewEvents.Invoke(new Action(() => listViewEvents.Items.Add(item)));
                    }
                }
                else
                {
                    MessageBox.Show("There are no events to show");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Can't retrieve events");
            }
        }

        private void buttonShowMyEvents_Click(object sender, EventArgs e)
        {
            buttonShowMyEvents.Enabled = false;
            new Thread(() =>
            {
                loadEvents();
                buttonShowMyEvents.Invoke(new Action(() => buttonShowMyEvents.Enabled = true));
            }).Start();
        }
    }
}