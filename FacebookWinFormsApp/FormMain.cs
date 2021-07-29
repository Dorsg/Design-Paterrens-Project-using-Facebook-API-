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
          User m_LoggedInUser;
          LoginResult m_LoginResult;
          FcbForm m_MainForm;

          public FormMain()
          {
               InitializeComponent();
               FacebookWrapper.FacebookService.s_CollectionLimit = 100;
          }

          private void buttonLogin_Click(object sender, EventArgs e)
          {
               Clipboard.SetText("design.patterns20cc"); /// the current password for Desig Patter

               m_LoginResult = FacebookService.Login(
                    /// (This is Desig Patter's App ID. replace it with your own)
                    "2932466203680140",
                    /// requested permissions:
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
                   "user_videos");

               if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
               {
                    m_LoggedInUser = m_LoginResult.LoggedInUser;
                    //buttonLogin.Text = $"Logged in as {m_LoginResult.LoggedInUser.Name}";
                    //buttonLogin.Hide();
                    //fetchUserInfo();
                    //loadName();
                    
                    m_MainForm = new FcbForm(m_LoggedInUser);
                 
                    m_MainForm.ShowDialog();

               }
               else
               {
                    MessageBox.Show(m_LoginResult.ErrorMessage, "Login Failed");
               }

               
          }

          private void buttonLogout_Click(object sender, EventArgs e)
          {
               FacebookService.LogoutWithUI();
               //buttonLogin.Text = "Login";
          }
          
          private void pictureBox2_Click(object sender, EventArgs e)
          {

          }

          private void FormMain_Load(object sender, EventArgs e)
          {

          }
     }
}
