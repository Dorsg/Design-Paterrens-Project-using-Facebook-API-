namespace BasicFacebookFeatures
{
    partial class FormMain
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
               System.Windows.Forms.Button buttonLogin;
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
               this.buttonLogout = new System.Windows.Forms.Button();
               this.pictureBox1 = new System.Windows.Forms.PictureBox();
               buttonLogin = new System.Windows.Forms.Button();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
               this.SuspendLayout();
               // 
               // buttonLogin
               // 
               buttonLogin.Location = new System.Drawing.Point(169, 164);
               buttonLogin.Name = "buttonLogin";
               buttonLogin.Size = new System.Drawing.Size(179, 33);
               buttonLogin.TabIndex = 36;
               buttonLogin.Text = "Login";
               buttonLogin.UseVisualStyleBackColor = true;
               buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
               // 
               // buttonLogout
               // 
               this.buttonLogout.Location = new System.Drawing.Point(169, 203);
               this.buttonLogout.Name = "buttonLogout";
               this.buttonLogout.Size = new System.Drawing.Size(179, 32);
               this.buttonLogout.TabIndex = 52;
               this.buttonLogout.Text = "Logout";
               this.buttonLogout.UseVisualStyleBackColor = true;
               this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
               // 
               // pictureBox1
               // 
               this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
               this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
               this.pictureBox1.Location = new System.Drawing.Point(80, 67);
               this.pictureBox1.Name = "pictureBox1";
               this.pictureBox1.Size = new System.Drawing.Size(366, 81);
               this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
               this.pictureBox1.TabIndex = 53;
               this.pictureBox1.TabStop = false;
               // 
               // FormMain
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
               this.ClientSize = new System.Drawing.Size(523, 339);
               this.Controls.Add(this.pictureBox1);
               this.Controls.Add(this.buttonLogout);
               this.Controls.Add(buttonLogin);
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
               this.Name = "FormMain";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.Text = "Facbook App";
               this.Load += new System.EventHandler(this.FormMain_Load);
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
               this.ResumeLayout(false);

        }

		#endregion
		private System.Windows.Forms.Button buttonLogout;
          private System.Windows.Forms.PictureBox pictureBox1;
     }
}

