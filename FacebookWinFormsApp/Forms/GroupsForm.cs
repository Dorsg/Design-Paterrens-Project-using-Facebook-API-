using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.Forms
{
     public partial class GroupsForm : Form
     {
          private readonly User m_LoggedInUser;
          public GroupsForm(User i_LoggedInUser)
          {
               m_LoggedInUser = i_LoggedInUser;
               InitializeComponent();
               fetchGroups();
          }

          private void fetchGroups()
          {
               m_ListBoxGroupList.Items.Clear();
               m_ListBoxGroupList.DisplayMember = "Name";

               try
               {
                    foreach (Group group in m_LoggedInUser.Groups)
                    {
                         m_ListBoxGroupList.Items.Add(group);
                    }
               }
               catch (Exception ex)
               {
                    MessageBox.Show(ex.Message);
               }

               if (m_ListBoxGroupList.Items.Count == 0)
               {
                    m_LabelGroupPic.Text = "no data :(";
               }
          }

          private void m_ListBoxAlbumList_SelectedIndexChanged(object sender, EventArgs e)
          {
               if (m_ListBoxGroupList.SelectedItems.Count == 1)
               {
                    Group selectedGroup = m_ListBoxGroupList.SelectedItem as Group;
                    m_PictureBoxGroups.LoadAsync(selectedGroup.PictureNormalURL);
               }
          }
     }
}
