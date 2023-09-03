using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace SpacielFeatures
{
    public class ScheduledPost
    {
        public User TheLoggedInUser { get; set; }

        public DateTime ScheduledTime { get; set; }

        public string PostContent { get; set; }

        public ScheduledPost(User i_TheLoggedInUser, DateTime i_ScheduledTime, string i_PostContent)
        {
            TheLoggedInUser = i_TheLoggedInUser;
            ScheduledTime = i_ScheduledTime;
            PostContent = i_PostContent;
        }

        public void PostScheduledPost()
        {
            DateTime currentTime = DateTime.UtcNow;

            try
            {
                if (ScheduledTime < currentTime)
                {
                    throw new Exception("Please enter a future date !");
                }
                else
                {
                    string scheduledTimeIso = ScheduledTime.ToString("yyyy-MM-ddTHH:mm");
                    string parameters = $"scheduled_publish_time, {scheduledTimeIso}";
                    TheLoggedInUser.PostStatus(PostContent, parameters);
                    MessageBox.Show($"Status will be posted in: {ScheduledTime.Day}/{ScheduledTime.Month}/{ScheduledTime.Year}, {ScheduledTime.Hour}:{ScheduledTime.Minute}!");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error occurred!\nError details:\n" + ex.ToString());
            }
        }
    }
}
