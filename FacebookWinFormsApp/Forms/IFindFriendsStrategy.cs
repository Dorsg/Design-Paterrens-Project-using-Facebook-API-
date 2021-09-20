using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.Forms
{
     internal interface IFindFriendsStrategy
     {
          void GetFriends(User i_user, Control i_control);

     }
}
