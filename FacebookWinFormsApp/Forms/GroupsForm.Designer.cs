
namespace BasicFacebookFeatures.Forms
{
     partial class GroupsForm
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
               this.m_ListBoxGroupList = new System.Windows.Forms.ListBox();
               this.m_LabelGroupsList = new System.Windows.Forms.Label();
               this.m_PictureBoxGroups = new System.Windows.Forms.PictureBox();
               this.m_LabelGroupPic = new System.Windows.Forms.Label();
               ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxGroups)).BeginInit();
               this.SuspendLayout();
               // 
               // m_ListBoxGroupList
               // 
               this.m_ListBoxGroupList.FormattingEnabled = true;
               this.m_ListBoxGroupList.Location = new System.Drawing.Point(57, 40);
               this.m_ListBoxGroupList.Name = "m_ListBoxGroupList";
               this.m_ListBoxGroupList.Size = new System.Drawing.Size(314, 225);
               this.m_ListBoxGroupList.TabIndex = 1;
               this.m_ListBoxGroupList.SelectedIndexChanged += new System.EventHandler(this.m_ListBoxAlbumList_SelectedIndexChanged);
               // 
               // m_LabelGroupsList
               // 
               this.m_LabelGroupsList.AutoSize = true;
               this.m_LabelGroupsList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.m_LabelGroupsList.Location = new System.Drawing.Point(53, 18);
               this.m_LabelGroupsList.Name = "m_LabelGroupsList";
               this.m_LabelGroupsList.Size = new System.Drawing.Size(55, 19);
               this.m_LabelGroupsList.TabIndex = 3;
               this.m_LabelGroupsList.Text = "Groups";
               // 
               // m_PictureBoxGroups
               // 
               this.m_PictureBoxGroups.Location = new System.Drawing.Point(407, 71);
               this.m_PictureBoxGroups.Name = "m_PictureBoxGroups";
               this.m_PictureBoxGroups.Size = new System.Drawing.Size(245, 194);
               this.m_PictureBoxGroups.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
               this.m_PictureBoxGroups.TabIndex = 4;
               this.m_PictureBoxGroups.TabStop = false;
               // 
               // m_LabelGroupPic
               // 
               this.m_LabelGroupPic.AutoSize = true;
               this.m_LabelGroupPic.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.m_LabelGroupPic.Location = new System.Drawing.Point(403, 40);
               this.m_LabelGroupPic.Name = "m_LabelGroupPic";
               this.m_LabelGroupPic.Size = new System.Drawing.Size(97, 19);
               this.m_LabelGroupPic.TabIndex = 5;
               this.m_LabelGroupPic.Text = "Group Picture";
               // 
               // GroupsForm
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(800, 450);
               this.Controls.Add(this.m_LabelGroupPic);
               this.Controls.Add(this.m_PictureBoxGroups);
               this.Controls.Add(this.m_LabelGroupsList);
               this.Controls.Add(this.m_ListBoxGroupList);
               this.Name = "GroupsForm";
               this.Text = "Groups";
               ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxGroups)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.ListBox m_ListBoxGroupList;
          private System.Windows.Forms.Label m_LabelGroupsList;
          private System.Windows.Forms.PictureBox m_PictureBoxGroups;
          private System.Windows.Forms.Label m_LabelGroupPic;
     }
}