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
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
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
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(19, 99);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(422, 16);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(200, 199);
            this.listBox1.TabIndex = 3;
            // 
            // Films
            // 
            this.Films.AutoSize = true;
            this.Films.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Films.Location = new System.Drawing.Point(10, 14);
            this.Films.Name = "Films";
            this.Films.Size = new System.Drawing.Size(124, 25);
            this.Films.TabIndex = 5;
            this.Films.Text = "Tüm Filmler";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label3.Location = new System.Drawing.Point(8, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tüm Diziler";
            // 
            // DiziList
            // 
            this.DiziList.FullRowSelect = true;
            this.DiziList.GridLines = true;
            this.DiziList.HideSelection = false;
            this.DiziList.Location = new System.Drawing.Point(8, 40);
            this.DiziList.Name = "DiziList";
            this.DiziList.Size = new System.Drawing.Size(1078, 519);
            this.DiziList.TabIndex = 6;
            this.DiziList.UseCompatibleStateImageBehavior = false;
            this.DiziList.View = System.Windows.Forms.View.Details;
            this.DiziList.DoubleClick += new System.EventHandler(this.DiziList_DoubleClick);
            // 
            // FilmList
            // 
            this.FilmList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.FilmList.FullRowSelect = true;
            this.FilmList.GridLines = true;
            this.FilmList.HideSelection = false;
            this.FilmList.Location = new System.Drawing.Point(15, 42);
            this.FilmList.Name = "FilmList";
            this.FilmList.Size = new System.Drawing.Size(819, 217);
            this.FilmList.TabIndex = 8;
            this.FilmList.UseCompatibleStateImageBehavior = false;
            this.FilmList.View = System.Windows.Forms.View.Details;
            this.FilmList.SelectedIndexChanged += new System.EventHandler(this.FilmList_SelectedIndexChanged);
            this.FilmList.DoubleClick += new System.EventHandler(this.FilmList_DoubleClick);
            // 
            // OnerilenlerList
            // 
            this.OnerilenlerList.FullRowSelect = true;
            this.OnerilenlerList.GridLines = true;
            this.OnerilenlerList.HideSelection = false;
            this.OnerilenlerList.Location = new System.Drawing.Point(13, 42);
            this.OnerilenlerList.Name = "OnerilenlerList";
            this.OnerilenlerList.Size = new System.Drawing.Size(1073, 517);
            this.OnerilenlerList.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.OnerilenlerList.TabIndex = 9;
            this.OnerilenlerList.UseCompatibleStateImageBehavior = false;
            this.OnerilenlerList.View = System.Windows.Forms.View.Details;
            this.OnerilenlerList.DoubleClick += new System.EventHandler(this.OnerilenlerList_DoubleClick);
            // 
            // OnerilenLabel
            // 
            this.OnerilenLabel.AutoSize = true;
            this.OnerilenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.OnerilenLabel.Location = new System.Drawing.Point(8, 14);
            this.OnerilenLabel.Name = "OnerilenLabel";
            this.OnerilenLabel.Size = new System.Drawing.Size(217, 25);
            this.OnerilenLabel.TabIndex = 10;
            this.OnerilenLabel.Text = "Senin İçin Önerilenler";
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(850, 451);
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
            this.tabPage1.Size = new System.Drawing.Size(842, 422);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Filmler";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DiziList);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(842, 422);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Diziler";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
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
            this.tabPage3.Size = new System.Drawing.Size(842, 422);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Arama Yap";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(320, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "label6";
            // 
            // typeIDCombo
            // 
            this.typeIDCombo.FormattingEnabled = true;
            this.typeIDCombo.Items.AddRange(new object[] {
            "-1"});
            this.typeIDCombo.Location = new System.Drawing.Point(965, 72);
            this.typeIDCombo.Name = "typeIDCombo";
            this.typeIDCombo.Size = new System.Drawing.Size(121, 21);
            this.typeIDCombo.TabIndex = 6;
            this.typeIDCombo.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(210, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 45);
            this.button1.TabIndex = 5;
            this.button1.Text = "Ara";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SearchButton);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Program Adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tür:";
            // 
            // programName
            // 
            this.programName.Location = new System.Drawing.Point(83, 45);
            this.programName.Name = "programName";
            this.programName.Size = new System.Drawing.Size(121, 20);
            this.programName.TabIndex = 2;
            // 
            // TypeCombo
            // 
            this.TypeCombo.FormattingEnabled = true;
            this.TypeCombo.Location = new System.Drawing.Point(83, 18);
            this.TypeCombo.Name = "TypeCombo";
            this.TypeCombo.Size = new System.Drawing.Size(121, 21);
            this.TypeCombo.TabIndex = 1;
            this.TypeCombo.Tag = "";
            // 
            // arananList
            // 
            this.arananList.FullRowSelect = true;
            this.arananList.GridLines = true;
            this.arananList.HideSelection = false;
            this.arananList.Location = new System.Drawing.Point(8, 72);
            this.arananList.MultiSelect = false;
            this.arananList.Name = "arananList";
            this.arananList.Size = new System.Drawing.Size(1078, 504);
            this.arananList.TabIndex = 0;
            this.arananList.UseCompatibleStateImageBehavior = false;
            this.arananList.View = System.Windows.Forms.View.Details;
            this.arananList.DoubleClick += new System.EventHandler(this.ArananList_DoubleClick);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.OnerilenlerList);
            this.tabPage4.Controls.Add(this.OnerilenLabel);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(842, 422);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Önerilen";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(318, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "label7";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.listBox1);
            this.tabPage5.Controls.Add(this.dateTimePicker1);
            this.tabPage5.Controls.Add(this.label2);
            this.tabPage5.Controls.Add(this.label1);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(842, 422);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Kalabalık";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(842, 422);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "İzle";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(850, 451);
            this.Controls.Add(this.tabControl1);
            this.IsMdiContainer = true;
            this.Name = "HomePage";
            this.Text = "HomePage";
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
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
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
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox programName;
        private System.Windows.Forms.ComboBox TypeCombo;
        private System.Windows.Forms.ListView arananList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox typeIDCombo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage6;
    }
}