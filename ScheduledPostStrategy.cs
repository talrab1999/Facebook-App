using System;
using SpecialFeatures;
using FacebookWrapper.ObjectModel;


namespace BasicFacebookFeatures
{
    public class ScheduledPostStrategy : IPostStrategy
    {
        private int m_Day;
        private int m_Month;
        private int m_Year;
        private int m_Hour;
        private int m_Minute;
        public User TheLoggedInUser { get; set; }
        public ScheduledPost ScheduledPostManger { get; set; }
        public SpecialFeaturesFactory FeaturesFactory { get; set; }
        public ScheduledPostStrategy(int i_Day, int i_Month, int i_Year, int i_Hour, int i_Minute)
        {
            m_Day = i_Day;
            m_Month = i_Month;
            m_Year = i_Year;
            m_Hour = i_Hour;
            m_Minute = i_Minute;
            FeaturesFactory = new SpecialFeaturesFactory();
        }
        public void Post(string i_PostContent, User i_TheLoggedInUser)
        {
            DateTime scheduledTime = new DateTime(m_Year, m_Month, m_Day, m_Hour, m_Minute, 0, DateTimeKind.Utc);

            ScheduledPostManger = FeaturesFactory.CreateScheduledPost(i_TheLoggedInUser, scheduledTime, i_PostContent);

            ScheduledPostManger.PostScheduledPost();
        }
    }
}
