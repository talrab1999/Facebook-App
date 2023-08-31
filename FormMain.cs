using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.Windows.Forms.VisualStyles;
using System.Threading;
using SpacielFeatures;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            FacebookWrapper.FacebookService.s_CollectionLimit = 25;
        }

        public LoginResult          LoginResult { get; set; }
        public User                 TheLoggedInUser { get; set; }
        public FeatureTop5LikePages Top5LikePages { get; set; }
        public ScheduledPost        ScheduledPostManger { get; set; }

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
              m_LoginResult = FacebookService.Login(
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
                  "pages_manage_posts"
                  );
            */



            LoginResult = FacebookService.Connect("EAAIrH96LbjcBO0iwwqb8jHIEGPavdqE4HT69ed6IZCn2nZBWeOfNTDjDjk2FBpIpybdtXjZBHwObGlil2CKCdvaZAGf2hsrKQPSXGBPGb8xEG46Bvc4i8YbiP3y5TWAXoGtWQoZAxUa8TIOYuHXIlIPk6sHlW08tljqp8VtNhVvJbOo3KHzCWjxvZACiwe");

            if (string.IsNullOrEmpty(LoginResult.ErrorMessage))
            {
                TheLoggedInUser = LoginResult.LoggedInUser;
                fetchUserInfo();
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI();
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
            listBoxPosts.Items.Clear();
            listBoxAlbums.Items.Clear();
            listBoxEvents.Items.Clear();
            listBoxFavoriteTeams.Items.Clear();
            listBoxLikePages.Items.Clear();
            listBoxTop5Pages.Items.Clear();

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

            if (!checkBoxScheduledPost.Checked)
            {
                try
                {
                    Status postedStatus = TheLoggedInUser.PostStatus(textBoxNewPost.Text);
                    MessageBox.Show("Status Posted! ID: " + postedStatus.Id);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occurred!\nError details:\n" + ex.ToString());
                }
            }
            else
            {
                new Thread(scheduledPost).Start();
                //scheduledPost();
            }
        }

        private void scheduledPost()
        {
            int day = (int)numericUpDownDay.Value;
            int month = (int)numericUpDownMonth.Value;
            int year = (int)numericUpDownYear.Value;
            int hour = (int)numericUpDownHour.Value;
            int minute = (int)numericUpDownMinute.Value;

            DateTime scheduledTime = new DateTime(year, month, day, hour, minute, 0, DateTimeKind.Utc);

            ScheduledPostManger = new ScheduledPost(TheLoggedInUser, scheduledTime, textBoxNewPost.Text);

            ScheduledPostManger.PostScheduledPost();

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
            listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Clear()));
            //listBoxPosts.Items.Clear();
            try
            {
                foreach (Post post in TheLoggedInUser.Posts)
                {
                    if (post.Message != null)
                    {
                        listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Add(post.Message)));
                        //listBoxPosts.Items.Add(post.Message);
                    }
                    else if (post.Caption != null)
                    {
                        listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Add(post.Caption)));
                        //listBoxPosts.Items.Add(post.Caption);
                    }
                    else
                    {
                        listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Add(string.Format("[{0}]", post.Type))));
                        //listBoxPosts.Items.Add(string.Format("[{0}]", post.Type));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred!\nError details:\n" + ex.ToString());
            }

            if (listBoxPosts.Items.Count == 0)
            {
                MessageBox.Show("No Posts to show");
            }
        }

        private void fetchAlbums()
        {
            listBoxAlbums.Invoke(new Action(() => listBoxAlbums.Items.Clear()));
            //listBoxAlbums.Items.Clear();

            try
            {
                foreach (Album album in TheLoggedInUser.Albums)
                {
                    listBoxAlbums.Invoke(new Action(() => listBoxAlbums.Items.Add(album)));
                    //listBoxAlbums.Items.Add(album);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred!\nError details:\n" + ex.ToString());
            }

            if (listBoxAlbums.Items.Count == 0)
            {
                listBoxAlbums.Invoke(new Action(() => listBoxAlbums.Items.Add("No Albums to retrieve")));
                //listBoxAlbums.Items.Add("No Albums to retrieve");
            }
        }

        private void fetchFavoriteTeams()
        {
            listBoxFavoriteTeams.Invoke(new Action(() => listBoxFavoriteTeams.Items.Clear()));
            listBoxFavoriteTeams.Invoke(new Action(() => listBoxFavoriteTeams.DisplayMember = "Name"));
            //listBoxFavoriteTeams.Items.Clear();
            //listBoxFavoriteTeams.DisplayMember = "Name";

            try
            {
                foreach (Page team in TheLoggedInUser.FavofriteTeams)
                {
                    listBoxFavoriteTeams.Invoke(new Action(() => listBoxFavoriteTeams.Items.Add(team)));
                    //listBoxFavoriteTeams.Items.Add(team);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred!\nError details:\n" + ex.ToString());
            }

            if (listBoxFavoriteTeams.Items.Count == 0)
            {
                listBoxFavoriteTeams.Invoke(new Action(() => listBoxFavoriteTeams.Items.Add("No teams to retrieve :(")));
                //listBoxFavoriteTeams.Items.Add("No teams to retrieve :(");
            }
        }

        private void fetchLikePages()
        {
            listBoxLikePages.Invoke(new Action(() => listBoxLikePages.Items.Clear()));
            listBoxLikePages.Invoke(new Action(() => listBoxLikePages.DisplayMember = "Name"));
            //listBoxLikePages.Items.Clear();
            //listBoxLikePages.DisplayMember = "Name";

            try
            {
                foreach (Page page in TheLoggedInUser.LikedPages)
                {
                    listBoxLikePages.Invoke(new Action(() => listBoxLikePages.Items.Add(page)));
                    //listBoxLikePages.Items.Add(page);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred!\nError details:\n" + ex.ToString());
            }


            if (listBoxLikePages.Items.Count == 0)
            {
                listBoxLikePages.Invoke(new Action(() => listBoxLikePages.Items.Add("No liked pages to retrieve")));
                //listBoxLikePages.Items.Add("No liked pages to retrieve");
            }
        }

        private void fetchTop5LikedPages()
        {
            listBoxTop5Pages.Invoke(new Action(() => listBoxTop5Pages.Items.Clear()));
            listBoxTop5Pages.Invoke(new Action(() => listBoxTop5Pages.DisplayMember = "Name"));
            //listBoxTop5Pages.Items.Clear();
            //listBoxTop5Pages.DisplayMember = "Name";

            try
            {
                Top5LikePages = new FeatureTop5LikePages(TheLoggedInUser);

                foreach (Page page in Top5LikePages.PageList)
                {
                    listBoxTop5Pages.Invoke(new Action(() => listBoxTop5Pages.Items.Add(page)));
                    //listBoxTop5Pages.Items.Add(page);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred!\nError details:\n" + ex.ToString());
            }

            if (listBoxTop5Pages.Items.Count == 0)
            {
                listBoxTop5Pages.Invoke(new Action(() => listBoxTop5Pages.Items.Add("No liked pages to retrieve")));
                //listBoxTop5Pages.Items.Add("No liked pages to retrieve");
            }
        }

        private void fetchMyEvents()
        {
            listBoxEvents.Invoke(new Action(() => listBoxEvents.Items.Clear()));
            listBoxEvents.Invoke(new Action(() => listBoxEvents.DisplayMember = "Name"));
            foreach (Event fbEvent in TheLoggedInUser.Events)
            {
                listBoxEvents.Invoke(new Action(() => listBoxEvents.Items.Add(fbEvent)));
                //listBoxEvents.Items.Add(fbEvent);
            }

            if (listBoxEvents.Items.Count == 0)
            {
                MessageBox.Show("No Events to retrieve :(");
            }

        }


        private void buttonFetchTop5Pages_Click(object sender, EventArgs e)
        {
            new Thread(fetchTop5LikedPages).Start();
            //fetchTop5LikedPages();
        }

        private void buttonFetchMyEvents_Click(object sender, EventArgs e)
        {
            new Thread(fetchMyEvents).Start();
            //fetchMyEvents();
        }

        private void buttonFetchFavoriteTeams_Click(object sender, EventArgs e)
        {
            new Thread(fetchFavoriteTeams).Start();
            //fetchFavoriteTeams();
        }

        private void buttonFetchLikePages_Click(object sender, EventArgs e)
        {
            new Thread(fetchLikePages).Start();
            //fetchLikePages();
        }

        private void buttonFetchPosts_Click(object sender, EventArgs e)
        {
            new Thread(fetchPosts).Start();
            //fetchPosts();
        }

        private void buttonFetchAlbums_Click(object sender, EventArgs e)
        {
            new Thread(fetchAlbums).Start();
            //fetchAlbums();
        }

   
    }
}
