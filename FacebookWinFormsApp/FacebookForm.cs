using System;
using System.Drawing;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.Runtime.InteropServices;
using System.Threading;
using BasicFacebookFeatures.Forms;

// features explanations:
// feature 1:
// find all of my single friends with a different gender than me and display them on a list
// with their profile picture, age, city + map
// feature 2:
// find all of my friends that are celebrating their birthday today and display them on a list
// with an ability to post an "happy birthday!" status on their page

namespace BasicFacebookFeatures
{
     public partial class FacebbokForm : Form
     {
          private User m_LoggedInUser;
          private AppSettingsSingleton m_AppSettingsSingleton;
          private ConcreteScreenFactory m_ScreenFactory;
          private Button m_CurrentButton;
          private Form m_ActiveForm;
          private LoginResult m_LoginResult;
          public FacebbokForm()
          {
               InitializeComponent();
               m_AppSettingsSingleton = AppSettingsSingleton.LoadFromFile();
               m_ScreenFactory = new ConcreteScreenFactory();
               this.m_CheckBoxRemmberMe.Checked = m_AppSettingsSingleton.m_RememberUser;

          }

          [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
          private extern static void ReleaseCapture();
          [DllImport("user32.DLL", EntryPoint = "SendMessage")]
          private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

          private void FcbForm_Load(object sender, EventArgs e) { }
          private void fetchUserInfo()
          {
               m_LabelTitle.Text = "Facebook";
               pictureBoxProfile.Image = m_LoggedInUser.ImageLarge;
               m_LabelName.Text = "Name: " + m_LoggedInUser.Name;
               m_LabelBirthday.Text = "Birthday: " + m_LoggedInUser.Birthday;
               m_LabelGender.Text = "Gender: " + m_LoggedInUser.Gender;
               m_LabelEmail.Text = "Email: " + m_LoggedInUser.Email;
               this.Text = string.Empty;

          }
          private void ActivateButton(object btnSender)
          {
               if (btnSender != null)
               {
                    if (m_CurrentButton != (Button)btnSender)
                    {
                         disableButton();
                         Color color = ColorTranslator.FromHtml("#BCC0C4");
                         m_CurrentButton = (Button)btnSender;
                         m_CurrentButton.BackColor = color;
                         m_CurrentButton.ForeColor = Color.Black;

                         m_CurrentButton.Font = new System.Drawing.Font("Microsoft Sans Serif",
                              11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,
                              ((byte)(0)));
                    }
               }

          }
          private void disableButton()
          {
               foreach (Control previousBtn in m_PanelMenu.Controls)
               {
                    if (previousBtn.GetType() == typeof(Button))
                    {
                         previousBtn.BackColor = Color.FromArgb(240, 242, 245);
                         previousBtn.ForeColor = Color.Black;
                         previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    }
               }
          }
          private void openChildForm(Form childForm, object btnSender)
          {
               if (m_ActiveForm != null)
               {
                    m_ActiveForm.Close();
               }

               ActivateButton(btnSender);
               m_ActiveForm = childForm;
               childForm.TopLevel = false;
               childForm.FormBorderStyle = FormBorderStyle.None;
               childForm.Dock = DockStyle.Fill;
               m_PanelDesktop.Controls.Add(childForm);
               m_PanelDesktop.Tag = childForm;
               childForm.BringToFront();
               childForm.Show();
               m_LabelTitle.Text = childForm.Text;
          }
          private void m_ButtonStatus_Click(object sender, EventArgs e)
          {
               Form statusForm = m_ScreenFactory.FactoryMethod(eScreenType.StatusForm, m_LoggedInUser);
               openChildForm(statusForm as StatusForm, sender);
               new Thread((statusForm as StatusForm).fetchPosts).Start();
          }
          private void m_ButtonAlbums_Click(object sender, EventArgs e)
          {
               Form albumsForm = m_ScreenFactory.FactoryMethod(eScreenType.AlbumsForm, m_LoggedInUser);
               openChildForm(albumsForm, sender);
               new Thread((albumsForm as AlbumsForm).fetchAlbums).Start();
          }
          private void m_buttonGroups_Click(object sender, EventArgs e)
          {
               Form groupForm = m_ScreenFactory.FactoryMethod(eScreenType.GroupsForm, m_LoggedInUser);
               openChildForm(groupForm, sender);
          }
          private void m_ButtonPages_Click(object sender, EventArgs e)
          {
               Form pagesForm = m_ScreenFactory.FactoryMethod(eScreenType.PagesForm, m_LoggedInUser);
               openChildForm(pagesForm, sender);
               new Thread((pagesForm as PagesForm).fetchLikedPages).Start();
          }
          private void m_ButtonEvents_Click(object sender, EventArgs e)
          {
               Form eventForm = m_ScreenFactory.FactoryMethod(eScreenType.EventsForm, m_LoggedInUser);
               openChildForm(eventForm, sender);
          }
          private void m_ButtonMyFeature1_Click(object sender, EventArgs e)
          {
               Form datingForm = m_ScreenFactory.FactoryMethod(eScreenType.DatingForm, m_LoggedInUser);
               openChildForm(datingForm, sender);
          }
          private void m_buttonMyFeature2_Click(object sender, EventArgs e)
          {
               Form birthdayForm = m_ScreenFactory.FactoryMethod(eScreenType.BirthdaysForm, m_LoggedInUser);
               openChildForm(birthdayForm, sender);
          }
          private void m_ButtonLogout_Click(object sender, EventArgs e)
          {
               FacebookService.LogoutWithUI();
               m_ButtonLogIn.Text = "Login";
          }
          private void m_TtilePanel_MouseDown(object sender, MouseEventArgs e)
          {
               ReleaseCapture();
               SendMessage(this.Handle, 0x112, 0xf012, 0);
          }
          private void m_PanelDesktop_MouseDown(object sender, MouseEventArgs e)
          {
               ReleaseCapture();
               SendMessage(this.Handle, 0x112, 0xf012, 0);
          }

          private void m_ButtonLogIn_Click(object sender, EventArgs e)
          {

               if (m_AppSettingsSingleton.m_RememberUser && !string.IsNullOrEmpty(m_AppSettingsSingleton.m_LastAccessToken))
               {
                    m_LoginResult = FacebookService.Connect(m_AppSettingsSingleton.m_LastAccessToken);
                    m_AppSettingsSingleton.SaveToFile();
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

                    m_AppSettingsSingleton.m_LastAccessToken = null;
               }

               if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
               {
                    m_AppSettingsSingleton.m_LastAccessToken = m_LoginResult.AccessToken;
                    m_LoggedInUser = m_LoginResult.LoggedInUser;
                    m_ButtonLogIn.Text = "Logged in";
                    fetchUserInfo();
               }
               else
               {
                    MessageBox.Show(m_LoginResult.ErrorMessage, "Login Failed");
               }
          }

          private void m_CheckBoxRemmberMe_CheckedChanged(object sender, EventArgs e)
          {
               m_AppSettingsSingleton.m_RememberUser = m_CheckBoxRemmberMe.Checked;
          }

          protected override void OnClosed(EventArgs e)
          {
               m_AppSettingsSingleton.SaveToFile();
               base.OnClosed(e);
          }
     }
}
