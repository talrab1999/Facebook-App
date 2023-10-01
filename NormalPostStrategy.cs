
using FacebookWrapper.ObjectModel;
using System;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public class NormalPostStrategy : IPostStrategy
    {
        public User TheLoggedInUser { get; set; }
        public void Post(string i_PostContent, User i_TheLoggedInUser)
        {

            try
            {
                Status postedStatus = i_TheLoggedInUser.PostStatus(i_PostContent);
                MessageBox.Show("Status Posted! ID: " + postedStatus.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred!\nError details:\n" + ex.ToString());
            }
        }

    }
}
