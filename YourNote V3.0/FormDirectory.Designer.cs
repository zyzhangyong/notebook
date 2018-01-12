namespace DesktopNote
{
    partial class FormDirectory
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
            this.labelChooseDir = new System.Windows.Forms.Label();
            this.comboBoxDirName = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxMove = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonDirstore = new System.Windows.Forms.Button();
            this.richTextBoxContent = new System.Windows.Forms.RichTextBox();
            this.textBoxDirSearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DGDir = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGDir)).BeginInit();
            this.SuspendLayout();
            // 
            // labelChooseDir
            // 
            this.labelChooseDir.AutoSize = true;
            this.labelChooseDir.Location = new System.Drawing.Point(12, 36);
            this.labelChooseDir.Name = "labelChooseDir";
            this.labelChooseDir.Size = new System.Drawing.Size(97, 15);
            this.labelChooseDir.TabIndex = 0;
            this.labelChooseDir.Text = "请选择分类：";
            // 
            // comboBoxDirName
            // 
            this.comboBoxDirName.FormattingEnabled = true;
            this.comboBoxDirName.Items.AddRange(new object[] {
            "666666",
            "ppt",
            "txt",
            "word",
            "庙镇东",
            "英语笔记",
            "语文笔记"});
            this.comboBoxDirName.Location = new System.Drawing.Point(115, 33);
            this.comboBoxDirName.Name = "comboBoxDirName";
            this.comboBoxDirName.Size = new System.Drawing.Size(127, 23);
            this.comboBoxDirName.TabIndex = 1;
            this.comboBoxDirName.Text = "请选择分类";
            this.comboBoxDirName.SelectedIndexChanged += new System.EventHandler(this.comboBoxDirNum_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonDelete);
            this.groupBox1.Controls.Add(this.buttonNew);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBoxMove);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.buttonDirstore);
            this.groupBox1.Controls.Add(this.richTextBoxContent);
            this.groupBox1.Location = new System.Drawing.Point(255, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(797, 430);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "详细信息";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(202, 379);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(96, 32);
            this.buttonDelete.TabIndex = 9;
            this.buttonDelete.Text = "删除笔记";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(58, 379);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(99, 32);
            this.buttonNew.TabIndex = 9;
            this.buttonNew.Text = "新建笔记";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(475, 388);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "将笔记移动到分类:";
            // 
            // comboBoxMove
            // 
            this.comboBoxMove.FormattingEnabled = true;
            this.comboBoxMove.Items.AddRange(new object[] {
            "666666",
            "ppt",
            "txt",
            "word",
            "庙镇东",
            "英语笔记",
            "语文笔记"});
            this.comboBoxMove.Location = new System.Drawing.Point(618, 385);
            this.comboBoxMove.Name = "comboBoxMove";
            this.comboBoxMove.Size = new System.Drawing.Size(139, 23);
            this.comboBoxMove.TabIndex = 7;
            this.comboBoxMove.SelectedIndexChanged += new System.EventHandler(this.comboBoxMove_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-200, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(176, 373);
            this.dataGridView1.TabIndex = 6;
            // 
            // buttonDirstore
            // 
            this.buttonDirstore.Location = new System.Drawing.Point(342, 379);
            this.buttonDirstore.Name = "buttonDirstore";
            this.buttonDirstore.Size = new System.Drawing.Size(98, 32);
            this.buttonDirstore.TabIndex = 2;
            this.buttonDirstore.Text = "保存修改";
            this.buttonDirstore.UseVisualStyleBackColor = true;
            this.buttonDirstore.Click += new System.EventHandler(this.buttonDirstore_Click);
            // 
            // richTextBoxContent
            // 
            this.richTextBoxContent.Location = new System.Drawing.Point(42, 24);
            this.richTextBoxContent.Name = "richTextBoxContent";
            this.richTextBoxContent.Size = new System.Drawing.Size(720, 333);
            this.richTextBoxContent.TabIndex = 1;
            this.richTextBoxContent.Text = "";
            // 
            // textBoxDirSearch
            // 
            this.textBoxDirSearch.Location = new System.Drawing.Point(849, 36);
            this.textBoxDirSearch.Name = "textBoxDirSearch";
            this.textBoxDirSearch.Size = new System.Drawing.Size(168, 25);
            this.textBoxDirSearch.TabIndex = 4;
            this.textBoxDirSearch.TextChanged += new System.EventHandler(this.textBoxDirSearch_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(792, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "搜索：";
            // 
            // DGDir
            // 
            this.DGDir.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGDir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGDir.Location = new System.Drawing.Point(32, 92);
            this.DGDir.Name = "DGDir";
            this.DGDir.RowTemplate.Height = 27;
            this.DGDir.Size = new System.Drawing.Size(192, 424);
            this.DGDir.TabIndex = 6;
            this.DGDir.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGDir_CellDoubleClick);
            // 
            // FormDirectory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 562);
            this.Controls.Add(this.DGDir);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxDirSearch);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBoxDirName);
            this.Controls.Add(this.labelChooseDir);
            this.Name = "FormDirectory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDirectory";
            this.Load += new System.EventHandler(this.FormDirectory_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGDir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelChooseDir;
        private System.Windows.Forms.ComboBox comboBoxDirName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonDirstore;
        private System.Windows.Forms.TextBox textBoxDirSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxMove;
        public System.Windows.Forms.DataGridView DGDir;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonNew;
        public System.Windows.Forms.RichTextBox richTextBoxContent;
    }
}