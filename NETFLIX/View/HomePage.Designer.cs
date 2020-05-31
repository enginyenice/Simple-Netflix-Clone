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
            this.Films = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DiziList = new System.Windows.Forms.ListView();
            this.FilmList = new System.Windows.Forms.ListView();
            this.OnerilenlerList = new System.Windows.Forms.ListView();
            this.OnerilenLabel = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.typeIDCombo = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.programName = new System.Windows.Forms.TextBox();
            this.TypeCombo = new System.Windows.Forms.ComboBox();
            this.arananList = new System.Windows.Forms.ListView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Logout = new System.Windows.Forms.Button();
            this.TakipBtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.TakipEttigimProgramlarList = new System.Windows.Forms.ListView();
            this.dogumtarihi = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.eposta = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.adsoyad = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Films
            // 
            this.Films.AutoSize = true;
            this.Films.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Films.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.Films.Location = new System.Drawing.Point(8, 19);
            this.Films.Name = "Films";
            this.Films.Size = new System.Drawing.Size(76, 25);
            this.Films.TabIndex = 5;
            this.Films.Text = "Filmler";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.label3.Location = new System.Drawing.Point(8, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Diziler";
            // 
            // DiziList
            // 
            this.DiziList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DiziList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.DiziList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.DiziList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.DiziList.FullRowSelect = true;
            this.DiziList.GridLines = true;
            this.DiziList.HideSelection = false;
            this.DiziList.Location = new System.Drawing.Point(10, 44);
            this.DiziList.Name = "DiziList";
            this.DiziList.Size = new System.Drawing.Size(1060, 380);
            this.DiziList.TabIndex = 6;
            this.DiziList.UseCompatibleStateImageBehavior = false;
            this.DiziList.View = System.Windows.Forms.View.Details;
            this.DiziList.DoubleClick += new System.EventHandler(this.DiziList_DoubleClick);
            // 
            // FilmList
            // 
            this.FilmList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FilmList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.FilmList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.FilmList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.FilmList.FullRowSelect = true;
            this.FilmList.GridLines = true;
            this.FilmList.HideSelection = false;
            this.FilmList.Location = new System.Drawing.Point(8, 47);
            this.FilmList.Name = "FilmList";
            this.FilmList.Size = new System.Drawing.Size(1060, 380);
            this.FilmList.TabIndex = 8;
            this.FilmList.UseCompatibleStateImageBehavior = false;
            this.FilmList.View = System.Windows.Forms.View.Details;
            this.FilmList.SelectedIndexChanged += new System.EventHandler(this.FilmList_SelectedIndexChanged);
            this.FilmList.DoubleClick += new System.EventHandler(this.FilmList_DoubleClick);
            // 
            // OnerilenlerList
            // 
            this.OnerilenlerList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OnerilenlerList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.OnerilenlerList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OnerilenlerList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.OnerilenlerList.FullRowSelect = true;
            this.OnerilenlerList.GridLines = true;
            this.OnerilenlerList.HideSelection = false;
            this.OnerilenlerList.Location = new System.Drawing.Point(10, 66);
            this.OnerilenlerList.Name = "OnerilenlerList";
            this.OnerilenlerList.Size = new System.Drawing.Size(1060, 356);
            this.OnerilenlerList.TabIndex = 9;
            this.OnerilenlerList.UseCompatibleStateImageBehavior = false;
            this.OnerilenlerList.View = System.Windows.Forms.View.Details;
            this.OnerilenlerList.DoubleClick += new System.EventHandler(this.OnerilenlerList_DoubleClick);
            // 
            // OnerilenLabel
            // 
            this.OnerilenLabel.AutoSize = true;
            this.OnerilenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.OnerilenLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.OnerilenLabel.Location = new System.Drawing.Point(355, 14);
            this.OnerilenLabel.Name = "OnerilenLabel";
            this.OnerilenLabel.Size = new System.Drawing.Size(217, 25);
            this.OnerilenLabel.TabIndex = 10;
            this.OnerilenLabel.Text = "Senin İçin Önerilenler";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1084, 461);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.tabPage1.Controls.Add(this.FilmList);
            this.tabPage1.Controls.Add(this.Films);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1076, 432);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Filmler";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.tabPage2.Controls.Add(this.DiziList);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1076, 432);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Diziler";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.typeIDCombo);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.programName);
            this.tabPage3.Controls.Add(this.TypeCombo);
            this.tabPage3.Controls.Add(this.arananList);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1076, 432);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Arama Yap";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.label8.Location = new System.Drawing.Point(8, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 25);
            this.label8.TabIndex = 9;
            this.label8.Text = "Arama";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.label6.Location = new System.Drawing.Point(10, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "-";
            // 
            // typeIDCombo
            // 
            this.typeIDCombo.FormattingEnabled = true;
            this.typeIDCombo.Items.AddRange(new object[] {
            "-1"});
            this.typeIDCombo.Location = new System.Drawing.Point(12000, 151);
            this.typeIDCombo.Name = "typeIDCombo";
            this.typeIDCombo.Size = new System.Drawing.Size(121, 24);
            this.typeIDCombo.TabIndex = 6;
            this.typeIDCombo.Visible = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.button1.Location = new System.Drawing.Point(986, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 53);
            this.button1.TabIndex = 5;
            this.button1.Text = "Ara";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.SearchButton);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(710, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Program Adı:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(765, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tür:";
            // 
            // programName
            // 
            this.programName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.programName.Location = new System.Drawing.Point(803, 12);
            this.programName.Name = "programName";
            this.programName.Size = new System.Drawing.Size(177, 22);
            this.programName.TabIndex = 2;
            // 
            // TypeCombo
            // 
            this.TypeCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TypeCombo.FormattingEnabled = true;
            this.TypeCombo.Location = new System.Drawing.Point(803, 40);
            this.TypeCombo.Name = "TypeCombo";
            this.TypeCombo.Size = new System.Drawing.Size(177, 24);
            this.TypeCombo.TabIndex = 1;
            this.TypeCombo.Tag = "";
            // 
            // arananList
            // 
            this.arananList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.arananList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.arananList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.arananList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.arananList.FullRowSelect = true;
            this.arananList.GridLines = true;
            this.arananList.HideSelection = false;
            this.arananList.Location = new System.Drawing.Point(11, 74);
            this.arananList.MultiSelect = false;
            this.arananList.Name = "arananList";
            this.arananList.Size = new System.Drawing.Size(1050, 350);
            this.arananList.TabIndex = 0;
            this.arananList.UseCompatibleStateImageBehavior = false;
            this.arananList.View = System.Windows.Forms.View.Details;
            this.arananList.DoubleClick += new System.EventHandler(this.ArananList_DoubleClick);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.OnerilenlerList);
            this.tabPage4.Controls.Add(this.OnerilenLabel);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1076, 432);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Önerilen";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "label7";
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.tabPage6.Controls.Add(this.pictureBox1);
            this.tabPage6.Controls.Add(this.Logout);
            this.tabPage6.Controls.Add(this.TakipBtn);
            this.tabPage6.Controls.Add(this.label10);
            this.tabPage6.Controls.Add(this.TakipEttigimProgramlarList);
            this.tabPage6.Controls.Add(this.dogumtarihi);
            this.tabPage6.Controls.Add(this.label14);
            this.tabPage6.Controls.Add(this.eposta);
            this.tabPage6.Controls.Add(this.label12);
            this.tabPage6.Controls.Add(this.adsoyad);
            this.tabPage6.Controls.Add(this.label9);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1076, 432);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Hesabım";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(9, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 83);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Logout
            // 
            this.Logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.Logout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.Logout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.Logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Logout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.Logout.Location = new System.Drawing.Point(903, 10);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(165, 36);
            this.Logout.TabIndex = 13;
            this.Logout.Text = "Oturumu Kapat";
            this.Logout.UseVisualStyleBackColor = false;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // TakipBtn
            // 
            this.TakipBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TakipBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.TakipBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.TakipBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.TakipBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.TakipBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TakipBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TakipBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.TakipBtn.Location = new System.Drawing.Point(637, 93);
            this.TakipBtn.Name = "TakipBtn";
            this.TakipBtn.Size = new System.Drawing.Size(431, 36);
            this.TakipBtn.TabIndex = 12;
            this.TakipBtn.Text = "Takip Ettiğim Programlar Getir";
            this.TakipBtn.UseVisualStyleBackColor = false;
            this.TakipBtn.Click += new System.EventHandler(this.TakipBtn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.label10.Location = new System.Drawing.Point(8, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(247, 25);
            this.label10.TabIndex = 11;
            this.label10.Text = "Takip Ettiğim Programlar";
            // 
            // TakipEttigimProgramlarList
            // 
            this.TakipEttigimProgramlarList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TakipEttigimProgramlarList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.TakipEttigimProgramlarList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TakipEttigimProgramlarList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.TakipEttigimProgramlarList.FullRowSelect = true;
            this.TakipEttigimProgramlarList.GridLines = true;
            this.TakipEttigimProgramlarList.HideSelection = false;
            this.TakipEttigimProgramlarList.Location = new System.Drawing.Point(11, 132);
            this.TakipEttigimProgramlarList.Name = "TakipEttigimProgramlarList";
            this.TakipEttigimProgramlarList.Size = new System.Drawing.Size(1057, 292);
            this.TakipEttigimProgramlarList.TabIndex = 6;
            this.TakipEttigimProgramlarList.UseCompatibleStateImageBehavior = false;
            this.TakipEttigimProgramlarList.View = System.Windows.Forms.View.Details;
            this.TakipEttigimProgramlarList.DoubleClick += new System.EventHandler(this.TakipEttigimProgramlarList_DoubleClick);
            // 
            // dogumtarihi
            // 
            this.dogumtarihi.AutoSize = true;
            this.dogumtarihi.Location = new System.Drawing.Point(231, 77);
            this.dogumtarihi.Name = "dogumtarihi";
            this.dogumtarihi.Size = new System.Drawing.Size(52, 16);
            this.dogumtarihi.TabIndex = 5;
            this.dogumtarihi.Text = "label13";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(115, 77);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 16);
            this.label14.TabIndex = 4;
            this.label14.Text = "Doğum Tarihi:";
            // 
            // eposta
            // 
            this.eposta.AutoSize = true;
            this.eposta.Location = new System.Drawing.Point(231, 48);
            this.eposta.Name = "eposta";
            this.eposta.Size = new System.Drawing.Size(52, 16);
            this.eposta.TabIndex = 3;
            this.eposta.Text = "label11";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(115, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 16);
            this.label12.TabIndex = 2;
            this.label12.Text = "E-Posta";
            // 
            // adsoyad
            // 
            this.adsoyad.AutoSize = true;
            this.adsoyad.Location = new System.Drawing.Point(231, 21);
            this.adsoyad.Name = "adsoyad";
            this.adsoyad.Size = new System.Drawing.Size(52, 16);
            this.adsoyad.TabIndex = 1;
            this.adsoyad.Text = "label10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(115, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Ad Soyad:";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1084, 461);
            this.Controls.Add(this.tabControl1);
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NETFLIX";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HomePage_FormClosed);
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Films;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView DiziList;
        private System.Windows.Forms.ListView FilmList;
        private System.Windows.Forms.ListView OnerilenlerList;
        private System.Windows.Forms.Label OnerilenLabel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox programName;
        private System.Windows.Forms.ComboBox TypeCombo;
        private System.Windows.Forms.ListView arananList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox typeIDCombo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Label dogumtarihi;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label eposta;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label adsoyad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button TakipBtn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListView TakipEttigimProgramlarList;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}