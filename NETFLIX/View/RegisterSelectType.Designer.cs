namespace NETFLIX.View
{
    partial class RegisterSelectType
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
            this.TypeCheckList = new System.Windows.Forms.CheckedListBox();
            this.SelectTypeList = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 107);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // TypeCheckList
            // 
            this.TypeCheckList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.TypeCheckList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.TypeCheckList.FormattingEnabled = true;
            this.TypeCheckList.Location = new System.Drawing.Point(16, 122);
            this.TypeCheckList.Margin = new System.Windows.Forms.Padding(4);
            this.TypeCheckList.Name = "TypeCheckList";
            this.TypeCheckList.Size = new System.Drawing.Size(285, 276);
            this.TypeCheckList.TabIndex = 1;
            // 
            // SelectTypeList
            // 
            this.SelectTypeList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.SelectTypeList.Cursor = System.Windows.Forms.Cursors.Default;
            this.SelectTypeList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectTypeList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.SelectTypeList.Location = new System.Drawing.Point(16, 411);
            this.SelectTypeList.Margin = new System.Windows.Forms.Padding(4);
            this.SelectTypeList.Name = "SelectTypeList";
            this.SelectTypeList.Size = new System.Drawing.Size(287, 28);
            this.SelectTypeList.TabIndex = 2;
            this.SelectTypeList.Text = "Seçimi Tamamla";
            this.SelectTypeList.UseVisualStyleBackColor = false;
            this.SelectTypeList.Click += new System.EventHandler(this.SelectTypeList_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(180, 21);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 84);
            this.listBox1.TabIndex = 3;
            this.listBox1.Visible = false;
            // 
            // RegisterSelectType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(311, 447);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.SelectTypeList);
            this.Controls.Add(this.TypeCheckList);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RegisterSelectType";
            this.Text = "Tür Seçimi Yap";
            this.Load += new System.EventHandler(this.RegisterSelectType_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox TypeCheckList;
        private System.Windows.Forms.Button SelectTypeList;
        private System.Windows.Forms.ListBox listBox1;
    }
}