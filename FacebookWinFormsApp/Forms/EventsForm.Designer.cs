
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
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.m_LabelEventPic = new System.Windows.Forms.Label();
            this.m_EventBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.m_EventBox)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxEvents.DisplayMember = "name";
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.Location = new System.Drawing.Point(76, 51);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(231, 147);
            this.listBoxEvents.TabIndex = 41;
            // 
            // m_LabelEventPic
            // 
            this.m_LabelEventPic.AutoSize = true;
            this.m_LabelEventPic.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_LabelEventPic.Location = new System.Drawing.Point(347, 20);
            this.m_LabelEventPic.Name = "m_LabelEventPic";
            this.m_LabelEventPic.Size = new System.Drawing.Size(94, 19);
            this.m_LabelEventPic.TabIndex = 43;
            this.m_LabelEventPic.Text = "Event Picture";
            // 
            // m_EventBox
            // 
            this.m_EventBox.Location = new System.Drawing.Point(351, 51);
            this.m_EventBox.Name = "m_EventBox";
            this.m_EventBox.Size = new System.Drawing.Size(245, 194);
            this.m_EventBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m_EventBox.TabIndex = 42;
            this.m_EventBox.TabStop = false;
            // 
            // EventsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.m_LabelEventPic);
            this.Controls.Add(this.m_EventBox);
            this.Controls.Add(this.listBoxEvents);
            this.Name = "EventsForm";
            this.Text = "Events";
            ((System.ComponentModel.ISupportInitialize)(this.m_EventBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

          }

        #endregion

        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.Label m_LabelEventPic;
        private System.Windows.Forms.PictureBox m_EventBox;
    }
}