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
     public partial class FcbForm : Form
     {
          User m_LoggedInUser;
          public FcbForm(User i_LoggedInUser)
          {
               InitializeComponent();
               m_LoggedInUser = i_LoggedInUser;
               fetchUserInfo();
               this.Text = $"Logged in as {m_LoggedInUser.Name}";
          }

          private void FcbForm_Load(object sender, EventArgs e)
          {

          }

          private void fetchUserInfo()
          {
               pictureBoxProfile.Image = m_LoggedInUser.ImageLarge;
               //if (m_LoggedInUser.Posts.Count > 0)
               //{
               //     textBoxStatus.Text = m_LoggedInUser.Posts[0].Message;
               //}
          }

          private void label1_Click(object sender, EventArgs e)
          {

          }

          private void pictureBoxProfile_Click(object sender, EventArgs e)
          {

          }

          private void label_Name_Click(object sender, EventArgs e)
          {

          }
     }
}
