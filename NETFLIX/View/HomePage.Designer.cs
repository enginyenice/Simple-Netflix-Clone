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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 38);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(200, 43);
            this.listBox1.TabIndex = 3;
            // 
            // Films
            // 
            this.Films.AutoSize = true;
            this.Films.Location = new System.Drawing.Point(12, 104);
            this.Films.Name = "Films";
            this.Films.Size = new System.Drawing.Size(36, 13);
            this.Films.TabIndex = 5;
            this.Films.Text = "Filmler";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Diziler";
            // 
            // DiziList
            // 
            this.DiziList.FullRowSelect = true;
            this.DiziList.HideSelection = false;
            this.DiziList.Location = new System.Drawing.Point(15, 278);
            this.DiziList.Name = "DiziList";
            this.DiziList.Size = new System.Drawing.Size(949, 160);
            this.DiziList.TabIndex = 6;
            this.DiziList.UseCompatibleStateImageBehavior = false;
            this.DiziList.View = System.Windows.Forms.View.Details;
            // 
            // FilmList
            // 
            this.FilmList.FullRowSelect = true;
            this.FilmList.HideSelection = false;
            this.FilmList.Location = new System.Drawing.Point(12, 120);
            this.FilmList.Name = "FilmList";
            this.FilmList.Size = new System.Drawing.Size(949, 139);
            this.FilmList.TabIndex = 8;
            this.FilmList.UseCompatibleStateImageBehavior = false;
            this.FilmList.View = System.Windows.Forms.View.Details;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 450);
            this.Controls.Add(this.FilmList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DiziList);
            this.Controls.Add(this.Films);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}