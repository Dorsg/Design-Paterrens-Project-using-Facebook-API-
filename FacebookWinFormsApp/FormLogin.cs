using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
     public partial class FormLogin : Form
     {
          private User m_LoggedInUser;
          private LoginResult m_LoginResult;
          private FacebbokForm m_MainForm;
          private FormAppSettings m_FormAppSettings;

          public FormLogin()
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
                    m_MainForm = new FacebbokForm(m_LoggedInUser);
                    m_MainForm.ShowDialog();
                    m_LoginResult = null;
               }
               else
               {
                    MessageBox.Show(m_LoginResult.ErrorMessage, "Login Failed");
               }


          }
          private void FormMain_Load(object sender, EventArgs e)
          {

          }
          private void m_ButtonLoginSetting_Click(object sender, EventArgs e)
          {
               if (m_FormAppSettings == null)
               {
                    m_FormAppSettings = new FormAppSettings();
               }
               m_FormAppSettings.ShowDialog();
          }

     }
     public static class AppSettings
     {
          public static string s_AppID = "1450160541956417"; /// (desig patter's "Design Patterns Course App 2.4" app)
          public static string[] s_Permissions =  {
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
                                                            "user_videos"

                                                       };
     }
}
