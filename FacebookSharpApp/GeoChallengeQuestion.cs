using System;
using System.Collections.Generic;

namespace BasicFacebookFeatures
{
    public class GeoChallengeQuestion
    {
        private const int k_NumberRandomPlaces = 3;
        private readonly List<string> m_PlacesOptions = new List<string>(k_NumberRandomPlaces + 1);
        private readonly List<string> r_ShuffledPlacesOptions = new List<string>(k_NumberRandomPlaces + 1);
        private string m_PictureURL;
        private string m_CorrectPlace;

        public GeoChallengeQuestion()
        {
        }

        public int NumberRandomPlaces
        {
            get { return k_NumberRandomPlaces; }
        }

        public string PictureURL
        {
            get { return m_PictureURL; }
            internal set { m_PictureURL = value; }
        }

        public string CorrectPlace
        {
            get
            {
                return m_CorrectPlace;
            }

            internal set
            {
                m_CorrectPlace = value;
                m_PlacesOptions.Insert(0, m_CorrectPlace);
            }
        }

        public List<string> ShuffledPlacesOptions
        {
            get { return r_ShuffledPlacesOptions; }
        }

        internal void AddRandomPlace(string i_RandomPlaceToAdd)
        {
            m_PlacesOptions.Add(i_RandomPlaceToAdd);
        }

        internal bool DoesLocationExist(string i_Location)
        {
            return m_PlacesOptions.Contains(i_Location) || m_CorrectPlace.Equals(i_Location);
        }

        public void ShufflePlacesOptions()
        {
            Random random = new Random();

            for (int i = 0; i < m_PlacesOptions.Count; i++)
            {
                r_ShuffledPlacesOptions.Add(null);
            }

            for (int i = 0; i < r_ShuffledPlacesOptions.Count; i++)
            {
                int randomIndex;

                do
                {
                    randomIndex = random.Next(0, r_ShuffledPlacesOptions.Count);
                }
                while (r_ShuffledPlacesOptions[randomIndex] != null);

                r_ShuffledPlacesOptions[randomIndex] = m_PlacesOptions[i];
            }
        }

        public bool CheckAnswer(string i_Answer)
        {
            return CorrectPlace.Equals(i_Answer);
        }
    }
}