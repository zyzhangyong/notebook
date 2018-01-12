namespace DesktopNote
{
    partial class FormModNoteName
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
            this.label2 = new System.Windows.Forms.Label();
            this.labelNoteName = new System.Windows.Forms.Label();
            this.tbModName = new System.Windows.Forms.TextBox();
            this.btnModName = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "原笔记名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "新笔记名：";
            // 
            // labelNoteName
            // 
            this.labelNoteName.AutoSize = true;
            this.labelNoteName.Location = new System.Drawing.Point(125, 47);
            this.labelNoteName.Name = "labelNoteName";
            this.labelNoteName.Size = new System.Drawing.Size(55, 15);
            this.labelNoteName.TabIndex = 2;
            this.labelNoteName.Text = "label3";
            // 
            // tbModName
            // 
            this.tbModName.Location = new System.Drawing.Point(121, 90);
            this.tbModName.Name = "tbModName";
            this.tbModName.Size = new System.Drawing.Size(113, 25);
            this.tbModName.TabIndex = 3;
            // 
            // btnModName
            // 
            this.btnModName.Location = new System.Drawing.Point(42, 178);
            this.btnModName.Name = "btnModName";
            this.btnModName.Size = new System.Drawing.Size(75, 33);
            this.btnModName.TabIndex = 4;
            this.btnModName.Text = "确定";
            this.btnModName.UseVisualStyleBackColor = true;
            this.btnModName.Click += new System.EventHandler(this.btnModName_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(145, 178);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 33);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormModNoteName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 253);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnModName);
            this.Controls.Add(this.tbModName);
            this.Controls.Add(this.labelNoteName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormModNoteName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormModNoteName";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnModName;
        private System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Label labelNoteName;
        public System.Windows.Forms.TextBox tbModName;
    }
}