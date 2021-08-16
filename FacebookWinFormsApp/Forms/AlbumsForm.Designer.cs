
namespace BasicFacebookFeatures.Forms
{
     partial class AlbumsForm
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
               System.Windows.Forms.Label createdTimeLabel;
               System.Windows.Forms.Label descriptionLabel;
               System.Windows.Forms.Label linkLabel;
               System.Windows.Forms.Label locationLabel;
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlbumsForm));
               this.m_ListBoxAlbumList = new System.Windows.Forms.ListBox();
               this.albumBindingSource = new System.Windows.Forms.BindingSource(this.components);
               this.m_LabelAlbumList = new System.Windows.Forms.Label();
               this.panel1 = new System.Windows.Forms.Panel();
               this.imageAlbumPictureBox = new System.Windows.Forms.PictureBox();
               this.createdTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
               this.descriptionTextBox = new System.Windows.Forms.TextBox();
               this.linkLinkLabel = new System.Windows.Forms.LinkLabel();
               this.locationLabel1 = new System.Windows.Forms.Label();
               this.albumBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
               this.albumBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
               createdTimeLabel = new System.Windows.Forms.Label();
               descriptionLabel = new System.Windows.Forms.Label();
               linkLabel = new System.Windows.Forms.Label();
               locationLabel = new System.Windows.Forms.Label();
               ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).BeginInit();
               this.panel1.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.imageAlbumPictureBox)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.albumBindingNavigator)).BeginInit();
               this.albumBindingNavigator.SuspendLayout();
               this.SuspendLayout();
               // 
               // createdTimeLabel
               // 
               createdTimeLabel.AutoSize = true;
               createdTimeLabel.Location = new System.Drawing.Point(10, 144);
               createdTimeLabel.Name = "createdTimeLabel";
               createdTimeLabel.Size = new System.Drawing.Size(73, 13);
               createdTimeLabel.TabIndex = 2;
               createdTimeLabel.Text = "Created Time:";
               // 
               // descriptionLabel
               // 
               descriptionLabel.AutoSize = true;
               descriptionLabel.Location = new System.Drawing.Point(10, 169);
               descriptionLabel.Name = "descriptionLabel";
               descriptionLabel.Size = new System.Drawing.Size(63, 13);
               descriptionLabel.TabIndex = 4;
               descriptionLabel.Text = "Description:";
               // 
               // linkLabel
               // 
               linkLabel.AutoSize = true;
               linkLabel.Location = new System.Drawing.Point(10, 228);
               linkLabel.Name = "linkLabel";
               linkLabel.Size = new System.Drawing.Size(30, 13);
               linkLabel.TabIndex = 6;
               linkLabel.Text = "Link:";
               // 
               // locationLabel
               // 
               locationLabel.AutoSize = true;
               locationLabel.Location = new System.Drawing.Point(10, 251);
               locationLabel.Name = "locationLabel";
               locationLabel.Size = new System.Drawing.Size(51, 13);
               locationLabel.TabIndex = 8;
               locationLabel.Text = "Location:";
               // 
               // m_ListBoxAlbumList
               // 
               this.m_ListBoxAlbumList.DataSource = this.albumBindingSource;
               this.m_ListBoxAlbumList.DisplayMember = "Name";
               this.m_ListBoxAlbumList.FormattingEnabled = true;
               this.m_ListBoxAlbumList.Location = new System.Drawing.Point(64, 26);
               this.m_ListBoxAlbumList.Name = "m_ListBoxAlbumList";
               this.m_ListBoxAlbumList.Size = new System.Drawing.Size(186, 290);
               this.m_ListBoxAlbumList.TabIndex = 0;
               // 
               // albumBindingSource
               // 
               this.albumBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Album);
               // 
               // m_LabelAlbumList
               // 
               this.m_LabelAlbumList.AutoSize = true;
               this.m_LabelAlbumList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.m_LabelAlbumList.Location = new System.Drawing.Point(64, 7);
               this.m_LabelAlbumList.Name = "m_LabelAlbumList";
               this.m_LabelAlbumList.Size = new System.Drawing.Size(57, 19);
               this.m_LabelAlbumList.TabIndex = 2;
               this.m_LabelAlbumList.Text = "Albums";
               // 
               // panel1
               // 
               this.panel1.Controls.Add(this.imageAlbumPictureBox);
               this.panel1.Controls.Add(createdTimeLabel);
               this.panel1.Controls.Add(this.createdTimeDateTimePicker);
               this.panel1.Controls.Add(descriptionLabel);
               this.panel1.Controls.Add(this.descriptionTextBox);
               this.panel1.Controls.Add(linkLabel);
               this.panel1.Controls.Add(this.linkLinkLabel);
               this.panel1.Controls.Add(locationLabel);
               this.panel1.Controls.Add(this.locationLabel1);
               this.panel1.Location = new System.Drawing.Point(256, 26);
               this.panel1.Name = "panel1";
               this.panel1.Size = new System.Drawing.Size(344, 290);
               this.panel1.TabIndex = 3;
               // 
               // imageAlbumPictureBox
               // 
               this.imageAlbumPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.albumBindingSource, "ImageAlbum", true));
               this.imageAlbumPictureBox.Location = new System.Drawing.Point(83, 0);
               this.imageAlbumPictureBox.Name = "imageAlbumPictureBox";
               this.imageAlbumPictureBox.Size = new System.Drawing.Size(157, 134);
               this.imageAlbumPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
               this.imageAlbumPictureBox.TabIndex = 13;
               this.imageAlbumPictureBox.TabStop = false;
               // 
               // createdTimeDateTimePicker
               // 
               this.createdTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.albumBindingSource, "CreatedTime", true));
               this.createdTimeDateTimePicker.Location = new System.Drawing.Point(116, 140);
               this.createdTimeDateTimePicker.Name = "createdTimeDateTimePicker";
               this.createdTimeDateTimePicker.Size = new System.Drawing.Size(200, 20);
               this.createdTimeDateTimePicker.TabIndex = 3;
               // 
               // descriptionTextBox
               // 
               this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumBindingSource, "Description", true));
               this.descriptionTextBox.Location = new System.Drawing.Point(116, 166);
               this.descriptionTextBox.Multiline = true;
               this.descriptionTextBox.Name = "descriptionTextBox";
               this.descriptionTextBox.Size = new System.Drawing.Size(200, 59);
               this.descriptionTextBox.TabIndex = 5;
               // 
               // linkLinkLabel
               // 
               this.linkLinkLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumBindingSource, "Link", true));
               this.linkLinkLabel.Location = new System.Drawing.Point(116, 228);
               this.linkLinkLabel.Name = "linkLinkLabel";
               this.linkLinkLabel.Size = new System.Drawing.Size(200, 23);
               this.linkLinkLabel.TabIndex = 7;
               this.linkLinkLabel.TabStop = true;
               this.linkLinkLabel.Text = "linkLabel1";
               // 
               // locationLabel1
               // 
               this.locationLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumBindingSource, "Location", true));
               this.locationLabel1.Location = new System.Drawing.Point(116, 251);
               this.locationLabel1.Name = "locationLabel1";
               this.locationLabel1.Size = new System.Drawing.Size(200, 23);
               this.locationLabel1.TabIndex = 9;
               this.locationLabel1.Text = "label1";
               // 
               // albumBindingNavigator
               // 
               this.albumBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
               this.albumBindingNavigator.BindingSource = this.albumBindingSource;
               this.albumBindingNavigator.CountItem = this.bindingNavigatorCountItem;
               this.albumBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
               this.albumBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.albumBindingNavigatorSaveItem});
               this.albumBindingNavigator.Location = new System.Drawing.Point(0, 0);
               this.albumBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
               this.albumBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
               this.albumBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
               this.albumBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
               this.albumBindingNavigator.Name = "albumBindingNavigator";
               this.albumBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
               this.albumBindingNavigator.Size = new System.Drawing.Size(942, 25);
               this.albumBindingNavigator.TabIndex = 4;
               this.albumBindingNavigator.Text = "bindingNavigator1";
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
               // albumBindingNavigatorSaveItem
               // 
               this.albumBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
               this.albumBindingNavigatorSaveItem.Enabled = false;
               this.albumBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("albumBindingNavigatorSaveItem.Image")));
               this.albumBindingNavigatorSaveItem.Name = "albumBindingNavigatorSaveItem";
               this.albumBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
               this.albumBindingNavigatorSaveItem.Text = "Save Data";
               // 
               // AlbumsForm
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(942, 450);
               this.Controls.Add(this.albumBindingNavigator);
               this.Controls.Add(this.panel1);
               this.Controls.Add(this.m_LabelAlbumList);
               this.Controls.Add(this.m_ListBoxAlbumList);
               this.Name = "AlbumsForm";
               this.Text = "Albums";
               ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).EndInit();
               this.panel1.ResumeLayout(false);
               this.panel1.PerformLayout();
               ((System.ComponentModel.ISupportInitialize)(this.imageAlbumPictureBox)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.albumBindingNavigator)).EndInit();
               this.albumBindingNavigator.ResumeLayout(false);
               this.albumBindingNavigator.PerformLayout();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.ListBox m_ListBoxAlbumList;
          private System.Windows.Forms.Label m_LabelAlbumList;
          private System.Windows.Forms.Panel panel1;
          private System.Windows.Forms.BindingSource albumBindingSource;
          private System.Windows.Forms.DateTimePicker createdTimeDateTimePicker;
          private System.Windows.Forms.TextBox descriptionTextBox;
          private System.Windows.Forms.LinkLabel linkLinkLabel;
          private System.Windows.Forms.Label locationLabel1;
          private System.Windows.Forms.BindingNavigator albumBindingNavigator;
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
          private System.Windows.Forms.ToolStripButton albumBindingNavigatorSaveItem;
          private System.Windows.Forms.PictureBox imageAlbumPictureBox;
     }
}