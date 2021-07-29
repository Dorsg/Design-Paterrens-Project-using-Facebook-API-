
namespace BasicFacebookFeatures
{
     partial class FcbForm
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
               this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
               this.label_Name = new System.Windows.Forms.Label();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
               this.SuspendLayout();
               // 
               // pictureBoxProfile
               // 
               this.pictureBoxProfile.Location = new System.Drawing.Point(-1, 0);
               this.pictureBoxProfile.Name = "pictureBoxProfile";
               this.pictureBoxProfile.Size = new System.Drawing.Size(142, 125);
               this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
               this.pictureBoxProfile.TabIndex = 0;
               this.pictureBoxProfile.TabStop = false;
               this.pictureBoxProfile.Click += new System.EventHandler(this.pictureBoxProfile_Click);
               // 
               // label_Name
               // 
               this.label_Name.AutoSize = true;
               this.label_Name.Location = new System.Drawing.Point(164, 13);
               this.label_Name.Name = "label_Name";
               this.label_Name.Size = new System.Drawing.Size(35, 13);
               this.label_Name.TabIndex = 1;
               this.label_Name.Text = "label1";
               this.label_Name.Click += new System.EventHandler(this.label_Name_Click);
               // 
               // FcbForm
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(938, 526);
               this.Controls.Add(this.label_Name);
               this.Controls.Add(this.pictureBoxProfile);
               this.Name = "FcbForm";
               this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.Load += new System.EventHandler(this.FcbForm_Load);
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.PictureBox pictureBoxProfile;
          private System.Windows.Forms.Label label_Name;
     }
}