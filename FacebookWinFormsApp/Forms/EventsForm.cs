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
     public partial class EventsForm : Form
     {
        private readonly User m_LoggedInUser;
        public EventsForm(User i_LoggedInUser)
        {
            m_LoggedInUser = i_LoggedInUser;
            InitializeComponent();
            fetchEvents();
        }

        private void fetchEvents()
        {

            if (m_LoggedInUser.Events.Count != 0) 
            {
                  eventBindingSource.DataSource = m_LoggedInUser.Events;
            }
            else
            {
                 MessageBox.Show("no event to show");
            }
             
        }

        //private void listBoxEvents_SelectedIndexChanged(object sender, EventArgs e)
               //{
               //    if (listBoxEvents.SelectedItems.Count == 1)
               //    {
               //        Event selectedEvent = listBoxEvents.SelectedItem as Event;
               //        m_EventBox.LoadAsync(selectedEvent.Cover.SourceURL);
               //    }
               //}

          }
}
