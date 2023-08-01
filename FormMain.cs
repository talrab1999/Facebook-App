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

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 25;
        }

        FacebookWrapper.LoginResult m_LoginResult;
        FacebookWrapper.ObjectModel.User m_TheLoggedInUser = new FacebookWrapper.ObjectModel.User();

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
                textBoxAppID.Text,
                /// requested permissions:
                "email",
                "public_profile"

    


                /// add any relevant permissions
                );

            if (string.IsNullOrEmpty(m_LoginResult.ErrorMessage))
            { 
                m_TheLoggedInUser = m_LoginResult.LoggedInUser;
                buttonLogin.Text = $"Logged in as {m_TheLoggedInUser.Name}";
                buttonLogin.BackColor = Color.LightGreen;
                pictureBoxProfile.ImageLocation = m_TheLoggedInUser.PictureNormalURL;
                buttonLogin.Enabled = false;
                buttonLogout.Enabled = true;
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


    }
}
