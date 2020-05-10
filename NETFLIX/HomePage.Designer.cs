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
            this.components = new System.ComponentModel.Container();
            this.ApplicationClose = new System.Windows.Forms.Button();
            this.SignOut = new System.Windows.Forms.Button();
            this.HomePagePanel = new System.Windows.Forms.Panel();
            this.MenuBtn = new System.Windows.Forms.Button();
            this.MenuPage = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AccountInfoGroup = new System.Windows.Forms.GroupBox();
            this.UserID = new System.Windows.Forms.Label();
            this.UserNumber = new System.Windows.Forms.Label();
            this.EmailData = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SeriesGroup = new System.Windows.Forms.GroupBox();
            this.FilmGroup = new System.Windows.Forms.GroupBox();
            this.TypeGroup = new System.Windows.Forms.GroupBox();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.HomePagePanel.SuspendLayout();
            this.MenuPage.SuspendLayout();
            this.panel1.SuspendLayout();
            this.AccountInfoGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // ApplicationClose
            // 
            this.ApplicationClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.ApplicationClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(16)))), ((int)(((byte)(36)))));
            this.ApplicationClose.FlatAppearance.BorderSize = 2;
            this.ApplicationClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApplicationClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.ApplicationClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(241)))));
            this.ApplicationClose.Location = new System.Drawing.Point(126, 3);
            this.ApplicationClose.Name = "ApplicationClose";
            this.ApplicationClose.Size = new System.Drawing.Size(115, 60);
            this.ApplicationClose.TabIndex = 0;
            this.ApplicationClose.Text = "Programı Kapat";
            this.ApplicationClose.UseVisualStyleBackColor = false;
            this.ApplicationClose.Click += new System.EventHandler(this.ApplicationClose_Click);
            // 
            // SignOut
            // 
            this.SignOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.SignOut.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(16)))), ((int)(((byte)(36)))));
            this.SignOut.FlatAppearance.BorderSize = 2;
            this.SignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.SignOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(241)))));
            this.SignOut.Location = new System.Drawing.Point(0, 3);
            this.SignOut.Name = "SignOut";
            this.SignOut.Size = new System.Drawing.Size(115, 60);
            this.SignOut.TabIndex = 1;
            this.SignOut.Text = "Oturumu Kapat";
            this.SignOut.UseVisualStyleBackColor = false;
            this.SignOut.Click += new System.EventHandler(this.SignOut_Click);
            // 
            // HomePagePanel
            // 
            this.HomePagePanel.AutoSize = true;
            this.HomePagePanel.Controls.Add(this.MenuPage);
            this.HomePagePanel.Controls.Add(this.MenuBtn);
            this.HomePagePanel.Controls.Add(this.label3);
            this.HomePagePanel.Controls.Add(this.SeriesGroup);
            this.HomePagePanel.Controls.Add(this.FilmGroup);
            this.HomePagePanel.Controls.Add(this.TypeGroup);
            this.HomePagePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomePagePanel.Location = new System.Drawing.Point(0, 0);
            this.HomePagePanel.Name = "HomePagePanel";
            this.HomePagePanel.Size = new System.Drawing.Size(1280, 768);
            this.HomePagePanel.TabIndex = 2;
            // 
            // MenuBtn
            // 
            this.MenuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.MenuBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(16)))), ((int)(((byte)(36)))));
            this.MenuBtn.FlatAppearance.BorderSize = 2;
            this.MenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.MenuBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(241)))));
            this.MenuBtn.Location = new System.Drawing.Point(0, 0);
            this.MenuBtn.Name = "MenuBtn";
            this.MenuBtn.Size = new System.Drawing.Size(27, 27);
            this.MenuBtn.TabIndex = 4;
            this.MenuBtn.Text = "-";
            this.MenuBtn.UseVisualStyleBackColor = false;
            this.MenuBtn.Click += new System.EventHandler(this.MenuBtn_Click);
            // 
            // MenuPage
            // 
            this.MenuPage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MenuPage.Controls.Add(this.panel1);
            this.MenuPage.Controls.Add(this.AccountInfoGroup);
            this.MenuPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MenuPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(16)))), ((int)(((byte)(36)))));
            this.MenuPage.Location = new System.Drawing.Point(2000, 2000);
            this.MenuPage.Name = "MenuPage";
            this.MenuPage.Size = new System.Drawing.Size(250, 634);
            this.MenuPage.TabIndex = 3;
            this.MenuPage.TabStop = false;
            this.MenuPage.Text = "Menü";
            this.MenuPage.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ApplicationClose);
            this.panel1.Controls.Add(this.SignOut);
            this.panel1.Location = new System.Drawing.Point(6, 234);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 65);
            this.panel1.TabIndex = 4;
            // 
            // AccountInfoGroup
            // 
            this.AccountInfoGroup.Controls.Add(this.UserID);
            this.AccountInfoGroup.Controls.Add(this.UserNumber);
            this.AccountInfoGroup.Controls.Add(this.EmailData);
            this.AccountInfoGroup.Controls.Add(this.Email);
            this.AccountInfoGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccountInfoGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.AccountInfoGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(16)))), ((int)(((byte)(36)))));
            this.AccountInfoGroup.Location = new System.Drawing.Point(6, 28);
            this.AccountInfoGroup.Name = "AccountInfoGroup";
            this.AccountInfoGroup.Size = new System.Drawing.Size(238, 128);
            this.AccountInfoGroup.TabIndex = 3;
            this.AccountInfoGroup.TabStop = false;
            this.AccountInfoGroup.Text = "Hesap Bilgileri";
            // 
            // UserID
            // 
            this.UserID.AutoSize = true;
            this.UserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UserID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.UserID.Location = new System.Drawing.Point(5, 98);
            this.UserID.Name = "UserID";
            this.UserID.Size = new System.Drawing.Size(18, 20);
            this.UserID.TabIndex = 8;
            this.UserID.Text = "1";
            // 
            // UserNumber
            // 
            this.UserNumber.AutoSize = true;
            this.UserNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.UserNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.UserNumber.Location = new System.Drawing.Point(6, 82);
            this.UserNumber.Name = "UserNumber";
            this.UserNumber.Size = new System.Drawing.Size(136, 16);
            this.UserNumber.TabIndex = 7;
            this.UserNumber.Text = "Kullanıcı Numarası";
            // 
            // EmailData
            // 
            this.EmailData.AutoSize = true;
            this.EmailData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.EmailData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.EmailData.Location = new System.Drawing.Point(6, 50);
            this.EmailData.Name = "EmailData";
            this.EmailData.Size = new System.Drawing.Size(216, 20);
            this.EmailData.TabIndex = 6;
            this.EmailData.Text = "enginyenice2626@gmail.com";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.Email.Location = new System.Drawing.Point(6, 34);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(63, 16);
            this.Email.TabIndex = 5;
            this.Email.Text = "E-Posta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(16)))), ((int)(((byte)(36)))));
            this.label3.Location = new System.Drawing.Point(526, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 55);
            this.label3.TabIndex = 7;
            this.label3.Text = "NETFLIX";
            // 
            // SeriesGroup
            // 
            this.SeriesGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SeriesGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SeriesGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.SeriesGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(16)))), ((int)(((byte)(36)))));
            this.SeriesGroup.Location = new System.Drawing.Point(0, 500);
            this.SeriesGroup.Name = "SeriesGroup";
            this.SeriesGroup.Size = new System.Drawing.Size(1280, 250);
            this.SeriesGroup.TabIndex = 4;
            this.SeriesGroup.TabStop = false;
            this.SeriesGroup.Text = "Diziler";
            // 
            // FilmGroup
            // 
            this.FilmGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FilmGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FilmGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.FilmGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(16)))), ((int)(((byte)(36)))));
            this.FilmGroup.Location = new System.Drawing.Point(0, 250);
            this.FilmGroup.Name = "FilmGroup";
            this.FilmGroup.Size = new System.Drawing.Size(1280, 250);
            this.FilmGroup.TabIndex = 3;
            this.FilmGroup.TabStop = false;
            this.FilmGroup.Text = "Diziler";
            // 
            // TypeGroup
            // 
            this.TypeGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TypeGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TypeGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TypeGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(16)))), ((int)(((byte)(36)))));
            this.TypeGroup.Location = new System.Drawing.Point(0, 100);
            this.TypeGroup.Name = "TypeGroup";
            this.TypeGroup.Size = new System.Drawing.Size(1280, 150);
            this.TypeGroup.TabIndex = 2;
            this.TypeGroup.TabStop = false;
            this.TypeGroup.Text = "Türler";
            // 
            // Timer1
            // 
            this.Timer1.Interval = 5;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1280, 768);
            this.Controls.Add(this.HomePagePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnaEkran";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.HomePagePanel.ResumeLayout(false);
            this.HomePagePanel.PerformLayout();
            this.MenuPage.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.AccountInfoGroup.ResumeLayout(false);
            this.AccountInfoGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ApplicationClose;
        private System.Windows.Forms.Button SignOut;
        private System.Windows.Forms.Panel HomePagePanel;
        private System.Windows.Forms.GroupBox TypeGroup;
        private System.Windows.Forms.GroupBox SeriesGroup;
        private System.Windows.Forms.GroupBox FilmGroup;
        private System.Windows.Forms.GroupBox AccountInfoGroup;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label EmailData;
        private System.Windows.Forms.Label UserID;
        private System.Windows.Forms.Label UserNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox MenuPage;
        private System.Windows.Forms.Button MenuBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer Timer1;
    }
}