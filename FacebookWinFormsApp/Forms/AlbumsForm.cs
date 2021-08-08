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
               m_ListBoxAlbumList.Items.Clear();
               m_ListBoxAlbumList.DisplayMember = "Name";

               try
               {

                    foreach(Album album in m_LoggedInUser.Albums)
                    {
                         m_ListBoxAlbumList.Items.Add(album);
                    }
               }
               catch(Exception ex)
               {
                    MessageBox.Show(ex.ToString());
               }

               if (m_ListBoxAlbumList.Items.Count == 0)
               {
                    MessageBox.Show("No Albums to retrieve :(");
               }
          }

          private void displaySelectedAlbum()
          {
               if (m_ListBoxAlbumList.SelectedItems.Count == 1)
               {
                    Album selectedAlbum = m_ListBoxAlbumList.SelectedItem as Album;
                    if (selectedAlbum.PictureAlbumURL != null)
                    {
                         m_PictureBox.LoadAsync(selectedAlbum.PictureAlbumURL);
                    }
                    else
                    {
                        // m_PictureBox.Image = pictureBoxProfile.ErrorImage;
                    }
               }
          }

          private void m_ListBoxAlbumList_SelectedIndexChanged(object sender, EventArgs e)
          {
               displaySelectedAlbum();
          }
     }
}
