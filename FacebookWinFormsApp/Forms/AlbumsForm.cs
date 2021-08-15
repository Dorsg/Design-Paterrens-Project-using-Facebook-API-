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
               albumBindingSource.DataSource = m_LoggedInUser.Albums;
          }

          //private void displaySelectedAlbum()
          //{
          //     if (m_ListBoxAlbumList.SelectedItems.Count == 1)
          //     {
          //          Album selectedAlbum = m_ListBoxAlbumList.SelectedItem as Album;
          //          if (selectedAlbum.PictureAlbumURL != null)
          //          {
          //               m_PictureBox.LoadAsync(selectedAlbum.PictureAlbumURL);
          //          }
          //          else
          //          {
          //              // m_PictureBox.Image = pictureBoxProfile.ErrorImage;
          //          }
          //     }
          //}

          //private void m_ListBoxAlbumList_SelectedIndexChanged(object sender, EventArgs e)
          //{
          //     displaySelectedAlbum();
          //}
     }
}
