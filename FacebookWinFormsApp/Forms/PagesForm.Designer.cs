
namespace BasicFacebookFeatures.Forms
{
     partial class PagesForm
     {
          /// <summary>
          /// Required designer variable.
          /// </summary>
          private System.ComponentModel.IContainer components = null;

          /// <summary>
          /// Clean up any resources being used.
          /// </summary>
          /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
          protected override void Dispose(bool disposing)
          {
               if (disposing && (components != null))
               {
                    components.Dispose();
               }
               base.Dispose(disposing);
          }

          #region Windows Form Designer generated code

          /// <summary>
          /// Required method for Designer support - do not modify
          /// the contents of this method with the code editor.
          /// </summary>
          private void InitializeComponent()
          {
               this.components = new System.ComponentModel.Container();
               System.Windows.Forms.Label descriptionLabel;
               System.Windows.Forms.Label isPublishedLabel;
               System.Windows.Forms.Label likesCountLabel;
               System.Windows.Forms.Label talkingAboutCountLabel;
               System.Windows.Forms.Label uRLLabel1;
               System.Windows.Forms.Label phoneLabel1;
               System.Windows.Forms.Label websiteLabel1;
               System.Windows.Forms.Label nameLabel;
               this.m_LabelpagesList = new System.Windows.Forms.Label();
               this.listBoxPages = new System.Windows.Forms.ListBox();
               this.pageBindingSource = new System.Windows.Forms.BindingSource(this.components);
               this.panel1 = new System.Windows.Forms.Panel();
               this.nameLabel1 = new System.Windows.Forms.Label();
               this.websiteLinkLabel = new System.Windows.Forms.LinkLabel();
               this.phoneLabel2 = new System.Windows.Forms.Label();
               this.uRLLinkLabel = new System.Windows.Forms.LinkLabel();
               this.descriptionTextBox = new System.Windows.Forms.TextBox();
               this.imageNormalPictureBox = new System.Windows.Forms.PictureBox();
               this.isPublishedLabel1 = new System.Windows.Forms.Label();
               this.likesCountLabel1 = new System.Windows.Forms.Label();
               this.talkingAboutCountLabel1 = new System.Windows.Forms.Label();
               descriptionLabel = new System.Windows.Forms.Label();
               isPublishedLabel = new System.Windows.Forms.Label();
               likesCountLabel = new System.Windows.Forms.Label();
               talkingAboutCountLabel = new System.Windows.Forms.Label();
               uRLLabel1 = new System.Windows.Forms.Label();
               phoneLabel1 = new System.Windows.Forms.Label();
               websiteLabel1 = new System.Windows.Forms.Label();
               nameLabel = new System.Windows.Forms.Label();
               ((System.ComponentModel.ISupportInitialize)(this.pageBindingSource)).BeginInit();
               this.panel1.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).BeginInit();
               this.SuspendLayout();
               // 
               // descriptionLabel
               // 
               descriptionLabel.AutoSize = true;
               descriptionLabel.Location = new System.Drawing.Point(10, 69);
               descriptionLabel.Name = "descriptionLabel";
               descriptionLabel.Size = new System.Drawing.Size(63, 13);
               descriptionLabel.TabIndex = 0;
               descriptionLabel.Text = "Description:";
               // 
               // isPublishedLabel
               // 
               isPublishedLabel.AutoSize = true;
               isPublishedLabel.Location = new System.Drawing.Point(10, 130);
               isPublishedLabel.Name = "isPublishedLabel";
               isPublishedLabel.Size = new System.Drawing.Size(67, 13);
               isPublishedLabel.TabIndex = 4;
               isPublishedLabel.Text = "Is Published:";
               // 
               // likesCountLabel
               // 
               likesCountLabel.AutoSize = true;
               likesCountLabel.Location = new System.Drawing.Point(10, 151);
               likesCountLabel.Name = "likesCountLabel";
               likesCountLabel.Size = new System.Drawing.Size(66, 13);
               likesCountLabel.TabIndex = 6;
               likesCountLabel.Text = "Likes Count:";
               // 
               // talkingAboutCountLabel
               // 
               talkingAboutCountLabel.AutoSize = true;
               talkingAboutCountLabel.Location = new System.Drawing.Point(10, 196);
               talkingAboutCountLabel.Name = "talkingAboutCountLabel";
               talkingAboutCountLabel.Size = new System.Drawing.Size(107, 13);
               talkingAboutCountLabel.TabIndex = 12;
               talkingAboutCountLabel.Text = "Talking About Count:";
               // 
               // uRLLabel1
               // 
               uRLLabel1.AutoSize = true;
               uRLLabel1.Location = new System.Drawing.Point(10, 221);
               uRLLabel1.Name = "uRLLabel1";
               uRLLabel1.Size = new System.Drawing.Size(32, 13);
               uRLLabel1.TabIndex = 17;
               uRLLabel1.Text = "URL:";
               // 
               // phoneLabel1
               // 
               phoneLabel1.AutoSize = true;
               phoneLabel1.Location = new System.Drawing.Point(10, 172);
               phoneLabel1.Name = "phoneLabel1";
               phoneLabel1.Size = new System.Drawing.Size(41, 13);
               phoneLabel1.TabIndex = 18;
               phoneLabel1.Text = "Phone:";
               // 
               // websiteLabel1
               // 
               websiteLabel1.AutoSize = true;
               websiteLabel1.Location = new System.Drawing.Point(10, 244);
               websiteLabel1.Name = "websiteLabel1";
               websiteLabel1.Size = new System.Drawing.Size(49, 13);
               websiteLabel1.TabIndex = 19;
               websiteLabel1.Text = "Website:";
               // 
               // nameLabel
               // 
               nameLabel.AutoSize = true;
               nameLabel.Location = new System.Drawing.Point(119, 18);
               nameLabel.Name = "nameLabel";
               nameLabel.Size = new System.Drawing.Size(38, 13);
               nameLabel.TabIndex = 20;
               nameLabel.Text = "Name:";
               // 
               // m_LabelpagesList
               // 
               this.m_LabelpagesList.AutoSize = true;
               this.m_LabelpagesList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.m_LabelpagesList.Location = new System.Drawing.Point(58, 12);
               this.m_LabelpagesList.Name = "m_LabelpagesList";
               this.m_LabelpagesList.Size = new System.Drawing.Size(50, 19);
               this.m_LabelpagesList.TabIndex = 7;
               this.m_LabelpagesList.Text = "PAGES";
               // 
               // listBoxPages
               // 
               this.listBoxPages.DataSource = this.pageBindingSource;
               this.listBoxPages.DisplayMember = "Name";
               this.listBoxPages.FormattingEnabled = true;
               this.listBoxPages.Location = new System.Drawing.Point(62, 34);
               this.listBoxPages.Name = "listBoxPages";
               this.listBoxPages.Size = new System.Drawing.Size(235, 277);
               this.listBoxPages.TabIndex = 6;
               // 
               // pageBindingSource
               // 
               this.pageBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Page);
               // 
               // panel1
               // 
               this.panel1.Controls.Add(nameLabel);
               this.panel1.Controls.Add(this.nameLabel1);
               this.panel1.Controls.Add(websiteLabel1);
               this.panel1.Controls.Add(this.websiteLinkLabel);
               this.panel1.Controls.Add(phoneLabel1);
               this.panel1.Controls.Add(this.phoneLabel2);
               this.panel1.Controls.Add(uRLLabel1);
               this.panel1.Controls.Add(this.uRLLinkLabel);
               this.panel1.Controls.Add(descriptionLabel);
               this.panel1.Controls.Add(this.descriptionTextBox);
               this.panel1.Controls.Add(this.imageNormalPictureBox);
               this.panel1.Controls.Add(isPublishedLabel);
               this.panel1.Controls.Add(this.isPublishedLabel1);
               this.panel1.Controls.Add(likesCountLabel);
               this.panel1.Controls.Add(this.likesCountLabel1);
               this.panel1.Controls.Add(talkingAboutCountLabel);
               this.panel1.Controls.Add(this.talkingAboutCountLabel1);
               this.panel1.Location = new System.Drawing.Point(303, 34);
               this.panel1.Name = "panel1";
               this.panel1.Size = new System.Drawing.Size(268, 277);
               this.panel1.TabIndex = 8;
               // 
               // nameLabel1
               // 
               this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pageBindingSource, "Name", true));
               this.nameLabel1.Location = new System.Drawing.Point(163, 18);
               this.nameLabel1.Name = "nameLabel1";
               this.nameLabel1.Size = new System.Drawing.Size(100, 23);
               this.nameLabel1.TabIndex = 21;
               this.nameLabel1.Text = "label1";
               // 
               // websiteLinkLabel
               // 
               this.websiteLinkLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pageBindingSource, "Website", true));
               this.websiteLinkLabel.Location = new System.Drawing.Point(65, 244);
               this.websiteLinkLabel.Name = "websiteLinkLabel";
               this.websiteLinkLabel.Size = new System.Drawing.Size(100, 23);
               this.websiteLinkLabel.TabIndex = 20;
               this.websiteLinkLabel.TabStop = true;
               this.websiteLinkLabel.Text = "linkLabel1";
               // 
               // phoneLabel2
               // 
               this.phoneLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pageBindingSource, "Phone", true));
               this.phoneLabel2.Location = new System.Drawing.Point(57, 172);
               this.phoneLabel2.Name = "phoneLabel2";
               this.phoneLabel2.Size = new System.Drawing.Size(100, 23);
               this.phoneLabel2.TabIndex = 19;
               this.phoneLabel2.Text = "label1";
               // 
               // uRLLinkLabel
               // 
               this.uRLLinkLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pageBindingSource, "URL", true));
               this.uRLLinkLabel.Location = new System.Drawing.Point(65, 221);
               this.uRLLinkLabel.Name = "uRLLinkLabel";
               this.uRLLinkLabel.Size = new System.Drawing.Size(100, 23);
               this.uRLLinkLabel.TabIndex = 18;
               this.uRLLinkLabel.TabStop = true;
               this.uRLLinkLabel.Text = "linkLabel1";
               // 
               // descriptionTextBox
               // 
               this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pageBindingSource, "Description", true));
               this.descriptionTextBox.Location = new System.Drawing.Point(79, 68);
               this.descriptionTextBox.Multiline = true;
               this.descriptionTextBox.Name = "descriptionTextBox";
               this.descriptionTextBox.Size = new System.Drawing.Size(144, 50);
               this.descriptionTextBox.TabIndex = 1;
               // 
               // imageNormalPictureBox
               // 
               this.imageNormalPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.pageBindingSource, "ImageNormal", true));
               this.imageNormalPictureBox.Location = new System.Drawing.Point(13, 4);
               this.imageNormalPictureBox.Name = "imageNormalPictureBox";
               this.imageNormalPictureBox.Size = new System.Drawing.Size(74, 54);
               this.imageNormalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
               this.imageNormalPictureBox.TabIndex = 3;
               this.imageNormalPictureBox.TabStop = false;
               // 
               // isPublishedLabel1
               // 
               this.isPublishedLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pageBindingSource, "IsPublished", true));
               this.isPublishedLabel1.Location = new System.Drawing.Point(123, 130);
               this.isPublishedLabel1.Name = "isPublishedLabel1";
               this.isPublishedLabel1.Size = new System.Drawing.Size(100, 23);
               this.isPublishedLabel1.TabIndex = 5;
               this.isPublishedLabel1.Text = "label1";
               // 
               // likesCountLabel1
               // 
               this.likesCountLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pageBindingSource, "Name", true));
               this.likesCountLabel1.Location = new System.Drawing.Point(123, 151);
               this.likesCountLabel1.Name = "likesCountLabel1";
               this.likesCountLabel1.Size = new System.Drawing.Size(100, 23);
               this.likesCountLabel1.TabIndex = 7;
               this.likesCountLabel1.Text = "label1";
               // 
               // talkingAboutCountLabel1
               // 
               this.talkingAboutCountLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pageBindingSource, "TalkingAboutCount", true));
               this.talkingAboutCountLabel1.Location = new System.Drawing.Point(123, 196);
               this.talkingAboutCountLabel1.Name = "talkingAboutCountLabel1";
               this.talkingAboutCountLabel1.Size = new System.Drawing.Size(100, 23);
               this.talkingAboutCountLabel1.TabIndex = 13;
               this.talkingAboutCountLabel1.Text = "label1";
               // 
               // PagesForm
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.AutoScroll = true;
               this.ClientSize = new System.Drawing.Size(881, 749);
               this.Controls.Add(this.panel1);
               this.Controls.Add(this.m_LabelpagesList);
               this.Controls.Add(this.listBoxPages);
               this.Name = "PagesForm";
               this.Text = "Pages";
               ((System.ComponentModel.ISupportInitialize)(this.pageBindingSource)).EndInit();
               this.panel1.ResumeLayout(false);
               this.panel1.PerformLayout();
               ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

        #endregion
        private System.Windows.Forms.Label m_LabelpagesList;
        private System.Windows.Forms.ListBox listBoxPages;
          private System.Windows.Forms.Panel panel1;
          private System.Windows.Forms.TextBox descriptionTextBox;
          private System.Windows.Forms.BindingSource pageBindingSource;
          private System.Windows.Forms.PictureBox imageNormalPictureBox;
          private System.Windows.Forms.Label isPublishedLabel1;
          private System.Windows.Forms.Label likesCountLabel1;
          private System.Windows.Forms.Label talkingAboutCountLabel1;
          private System.Windows.Forms.Label nameLabel1;
          private System.Windows.Forms.LinkLabel websiteLinkLabel;
          private System.Windows.Forms.Label phoneLabel2;
          private System.Windows.Forms.LinkLabel uRLLinkLabel;
     }
}