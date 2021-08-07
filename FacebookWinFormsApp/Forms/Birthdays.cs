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
    public class BirthdayForm : Form
    {
        private Label m_LabelLocation;
        private Label m_LabelAge;
        private PictureBox m_PictureBoxFriendPic;
        private ListBox m_ListBirthdayFriends;
        private Button buttonSetStatus;
        private readonly User m_LoggedInUser;
        public BirthdayForm(User i_LoggedInUser)
        {
            m_LoggedInUser = i_LoggedInUser;
            InitializeComponent();
            fetchBirthdayFriends();
            buttonSetStatus.Hide();
        }
        private void fetchBirthdayFriends()
        {
            m_ListBirthdayFriends.Items.Clear();
            m_ListBirthdayFriends.DisplayMember = "Name";
            //string current_day = DateTime.Today.Day.ToString();
            //string current_month = DateTime.Today.Month.ToString();
            string current_day = "26";
            string current_month = "08";
            string[] words = current_day.Split('/');
            string show = words[0];

            foreach (User user in m_LoggedInUser.Friends)
            {
                string birthday = user.Birthday;
                string[] birthday_parts = birthday.Split('/');
                if (birthday_parts[1] == current_day && birthday_parts[0] == current_month)
                {
                     m_ListBirthdayFriends.Items.Add(user);
                }
            }

            if (m_ListBirthdayFriends.Items.Count == 0)
            {
                MessageBox.Show("No friends with birthday today to retrieve :(");
            }
        }

        private void displaySelectedBirthdayFriendImage()
        {
            if (m_ListBirthdayFriends.SelectedItems.Count == 1)
            {
                User user = m_ListBirthdayFriends.SelectedItem as User;

                m_PictureBoxFriendPic.Image = user.ImageLarge;


            }
        }

        private void displaySelectedBirthdayFriendPostBox()
        {
            if (m_ListBirthdayFriends.SelectedItems.Count == 1)
            {
                User user = m_ListBirthdayFriends.SelectedItem as User;

                buttonSetStatus.Show();

            }
        }
        private void displaySelectedBirthdayFriendDetails()
        {
            if (m_ListBirthdayFriends.SelectedItems.Count == 1)
            {
                User user = m_ListBirthdayFriends.SelectedItem as User;

                DateTime birthDay = Convert.ToDateTime(user.Birthday);

                m_LabelAge.Text = calculateAge(birthDay);

                m_LabelLocation.Text = user.Location.Name;

            }
        }

        private string calculateAge(DateTime Dob)
        {
            DateTime Now = DateTime.Now;
            int Years = new DateTime(DateTime.Now.Subtract(Dob).Ticks).Year - 1;
            DateTime PastYearDate = Dob.AddYears(Years);

            return String.Format("Age: {0}", Years);

        }
        private void InitializeComponent()
        {
               this.m_LabelLocation = new System.Windows.Forms.Label();
               this.m_LabelAge = new System.Windows.Forms.Label();
               this.m_PictureBoxFriendPic = new System.Windows.Forms.PictureBox();
               this.m_ListBirthdayFriends = new System.Windows.Forms.ListBox();
               this.buttonSetStatus = new System.Windows.Forms.Button();
               ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxFriendPic)).BeginInit();
               this.SuspendLayout();
               // 
               // m_LabelLocation
               // 
               this.m_LabelLocation.AutoSize = true;
               this.m_LabelLocation.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.m_LabelLocation.Location = new System.Drawing.Point(157, 174);
               this.m_LabelLocation.Name = "m_LabelLocation";
               this.m_LabelLocation.Size = new System.Drawing.Size(98, 14);
               this.m_LabelLocation.TabIndex = 7;
               this.m_LabelLocation.Text = "m_LabelLocation";
               // 
               // m_LabelAge
               // 
               this.m_LabelAge.AutoSize = true;
               this.m_LabelAge.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.m_LabelAge.Location = new System.Drawing.Point(157, 153);
               this.m_LabelAge.Name = "m_LabelAge";
               this.m_LabelAge.Size = new System.Drawing.Size(73, 14);
               this.m_LabelAge.TabIndex = 6;
               this.m_LabelAge.Text = "m_LabelAge";
               // 
               // m_PictureBoxFriendPic
               // 
               this.m_PictureBoxFriendPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
               this.m_PictureBoxFriendPic.Location = new System.Drawing.Point(160, 12);
               this.m_PictureBoxFriendPic.Name = "m_PictureBoxFriendPic";
               this.m_PictureBoxFriendPic.Size = new System.Drawing.Size(173, 135);
               this.m_PictureBoxFriendPic.TabIndex = 5;
               this.m_PictureBoxFriendPic.TabStop = false;
               // 
               // m_ListBirthdayFriends
               // 
               this.m_ListBirthdayFriends.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.m_ListBirthdayFriends.FormattingEnabled = true;
               this.m_ListBirthdayFriends.ItemHeight = 18;
               this.m_ListBirthdayFriends.Location = new System.Drawing.Point(12, 12);
               this.m_ListBirthdayFriends.Name = "m_ListBirthdayFriends";
               this.m_ListBirthdayFriends.Size = new System.Drawing.Size(139, 328);
               this.m_ListBirthdayFriends.TabIndex = 4;
               this.m_ListBirthdayFriends.SelectedIndexChanged += new System.EventHandler(this.m_ListBirthdayFriends_SelectedIndexChanged);
               // 
               // buttonSetStatus
               // 
               this.buttonSetStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
               this.buttonSetStatus.Location = new System.Drawing.Point(163, 208);
               this.buttonSetStatus.Name = "buttonSetStatus";
               this.buttonSetStatus.Size = new System.Drawing.Size(170, 23);
               this.buttonSetStatus.TabIndex = 49;
               this.buttonSetStatus.Text = "say happy birthday!";
               this.buttonSetStatus.UseVisualStyleBackColor = true;
               this.buttonSetStatus.Click += new System.EventHandler(this.buttonSetStatus_Click);
               // 
               // BirthdayForm
               // 
               this.ClientSize = new System.Drawing.Size(814, 388);
               this.Controls.Add(this.buttonSetStatus);
               this.Controls.Add(this.m_LabelLocation);
               this.Controls.Add(this.m_LabelAge);
               this.Controls.Add(this.m_PictureBoxFriendPic);
               this.Controls.Add(this.m_ListBirthdayFriends);
               this.Name = "BirthdayForm";
               ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxFriendPic)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

        }

        private void m_ListBirthdayFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedBirthdayFriendPostBox();
            displaySelectedBirthdayFriendImage();
            displaySelectedBirthdayFriendDetails();
           
        }

        private void buttonSetStatus_Click(object sender, EventArgs e)
        {
            User user = m_ListBirthdayFriends.SelectedItem as User;
            try
            {
                Status postedStatus = user.PostStatus("happy birhday!");
                MessageBox.Show("Status Posted! ID: " + postedStatus.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
            
        }
    }
}