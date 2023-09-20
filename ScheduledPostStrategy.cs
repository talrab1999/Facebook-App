using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public class ScheduledPostStrategy : IPostStrategy
    {
        private int m_Day;
        private int m_Month;
        private int m_Year;
        private int m_Hour;
        private int m_Minute;


        public ScheduledPostStrategy(int i_Day, int i_Month, int i_Year, int i_Hour, int i_Minute)
        {
            m_Day = i_Day;
            m_Month = i_Month;
            m_Year = i_Year;
            m_Hour = i_Hour;
            m_Minute = i_Minute;
        }
        public void Post(string i_PostContent, FacebookFacade i_FacebookFacade)
        {
            i_FacebookFacade.ScheduledPost(i_PostContent, m_Day, m_Month, m_Year, m_Hour, m_Minute);
        }
    }
}

