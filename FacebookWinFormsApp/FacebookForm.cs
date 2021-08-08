using System;
using System.Drawing;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.Runtime.InteropServices;

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
          private readonly User m_LoggedInUser;

          private Button m_CurrentButton;
          private Form m_ActiveForm;
          public FacebbokForm(User i_LoggedInUser)
          {
               InitializeComponent();
               m_LoggedInUser = i_LoggedInUser;
               fetchUserInfo();
          }

          [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
          private extern static void ReleaseCapture();
          [DllImport("user32.DLL", EntryPoint = "SendMessage")]
          private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

          private void FcbForm_Load(object sender, EventArgs e){}
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
               openChildForm(new Forms.StatusForm(m_LoggedInUser), sender);
          }
          private void m_ButtonAlbums_Click(object sender, EventArgs e)
          {
               openChildForm(new Forms.AlbumsForm(m_LoggedInUser), sender);
          }
          private void m_buttonGroups_Click(object sender, EventArgs e)
          {
               openChildForm(new Forms.GroupsForm(m_LoggedInUser), sender);
          }
          private void m_ButtonPages_Click(object sender, EventArgs e)
          {
               openChildForm(new Forms.PagesForm(m_LoggedInUser), sender);
          }
          private void m_ButtonEvents_Click(object sender, EventArgs e)
          {
              openChildForm(new Forms.EventsForm(m_LoggedInUser), sender);
          }
          private void m_ButtonMyFeature1_Click(object sender, EventArgs e)
          {
               openChildForm(new Forms.DatingForm(m_LoggedInUser), sender);
          }
          private void m_buttonMyFeature2_Click(object sender, EventArgs e)
          {
               openChildForm(new Forms.BirthdayForm(m_LoggedInUser), sender);
          }
          private void m_ButtonLogout_Click(object sender, EventArgs e)
          {
               FacebookService.LogoutWithUI();
               this.Close();
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
     }
}
