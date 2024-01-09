using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class FormGeoChallenge : Form
    {
        private readonly GeoChallengeLogic r_GeoChallengeLogic = AppEngine.Instance.GetFeatureLogicByType<GeoChallengeLogic>();
        private IEnumerator<GeoChallengeQuestion> m_QuestionIterator;

        public FormGeoChallenge()
        {
            InitializeComponent();
        }

        private void formGeoChallenge_Load(object sender, EventArgs e)
        {
            initializeGeoCallenge();
        }

        private void initializeGeoCallenge()
        {
            bool isInitializationSuccessful = false;

            panelContent.Controls.HideAll();
            panelPointsStatus.Controls.HideAll();
            loadingAnimation.Visible = true;
            colorStatusLabelsWithOriginalColors();
            new Thread(() =>
            {
                isInitializationSuccessful = r_GeoChallengeLogic.TryInitializeGeoChallenge();
                geoChallengeLogic_FinishedInitialization(isInitializationSuccessful);
            }).Start();
        }

        private void geoChallengeLogic_FinishedInitialization(bool i_IsInitializationSuccessful)
        {
            string messageToUser;

            loadingAnimation.Invoke(new Action(() => loadingAnimation.Visible = false));
            if (!i_IsInitializationSuccessful)
            {
                messageToUser = "Try again later";
                panelContent.Controls.HideAll();
                buttonReload.Invoke(new Action(() => buttonReload.Visible = true));
                MessageBox.Show("Cannot fetch your checked in photos, Try again later");
            }
            else
            {
                messageToUser = string.Format("Welcome to {0}", r_GeoChallengeLogic.Name);
                buttonStartGame.Invoke(new Action(() => buttonStartGame.Visible = true));
                updateGameStatusDisplay();
                m_QuestionIterator = r_GeoChallengeLogic.GetEnumerator();
            }

            labelMessageToUser.Invoke(new Action(() => labelMessageToUser.Visible = true));
            labelMessageToUser.Invoke(new Action(() => labelMessageToUser.Text = messageToUser));
        }

        private void colorStatusLabelsWithOriginalColors()
        {
            panelPointsStatus.Controls.ChangeColorForAll(Color.Purple);
            panelGameStatusDisplay.Controls.ChangeColorForAll(Color.MediumOrchid);
        }

        private void buttonNextQuestion_Click(object sender, EventArgs e)
        {
            colorStatusLabelsWithOriginalColors();
            showNextQuestion();
        }

        private void showNextQuestion()
        {
            if (m_QuestionIterator.MoveNext())
            {
                GeoChallengeQuestion question = m_QuestionIterator.Current;

                labelMessageToUser.Text = "Where was this photo taken?";
                pictureBoxGeoChallenge.LoadAsync(question.PictureURL);
                listBoxPlacesOptions.DataSource = question.ShuffledPlacesOptions;
                buttonCheckAnswer.Enabled = true;
            }
            else
            {
                pictureBoxGeoChallenge.Visible = false;
                buttonCheckAnswer.Enabled = false;
                buttonNextQuestion.Enabled = false;
                MessageBox.Show("You answered all the questions! Good Job!");
            }
        }

        private void buttonCheckAnswer_Click(object sender, EventArgs e)
        {
            (sender as Button).Enabled = false;
            if (listBoxPlacesOptions.SelectedItems.Count == 1)
            {
                string selectedAnswer = listBoxPlacesOptions.SelectedItem as string;
                bool isSelectedAnswerCorrect = r_GeoChallengeLogic.CheckAnswer(selectedAnswer, m_QuestionIterator.Current);
                string answerCheckedMessage;
                Color colorLabels;

                if (isSelectedAnswerCorrect)
                {
                    answerCheckedMessage = "Your Answer is Correct";
                    colorLabels = Color.Green;
                }
                else
                {
                    answerCheckedMessage = string.Format(
@"Your Answer is Wrong.
The Correct Answer is: {0}",
m_QuestionIterator.Current.CorrectPlace);
                    colorLabels = Color.Red;
                }

                labelMessageToUser.Text = answerCheckedMessage;
                panelPointsStatus.Controls.ChangeColorForAll(colorLabels);
                panelGameStatusDisplay.Controls.ChangeColorForAll(colorLabels);
                updateGameStatusDisplay();
            }
        }

        private void updateGameStatusDisplay()
        {
            labelQuestionsAnswered.Invoke(new Action(() => labelQuestionsAnswered.Text = string.Format("{0}/{1}", r_GeoChallengeLogic.QuestionsAnswered, r_GeoChallengeLogic.MaximumQuestions)));
            labelUserPoints.Invoke(new Action(() => labelUserPoints.Text = r_GeoChallengeLogic.PointsGained.ToString()));
            labelScore.Invoke(new Action(() => labelScore.Text = string.Format("{0}%", r_GeoChallengeLogic.ScorePercentage.ToString())));
            labelRoundNumber.Invoke(new Action(() => labelRoundNumber.Text = r_GeoChallengeLogic.GamesCounter.ToString()));
        }

        private void buttonStartGame_Click(object sender, EventArgs e)
        {
            buttonStartGame.Visible = false;
            panelPointsStatus.Controls.ShowAll();
            buttonNextQuestion.Enabled = true;
            panelContent.Controls.ShowAll();
            panelGameStatusDisplay.Controls.ShowAll();
            showNextQuestion();
        }

        private void buttonReload_Click(object sender, EventArgs e)
        {
            initializeGeoCallenge();
        }
    }
}