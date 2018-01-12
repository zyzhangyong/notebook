namespace DesktopNote
{
    partial class SelectDirectoryForm
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
            this.logicalDriveComboBox = new System.Windows.Forms.ComboBox();
            this.dirctoryListBox = new System.Windows.Forms.ListBox();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.UPbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.workDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.OKbutton = new System.Windows.Forms.Button();
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.bottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // logicalDriveComboBox
            // 
            this.logicalDriveComboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.logicalDriveComboBox.FormattingEnabled = true;
            this.logicalDriveComboBox.Location = new System.Drawing.Point(0, 0);
            this.logicalDriveComboBox.Name = "logicalDriveComboBox";
            this.logicalDriveComboBox.Size = new System.Drawing.Size(466, 20);
            this.logicalDriveComboBox.TabIndex = 0;
            this.logicalDriveComboBox.SelectedValueChanged += new System.EventHandler(this.logicalDriveComboBox_SelectedValueChanged);
            // 
            // dirctoryListBox
            // 
            this.dirctoryListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dirctoryListBox.FormattingEnabled = true;
            this.dirctoryListBox.ItemHeight = 12;
            this.dirctoryListBox.Location = new System.Drawing.Point(0, 20);
            this.dirctoryListBox.Name = "dirctoryListBox";
            this.dirctoryListBox.Size = new System.Drawing.Size(466, 242);
            this.dirctoryListBox.TabIndex = 1;
            this.dirctoryListBox.DoubleClick += new System.EventHandler(this.dirctoryListBox_DoubleClick);
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.Cancelbutton);
            this.bottomPanel.Controls.Add(this.OKbutton);
            this.bottomPanel.Controls.Add(this.workDirectoryTextBox);
            this.bottomPanel.Controls.Add(this.label1);
            this.bottomPanel.Controls.Add(this.UPbutton);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 162);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(466, 100);
            this.bottomPanel.TabIndex = 2;
            // 
            // UPbutton
            // 
            this.UPbutton.Location = new System.Drawing.Point(3, 41);
            this.UPbutton.Name = "UPbutton";
            this.UPbutton.Size = new System.Drawing.Size(56, 22);
            this.UPbutton.TabIndex = 0;
            this.UPbutton.Text = "向上";
            this.UPbutton.UseVisualStyleBackColor = true;
            this.UPbutton.Click += new System.EventHandler(this.UPbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "工作目录：";
            // 
            // workDirectoryTextBox
            // 
            this.workDirectoryTextBox.Location = new System.Drawing.Point(136, 41);
            this.workDirectoryTextBox.Name = "workDirectoryTextBox";
            this.workDirectoryTextBox.Size = new System.Drawing.Size(137, 21);
            this.workDirectoryTextBox.TabIndex = 2;
            // 
            // OKbutton
            // 
            this.OKbutton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKbutton.Location = new System.Drawing.Point(299, 38);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(52, 25);
            this.OKbutton.TabIndex = 3;
            this.OKbutton.Text = "确定";
            this.OKbutton.UseVisualStyleBackColor = true;
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancelbutton.Location = new System.Drawing.Point(368, 37);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(52, 25);
            this.Cancelbutton.TabIndex = 3;
            this.Cancelbutton.Text = "取消";
            this.Cancelbutton.UseVisualStyleBackColor = true;
            // 
            // SelectDirectoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 262);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.dirctoryListBox);
            this.Controls.Add(this.logicalDriveComboBox);
            this.Name = "SelectDirectoryForm";
            this.Text = "SelectDirectoryForm";
            this.bottomPanel.ResumeLayout(false);
            this.bottomPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox logicalDriveComboBox;
        private System.Windows.Forms.ListBox dirctoryListBox;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Button Cancelbutton;
        private System.Windows.Forms.Button OKbutton;
        private System.Windows.Forms.TextBox workDirectoryTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UPbutton;
    }
}