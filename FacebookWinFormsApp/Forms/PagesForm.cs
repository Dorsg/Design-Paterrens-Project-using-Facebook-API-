using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.Runtime.InteropServices;

namespace BasicFacebookFeatures.Forms
{
     public partial class PagesForm : Form
     {
        private readonly User m_LoggedInUser;
        public PagesForm(User i_LoggedInUser)
        {
            m_LoggedInUser = i_LoggedInUser;
            InitializeComponent();
        }

        public void fetchLikedPages()
        {
             try
             {
                  this.Invoke(new Action(
                       () => pageBindingSource.DataSource = m_LoggedInUser.LikedPages ));
             }
             catch (Exception ex)
             {
                  MessageBox.Show(ex.Message);
             }

             if (m_LoggedInUser.LikedPages.Count == 0)
             {
                  MessageBox.Show("No liked pages to retrieve :( ");
             }
        }
     }
}
