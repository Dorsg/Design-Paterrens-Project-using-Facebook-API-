
namespace BasicFacebookFeatures.Forms
{
     partial class StatusForm
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
               System.Windows.Forms.Label captionLabel;
               System.Windows.Forms.Label createdTimeLabel;
               System.Windows.Forms.Label descriptionLabel;
               System.Windows.Forms.Label linkLabel;
               System.Windows.Forms.Label messageLabel;
               System.Windows.Forms.Label nameLabel;
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatusForm));
               this.m_LabelWritePost = new System.Windows.Forms.Label();
               this.m_TextBoxPost = new System.Windows.Forms.TextBox();
               this.m_ButtonPost = new System.Windows.Forms.Button();
               this.m_ListBoxPastPost = new System.Windows.Forms.ListBox();
               this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
               this.m_LabelPastPost = new System.Windows.Forms.Label();
               this.panel1 = new System.Windows.Forms.Panel();
               this.captionLabel1 = new System.Windows.Forms.Label();
               this.createdTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
               this.descriptionTextBox = new System.Windows.Forms.TextBox();
               this.linkLinkLabel = new System.Windows.Forms.LinkLabel();
               this.messageLabel1 = new System.Windows.Forms.Label();
               this.nameLabel1 = new System.Windows.Forms.Label();
               this.postBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
               this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
               this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
               this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
               this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
               this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
               this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
               this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
               this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
               this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
               this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
               this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
               this.postBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
               captionLabel = new System.Windows.Forms.Label();
               createdTimeLabel = new System.Windows.Forms.Label();
               descriptionLabel = new System.Windows.Forms.Label();
               linkLabel = new System.Windows.Forms.Label();
               messageLabel = new System.Windows.Forms.Label();
               nameLabel = new System.Windows.Forms.Label();
               ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
               this.panel1.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.postBindingNavigator)).BeginInit();
               this.postBindingNavigator.SuspendLayout();
               this.SuspendLayout();
               // 
               // captionLabel
               // 
               captionLabel.AutoSize = true;
               captionLabel.Location = new System.Drawing.Point(3, 11);
               captionLabel.Name = "captionLabel";
               captionLabel.Size = new System.Drawing.Size(46, 13);
               captionLabel.TabIndex = 0;
               captionLabel.Text = "Caption:";
               // 
               // createdTimeLabel
               // 
               createdTimeLabel.AutoSize = true;
               createdTimeLabel.Location = new System.Drawing.Point(3, 41);
               createdTimeLabel.Name = "createdTimeLabel";
               createdTimeLabel.Size = new System.Drawing.Size(73, 13);
               createdTimeLabel.TabIndex = 2;
               createdTimeLabel.Text = "Created Time:";
               // 
               // descriptionLabel
               // 
               descriptionLabel.AutoSize = true;
               descriptionLabel.Location = new System.Drawing.Point(3, 66);
               descriptionLabel.Name = "descriptionLabel";
               descriptionLabel.Size = new System.Drawing.Size(63, 13);
               descriptionLabel.TabIndex = 4;
               descriptionLabel.Text = "Description:";
               // 
               // linkLabel
               // 
               linkLabel.AutoSize = true;
               linkLabel.Location = new System.Drawing.Point(3, 126);
               linkLabel.Name = "linkLabel";
               linkLabel.Size = new System.Drawing.Size(30, 13);
               linkLabel.TabIndex = 8;
               linkLabel.Text = "Link:";
               // 
               // messageLabel
               // 
               messageLabel.AutoSize = true;
               messageLabel.Location = new System.Drawing.Point(3, 149);
               messageLabel.Name = "messageLabel";
               messageLabel.Size = new System.Drawing.Size(53, 13);
               messageLabel.TabIndex = 10;
               messageLabel.Text = "Message:";
               // 
               // nameLabel
               // 
               nameLabel.AutoSize = true;
               nameLabel.Location = new System.Drawing.Point(3, 172);
               nameLabel.Name = "nameLabel";
               nameLabel.Size = new System.Drawing.Size(38, 13);
               nameLabel.TabIndex = 12;
               nameLabel.Text = "Name:";
               // 
               // m_LabelWritePost
               // 
               this.m_LabelWritePost.AutoSize = true;
               this.m_LabelWritePost.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.m_LabelWritePost.Location = new System.Drawing.Point(59, 28);
               this.m_LabelWritePost.Name = "m_LabelWritePost";
               this.m_LabelWritePost.Size = new System.Drawing.Size(194, 24);
               this.m_LabelWritePost.TabIndex = 0;
               this.m_LabelWritePost.Text = "Write your post here: ";
               this.m_LabelWritePost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
               // 
               // m_TextBoxPost
               // 
               this.m_TextBoxPost.Location = new System.Drawing.Point(259, 33);
               this.m_TextBoxPost.Name = "m_TextBoxPost";
               this.m_TextBoxPost.Size = new System.Drawing.Size(354, 20);
               this.m_TextBoxPost.TabIndex = 1;
               // 
               // m_ButtonPost
               // 
               this.m_ButtonPost.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.m_ButtonPost.Location = new System.Drawing.Point(386, 70);
               this.m_ButtonPost.Name = "m_ButtonPost";
               this.m_ButtonPost.Size = new System.Drawing.Size(81, 35);
               this.m_ButtonPost.TabIndex = 2;
               this.m_ButtonPost.Text = "Post";
               this.m_ButtonPost.UseVisualStyleBackColor = true;
               this.m_ButtonPost.Click += new System.EventHandler(this.m_ButtonPost_Click);
               // 
               // m_ListBoxPastPost
               // 
               this.m_ListBoxPastPost.DataSource = this.postBindingSource;
               this.m_ListBoxPastPost.DisplayMember = "Name";
               this.m_ListBoxPastPost.FormattingEnabled = true;
               this.m_ListBoxPastPost.Location = new System.Drawing.Point(63, 135);
               this.m_ListBoxPastPost.Name = "m_ListBoxPastPost";
               this.m_ListBoxPastPost.Size = new System.Drawing.Size(297, 199);
               this.m_ListBoxPastPost.TabIndex = 3;
               // 
               // postBindingSource
               // 
               this.postBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Post);
               // 
               // m_LabelPastPost
               // 
               this.m_LabelPastPost.AutoSize = true;
               this.m_LabelPastPost.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.m_LabelPastPost.Location = new System.Drawing.Point(59, 108);
               this.m_LabelPastPost.Name = "m_LabelPastPost";
               this.m_LabelPastPost.Size = new System.Drawing.Size(119, 24);
               this.m_LabelPastPost.TabIndex = 4;
               this.m_LabelPastPost.Text = "My past post";
               this.m_LabelPastPost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
               // 
               // panel1
               // 
               this.panel1.Controls.Add(captionLabel);
               this.panel1.Controls.Add(this.captionLabel1);
               this.panel1.Controls.Add(createdTimeLabel);
               this.panel1.Controls.Add(this.createdTimeDateTimePicker);
               this.panel1.Controls.Add(descriptionLabel);
               this.panel1.Controls.Add(this.descriptionTextBox);
               this.panel1.Controls.Add(linkLabel);
               this.panel1.Controls.Add(this.linkLinkLabel);
               this.panel1.Controls.Add(messageLabel);
               this.panel1.Controls.Add(this.messageLabel1);
               this.panel1.Controls.Add(nameLabel);
               this.panel1.Controls.Add(this.nameLabel1);
               this.panel1.Location = new System.Drawing.Point(366, 135);
               this.panel1.Name = "panel1";
               this.panel1.Size = new System.Drawing.Size(370, 199);
               this.panel1.TabIndex = 5;
               // 
               // captionLabel1
               // 
               this.captionLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postBindingSource, "Caption", true));
               this.captionLabel1.Location = new System.Drawing.Point(82, 11);
               this.captionLabel1.Name = "captionLabel1";
               this.captionLabel1.Size = new System.Drawing.Size(200, 23);
               this.captionLabel1.TabIndex = 1;
               this.captionLabel1.Text = "label1";
               // 
               // createdTimeDateTimePicker
               // 
               this.createdTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.postBindingSource, "CreatedTime", true));
               this.createdTimeDateTimePicker.Location = new System.Drawing.Point(82, 37);
               this.createdTimeDateTimePicker.Name = "createdTimeDateTimePicker";
               this.createdTimeDateTimePicker.Size = new System.Drawing.Size(200, 20);
               this.createdTimeDateTimePicker.TabIndex = 3;
               // 
               // descriptionTextBox
               // 
               this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postBindingSource, "Description", true));
               this.descriptionTextBox.Location = new System.Drawing.Point(82, 63);
               this.descriptionTextBox.Multiline = true;
               this.descriptionTextBox.Name = "descriptionTextBox";
               this.descriptionTextBox.Size = new System.Drawing.Size(200, 60);
               this.descriptionTextBox.TabIndex = 5;
               // 
               // linkLinkLabel
               // 
               this.linkLinkLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postBindingSource, "Link", true));
               this.linkLinkLabel.Location = new System.Drawing.Point(82, 126);
               this.linkLinkLabel.Name = "linkLinkLabel";
               this.linkLinkLabel.Size = new System.Drawing.Size(200, 23);
               this.linkLinkLabel.TabIndex = 9;
               this.linkLinkLabel.TabStop = true;
               this.linkLinkLabel.Text = "linkLabel1";
               // 
               // messageLabel1
               // 
               this.messageLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postBindingSource, "Message", true));
               this.messageLabel1.Location = new System.Drawing.Point(82, 149);
               this.messageLabel1.Name = "messageLabel1";
               this.messageLabel1.Size = new System.Drawing.Size(200, 23);
               this.messageLabel1.TabIndex = 11;
               this.messageLabel1.Text = "label1";
               // 
               // nameLabel1
               // 
               this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postBindingSource, "Name", true));
               this.nameLabel1.Location = new System.Drawing.Point(82, 172);
               this.nameLabel1.Name = "nameLabel1";
               this.nameLabel1.Size = new System.Drawing.Size(200, 23);
               this.nameLabel1.TabIndex = 13;
               this.nameLabel1.Text = "label1";
               // 
               // postBindingNavigator
               // 
               this.postBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
               this.postBindingNavigator.BindingSource = this.postBindingSource;
               this.postBindingNavigator.CountItem = this.bindingNavigatorCountItem;
               this.postBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
               this.postBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.postBindingNavigatorSaveItem});
               this.postBindingNavigator.Location = new System.Drawing.Point(0, 0);
               this.postBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
               this.postBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
               this.postBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
               this.postBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
               this.postBindingNavigator.Name = "postBindingNavigator";
               this.postBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
               this.postBindingNavigator.Size = new System.Drawing.Size(800, 25);
               this.postBindingNavigator.TabIndex = 6;
               this.postBindingNavigator.Text = "bindingNavigator1";
               // 
               // bindingNavigatorAddNewItem
               // 
               this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
               this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
               this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
               this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
               this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
               this.bindingNavigatorAddNewItem.Text = "Add new";
               // 
               // bindingNavigatorCountItem
               // 
               this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
               this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
               this.bindingNavigatorCountItem.Text = "of {0}";
               this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
               // 
               // bindingNavigatorDeleteItem
               // 
               this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
               this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
               this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
               this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
               this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
               this.bindingNavigatorDeleteItem.Text = "Delete";
               // 
               // bindingNavigatorMoveFirstItem
               // 
               this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
               this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
               this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
               this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
               this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
               this.bindingNavigatorMoveFirstItem.Text = "Move first";
               // 
               // bindingNavigatorMovePreviousItem
               // 
               this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
               this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
               this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
               this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
               this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
               this.bindingNavigatorMovePreviousItem.Text = "Move previous";
               // 
               // bindingNavigatorSeparator
               // 
               this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
               this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
               // 
               // bindingNavigatorPositionItem
               // 
               this.bindingNavigatorPositionItem.AccessibleName = "Position";
               this.bindingNavigatorPositionItem.AutoSize = false;
               this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
               this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
               this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
               this.bindingNavigatorPositionItem.Text = "0";
               this.bindingNavigatorPositionItem.ToolTipText = "Current position";
               // 
               // bindingNavigatorSeparator1
               // 
               this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
               this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
               // 
               // bindingNavigatorMoveNextItem
               // 
               this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
               this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
               this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
               this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
               this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
               this.bindingNavigatorMoveNextItem.Text = "Move next";
               // 
               // bindingNavigatorMoveLastItem
               // 
               this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
               this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
               this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
               this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
               this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
               this.bindingNavigatorMoveLastItem.Text = "Move last";
               // 
               // bindingNavigatorSeparator2
               // 
               this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
               this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
               // 
               // postBindingNavigatorSaveItem
               // 
               this.postBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
               this.postBindingNavigatorSaveItem.Enabled = false;
               this.postBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("postBindingNavigatorSaveItem.Image")));
               this.postBindingNavigatorSaveItem.Name = "postBindingNavigatorSaveItem";
               this.postBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
               this.postBindingNavigatorSaveItem.Text = "Save Data";
               // 
               // StatusForm
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(800, 450);
               this.Controls.Add(this.postBindingNavigator);
               this.Controls.Add(this.panel1);
               this.Controls.Add(this.m_LabelPastPost);
               this.Controls.Add(this.m_ListBoxPastPost);
               this.Controls.Add(this.m_ButtonPost);
               this.Controls.Add(this.m_TextBoxPost);
               this.Controls.Add(this.m_LabelWritePost);
               this.Name = "StatusForm";
               this.Text = "Status";
               ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
               this.panel1.ResumeLayout(false);
               this.panel1.PerformLayout();
               ((System.ComponentModel.ISupportInitialize)(this.postBindingNavigator)).EndInit();
               this.postBindingNavigator.ResumeLayout(false);
               this.postBindingNavigator.PerformLayout();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.Label m_LabelWritePost;
          private System.Windows.Forms.TextBox m_TextBoxPost;
          private System.Windows.Forms.Button m_ButtonPost;
          private System.Windows.Forms.ListBox m_ListBoxPastPost;
          private System.Windows.Forms.Label m_LabelPastPost;
          private System.Windows.Forms.BindingSource postBindingSource;
          private System.Windows.Forms.Panel panel1;
          private System.Windows.Forms.Label captionLabel1;
          private System.Windows.Forms.DateTimePicker createdTimeDateTimePicker;
          private System.Windows.Forms.TextBox descriptionTextBox;
          private System.Windows.Forms.LinkLabel linkLinkLabel;
          private System.Windows.Forms.Label messageLabel1;
          private System.Windows.Forms.Label nameLabel1;
          private System.Windows.Forms.BindingNavigator postBindingNavigator;
          private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
          private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
          private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
          private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
          private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
          private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
          private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
          private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
          private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
          private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
          private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
          private System.Windows.Forms.ToolStripButton postBindingNavigatorSaveItem;
     }
}