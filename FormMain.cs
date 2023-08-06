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

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 25;
        }

        private FacebookWrapper.LoginResult m_LoginResult;
        private FacebookWrapper.ObjectModel.User m_TheLoggedInUser;

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("design.patterns");

            if (m_LoginResult == null)
            {
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
          


           m_LoginResult = FacebookService.Connect("EAAIrH96LbjcBO0iwwqb8jHIEGPavdqE4HT69ed6IZCn2nZBWeOfNTDjDjk2FBpIpybdtXjZBHwObGlil2CKCdvaZAGf2hsrKQPSXGBPGb8xEG46Bvc4i8YbiP3y5TWAXoGtWQoZAxUa8TIOYuHXIlIPk6sHlW08tljqp8VtNhVvJbOo3KHzCWjxvZACiwe");

            if (string.IsNullOrEmpty(m_LoginResult.ErrorMessage))
            { 
                m_TheLoggedInUser = m_LoginResult.LoggedInUser;
                buttonLogin.Enabled = false;
                buttonLogout.Enabled = true;
                fetchUserInfo();
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI();
            buttonLogin.Text = "Login";
            buttonLogin.BackColor = buttonLogout.BackColor;
            m_LoginResult = null;
            buttonLogin.Enabled = true;
            buttonLogout.Enabled = false;
        }

        private void fetchUserInfo()
        {
            buttonLogin.Text = $"Logged in as {m_TheLoggedInUser.Name}";
            buttonLogin.BackColor = Color.LightGreen;
            pictureBoxProfile.ImageLocation = m_TheLoggedInUser.PictureNormalURL;
            loadUI();
        }

        private void loadUI()
        {
            fetchPosts();
            fetchAlbums();
            fetchFavoriteTeams();
            fetchLikePages();
        }

        private void fetchPosts()
        {
            listBoxPosts.Items.Clear();
            try
            {
                foreach (Post post in m_TheLoggedInUser.Posts)
                {
                    if (post.Message != null)
                    {
                        listBoxPosts.Items.Add(post.Message);
                    }
                    else if (post.Caption != null)
                    {
                        listBoxPosts.Items.Add(post.Caption);
                    }
                    else
                    {
                        listBoxPosts.Items.Add(string.Format("[{0}]", post.Type));
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
            listBoxAlbums.Items.Clear();

            try
            {
                foreach (Album album in m_TheLoggedInUser.Albums)
                {
                    listBoxAlbums.Items.Add(album);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred!\nError details:\n" + ex.ToString());
            }

            if (listBoxAlbums.Items.Count == 0)
            {
                listBoxAlbums.Items.Add("No Albums to retrieve");
            }
        }

        private void buttonPost_Click(object sender, EventArgs e)
        {

            if (m_TheLoggedInUser != null)
            {
                if (!checkBoxScheduledPost.Checked)
                {
                    try
                    {
                        Status postedStatus = m_TheLoggedInUser.PostStatus(textBoxNewPost.Text);
                        MessageBox.Show("Status Posted! ID: " + postedStatus.Id);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error occurred!\nError details:\n" + ex.ToString());
                    }
                }
                else
                {
                    scheduledPost();
                }
            }
            else
            {
                MessageBox.Show("You need to be logged in to post!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    
        private void scheduledPost()
        {
            try
            {
                DateTime currentTime = DateTime.UtcNow;
                int day = (int)numericUpDownDay.Value;
                int month = (int)numericUpDownMonth.Value;
                int year = (int)numericUpDownYear.Value;
                int hour = (int)numericUpDownHour.Value;
                int minute = (int)numericUpDownMinute.Value;

                DateTime scheduledTime = new DateTime(year, month, day, hour, minute, 0, DateTimeKind.Utc);

                if(scheduledTime < currentTime)
                {
                    throw new Exception("Please enter a future date !");
                }
                else
                {
                    string scheduledTimeIso = scheduledTime.ToString("yyyy-MM-ddTHH:mm:sszzz");
                    string parameters = $"scheduled_publish_time, {scheduledTimeIso}";
                    m_TheLoggedInUser.PostStatus(textBoxNewPost.Text, parameters);
                    MessageBox.Show($"Status will be Post in: {day}/{month}/{year}, {hour}:{minute}!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred!\nError details:\n" + ex.ToString());
            }
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

        private void fetchFavoriteTeams()
        {
            listBoxFavoriteTeams.Items.Clear();
            listBoxFavoriteTeams.DisplayMember = "Name";

            try
            {
                foreach (Page team in m_TheLoggedInUser.FavofriteTeams)
                {
                    listBoxFavoriteTeams.Items.Add(team);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred!\nError details:\n" + ex.ToString());
            }

            if (listBoxFavoriteTeams.Items.Count == 0)
            {
                listBoxFavoriteTeams.Items.Add("No teams to retrieve :(");
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

        private void fetchLikePages() 
        {
            listBoxLikePages.Items.Clear();

            listBoxLikePages.DisplayMember = "Name";

            try
            {
                foreach (Page page in m_TheLoggedInUser.LikedPages)
                {
                    listBoxLikePages.Items.Add(page);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred!\nError details:\n" + ex.ToString());
            }


            if (listBoxLikePages.Items.Count == 0)
            {
                listBoxLikePages.Items.Add("No liked pages to retrieve");
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

        private void fetchTop5LikedPages()
        {
            listBoxTop5Pages.Items.Clear();
            listBoxTop5Pages.DisplayMember = "Name";
            List<Page> pageList = new List<Page>();

            try
            {
                if (m_TheLoggedInUser != null)
                {
                    foreach (Page page in m_TheLoggedInUser.LikedPages)
                    {
                        if (pageList.Count < 5)
                        {
                            pageList.Add(page);
                        }
                        else
                        {
                            foreach (Page topPage in pageList)
                            {
                                if (page.LikesCount > topPage.LikesCount)
                                {
                                    pageList.Add(topPage);
                                    pageList.Remove(topPage);
                                }
                            }
                        }
                    }

                    foreach (Page topPage in pageList)
                    {
                        listBoxTop5Pages.Items.Add(topPage);
                    }


                }
                else
                {
                    MessageBox.Show("You need to be logged in to post!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred!\nError details:\n" + ex.ToString());
            }


            if (listBoxTop5Pages.Items.Count == 0)
            {
                listBoxTop5Pages.Items.Add("No liked pages to retrieve");
            }
        }

        private void buttonFetchTop5Pages_Click(object sender, EventArgs e)
        {
            fetchTop5LikedPages();
        }

        private void listBoxTop5Pages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxTop5Pages.SelectedItems.Count == 1)
            {
                Page selectedTeam = listBoxTop5Pages.SelectedItem as Page;
                pictureBoxTop5Photos.LoadAsync(selectedTeam.PictureNormalURL);
            }
        }
    }
}
