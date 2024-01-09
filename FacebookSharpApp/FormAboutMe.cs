using System;
using System.Text;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class FormAboutMe : Form
    {
        private const string k_CouldntRetrieveTitle = "Couldn't retrieve";
        private readonly AppEngine r_AppEngine = AppEngine.Instance;
        private readonly GeoChallengeLogic r_GeoChallengeLogic = AppEngine.Instance.GetFeatureLogicByType<GeoChallengeLogic>();

        public FormAboutMe()
        {
            InitializeComponent();
        }

        private void formAboutMe_Load(object sender, EventArgs e)
        {
            r_GeoChallengeLogic.GameInitialized += geoChallengeLogic_GameInitialized;
            r_GeoChallengeLogic.AnswerChecked += geoChallengeLogic_AnswerChecked;
            fetchPersonlInformation();
        }

        private void fetchPersonlInformation()
        {
            pictureBoxProfile.LoadAsync(r_AppEngine.LoggedInUser.PictureNormalURL);
            labelUserName.Text = string.Format("{0} {1}", r_AppEngine.LoggedInUser.FirstName, r_AppEngine.LoggedInUser.LastName);
            fillLabel(labelBirthday, "Biryhday", r_AppEngine.LoggedInUser.Birthday);
            fillLabel(labelEmail, "Email", r_AppEngine.LoggedInUser.Email);
            fillLabel(labelGender, "Gender", r_AppEngine.LoggedInUser.Gender.ToString());
            fillLabel(labelLocation, "Location", r_AppEngine.LoggedInUser.Location.Name);
            if (r_GeoChallengeLogic.GamesCounter == 0)
            {
                labelGeoChallengeGamesCounter.Text = "You haven't played Geo Challenge yet";
            }
            else
            {
                updateGeoChallengeGameInitialized();
            }
        }

        private void fillLabel(Label i_Label, string i_InformationTitle, string i_InformationValue)
        {
            StringBuilder labelTitleBuilder = new StringBuilder();

            labelTitleBuilder.AppendFormat("{0}: ", i_InformationTitle);
            try
            {
                if (!string.IsNullOrEmpty(i_InformationValue))
                {
                    labelTitleBuilder.Append(i_InformationValue);
                }
                else
                {
                    labelTitleBuilder.AppendFormat(k_CouldntRetrieveTitle);
                }
            }
            catch (Exception)
            {
                labelTitleBuilder.AppendFormat(k_CouldntRetrieveTitle);
            }

            i_Label.Invoke(new Action(() => i_Label.Text = labelTitleBuilder.ToString()));
        }

        private void geoChallengeLogic_GameInitialized()
        {
            updateGeoChallengeGameInitialized();
        }

        private void geoChallengeLogic_AnswerChecked()
        {
            updateGeoChallengeGameStatus();
        }

        private void updateGeoChallengeGameInitialized()
        {
            fillLabel(labelGeoChallengeGamesCounter, "Number of rounds you've played Geo Challenge", r_GeoChallengeLogic.GamesCounter.ToString());
            panelGeoChallengeDetails.Controls.ShowAll();
            updateGeoChallengeGameStatus();
        }

        private void updateGeoChallengeGameStatus()
        {
            fillLabel(labelGeoChallengePoints, "Points you've earned in current round", r_GeoChallengeLogic.PointsGained.ToString());
            fillLabel(labelNumberQuestionsAnswered, "Questions answered", r_GeoChallengeLogic.QuestionsAnswered.ToString());
            fillLabel(labelMaximumQuestions, "Out of", r_GeoChallengeLogic.MaximumQuestions.ToString());
            fillLabel(labelScorePercentage, "Your score", string.Format("{0}%", r_GeoChallengeLogic.ScorePercentage.ToString()));
        }
    }
}