using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures.Forms
{
     public partial class AlbumsForm : Form
     {
          User m_LoggedInUser;
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
               foreach (Album album in m_LoggedInUser.Albums)
               {
                    m_ListBoxAlbumList.Items.Add(album);
                    //album.ReFetch(DynamicWrapper.eLoadOptions.Full);
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
