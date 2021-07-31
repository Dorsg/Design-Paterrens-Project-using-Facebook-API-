
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
               this.m_ListBoxAlbumList = new System.Windows.Forms.ListBox();
               this.m_LabelAlbumList = new System.Windows.Forms.Label();
               this.m_LabelPictureBox = new System.Windows.Forms.Label();
               this.m_PictureBox = new System.Windows.Forms.PictureBox();
               ((System.ComponentModel.ISupportInitialize)(this.m_PictureBox)).BeginInit();
               this.SuspendLayout();
               // 
               // m_ListBoxAlbumList
               // 
               this.m_ListBoxAlbumList.FormattingEnabled = true;
               this.m_ListBoxAlbumList.Location = new System.Drawing.Point(64, 26);
               this.m_ListBoxAlbumList.Name = "m_ListBoxAlbumList";
               this.m_ListBoxAlbumList.Size = new System.Drawing.Size(323, 277);
               this.m_ListBoxAlbumList.TabIndex = 0;
               this.m_ListBoxAlbumList.SelectedIndexChanged += new System.EventHandler(this.m_ListBoxAlbumList_SelectedIndexChanged);
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
               // m_LabelPictureBox
               // 
               this.m_LabelPictureBox.AutoSize = true;
               this.m_LabelPictureBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.m_LabelPictureBox.Location = new System.Drawing.Point(415, 54);
               this.m_LabelPictureBox.Name = "m_LabelPictureBox";
               this.m_LabelPictureBox.Size = new System.Drawing.Size(91, 19);
               this.m_LabelPictureBox.TabIndex = 3;
               this.m_LabelPictureBox.Text = "Main picture";
               // 
               // m_PictureBox
               // 
               this.m_PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
               this.m_PictureBox.Location = new System.Drawing.Point(418, 79);
               this.m_PictureBox.Name = "m_PictureBox";
               this.m_PictureBox.Size = new System.Drawing.Size(245, 194);
               this.m_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
               this.m_PictureBox.TabIndex = 1;
               this.m_PictureBox.TabStop = false;
               // 
               // AlbumsForm
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(800, 450);
               this.Controls.Add(this.m_LabelPictureBox);
               this.Controls.Add(this.m_LabelAlbumList);
               this.Controls.Add(this.m_PictureBox);
               this.Controls.Add(this.m_ListBoxAlbumList);
               this.Name = "AlbumsForm";
               this.Text = "Albums";
               ((System.ComponentModel.ISupportInitialize)(this.m_PictureBox)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.ListBox m_ListBoxAlbumList;
          private System.Windows.Forms.PictureBox m_PictureBox;
          private System.Windows.Forms.Label m_LabelAlbumList;
          private System.Windows.Forms.Label m_LabelPictureBox;
     }
}