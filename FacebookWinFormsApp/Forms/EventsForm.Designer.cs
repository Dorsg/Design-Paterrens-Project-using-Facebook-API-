
namespace BasicFacebookFeatures.Forms
{
     partial class EventsForm
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
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventsForm));
               System.Windows.Forms.Label attendingCountLabel;
               System.Windows.Forms.Label descriptionLabel;
               System.Windows.Forms.Label endTimeLabel;
               System.Windows.Forms.Label linkToFacebookLabel;
               System.Windows.Forms.Label locationLabel;
               System.Windows.Forms.Label startTimeLabel;
               this.listBoxEvents = new System.Windows.Forms.ListBox();
               this.panel1 = new System.Windows.Forms.Panel();
               this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
               this.eventBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
               this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
               this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
               this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
               this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
               this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
               this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
               this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
               this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
               this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
               this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
               this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
               this.eventBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
               this.attendingCountTextBox = new System.Windows.Forms.TextBox();
               this.descriptionTextBox = new System.Windows.Forms.TextBox();
               this.endTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
               this.imageNormalPictureBox = new System.Windows.Forms.PictureBox();
               this.linkToFacebookTextBox = new System.Windows.Forms.TextBox();
               this.locationTextBox = new System.Windows.Forms.TextBox();
               this.startTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
               attendingCountLabel = new System.Windows.Forms.Label();
               descriptionLabel = new System.Windows.Forms.Label();
               endTimeLabel = new System.Windows.Forms.Label();
               linkToFacebookLabel = new System.Windows.Forms.Label();
               locationLabel = new System.Windows.Forms.Label();
               startTimeLabel = new System.Windows.Forms.Label();
               this.panel1.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.eventBindingNavigator)).BeginInit();
               this.eventBindingNavigator.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).BeginInit();
               this.SuspendLayout();
               // 
               // listBoxEvents
               // 
               this.listBoxEvents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
               this.listBoxEvents.DataSource = this.eventBindingSource;
               this.listBoxEvents.DisplayMember = "name";
               this.listBoxEvents.FormattingEnabled = true;
               this.listBoxEvents.Location = new System.Drawing.Point(76, 51);
               this.listBoxEvents.Name = "listBoxEvents";
               this.listBoxEvents.Size = new System.Drawing.Size(241, 264);
               this.listBoxEvents.TabIndex = 41;
               // 
               // panel1
               // 
               this.panel1.Controls.Add(attendingCountLabel);
               this.panel1.Controls.Add(this.attendingCountTextBox);
               this.panel1.Controls.Add(descriptionLabel);
               this.panel1.Controls.Add(this.imageNormalPictureBox);
               this.panel1.Controls.Add(this.descriptionTextBox);
               this.panel1.Controls.Add(endTimeLabel);
               this.panel1.Controls.Add(this.endTimeDateTimePicker);
               this.panel1.Controls.Add(linkToFacebookLabel);
               this.panel1.Controls.Add(this.linkToFacebookTextBox);
               this.panel1.Controls.Add(locationLabel);
               this.panel1.Controls.Add(this.locationTextBox);
               this.panel1.Controls.Add(startTimeLabel);
               this.panel1.Controls.Add(this.startTimeDateTimePicker);
               this.panel1.Location = new System.Drawing.Point(340, 51);
               this.panel1.Name = "panel1";
               this.panel1.Size = new System.Drawing.Size(411, 266);
               this.panel1.TabIndex = 42;
               // 
               // eventBindingSource
               // 
               this.eventBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Event);
               // 
               // eventBindingNavigator
               // 
               this.eventBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
               this.eventBindingNavigator.BindingSource = this.eventBindingSource;
               this.eventBindingNavigator.CountItem = this.bindingNavigatorCountItem;
               this.eventBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
               this.eventBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.eventBindingNavigatorSaveItem});
               this.eventBindingNavigator.Location = new System.Drawing.Point(0, 0);
               this.eventBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
               this.eventBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
               this.eventBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
               this.eventBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
               this.eventBindingNavigator.Name = "eventBindingNavigator";
               this.eventBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
               this.eventBindingNavigator.Size = new System.Drawing.Size(800, 25);
               this.eventBindingNavigator.TabIndex = 43;
               this.eventBindingNavigator.Text = "bindingNavigator1";
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
               // bindingNavigatorCountItem
               // 
               this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
               this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
               this.bindingNavigatorCountItem.Text = "of {0}";
               this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
               // 
               // bindingNavigatorSeparator1
               // 
               this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
               this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
               this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
               // bindingNavigatorDeleteItem
               // 
               this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
               this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
               this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
               this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
               this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
               this.bindingNavigatorDeleteItem.Text = "Delete";
               // 
               // eventBindingNavigatorSaveItem
               // 
               this.eventBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
               this.eventBindingNavigatorSaveItem.Enabled = false;
               this.eventBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("eventBindingNavigatorSaveItem.Image")));
               this.eventBindingNavigatorSaveItem.Name = "eventBindingNavigatorSaveItem";
               this.eventBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
               this.eventBindingNavigatorSaveItem.Text = "Save Data";
               // 
               // attendingCountLabel
               // 
               attendingCountLabel.AutoSize = true;
               attendingCountLabel.Location = new System.Drawing.Point(12, 108);
               attendingCountLabel.Name = "attendingCountLabel";
               attendingCountLabel.Size = new System.Drawing.Size(86, 13);
               attendingCountLabel.TabIndex = 0;
               attendingCountLabel.Text = "Attending Count:";
               // 
               // attendingCountTextBox
               // 
               this.attendingCountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "AttendingCount", true));
               this.attendingCountTextBox.Location = new System.Drawing.Point(115, 105);
               this.attendingCountTextBox.Name = "attendingCountTextBox";
               this.attendingCountTextBox.Size = new System.Drawing.Size(200, 20);
               this.attendingCountTextBox.TabIndex = 1;
               // 
               // descriptionLabel
               // 
               descriptionLabel.AutoSize = true;
               descriptionLabel.Location = new System.Drawing.Point(12, 134);
               descriptionLabel.Name = "descriptionLabel";
               descriptionLabel.Size = new System.Drawing.Size(63, 13);
               descriptionLabel.TabIndex = 2;
               descriptionLabel.Text = "Description:";
               // 
               // descriptionTextBox
               // 
               this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Description", true));
               this.descriptionTextBox.Location = new System.Drawing.Point(115, 131);
               this.descriptionTextBox.Name = "descriptionTextBox";
               this.descriptionTextBox.Size = new System.Drawing.Size(200, 20);
               this.descriptionTextBox.TabIndex = 3;
               // 
               // endTimeLabel
               // 
               endTimeLabel.AutoSize = true;
               endTimeLabel.Location = new System.Drawing.Point(12, 239);
               endTimeLabel.Name = "endTimeLabel";
               endTimeLabel.Size = new System.Drawing.Size(55, 13);
               endTimeLabel.TabIndex = 4;
               endTimeLabel.Text = "End Time:";
               // 
               // endTimeDateTimePicker
               // 
               this.endTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.eventBindingSource, "EndTime", true));
               this.endTimeDateTimePicker.Location = new System.Drawing.Point(115, 235);
               this.endTimeDateTimePicker.Name = "endTimeDateTimePicker";
               this.endTimeDateTimePicker.Size = new System.Drawing.Size(200, 20);
               this.endTimeDateTimePicker.TabIndex = 5;
               // 
               // imageNormalPictureBox
               // 
               this.imageNormalPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.eventBindingSource, "ImageNormal", true));
               this.imageNormalPictureBox.Location = new System.Drawing.Point(15, 3);
               this.imageNormalPictureBox.Name = "imageNormalPictureBox";
               this.imageNormalPictureBox.Size = new System.Drawing.Size(118, 96);
               this.imageNormalPictureBox.TabIndex = 7;
               this.imageNormalPictureBox.TabStop = false;
               // 
               // linkToFacebookLabel
               // 
               linkToFacebookLabel.AutoSize = true;
               linkToFacebookLabel.Location = new System.Drawing.Point(12, 160);
               linkToFacebookLabel.Name = "linkToFacebookLabel";
               linkToFacebookLabel.Size = new System.Drawing.Size(97, 13);
               linkToFacebookLabel.TabIndex = 8;
               linkToFacebookLabel.Text = "Link To Facebook:";
               // 
               // linkToFacebookTextBox
               // 
               this.linkToFacebookTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "LinkToFacebook", true));
               this.linkToFacebookTextBox.Location = new System.Drawing.Point(115, 157);
               this.linkToFacebookTextBox.Name = "linkToFacebookTextBox";
               this.linkToFacebookTextBox.Size = new System.Drawing.Size(200, 20);
               this.linkToFacebookTextBox.TabIndex = 9;
               // 
               // locationLabel
               // 
               locationLabel.AutoSize = true;
               locationLabel.Location = new System.Drawing.Point(12, 186);
               locationLabel.Name = "locationLabel";
               locationLabel.Size = new System.Drawing.Size(51, 13);
               locationLabel.TabIndex = 10;
               locationLabel.Text = "Location:";
               // 
               // locationTextBox
               // 
               this.locationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Location", true));
               this.locationTextBox.Location = new System.Drawing.Point(115, 183);
               this.locationTextBox.Name = "locationTextBox";
               this.locationTextBox.Size = new System.Drawing.Size(200, 20);
               this.locationTextBox.TabIndex = 11;
               // 
               // startTimeLabel
               // 
               startTimeLabel.AutoSize = true;
               startTimeLabel.Location = new System.Drawing.Point(12, 213);
               startTimeLabel.Name = "startTimeLabel";
               startTimeLabel.Size = new System.Drawing.Size(58, 13);
               startTimeLabel.TabIndex = 12;
               startTimeLabel.Text = "Start Time:";
               // 
               // startTimeDateTimePicker
               // 
               this.startTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.eventBindingSource, "StartTime", true));
               this.startTimeDateTimePicker.Location = new System.Drawing.Point(115, 209);
               this.startTimeDateTimePicker.Name = "startTimeDateTimePicker";
               this.startTimeDateTimePicker.Size = new System.Drawing.Size(200, 20);
               this.startTimeDateTimePicker.TabIndex = 13;
               // 
               // EventsForm
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(800, 450);
               this.Controls.Add(this.eventBindingNavigator);
               this.Controls.Add(this.panel1);
               this.Controls.Add(this.listBoxEvents);
               this.Name = "EventsForm";
               this.Text = "Events";
               this.panel1.ResumeLayout(false);
               this.panel1.PerformLayout();
               ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.eventBindingNavigator)).EndInit();
               this.eventBindingNavigator.ResumeLayout(false);
               this.eventBindingNavigator.PerformLayout();
               ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

        #endregion

        private System.Windows.Forms.ListBox listBoxEvents;
          private System.Windows.Forms.BindingSource eventBindingSource;
          private System.Windows.Forms.Panel panel1;
          private System.Windows.Forms.TextBox attendingCountTextBox;
          private System.Windows.Forms.PictureBox imageNormalPictureBox;
          private System.Windows.Forms.TextBox descriptionTextBox;
          private System.Windows.Forms.DateTimePicker endTimeDateTimePicker;
          private System.Windows.Forms.TextBox linkToFacebookTextBox;
          private System.Windows.Forms.TextBox locationTextBox;
          private System.Windows.Forms.DateTimePicker startTimeDateTimePicker;
          private System.Windows.Forms.BindingNavigator eventBindingNavigator;
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
          private System.Windows.Forms.ToolStripButton eventBindingNavigatorSaveItem;
     }
}