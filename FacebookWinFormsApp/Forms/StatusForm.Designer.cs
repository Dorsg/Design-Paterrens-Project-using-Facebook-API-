
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
               this.m_LabelWritePost = new System.Windows.Forms.Label();
               this.m_TextBoxPost = new System.Windows.Forms.TextBox();
               this.m_ButtonPost = new System.Windows.Forms.Button();
               this.m_ListBoxPastPost = new System.Windows.Forms.ListBox();
               this.m_LabelPastPost = new System.Windows.Forms.Label();
               this.SuspendLayout();
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
               this.m_ListBoxPastPost.FormattingEnabled = true;
               this.m_ListBoxPastPost.Location = new System.Drawing.Point(63, 135);
               this.m_ListBoxPastPost.Name = "m_ListBoxPastPost";
               this.m_ListBoxPastPost.Size = new System.Drawing.Size(550, 199);
               this.m_ListBoxPastPost.TabIndex = 3;
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
               // StatusForm
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(800, 450);
               this.Controls.Add(this.m_LabelPastPost);
               this.Controls.Add(this.m_ListBoxPastPost);
               this.Controls.Add(this.m_ButtonPost);
               this.Controls.Add(this.m_TextBoxPost);
               this.Controls.Add(this.m_LabelWritePost);
               this.Name = "StatusForm";
               this.Text = "Status";
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.Label m_LabelWritePost;
          private System.Windows.Forms.TextBox m_TextBoxPost;
          private System.Windows.Forms.Button m_ButtonPost;
          private System.Windows.Forms.ListBox m_ListBoxPastPost;
          private System.Windows.Forms.Label m_LabelPastPost;
     }
}