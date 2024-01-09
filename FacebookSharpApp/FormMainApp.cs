using System;
using System.Drawing;
using System.Windows.Forms;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public partial class FormMainApp : Form
    {
        private const int k_LeftBorderButtonWidth = 10;
        private const int k_LeftBorderButtonHeight = 75;
        private const float k_DisabledButtonFontSize = 10f;
        private const float k_ActivatedButtonFontSize = 11f;
        private readonly AppEngine r_AppEngine = AppEngine.Instance;
        private readonly Size r_SizeLeftBorderOfButton = new Size(k_LeftBorderButtonWidth, k_LeftBorderButtonHeight);
        private readonly Panel r_PanelLeftBorderOfButton = new Panel();
        private readonly Color r_ColorMenu = Color.FromArgb(45, 45, 80);
        private readonly Font r_DisabledButtonFont = new Font("Segoe UI", k_DisabledButtonFontSize, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
        private readonly Font r_ActivatedButtonFont = new Font("Segoe UI", k_ActivatedButtonFontSize, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
        private readonly FormAboutMe r_FormAboutMe;
        private readonly FormGeoChallenge r_FormGeoChallenge;
        private readonly FormMyEvents r_FormMyEvents;
        private readonly FormMyFavorites r_FormMyFavorites;
        private readonly FormMyFriends r_FormMyFriends;
        private readonly FormMyGallery r_FormMyGallery;
        private readonly FormMyPosts r_FormMyPosts;
        private readonly FormPostTips r_FormPostTips;
        private Button m_CurrentButton;
        private Form m_CurrentFeatureForm;
        private bool m_WasClosedByLogout = false;

        public FormMainApp()
        {
            InitializeComponent();
            FacebookService.s_CollectionLimit = 50;
            r_AppEngine.AddFeatureLogic(new PostTipsLogic());
            r_AppEngine.AddFeatureLogic(new GeoChallengeLogic());
            r_FormAboutMe = new FormAboutMe();
            r_FormGeoChallenge = new FormGeoChallenge();
            r_FormMyEvents = new FormMyEvents();
            r_FormMyFavorites = new FormMyFavorites();
            r_FormMyFriends = new FormMyFriends();
            r_FormMyGallery = new FormMyGallery();
            r_FormMyPosts = new FormMyPosts();
            r_FormPostTips = new FormPostTips();
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            r_PanelLeftBorderOfButton.Size = r_SizeLeftBorderOfButton;
            panelMenu.Controls.Add(r_PanelLeftBorderOfButton);
            buttonAboutMe.PerformClick();
        }

        internal bool WasClosedByLogout
        {
            get { return m_WasClosedByLogout; }
        }

        private void activateButton(object i_ButtonSender, Color i_ThemeColor)
        {
            if (i_ButtonSender != null)
            {
                disableButton();
                m_CurrentButton = i_ButtonSender as Button;
                m_CurrentButton.BackColor = i_ThemeColor;
                m_CurrentButton.ForeColor = Color.White;
                m_CurrentButton.Font = r_ActivatedButtonFont;
                r_PanelLeftBorderOfButton.BackColor = Color.White;
                r_PanelLeftBorderOfButton.Location = new Point(0, m_CurrentButton.Location.Y);
                r_PanelLeftBorderOfButton.Visible = true;
                r_PanelLeftBorderOfButton.BringToFront();
                labelTitle.Text = m_CurrentButton.Text;
                panelTitle.BackColor = i_ThemeColor;
                labelTitle.BackColor = i_ThemeColor;
            }
        }

        private void disableButton()
        {
            if (m_CurrentButton != null)
            {
                m_CurrentButton.BackColor = r_ColorMenu;
                m_CurrentButton.ForeColor = Color.Gainsboro;
                m_CurrentButton.Font = r_DisabledButtonFont;
            }
        }

        private void openFeatureForm(object i_ButtonSender, Form i_SelectedFeatureForm, Color i_ThemeColor)
        {
            if (m_CurrentFeatureForm != null && m_CurrentFeatureForm != i_SelectedFeatureForm)
            {
                m_CurrentFeatureForm.Hide();
            }

            m_CurrentFeatureForm = i_SelectedFeatureForm;
            i_SelectedFeatureForm.TopLevel = false;
            i_SelectedFeatureForm.FormBorderStyle = FormBorderStyle.None;
            i_SelectedFeatureForm.Dock = DockStyle.Fill;
            panelFeatureDisplay.Controls.Add(i_SelectedFeatureForm);
            i_SelectedFeatureForm.BringToFront();
            activateButton(i_ButtonSender, i_ThemeColor);
            i_SelectedFeatureForm.Visible = true;
            i_SelectedFeatureForm.Show();
        }

        private void buttonAboutMe_Click(object sender, EventArgs e)
        {
            openFeatureForm(sender, r_FormAboutMe, Color.Purple);
        }

        private void buttonMyAlbums_Click(object sender, EventArgs e)
        {
            openFeatureForm(sender, r_FormMyGallery, Color.Teal);
        }

        private void buttonMyPosts_Click(object sender, EventArgs e)
        {
            openFeatureForm(sender, r_FormMyPosts, Color.SeaGreen);
        }

        private void buttonMyEvents_Click(object sender, EventArgs e)
        {
            openFeatureForm(sender, r_FormMyEvents, Color.IndianRed);
        }

        private void buttonMyFriends_Click(object sender, EventArgs e)
        {
            openFeatureForm(sender, r_FormMyFriends, Color.SlateGray);
        }

        private void buttonMyFavorites_Click(object sender, EventArgs e)
        {
            openFeatureForm(sender, r_FormMyFavorites, Color.DarkSeaGreen);
        }

        private void buttonPostTips_Click(object sender, EventArgs e)
        {
            openFeatureForm(sender, r_FormPostTips, Color.Teal);
        }

        private void buttonGeoChallenge_Click(object sender, EventArgs e)
        {
            openFeatureForm(sender, r_FormGeoChallenge, Color.MediumPurple);
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            r_AppEngine.Logout();
            m_WasClosedByLogout = true;
            this.Dispose();
        }
    }
}