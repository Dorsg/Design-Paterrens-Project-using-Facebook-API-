using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
     public class LoginFacade
     {
          protected LoginResult m_LoginResult;

          public LoginFacade()
          {
               m_LoginResult = new LoginResult();
          }

          public bool CanLogin(ref User i_LoggedInUser, AppSettingsSingleton i_AppSettingsSingleton)
          {
               if (i_AppSettingsSingleton.m_RememberUser && !string.IsNullOrEmpty(i_AppSettingsSingleton.m_LastAccessToken))
               {
                    m_LoginResult = FacebookService.Connect(i_AppSettingsSingleton.m_LastAccessToken);
                    i_AppSettingsSingleton.SaveToFile();
               }
               else
               {
                    m_LoginResult = FacebookService.Login(
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

                    i_AppSettingsSingleton.m_LastAccessToken = null;
               }

               if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
               {
                    i_AppSettingsSingleton.m_LastAccessToken = m_LoginResult.AccessToken;
                    i_LoggedInUser = m_LoginResult.LoggedInUser;
                    return true;
               }
               else
               {
                    return false;
               }
          }
     }
}
