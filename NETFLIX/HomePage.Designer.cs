namespace NETFLIX
{
    partial class HomePage
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
            this.ApplicationClose = new System.Windows.Forms.Button();
            this.SignOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ApplicationClose
            // 
            this.ApplicationClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ApplicationClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.ApplicationClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(16)))), ((int)(((byte)(36)))));
            this.ApplicationClose.FlatAppearance.BorderSize = 2;
            this.ApplicationClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApplicationClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.ApplicationClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(241)))));
            this.ApplicationClose.Location = new System.Drawing.Point(1138, 690);
            this.ApplicationClose.Name = "ApplicationClose";
            this.ApplicationClose.Size = new System.Drawing.Size(130, 30);
            this.ApplicationClose.TabIndex = 0;
            this.ApplicationClose.Text = "Programı Kapat";
            this.ApplicationClose.UseVisualStyleBackColor = false;
            this.ApplicationClose.Click += new System.EventHandler(this.ApplicationClose_Click);
            // 
            // SignOut
            // 
            this.SignOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SignOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.SignOut.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(16)))), ((int)(((byte)(36)))));
            this.SignOut.FlatAppearance.BorderSize = 2;
            this.SignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.SignOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(241)))));
            this.SignOut.Location = new System.Drawing.Point(1138, 726);
            this.SignOut.Name = "SignOut";
            this.SignOut.Size = new System.Drawing.Size(130, 30);
            this.SignOut.TabIndex = 1;
            this.SignOut.Text = "Oturumu Kapat";
            this.SignOut.UseVisualStyleBackColor = false;
            this.SignOut.Click += new System.EventHandler(this.SignOut_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1280, 768);
            this.Controls.Add(this.SignOut);
            this.Controls.Add(this.ApplicationClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnaEkran";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ApplicationClose;
        private System.Windows.Forms.Button SignOut;
    }
}