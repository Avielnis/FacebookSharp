using System;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class FormLogin : Form
    {
        private readonly AppEngine r_AppEngine = AppEngine.Instance;

        public FormLogin()
        {
            InitializeComponent();
            initializeFormLogin();
        }

        private void initializeFormLogin()
        {
            bool isNeededNewLogin;

            r_AppEngine.AccessTokenManeger.LoadAccessTokenFromFile();
            isNeededNewLogin = string.IsNullOrEmpty(r_AppEngine.AccessTokenManeger.AccessToken) || !r_AppEngine.TryProceedAndInitialize();
            changeControlsForLoginFashion(isNeededNewLogin);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (r_AppEngine.TryLoginAndInitialize())
            {
                getIntoFormMainApp();
            }
            else
            {
                MessageBox.Show(r_AppEngine.LoginResult.ErrorMessage, "Login Failed");
            }
        }

        private void checkBoxRememberMe_CheckedChanged(object sender, EventArgs e)
        {
            r_AppEngine.AccessTokenManeger.IsRememberingAccessToken = checkBoxRememberMe.Checked;
        }

        private void buttonProceed_Click(object sender, EventArgs e)
        {
            getIntoFormMainApp();
        }

        private void getIntoFormMainApp()
        {
            FormMainApp formMainApp = new FormMainApp();

            Visible = false;
            formMainApp.ShowDialog();
            if (formMainApp.WasClosedByLogout)
            {
                Application.Restart();
            }
            else
            {
                Dispose();
            }
        }

        private void logOut()
        {
            bool v_IsNeededNewLogin = true;

            r_AppEngine.Logout();
            changeControlsForLoginFashion(v_IsNeededNewLogin);
        }

        private void changeControlsForLoginFashion(bool i_IsNeededNewLogin)
        {
            buttonLogin.Visible = i_IsNeededNewLogin;
            buttonProceed.Visible = !i_IsNeededNewLogin;
            checkBoxRememberMe.Visible = i_IsNeededNewLogin;
            buttonLogout.Visible = !i_IsNeededNewLogin;
            if (!i_IsNeededNewLogin)
            {
                buttonProceed.Text = $"Proceed with Facebook as {r_AppEngine.LoggedInUser.Name}";
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            logOut();
        }
    }
}