using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.Forms
{
     public abstract class ScreensFactory
     {
          public abstract Form FactoryMethod(eScreenType i_ScreenType, User i_User);
     }
}
