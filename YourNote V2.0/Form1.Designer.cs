namespace DesktopNote
{
    partial class NoteForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.mainTextBox = new System.Windows.Forms.TextBox();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.openGraffitiFormButton = new System.Windows.Forms.Button();
            this.setFontButton = new System.Windows.Forms.Button();
            this.setForeColorButton = new System.Windows.Forms.Button();
            this.setBackgroundButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.preButton = new System.Windows.Forms.Button();
            this.delButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.noteFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.上一个ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.下一个ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.载入文本文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存文本文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置工作目录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.退出XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.前景色BToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.前景色HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.字体FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.涂鸦GToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bottomPanel.SuspendLayout();
            this.noteFormMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTextBox
            // 
            this.mainTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTextBox.Location = new System.Drawing.Point(0, 28);
            this.mainTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.mainTextBox.Multiline = true;
            this.mainTextBox.Name = "mainTextBox";
            this.mainTextBox.Size = new System.Drawing.Size(734, 459);
            this.mainTextBox.TabIndex = 0;
            this.mainTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mainTextBox_KeyDown);
            this.mainTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mainTextBox_KeyPress);
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.openGraffitiFormButton);
            this.bottomPanel.Controls.Add(this.setFontButton);
            this.bottomPanel.Controls.Add(this.setForeColorButton);
            this.bottomPanel.Controls.Add(this.setBackgroundButton);
            this.bottomPanel.Controls.Add(this.nextButton);
            this.bottomPanel.Controls.Add(this.preButton);
            this.bottomPanel.Controls.Add(this.delButton);
            this.bottomPanel.Controls.Add(this.newButton);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 415);
            this.bottomPanel.Margin = new System.Windows.Forms.Padding(4);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(734, 72);
            this.bottomPanel.TabIndex = 1;
            // 
            // openGraffitiFormButton
            // 
            this.openGraffitiFormButton.Location = new System.Drawing.Point(468, 36);
            this.openGraffitiFormButton.Margin = new System.Windows.Forms.Padding(4);
            this.openGraffitiFormButton.Name = "openGraffitiFormButton";
            this.openGraffitiFormButton.Size = new System.Drawing.Size(100, 29);
            this.openGraffitiFormButton.TabIndex = 1;
            this.openGraffitiFormButton.Text = "涂鸦";
            this.openGraffitiFormButton.UseVisualStyleBackColor = true;
            this.openGraffitiFormButton.Click += new System.EventHandler(this.openGraffitiFormButton_Click);
            // 
            // setFontButton
            // 
            this.setFontButton.Location = new System.Drawing.Point(468, -1);
            this.setFontButton.Margin = new System.Windows.Forms.Padding(4);
            this.setFontButton.Name = "setFontButton";
            this.setFontButton.Size = new System.Drawing.Size(100, 29);
            this.setFontButton.TabIndex = 0;
            this.setFontButton.Text = "字体";
            this.setFontButton.UseVisualStyleBackColor = true;
            this.setFontButton.Click += new System.EventHandler(this.setFontButton_Click);
            // 
            // setForeColorButton
            // 
            this.setForeColorButton.Location = new System.Drawing.Point(252, 36);
            this.setForeColorButton.Margin = new System.Windows.Forms.Padding(4);
            this.setForeColorButton.Name = "setForeColorButton";
            this.setForeColorButton.Size = new System.Drawing.Size(100, 29);
            this.setForeColorButton.TabIndex = 0;
            this.setForeColorButton.Text = "前景色";
            this.setForeColorButton.UseVisualStyleBackColor = true;
            this.setForeColorButton.Click += new System.EventHandler(this.setForeColorButton_Click);
            // 
            // setBackgroundButton
            // 
            this.setBackgroundButton.Location = new System.Drawing.Point(248, 4);
            this.setBackgroundButton.Margin = new System.Windows.Forms.Padding(4);
            this.setBackgroundButton.Name = "setBackgroundButton";
            this.setBackgroundButton.Size = new System.Drawing.Size(100, 29);
            this.setBackgroundButton.TabIndex = 0;
            this.setBackgroundButton.Text = "背景色";
            this.setBackgroundButton.UseVisualStyleBackColor = true;
            this.setBackgroundButton.Click += new System.EventHandler(this.setBackgroundButton_Check);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(360, 36);
            this.nextButton.Margin = new System.Windows.Forms.Padding(4);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(100, 29);
            this.nextButton.TabIndex = 0;
            this.nextButton.Text = "下一个";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // preButton
            // 
            this.preButton.Location = new System.Drawing.Point(356, 4);
            this.preButton.Margin = new System.Windows.Forms.Padding(4);
            this.preButton.Name = "preButton";
            this.preButton.Size = new System.Drawing.Size(100, 29);
            this.preButton.TabIndex = 0;
            this.preButton.Text = "上一个";
            this.preButton.UseVisualStyleBackColor = true;
            this.preButton.Click += new System.EventHandler(this.preButton_Click);
            // 
            // delButton
            // 
            this.delButton.Location = new System.Drawing.Point(140, 36);
            this.delButton.Margin = new System.Windows.Forms.Padding(4);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(100, 29);
            this.delButton.TabIndex = 0;
            this.delButton.Text = "删除";
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(140, 0);
            this.newButton.Margin = new System.Windows.Forms.Padding(4);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(100, 29);
            this.newButton.TabIndex = 0;
            this.newButton.Text = "新建";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // noteFormMenuStrip
            // 
            this.noteFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.编辑ToolStripMenuItem,
            this.工具ToolStripMenuItem});
            this.noteFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.noteFormMenuStrip.Name = "noteFormMenuStrip";
            this.noteFormMenuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.noteFormMenuStrip.Size = new System.Drawing.Size(734, 28);
            this.noteFormMenuStrip.TabIndex = 2;
            this.noteFormMenuStrip.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建ToolStripMenuItem,
            this.删除ToolStripMenuItem,
            this.上一个ToolStripMenuItem,
            this.下一个ToolStripMenuItem,
            this.载入文本文件ToolStripMenuItem,
            this.保存文本文件ToolStripMenuItem,
            this.设置工作目录ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.退出XToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.文件ToolStripMenuItem.Text = "文件(&F)";
            // 
            // 新建ToolStripMenuItem
            // 
            this.新建ToolStripMenuItem.Name = "新建ToolStripMenuItem";
            this.新建ToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.新建ToolStripMenuItem.Text = "新建(&N)";
            this.新建ToolStripMenuItem.Click += new System.EventHandler(this.newButton_Click);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.删除ToolStripMenuItem.Text = "删除(&D)";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.delButton_Click);
            // 
            // 上一个ToolStripMenuItem
            // 
            this.上一个ToolStripMenuItem.Name = "上一个ToolStripMenuItem";
            this.上一个ToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.上一个ToolStripMenuItem.Text = "上一个(&P)";
            this.上一个ToolStripMenuItem.Click += new System.EventHandler(this.preButton_Click);
            // 
            // 下一个ToolStripMenuItem
            // 
            this.下一个ToolStripMenuItem.Name = "下一个ToolStripMenuItem";
            this.下一个ToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.下一个ToolStripMenuItem.Text = "下一个(&L)";
            this.下一个ToolStripMenuItem.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // 载入文本文件ToolStripMenuItem
            // 
            this.载入文本文件ToolStripMenuItem.Name = "载入文本文件ToolStripMenuItem";
            this.载入文本文件ToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.载入文本文件ToolStripMenuItem.Text = "载入文本文件";
            this.载入文本文件ToolStripMenuItem.Click += new System.EventHandler(this.载入文本文件ToolStripMenuItem_Click);
            // 
            // 保存文本文件ToolStripMenuItem
            // 
            this.保存文本文件ToolStripMenuItem.Name = "保存文本文件ToolStripMenuItem";
            this.保存文本文件ToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.保存文本文件ToolStripMenuItem.Text = "保存文本文件";
            this.保存文本文件ToolStripMenuItem.Click += new System.EventHandler(this.保存文本文件ToolStripMenuItem_Click);
            // 
            // 设置工作目录ToolStripMenuItem
            // 
            this.设置工作目录ToolStripMenuItem.Name = "设置工作目录ToolStripMenuItem";
            this.设置工作目录ToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.设置工作目录ToolStripMenuItem.Text = "设置工作目录";
            this.设置工作目录ToolStripMenuItem.Visible = false;
            this.设置工作目录ToolStripMenuItem.Click += new System.EventHandler(this.设置工作目录ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(165, 6);
            // 
            // 退出XToolStripMenuItem
            // 
            this.退出XToolStripMenuItem.Name = "退出XToolStripMenuItem";
            this.退出XToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.退出XToolStripMenuItem.Text = "退出(&X)";
            this.退出XToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.前景色BToolStripMenuItem,
            this.前景色HToolStripMenuItem,
            this.字体FToolStripMenuItem});
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.编辑ToolStripMenuItem.Text = "编辑(&E)";
            // 
            // 前景色BToolStripMenuItem
            // 
            this.前景色BToolStripMenuItem.Name = "前景色BToolStripMenuItem";
            this.前景色BToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.前景色BToolStripMenuItem.Text = "背景色(&B)";
            this.前景色BToolStripMenuItem.Click += new System.EventHandler(this.setBackgroundButton_Check);
            // 
            // 前景色HToolStripMenuItem
            // 
            this.前景色HToolStripMenuItem.Name = "前景色HToolStripMenuItem";
            this.前景色HToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.前景色HToolStripMenuItem.Text = "前景色(&H)";
            this.前景色HToolStripMenuItem.Click += new System.EventHandler(this.setForeColorButton_Click);
            // 
            // 字体FToolStripMenuItem
            // 
            this.字体FToolStripMenuItem.Name = "字体FToolStripMenuItem";
            this.字体FToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.字体FToolStripMenuItem.Text = "字体(&F)";
            this.字体FToolStripMenuItem.Click += new System.EventHandler(this.setFontButton_Click);
            // 
            // 工具ToolStripMenuItem
            // 
            this.工具ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.涂鸦GToolStripMenuItem});
            this.工具ToolStripMenuItem.Name = "工具ToolStripMenuItem";
            this.工具ToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.工具ToolStripMenuItem.Text = "工具(&T)";
            this.工具ToolStripMenuItem.Click += new System.EventHandler(this.工具ToolStripMenuItem_Click);
            // 
            // 涂鸦GToolStripMenuItem
            // 
            this.涂鸦GToolStripMenuItem.Name = "涂鸦GToolStripMenuItem";
            this.涂鸦GToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.涂鸦GToolStripMenuItem.Text = "涂鸦(&G)";
            this.涂鸦GToolStripMenuItem.Click += new System.EventHandler(this.openGraffitiFormButton_Click);
            // 
            // NoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 487);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.mainTextBox);
            this.Controls.Add(this.noteFormMenuStrip);
            this.MainMenuStrip = this.noteFormMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NoteForm";
            this.Text = "记事本啦";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NoteForm_FormClosing);
            this.Load += new System.EventHandler(this.NoteForm_Load);
            this.SizeChanged += new System.EventHandler(this.NoteForm_SizeChanged);
            this.bottomPanel.ResumeLayout(false);
            this.noteFormMenuStrip.ResumeLayout(false);
            this.noteFormMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void setBackButton_Click(object sender, System.EventArgs e)
        {

        }

        #endregion

        private System.Windows.Forms.TextBox mainTextBox;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Button setFontButton;
        private System.Windows.Forms.Button setForeColorButton;
        private System.Windows.Forms.Button setBackgroundButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button preButton;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button openGraffitiFormButton;
        private System.Windows.Forms.MenuStrip noteFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 上一个ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 下一个ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 工具ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 退出XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 前景色BToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 前景色HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 字体FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 涂鸦GToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 载入文本文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存文本文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置工作目录ToolStripMenuItem;
    }
}

