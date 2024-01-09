namespace BasicFacebookFeatures
{
    public class PostLikesPerHour
    {
        private string m_Hour;
        private int m_NumberOfLikes = 0;
        private int m_Count = 0;
        private int m_Average = 0;

        public PostLikesPerHour(string i_HourRange)
        {
            m_Hour = i_HourRange;
        }

        public int NumberOfLikes
        {
            get { return m_NumberOfLikes; }
            set { m_NumberOfLikes = value; }
        }

        public int Count
        {
            get { return m_Count; }
            set { m_Count = value; }
        }

        public string Hour
        {
            get { return m_Hour; }
            set { m_Hour = value; }
        }

        public int Average
        {
            get { return m_Average; }
            set { m_Average = value; }
        }

        public void CalculateAverage()
        {
            m_Average = m_Count != 0 ? m_NumberOfLikes / m_Count : 0;
        }
    }
}