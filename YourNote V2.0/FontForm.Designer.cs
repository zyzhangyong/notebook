namespace DesktopNote
{
    partial class FontForm
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
            this.fontComboBox = new System.Windows.Forms.ComboBox();
            this.sizeGroupBox = new System.Windows.Forms.GroupBox();
            this.sizeRadioButton4 = new System.Windows.Forms.RadioButton();
            this.sizeRadioButton3 = new System.Windows.Forms.RadioButton();
            this.sizeRadioButton2 = new System.Windows.Forms.RadioButton();
            this.sizeRadioButton1 = new System.Windows.Forms.RadioButton();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.boldCheckBox = new System.Windows.Forms.CheckBox();
            this.italicCheckBox = new System.Windows.Forms.CheckBox();
            this.underlineCheckBox = new System.Windows.Forms.CheckBox();
            this.strikeoutCheckBox = new System.Windows.Forms.CheckBox();
            this.applyButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.sizeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "字体:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // fontComboBox
            // 
            this.fontComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fontComboBox.FormattingEnabled = true;
            this.fontComboBox.Items.AddRange(new object[] {
            "宋体",
            "黑色",
            "楷体"});
            this.fontComboBox.Location = new System.Drawing.Point(99, 68);
            this.fontComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fontComboBox.Name = "fontComboBox";
            this.fontComboBox.Size = new System.Drawing.Size(155, 23);
            this.fontComboBox.TabIndex = 1;
            this.fontComboBox.SelectedIndexChanged += new System.EventHandler(this.fontComboBox_SelectedIndexChanged);
            // 
            // sizeGroupBox
            // 
            this.sizeGroupBox.Controls.Add(this.sizeRadioButton4);
            this.sizeGroupBox.Controls.Add(this.sizeRadioButton3);
            this.sizeGroupBox.Controls.Add(this.sizeRadioButton2);
            this.sizeGroupBox.Controls.Add(this.sizeRadioButton1);
            this.sizeGroupBox.Location = new System.Drawing.Point(40, 129);
            this.sizeGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sizeGroupBox.Name = "sizeGroupBox";
            this.sizeGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sizeGroupBox.Size = new System.Drawing.Size(215, 184);
            this.sizeGroupBox.TabIndex = 2;
            this.sizeGroupBox.TabStop = false;
            this.sizeGroupBox.Text = "字体大小";
            // 
            // sizeRadioButton4
            // 
            this.sizeRadioButton4.AutoSize = true;
            this.sizeRadioButton4.Location = new System.Drawing.Point(27, 121);
            this.sizeRadioButton4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sizeRadioButton4.Name = "sizeRadioButton4";
            this.sizeRadioButton4.Size = new System.Drawing.Size(44, 19);
            this.sizeRadioButton4.TabIndex = 0;
            this.sizeRadioButton4.TabStop = true;
            this.sizeRadioButton4.Text = "12";
            this.sizeRadioButton4.UseVisualStyleBackColor = true;
            this.sizeRadioButton4.CheckedChanged += new System.EventHandler(this.sizeRadioButton_CheckedChanged);
            // 
            // sizeRadioButton3
            // 
            this.sizeRadioButton3.AutoSize = true;
            this.sizeRadioButton3.Location = new System.Drawing.Point(27, 94);
            this.sizeRadioButton3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sizeRadioButton3.Name = "sizeRadioButton3";
            this.sizeRadioButton3.Size = new System.Drawing.Size(44, 19);
            this.sizeRadioButton3.TabIndex = 0;
            this.sizeRadioButton3.TabStop = true;
            this.sizeRadioButton3.Text = "11";
            this.sizeRadioButton3.UseVisualStyleBackColor = true;
            this.sizeRadioButton3.CheckedChanged += new System.EventHandler(this.sizeRadioButton_CheckedChanged);
            // 
            // sizeRadioButton2
            // 
            this.sizeRadioButton2.AutoSize = true;
            this.sizeRadioButton2.Location = new System.Drawing.Point(27, 66);
            this.sizeRadioButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sizeRadioButton2.Name = "sizeRadioButton2";
            this.sizeRadioButton2.Size = new System.Drawing.Size(44, 19);
            this.sizeRadioButton2.TabIndex = 0;
            this.sizeRadioButton2.TabStop = true;
            this.sizeRadioButton2.Text = "10";
            this.sizeRadioButton2.UseVisualStyleBackColor = true;
            this.sizeRadioButton2.CheckedChanged += new System.EventHandler(this.sizeRadioButton_CheckedChanged);
            // 
            // sizeRadioButton1
            // 
            this.sizeRadioButton1.AutoSize = true;
            this.sizeRadioButton1.Checked = true;
            this.sizeRadioButton1.Location = new System.Drawing.Point(27, 39);
            this.sizeRadioButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sizeRadioButton1.Name = "sizeRadioButton1";
            this.sizeRadioButton1.Size = new System.Drawing.Size(36, 19);
            this.sizeRadioButton1.TabIndex = 0;
            this.sizeRadioButton1.TabStop = true;
            this.sizeRadioButton1.Text = "9";
            this.sizeRadioButton1.UseVisualStyleBackColor = true;
            this.sizeRadioButton1.CheckedChanged += new System.EventHandler(this.sizeRadioButton_CheckedChanged);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(376, 246);
            this.okButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(100, 29);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "确定";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(376, 284);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 29);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "取消";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // boldCheckBox
            // 
            this.boldCheckBox.AutoSize = true;
            this.boldCheckBox.Location = new System.Drawing.Point(376, 82);
            this.boldCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.boldCheckBox.Name = "boldCheckBox";
            this.boldCheckBox.Size = new System.Drawing.Size(59, 19);
            this.boldCheckBox.TabIndex = 4;
            this.boldCheckBox.Text = "粗体";
            this.boldCheckBox.UseVisualStyleBackColor = true;
            this.boldCheckBox.CheckedChanged += new System.EventHandler(this.styleCheckBox_CheckedChanged);
            // 
            // italicCheckBox
            // 
            this.italicCheckBox.AutoSize = true;
            this.italicCheckBox.Location = new System.Drawing.Point(376, 110);
            this.italicCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.italicCheckBox.Name = "italicCheckBox";
            this.italicCheckBox.Size = new System.Drawing.Size(59, 19);
            this.italicCheckBox.TabIndex = 4;
            this.italicCheckBox.Text = "斜体";
            this.italicCheckBox.UseVisualStyleBackColor = true;
            this.italicCheckBox.CheckedChanged += new System.EventHandler(this.styleCheckBox_CheckedChanged);
            // 
            // underlineCheckBox
            // 
            this.underlineCheckBox.AutoSize = true;
            this.underlineCheckBox.Location = new System.Drawing.Point(376, 138);
            this.underlineCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.underlineCheckBox.Name = "underlineCheckBox";
            this.underlineCheckBox.Size = new System.Drawing.Size(74, 19);
            this.underlineCheckBox.TabIndex = 4;
            this.underlineCheckBox.Text = "下划线";
            this.underlineCheckBox.UseVisualStyleBackColor = true;
            this.underlineCheckBox.CheckedChanged += new System.EventHandler(this.styleCheckBox_CheckedChanged);
            // 
            // strikeoutCheckBox
            // 
            this.strikeoutCheckBox.AutoSize = true;
            this.strikeoutCheckBox.Location = new System.Drawing.Point(376, 169);
            this.strikeoutCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.strikeoutCheckBox.Name = "strikeoutCheckBox";
            this.strikeoutCheckBox.Size = new System.Drawing.Size(74, 19);
            this.strikeoutCheckBox.TabIndex = 4;
            this.strikeoutCheckBox.Text = "删除线";
            this.strikeoutCheckBox.UseVisualStyleBackColor = true;
            this.strikeoutCheckBox.CheckedChanged += new System.EventHandler(this.styleCheckBox_CheckedChanged);
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(376, 210);
            this.applyButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(100, 29);
            this.applyButton.TabIndex = 3;
            this.applyButton.Text = "应用";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(447, 31);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "扩展";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(99, 16);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 29);
            this.button2.TabIndex = 6;
            this.button2.Text = "涂鸦啦";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(283, 67);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(67, 15);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "更多字体";
            // 
            // FontForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 328);
            this.ControlBox = false;
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.strikeoutCheckBox);
            this.Controls.Add(this.underlineCheckBox);
            this.Controls.Add(this.italicCheckBox);
            this.Controls.Add(this.boldCheckBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.sizeGroupBox);
            this.Controls.Add(this.fontComboBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FontForm";
            this.ShowInTaskbar = false;
            this.Text = "字体设置";
            this.Load += new System.EventHandler(this.FontForm_Load);
            this.sizeGroupBox.ResumeLayout(false);
            this.sizeGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox fontComboBox;
        private System.Windows.Forms.GroupBox sizeGroupBox;
        private System.Windows.Forms.RadioButton sizeRadioButton4;
        private System.Windows.Forms.RadioButton sizeRadioButton3;
        private System.Windows.Forms.RadioButton sizeRadioButton2;
        private System.Windows.Forms.RadioButton sizeRadioButton1;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.CheckBox boldCheckBox;
        private System.Windows.Forms.CheckBox italicCheckBox;
        private System.Windows.Forms.CheckBox underlineCheckBox;
        private System.Windows.Forms.CheckBox strikeoutCheckBox;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}