using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class GeoChallengeLogic : IEnumerable<GeoChallengeQuestion>, IFeatureLogic
    {
        private readonly string r_LocationsFileName = string.Format("{0}\\Resources\\Locations.txt", Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName);
        private readonly Random r_Random = new Random();
        private string[] m_LoactionsFromFile = null;

        public event Action AnswerChecked;

        public event Action GameInitialized;

        public int PointsGained { get; private set; }

        public int QuestionsAnswered { get; private set; }

        public int MaximumQuestions { get; private set; }

        public int GamesCounter { get; private set; }

        public float ScorePercentage { get; private set; }

        public string Name
        {
            get { return "Geo Challenge"; }
        }

        public GeoChallengeLogic()
        {
        }

        private void loadAllLoacations()
        {
            if (m_LoactionsFromFile == null)
            {
                m_LoactionsFromFile = File.ReadAllLines(r_LocationsFileName);
            }
        }

        public bool TryInitializeGeoChallenge()
        {
            bool isInitializationSuccessful;

            PointsGained = 0;
            QuestionsAnswered = 0;
            loadAllLoacations();
            try
            {
                isInitializationSuccessful = GetEnumerator().MoveNext();
                GamesCounter++;
                MaximumQuestions = this.Count();
                ScorePercentage = 0f;
                OnGameInitialized();
            }
            catch (Exception)
            {
                isInitializationSuccessful = false;
            }

            return isInitializationSuccessful;
        }

        protected virtual void OnGameInitialized()
        {
            GameInitialized?.Invoke();
        }

        private GeoChallengeQuestion createGeoChallengeQuestion(string i_PictureUrl, string i_CorrectPlace)
        {
            GeoChallengeQuestion newGeoChallengeQuestion = new GeoChallengeQuestion()
            {
                PictureURL = i_PictureUrl,
                CorrectPlace = i_CorrectPlace,
            };

            for (int i = 0; i < newGeoChallengeQuestion.NumberRandomPlaces; i++)
            {
                string newRandomPlace;

                do
                {
                    newRandomPlace = createRandomPlace();
                }
                while (newGeoChallengeQuestion.DoesLocationExist(newRandomPlace));

                newGeoChallengeQuestion.AddRandomPlace(newRandomPlace);
            }

            newGeoChallengeQuestion.ShufflePlacesOptions();

            return newGeoChallengeQuestion;
        }

        private string createRandomPlace()
        {
            return m_LoactionsFromFile[r_Random.Next(0, m_LoactionsFromFile.Length)];
        }

        public bool CheckAnswer(string i_Answer, GeoChallengeQuestion i_Question)
        {
            bool isAnswerCorrect = i_Question != null && i_Question.CheckAnswer(i_Answer);

            QuestionsAnswered++;
            PointsGained = isAnswerCorrect ? PointsGained + 1 : PointsGained;
            ScorePercentage = (PointsGained * 100f) / MaximumQuestions;
            OnAnswerChecked();

            return isAnswerCorrect;
        }

        protected virtual void OnAnswerChecked()
        {
            AnswerChecked?.Invoke();
        }

        public IEnumerator<GeoChallengeQuestion> GetEnumerator()
        {
            return new GeoChallengeQuestionIterator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private class GeoChallengeQuestionIterator : IEnumerator<GeoChallengeQuestion>
        {
            private readonly IEnumerator<Post> r_PostIterator = AppEngine.Instance.LoggedInUser.Posts.GetEnumerator();
            private GeoChallengeQuestion m_CurrentQuestion;
            private bool m_ShouldCreateNewQuestion = true;

            public GeoChallengeLogic GeoChallengeLogic { get; private set; }

            internal GeoChallengeQuestionIterator(GeoChallengeLogic i_GeoChallengeLogic)
            {
                GeoChallengeLogic = i_GeoChallengeLogic;
            }

            public GeoChallengeQuestion Current
            {
                get
                {
                    if (m_ShouldCreateNewQuestion)
                    {
                        m_ShouldCreateNewQuestion = false;
                        m_CurrentQuestion = GeoChallengeLogic.createGeoChallengeQuestion(r_PostIterator.Current.PictureURL, r_PostIterator.Current.Place.Name);
                    }

                    return m_CurrentQuestion;
                }
            }

            object IEnumerator.Current
            {
                get
                {
                    return Current;
                }
            }

            public void Dispose()
            {
                Reset();
            }

            public bool MoveNext()
            {
                bool foundNewCurrent = false;

                m_ShouldCreateNewQuestion = true;
                while (r_PostIterator.MoveNext())
                {
                    Post currentPost = r_PostIterator.Current;

                    if (currentPost.PictureURL != null && currentPost.Place != null)
                    {
                        foundNewCurrent = true;
                        break;
                    }
                }

                return foundNewCurrent;
            }

            public void Reset()
            {
                r_PostIterator.Reset();
                m_CurrentQuestion = null;
                m_ShouldCreateNewQuestion = true;
            }
        }
    }
}