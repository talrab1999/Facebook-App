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
        private FacebookWrapper.ObjectModel.User m_TheLoggedInUser = new FacebookWrapper.ObjectModel.User();

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
            "pages_read_engagement"
                );
          


         //   m_LoginResult = FacebookService.Connect("EAAIrH96LbjcBO8pgTpokr7qVKJehjlDMjhMFpYUujO1gf496YeA9DZADRLrFmxidrixK3Tf6tqAOpV7N2rSUu66T2lhoOeVkUxyRzoOykZB4QjbsUZCfs5U8mufpeooG7wkLOOfs3NCeVtH8iqr2PzpeXIRxkXURC89A682HgdMZB8G9ASfbiGTGb1hsMmKZAICCUoh9lMuMZD");

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
            fetchPosts();
            fetchAlbums();
            fetchFavoriteTeams();
            fetchLikePages();
        }

        private void fetchPosts()
        {
            listBoxPosts.Items.Clear();

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

            if (listBoxPosts.Items.Count == 0)
            {
                MessageBox.Show("No Posts to show");
            }
        }

        private void fetchAlbums()
        {
            listBoxAlbums.Items.Clear();

            foreach(Album album in m_TheLoggedInUser.Albums)
            {
                listBoxAlbums.Items.Add(album);
            }

            if (listBoxAlbums.Items.Count == 0)
            {
                listBoxAlbums.Items.Add("No Albums to retrieve");
            }
        }

        private void buttonPost_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(buttonPost.Text))
            {
                Status postedStatus = m_TheLoggedInUser.PostStatus(textBoxNewPost.Text);
                MessageBox.Show("Status Posted! ID: " + postedStatus.Id);
            }
            else 
            {
                MessageBox.Show("Can't post empty status, Please try again.");
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

            foreach (Page team in m_TheLoggedInUser.FavofriteTeams)
            {
                listBoxFavoriteTeams.Items.Add(team);
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
                pictureBoxFavoriteBox.LoadAsync(selectedTeam.PictureNormalURL);
            }
        }

        private void fetchLikePages() 
        {
            listBoxLikePages.Items.Clear();

            listBoxLikePages.DisplayMember = "Name";

            foreach (Page page in m_TheLoggedInUser.LikedPages)
            {
                listBoxLikePages.Items.Add(page);
            }
           

            if (listBoxLikePages.Items.Count == 0)
            {
                listBoxLikePages.Items.Add("No liked pages to retrieve");
            }
        }
    }
}
