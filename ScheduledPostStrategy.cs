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
        private int day;
        private int month;
        private int year;
        private int hour;
        private int minute;


        public ScheduledPostStrategy(int day, int month, int year, int hour, int minute)
        {
            this.day = day;
            this.month = month;
            this.year = year;
            this.hour = hour;
            this.minute = minute;
        }
        public void Post(string postContent, FacebookFacade facebookFacade)
        {
            facebookFacade.ScheduledPost(postContent, day, month, year, hour, minute);
        }
    }
}
