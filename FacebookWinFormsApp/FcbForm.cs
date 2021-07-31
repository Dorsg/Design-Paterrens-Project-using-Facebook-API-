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
using System.Runtime.InteropServices;

namespace BasicFacebookFeatures
{
     public partial class FcbForm : Form
     {
          User m_LoggedInUser;

          private Button m_CurrentButton;
          private Form m_ActiveForm;
          public FcbForm(User i_LoggedInUser)
          {
               InitializeComponent();
               m_LoggedInUser = i_LoggedInUser;
               fetchUserInfo();         
               
          }
          [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
          private extern static void ReleaseCapture();
          [DllImport("user32.DLL", EntryPoint = "SendMessage")]
          private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


          private void FcbForm_Load(object sender, EventArgs e)
          {

          }

          private void fetchUserInfo()
          {
               m_LabelTitle.Text = "Facebook";
               //m_LabelTitle.Text = $"Facebook | Logged in as {m_LoggedInUser.Name}";
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
                         Color color = ColorTranslator.FromHtml("#166ADA");
                         m_CurrentButton = (Button)btnSender;
                         m_CurrentButton.BackColor = color;
                         m_CurrentButton.ForeColor = Color.White;
                         m_CurrentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));


                    }
               }
          }

          private void disableButton()
          {
               foreach (Control previousBtn in m_PanelMenu.Controls)
               {
                    if (previousBtn.GetType() == typeof(Button))
                    {
                         previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                         previousBtn.ForeColor = Color.Gainsboro;
                         previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    }
               }
          }

          private void OpenChildForm(Form childForm, object btnSender)
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
               OpenChildForm(new Forms.StatusForm(m_LoggedInUser), sender);
          }

          private void m_ButtonAlbums_Click(object sender, EventArgs e)
          {
               OpenChildForm(new Forms.AlbumsForm(m_LoggedInUser), sender);
          }

          private void m_buttonGroups_Click(object sender, EventArgs e)
          {
               OpenChildForm(new Forms.GroupsForm(m_LoggedInUser), sender);
          }

          private void m_ButtonPages_Click(object sender, EventArgs e)
          {
               OpenChildForm(new Forms.PagesForm(), sender);
          }

          private void m_ButtonEvents_Click(object sender, EventArgs e)
          {
               OpenChildForm(new Forms.EventsForm(), sender);
          }

          private void m_ButtonMyFeature1_Click(object sender, EventArgs e)
          {
               OpenChildForm(new Forms.DatingForm(m_LoggedInUser), sender);
          }

          private void m_buttonMyFeature2_Click(object sender, EventArgs e)
          {
               //OpenChildForm(new Forms.StatusForm(), sender);
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
