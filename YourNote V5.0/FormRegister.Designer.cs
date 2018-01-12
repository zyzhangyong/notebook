namespace DesktopNote
{
    partial class FormRegister
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
            this.textBoxAccount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPwd = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnRegisCancel = new System.Windows.Forms.Button();
            this.comboBoxQuanxian = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPwd2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxAccount
            // 
            this.textBoxAccount.Location = new System.Drawing.Point(214, 78);
            this.textBoxAccount.Name = "textBoxAccount";
            this.textBoxAccount.Size = new System.Drawing.Size(171, 25);
            this.textBoxAccount.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "账号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "用户权限";
            // 
            // textBoxPwd
            // 
            this.textBoxPwd.Location = new System.Drawing.Point(214, 124);
            this.textBoxPwd.Name = "textBoxPwd";
            this.textBoxPwd.Size = new System.Drawing.Size(171, 25);
            this.textBoxPwd.TabIndex = 1;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(179, 336);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 31);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "注册";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnRegisCancel
            // 
            this.btnRegisCancel.Location = new System.Drawing.Point(275, 335);
            this.btnRegisCancel.Name = "btnRegisCancel";
            this.btnRegisCancel.Size = new System.Drawing.Size(75, 32);
            this.btnRegisCancel.TabIndex = 5;
            this.btnRegisCancel.Text = "取消";
            this.btnRegisCancel.UseVisualStyleBackColor = true;
            this.btnRegisCancel.Click += new System.EventHandler(this.btnRegisCancel_Click);
            // 
            // comboBoxQuanxian
            // 
            this.comboBoxQuanxian.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxQuanxian.FormattingEnabled = true;
            this.comboBoxQuanxian.Items.AddRange(new object[] {
            "admin",
            "user"});
            this.comboBoxQuanxian.Location = new System.Drawing.Point(214, 216);
            this.comboBoxQuanxian.Name = "comboBoxQuanxian";
            this.comboBoxQuanxian.Size = new System.Drawing.Size(171, 23);
            this.comboBoxQuanxian.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "确认密码";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxPwd2
            // 
            this.textBoxPwd2.Location = new System.Drawing.Point(214, 169);
            this.textBoxPwd2.Name = "textBoxPwd2";
            this.textBoxPwd2.Size = new System.Drawing.Size(171, 25);
            this.textBoxPwd2.TabIndex = 2;
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 483);
            this.Controls.Add(this.comboBoxQuanxian);
            this.Controls.Add(this.btnRegisCancel);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPwd2);
            this.Controls.Add(this.textBoxPwd);
            this.Controls.Add(this.textBoxAccount);
            this.Name = "FormRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRegister";
            this.Load += new System.EventHandler(this.FormRegister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPwd;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnRegisCancel;
        private System.Windows.Forms.ComboBox comboBoxQuanxian;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPwd2;
    }
}