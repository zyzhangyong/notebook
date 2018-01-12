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
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.OKbutton = new System.Windows.Forms.Button();
            this.workDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UPbutton = new System.Windows.Forms.Button();
            this.bottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // logicalDriveComboBox
            // 
            this.logicalDriveComboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.logicalDriveComboBox.FormattingEnabled = true;
            this.logicalDriveComboBox.Location = new System.Drawing.Point(0, 0);
            this.logicalDriveComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logicalDriveComboBox.Name = "logicalDriveComboBox";
            this.logicalDriveComboBox.Size = new System.Drawing.Size(621, 23);
            this.logicalDriveComboBox.TabIndex = 0;
            this.logicalDriveComboBox.SelectedValueChanged += new System.EventHandler(this.logicalDriveComboBox_SelectedValueChanged);
            // 
            // dirctoryListBox
            // 
            this.dirctoryListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dirctoryListBox.FormattingEnabled = true;
            this.dirctoryListBox.ItemHeight = 15;
            this.dirctoryListBox.Location = new System.Drawing.Point(0, 23);
            this.dirctoryListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dirctoryListBox.Name = "dirctoryListBox";
            this.dirctoryListBox.Size = new System.Drawing.Size(621, 459);
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
            this.bottomPanel.Location = new System.Drawing.Point(0, 356);
            this.bottomPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(621, 125);
            this.bottomPanel.TabIndex = 2;
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancelbutton.Location = new System.Drawing.Point(491, 46);
            this.Cancelbutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(69, 31);
            this.Cancelbutton.TabIndex = 3;
            this.Cancelbutton.Text = "取消";
            this.Cancelbutton.UseVisualStyleBackColor = true;
            // 
            // OKbutton
            // 
            this.OKbutton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKbutton.Location = new System.Drawing.Point(399, 48);
            this.OKbutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(69, 31);
            this.OKbutton.TabIndex = 3;
            this.OKbutton.Text = "确定";
            this.OKbutton.UseVisualStyleBackColor = true;
            // 
            // workDirectoryTextBox
            // 
            this.workDirectoryTextBox.Location = new System.Drawing.Point(181, 51);
            this.workDirectoryTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.workDirectoryTextBox.Name = "workDirectoryTextBox";
            this.workDirectoryTextBox.Size = new System.Drawing.Size(181, 25);
            this.workDirectoryTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "工作目录：";
            // 
            // UPbutton
            // 
            this.UPbutton.Location = new System.Drawing.Point(4, 51);
            this.UPbutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UPbutton.Name = "UPbutton";
            this.UPbutton.Size = new System.Drawing.Size(75, 28);
            this.UPbutton.TabIndex = 0;
            this.UPbutton.Text = "向上";
            this.UPbutton.UseVisualStyleBackColor = true;
            this.UPbutton.Click += new System.EventHandler(this.UPbutton_Click);
            // 
            // SelectDirectoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(621, 482);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.dirctoryListBox);
            this.Controls.Add(this.logicalDriveComboBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SelectDirectoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectDirectoryForm";
            this.Load += new System.EventHandler(this.SelectDirectoryForm_Load);
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