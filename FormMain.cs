using System;
using System.Drawing;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.Threading;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        public FormMain(FacebookServiceSingleton facebookService)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            FacebookServiceSing = facebookService;
            FacebookWrapper.FacebookService.s_CollectionLimit = 25;
        }

        public FacebookServiceSingleton FacebookServiceSing { get; set; }
        public LoginResult          LoginResult { get; set; }
        public User                 TheLoggedInUser { get; set; }
        public FacebookFacade facebookFacade { get; set; }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("design.patterns");

            if (LoginResult == null)
            {
                //new Thread(login).Start();
                login();
            }
        }

        private void login()
        {
            /*
            LoginResult = FacebookServiceSing.LoginWithAppIdAndPermissions(
                  "610365831081527",
                  "email",
                  "public_profile",
                  "user_age_range",
                  "user_birthday",
                  "user_events",
                  "user_friends",
                  "user_gender",
                  "user_hometown",
                  "user_likes",
                  "user_link",
                  "user_location",
                  "user_photos",
                  "user_posts",
                  "user_videos",
                  "publish_to_groups",
                  "pages_read_engagement",
                  "pages_manage_posts");
            */
           
            LoginResult = FacebookServiceSing.LoginWithAccessToken("EAAIrH96LbjcBO0iwwqb8jHIEGPavdqE4HT69ed6IZCn2nZBWeOfNTDjDjk2FBpIpybdtXjZBHwObGlil2CKCdvaZAGf2hsrKQPSXGBPGb8xEG46Bvc4i8YbiP3y5TWAXoGtWQoZAxUa8TIOYuHXIlIPk6sHlW08tljqp8VtNhVvJbOo3KHzCWjxvZACiwe");

            if (string.IsNullOrEmpty(LoginResult.ErrorMessage))
            {
                TheLoggedInUser = LoginResult.LoggedInUser;
                fetchUserInfo();
                facebookFacade = new FacebookFacade(TheLoggedInUser);
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookServiceSing.Logout();
            buttonLogin.Text = "Login";
            buttonLogin.BackColor = buttonLogout.BackColor;
            LoginResult = null;
            pictureBoxProfile.ImageLocation = null;
            switchEnabledModeAndClearListBox();
        }

        private void fetchUserInfo()
        {
            buttonLogin.Text = $"Logged in as {TheLoggedInUser.Name}";
            buttonLogin.BackColor = Color.LightGreen;
            pictureBoxProfile.ImageLocation = TheLoggedInUser.PictureNormalURL;
            switchEnabledModeAndClearListBox();
        }

        private void switchEnabledModeAndClearListBox()
        {

            buttonFetchAlbums.Enabled = !buttonFetchAlbums.Enabled;
            buttonFetchFavoriteTeams.Enabled = !buttonFetchFavoriteTeams.Enabled;
            buttonFetchLikePages.Enabled = !buttonFetchLikePages.Enabled;
            buttonFetchTop5Pages.Enabled = !buttonFetchTop5Pages.Enabled;
            buttonFetchMyEvents.Enabled = !buttonFetchPosts.Enabled;
            buttonFetchPosts.Enabled = !buttonFetchPosts.Enabled;
            buttonPost.Enabled = !buttonPost.Enabled;
            checkBoxScheduledPost.Enabled = !checkBoxScheduledPost.Enabled;
            buttonLogin.Enabled = !buttonLogin.Enabled;
            buttonLogout.Enabled = !buttonLogout.Enabled;
            textBoxNewPost.Enabled = !textBoxNewPost.Enabled;

            textBoxNewPost.Clear();
            listBoxPosts.DataSource = null;
            listBoxAlbums.DataSource = null;
            listBoxEvents.DataSource = null;
            listBoxLikePages.DataSource = null;
            listBoxFavoriteTeams.DataSource = null;
            listBoxTop5Pages.DataSource = null;

            pictureBoxAlbum.ImageLocation = null;
            pictureBoxFavoriteTeam.ImageLocation = null;
            pictureBoxTop5Photos.ImageLocation = null;

            if (checkBoxScheduledPost.Checked)
            {
                checkBoxScheduledPost.Checked = !checkBoxScheduledPost.Checked;
            }

        }

        private void buttonPost_Click(object sender, EventArgs e)
        {
            string postContent = textBoxNewPost.Text;

            if (!checkBoxScheduledPost.Checked)
            {
                facebookFacade.PostStatus(postContent);
            }
            else
            {
                new Thread(() => scheduledPost(postContent)).Start();
            }
        }

        private void scheduledPost(string i_PostContent)
        {
            int day = (int)numericUpDownDay.Value;
            int month = (int)numericUpDownMonth.Value;
            int year = (int)numericUpDownYear.Value;
            int hour = (int)numericUpDownHour.Value;
            int minute = (int)numericUpDownMinute.Value;

            facebookFacade.ScheduledPost(i_PostContent, day, month, year, hour, minute);
        }

        private void listBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedAlbum();
        }

        private void displaySelectedAlbum()
        {
            if (listBoxAlbums.SelectedItems.Count == 1)
            {
                Album selectedAlbum = listBoxAlbums.SelectedItem as Album;
                if (selectedAlbum.PictureAlbumURL != null)
                {
                    pictureBoxAlbum.LoadAsync(selectedAlbum.PictureAlbumURL);
                }
                else
                {
                    pictureBoxProfile.Image = pictureBoxProfile.ErrorImage;
                }
            }
        }

        private void listBoxFavoriteTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxFavoriteTeams.SelectedItems.Count == 1)
            {
                Page selectedTeam = listBoxFavoriteTeams.SelectedItem as Page;
                pictureBoxFavoriteTeam.LoadAsync(selectedTeam.PictureNormalURL);
            }
        }

        private void checkBoxScheduledPost_CheckedChanged(object sender, EventArgs e)
        {
            labelDate.Visible = !labelDate.Visible;
            labelTime.Visible = !labelTime.Visible;
            label1Sperate.Visible = !label1Sperate.Visible;
            numericUpDownDay.Visible = !numericUpDownDay.Visible;
            numericUpDownMonth.Visible = !numericUpDownMonth.Visible;
            numericUpDownYear.Visible = !numericUpDownYear.Visible;
            numericUpDownMinute.Visible = !numericUpDownMinute.Visible;
            numericUpDownHour.Visible = !numericUpDownHour.Visible;
        }

        private void listBoxTop5Pages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxTop5Pages.SelectedItems.Count == 1)
            {
                Page selectedTeam = listBoxTop5Pages.SelectedItem as Page;
                pictureBoxTop5Photos.LoadAsync(selectedTeam.PictureNormalURL);
            }
        }

        private void fetchPosts()
        {
            listBoxPosts.Invoke(new Action( () => listBoxPosts.DataSource = facebookFacade.GetPosts()));
           
            if (listBoxPosts.Items.Count == 0)
            {
                MessageBox.Show("No Posts to show");
            }
        }

        private void fetchAlbums()
        {
            listBoxAlbums.Invoke(new Action(() => listBoxAlbums.DataSource = facebookFacade.GetAlbums()));

            if (listBoxAlbums.Items.Count == 0)
            {
                MessageBox.Show("No albums to retrieve :(");
            }
        }

        private void fetchFavoriteTeams()
        {
            var favoriteTeams = facebookFacade.GetFavoriteTeams();

            listBoxFavoriteTeams.Invoke(new Action(() => listBoxFavoriteTeams.DataSource = favoriteTeams));
            listBoxFavoriteTeams.Invoke(new Action(() => listBoxFavoriteTeams.DisplayMember = "Name"));

            if (listBoxFavoriteTeams.Items.Count == 0)
            {
                MessageBox.Show("No teams to retrieve :(");
            }
        }

        private void fetchLikePages()
        {    
            listBoxLikePages.Invoke(new Action(() => listBoxLikePages.DataSource = facebookFacade.GetLikedPages()));
            listBoxLikePages.Invoke(new Action(() => listBoxLikePages.DisplayMember = "Name"));

            if (listBoxLikePages.Items.Count == 0)
            {
                MessageBox.Show("No pages to retrieve :(");
            }
        }

        private void fetchTop5LikedPages()
        {
            listBoxTop5Pages.Invoke(new Action(() => listBoxTop5Pages.DataSource = facebookFacade.GetTop5LikedPages()));
            listBoxTop5Pages.Invoke(new Action(() => listBoxTop5Pages.DisplayMember = "Name"));

            if (listBoxTop5Pages.Items.Count == 0)
            {
                MessageBox.Show("No pages to retrieve :(");
            }
        }

        private void fetchEvents()
        {
            listBoxEvents.Invoke(new Action(() => listBoxEvents.DataSource = facebookFacade.GetEvents())); 
    
            if (listBoxEvents.Items.Count == 0)
            {
                MessageBox.Show("No Events to retrieve :(");
            }
        }

        private void buttonFetchTop5Pages_Click(object sender, EventArgs e)
        {
            new Thread(fetchTop5LikedPages).Start();
        }

        private void buttonFetchMyEvents_Click(object sender, EventArgs e)
        {
            new Thread(fetchEvents).Start();
        }

        private void buttonFetchFavoriteTeams_Click(object sender, EventArgs e)
        {
            new Thread(fetchFavoriteTeams).Start();
        }

        private void buttonFetchLikePages_Click(object sender, EventArgs e)
        {
            new Thread(fetchLikePages).Start();
        }

        private void buttonFetchPosts_Click(object sender, EventArgs e)
        {
            new Thread(fetchPosts).Start();
        }

        private void buttonFetchAlbums_Click(object sender, EventArgs e)
        {
            new Thread(fetchAlbums).Start();
        }
    }
}
