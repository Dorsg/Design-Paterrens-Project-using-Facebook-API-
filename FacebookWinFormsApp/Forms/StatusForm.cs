using FacebookWrapper.ObjectModel;
using System;
using System.Threading;
using System.Windows.Forms;

namespace BasicFacebookFeatures.Forms
{
     public partial class StatusForm : Form
     {
          private readonly User m_LoggedInUser;
          public StatusForm(User i_LoggedInUser)
          {
               m_LoggedInUser = i_LoggedInUser;
               InitializeComponent();
              // fetchPosts();
               
          }
          public void fetchPosts()
          {
               try
               {
                  //  postBindingSource.DataSource = m_LoggedInUser.Posts;
                     this.Invoke(new Action(
                       () => postBindingSource.DataSource = m_LoggedInUser.Posts ));

               }
               catch (Exception ex)
               {
                    MessageBox.Show(ex.Message);
               }

               if (m_LoggedInUser.Posts.Count == 0)
               {
                    MessageBox.Show("No posts to retrieve :( ");
               }
          }
          private void m_ButtonPost_Click(object sender, EventArgs e)
          {
               try
               {
                    Status postedStatus = m_LoggedInUser.PostStatus(m_TextBoxPost.Text);
                    MessageBox.Show("Status Posted! ID: " + postedStatus.Id);
               }
               catch (Exception ex)
               {
                    MessageBox.Show(ex.ToString());
               }
          }
     }
}
