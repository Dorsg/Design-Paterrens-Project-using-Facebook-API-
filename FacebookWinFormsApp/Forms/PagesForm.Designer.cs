
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
            this.m_labelPagesPic = new System.Windows.Forms.Label();
            this.m_PictureBoxPages = new System.Windows.Forms.PictureBox();
            this.m_LabelpagesList = new System.Windows.Forms.Label();
            this.listBoxPages = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxPages)).BeginInit();
            this.SuspendLayout();
            // 
            // m_labelPagesPic
            // 
            this.m_labelPagesPic.AutoSize = true;
            this.m_labelPagesPic.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_labelPagesPic.Location = new System.Drawing.Point(408, 51);
            this.m_labelPagesPic.Name = "m_labelPagesPic";
            this.m_labelPagesPic.Size = new System.Drawing.Size(97, 19);
            this.m_labelPagesPic.TabIndex = 9;
            this.m_labelPagesPic.Text = "Pages Picture";
            // 
            // m_PictureBoxPages
            // 
            this.m_PictureBoxPages.Location = new System.Drawing.Point(412, 82);
            this.m_PictureBoxPages.Name = "m_PictureBoxPages";
            this.m_PictureBoxPages.Size = new System.Drawing.Size(245, 194);
            this.m_PictureBoxPages.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m_PictureBoxPages.TabIndex = 8;
            this.m_PictureBoxPages.TabStop = false;
            // 
            // m_LabelpagesList
            // 
            this.m_LabelpagesList.AutoSize = true;
            this.m_LabelpagesList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_LabelpagesList.Location = new System.Drawing.Point(58, 29);
            this.m_LabelpagesList.Name = "m_LabelpagesList";
            this.m_LabelpagesList.Size = new System.Drawing.Size(50, 19);
            this.m_LabelpagesList.TabIndex = 7;
            this.m_LabelpagesList.Text = "PAGES";
            // 
            // listBoxPages
            // 
            this.listBoxPages.FormattingEnabled = true;
            this.listBoxPages.Location = new System.Drawing.Point(62, 51);
            this.listBoxPages.Name = "listBoxPages";
            this.listBoxPages.Size = new System.Drawing.Size(314, 225);
            this.listBoxPages.TabIndex = 6;
            // 
            // PagesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.m_labelPagesPic);
            this.Controls.Add(this.m_PictureBoxPages);
            this.Controls.Add(this.m_LabelpagesList);
            this.Controls.Add(this.listBoxPages);
            this.Name = "PagesForm";
            this.Text = "Pages";
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxPages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

          }

        #endregion

        private System.Windows.Forms.Label m_labelPagesPic;
        private System.Windows.Forms.PictureBox m_PictureBoxPages;
        private System.Windows.Forms.Label m_LabelpagesList;
        private System.Windows.Forms.ListBox listBoxPages;
    }
}