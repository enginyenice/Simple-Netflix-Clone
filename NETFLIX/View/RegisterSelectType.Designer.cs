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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 87);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // TypeCheckList
            // 
            this.TypeCheckList.FormattingEnabled = true;
            this.TypeCheckList.Location = new System.Drawing.Point(12, 99);
            this.TypeCheckList.Name = "TypeCheckList";
            this.TypeCheckList.Size = new System.Drawing.Size(215, 229);
            this.TypeCheckList.TabIndex = 2;
            // 
            // SelectTypeList
            // 
            this.SelectTypeList.Location = new System.Drawing.Point(12, 334);
            this.SelectTypeList.Name = "SelectTypeList";
            this.SelectTypeList.Size = new System.Drawing.Size(215, 23);
            this.SelectTypeList.TabIndex = 3;
            this.SelectTypeList.Text = "Seçimi Tamamla";
            this.SelectTypeList.UseVisualStyleBackColor = true;
            this.SelectTypeList.Click += new System.EventHandler(this.SelectTypeList_Click);
            // 
            // RegisterSelectType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 363);
            this.Controls.Add(this.SelectTypeList);
            this.Controls.Add(this.TypeCheckList);
            this.Controls.Add(this.label1);
            this.Name = "RegisterSelectType";
            this.Text = "RegisterSelectType";
            this.Load += new System.EventHandler(this.RegisterSelectType_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox TypeCheckList;
        private System.Windows.Forms.Button SelectTypeList;
    }
}