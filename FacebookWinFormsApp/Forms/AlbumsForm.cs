using FacebookWrapper.ObjectModel;
using System;
using System.Windows.Forms;

namespace BasicFacebookFeatures.Forms
{
     public partial class AlbumsForm : Form
     {
          private readonly User m_LoggedInUser;
          public AlbumsForm(User i_LoggedInUser)
          {
               m_LoggedInUser = i_LoggedInUser;
               InitializeComponent();
               fetchAlbums();
          }
          private void fetchAlbums()
          {
               try
               {
                    albumBindingSource.DataSource = m_LoggedInUser.Albums;
               }
               catch(Exception ex)
               {
                    MessageBox.Show(ex.Message);
               }

               if (m_LoggedInUser.Albums.Count == 0)
               {
                    MessageBox.Show("No albums  to retrieve :( ");
               }
          }
     }


     
}
