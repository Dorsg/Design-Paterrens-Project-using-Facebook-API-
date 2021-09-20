using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures.Forms
{
     public class FindSingleFriendsStrategy : IFindFriendsStrategy
     {

          public void GetFriends(User i_user, Control i_control)
          {
               ListBox ListBoxSingles = i_control as ListBox;
               

               ListBoxSingles.Items.Clear();
               ListBoxSingles.DisplayMember = "Name";
               try
               {
                    foreach (User user in i_user.Friends)
                    {
                         if (user.Gender != i_user.Gender
                             && user.RelationshipStatus == User.eRelationshipStatus.Single)
                         {
                              ListBoxSingles.Items.Add(user);
                         }

                    }
               }
               catch (Exception ex)
               {
                    MessageBox.Show(ex.ToString());
               }

               if (ListBoxSingles.Items.Count == 0)
               {
                    MessageBox.Show("No Singles to retrieve :(");
               }
          }
     }
}
