
namespace BasicFacebookFeatures.Forms
{
     partial class DatingForm
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
               this.m_ListBoxSingles = new System.Windows.Forms.ListBox();
               this.m_LabelAge = new System.Windows.Forms.Label();
               this.m_LabelLocation = new System.Windows.Forms.Label();
               this.m_WebBrowserMap = new System.Windows.Forms.WebBrowser();
               this.m_PictureBoxSinglePic = new System.Windows.Forms.PictureBox();
               ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxSinglePic)).BeginInit();
               this.SuspendLayout();
               // 
               // m_ListBoxSingles
               // 
               this.m_ListBoxSingles.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.m_ListBoxSingles.FormattingEnabled = true;
               this.m_ListBoxSingles.ItemHeight = 18;
               this.m_ListBoxSingles.Location = new System.Drawing.Point(12, 8);
               this.m_ListBoxSingles.Name = "m_ListBoxSingles";
               this.m_ListBoxSingles.Size = new System.Drawing.Size(139, 328);
               this.m_ListBoxSingles.TabIndex = 0;
               this.m_ListBoxSingles.SelectedIndexChanged += new System.EventHandler(this.m_ListBoxSingles_SelectedIndexChanged);
               // 
               // m_LabelAge
               // 
               this.m_LabelAge.AutoSize = true;
               this.m_LabelAge.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.m_LabelAge.Location = new System.Drawing.Point(157, 149);
               this.m_LabelAge.Name = "m_LabelAge";
               this.m_LabelAge.Size = new System.Drawing.Size(73, 14);
               this.m_LabelAge.TabIndex = 2;
               this.m_LabelAge.Text = "m_LabelAge";
               // 
               // m_LabelLocation
               // 
               this.m_LabelLocation.AutoSize = true;
               this.m_LabelLocation.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.m_LabelLocation.Location = new System.Drawing.Point(157, 170);
               this.m_LabelLocation.Name = "m_LabelLocation";
               this.m_LabelLocation.Size = new System.Drawing.Size(98, 14);
               this.m_LabelLocation.TabIndex = 3;
               this.m_LabelLocation.Text = "m_LabelLocation";
               // 
               // m_WebBrowserMap
               // 
               this.m_WebBrowserMap.Dock = System.Windows.Forms.DockStyle.Right;
               this.m_WebBrowserMap.Location = new System.Drawing.Point(459, 0);
               this.m_WebBrowserMap.MinimumSize = new System.Drawing.Size(20, 20);
               this.m_WebBrowserMap.Name = "m_WebBrowserMap";
               this.m_WebBrowserMap.ScriptErrorsSuppressed = true;
               this.m_WebBrowserMap.Size = new System.Drawing.Size(341, 450);
               this.m_WebBrowserMap.TabIndex = 4;
               // 
               // m_PictureBoxSinglePic
               // 
               this.m_PictureBoxSinglePic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
               this.m_PictureBoxSinglePic.Location = new System.Drawing.Point(157, 8);
               this.m_PictureBoxSinglePic.Name = "m_PictureBoxSinglePic";
               this.m_PictureBoxSinglePic.Size = new System.Drawing.Size(173, 135);
               this.m_PictureBoxSinglePic.TabIndex = 1;
               this.m_PictureBoxSinglePic.TabStop = false;
               // 
               // DatingForm
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(800, 450);
               this.Controls.Add(this.m_WebBrowserMap);
               this.Controls.Add(this.m_LabelLocation);
               this.Controls.Add(this.m_LabelAge);
               this.Controls.Add(this.m_PictureBoxSinglePic);
               this.Controls.Add(this.m_ListBoxSingles);
               this.Name = "DatingForm";
               this.Text = "Find a single friend";
               ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxSinglePic)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.ListBox m_ListBoxSingles;
          private System.Windows.Forms.PictureBox m_PictureBoxSinglePic;
          private System.Windows.Forms.Label m_LabelAge;
          private System.Windows.Forms.Label m_LabelLocation;
          private System.Windows.Forms.WebBrowser m_WebBrowserMap;
     }
}