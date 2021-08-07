﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp.WinForms.Internals;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.Forms
{
     public partial class DatingForm : Form
     {
          private readonly User m_LoggedInUser;
          public DatingForm(User i_LoggedInUser)
          {
               m_LoggedInUser = i_LoggedInUser;
               InitializeComponent();
               fetchSingles();
          }

          private void fetchSingles()
          {
               m_ListBoxSingles.Items.Clear();
               m_ListBoxSingles.DisplayMember = "Name";

               foreach (User user in m_LoggedInUser.Friends)
               {
                    
                    if (user.Gender != m_LoggedInUser.Gender && 
                        user.RelationshipStatus == User.eRelationshipStatus.Single)
                    {
                         m_ListBoxSingles.Items.Add(user);
                    }
                    
               }

               if (m_ListBoxSingles.Items.Count == 0)
               {
                    MessageBox.Show("No Singles to retrieve :(");
               }
          }

          private void displaySelectedSingleImage()
          {
               if (m_ListBoxSingles.SelectedItems.Count == 1)
               {
                    User user = m_ListBoxSingles.SelectedItem as User;
               
                    m_PictureBoxSinglePic.Image = user.ImageLarge;
                         
                
               }
          }
          private void displaySelectedSingleDetails()
          {
               if (m_ListBoxSingles.SelectedItems.Count == 1)
               {
                    User user = m_ListBoxSingles.SelectedItem as User;

                    DateTime birthDay = Convert.ToDateTime(user.Birthday);

                    m_LabelAge.Text = calculateAge(birthDay);

                    m_LabelLocation.Text = user.Location.Name;

               }
          }
          private void displaySelectedSingleMap()
          {
               if (m_ListBoxSingles.SelectedItems.Count == 1)
               {
                    User user = m_ListBoxSingles.SelectedItem as User;
                    
                    if (user.Location != null)
                    {
                         
                         string address = "https://maps.google.com/maps?q=" + user.Location.Name;
                         m_WebBrowserMap.Navigate(address);
                    }


               }
          }

          private string calculateAge(DateTime Dob)
          {
               int year = new DateTime(DateTime.Now.Subtract(Dob).Ticks).Year - 1;

               return "Age: " + year;

          }

          private void m_ListBoxSingles_SelectedIndexChanged(object sender, EventArgs e)
          {
               displaySelectedSingleImage();
               displaySelectedSingleDetails();
               displaySelectedSingleMap();
          }
     }
}
