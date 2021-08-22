using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.Forms
{
     public class ConcreteScreenFactory : ScreensFactory
     {
          public override Form FactoryMethod(eScreenType i_ScreenType, User i_User)
          {
               Form screenForm = new Form();

               try
               {
                    switch (i_ScreenType)
                    {
                         case eScreenType.AlbumsForm:
                              screenForm = new AlbumsForm(i_User);
                              break;
                         case eScreenType.BirthdaysForm:
                              screenForm = new BirthdayForm(i_User);
                              break;
                         case eScreenType.DatingForm:
                              screenForm = new DatingForm(i_User);
                              break;
                         case eScreenType.EventsForm:
                              screenForm = new EventsForm(i_User);
                              break;
                         case eScreenType.PagesForm:
                              screenForm = new PagesForm(i_User);
                              break;
                         case eScreenType.GroupsForm:
                              screenForm = new GroupsForm(i_User);
                              break;
                         case eScreenType.StatusForm:
                              screenForm = new StatusForm(i_User);
                              break;
                    }
               }
               catch (Exception ex)
               {
                    MessageBox.Show(ex.Message);
               }

               return screenForm;
          }
     }
}
