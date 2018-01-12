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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSelectdir = new System.Windows.Forms.Button();
            this.btnGodir = new System.Windows.Forms.Button();
            this.btnNewdir = new System.Windows.Forms.Button();
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
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.全选AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.复制CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.粘贴VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.日期ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.涂鸦GToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuPrivilege = new System.Windows.Forms.ToolStripMenuItem();
            this.uploadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.translateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.execlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.语音ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.插入图片标注ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于记事本ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
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
            this.mainTextBox.Size = new System.Drawing.Size(1060, 505);
            this.mainTextBox.TabIndex = 0;
            this.mainTextBox.TextChanged += new System.EventHandler(this.mainTextBox_TextChanged);
            this.mainTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mainTextBox_KeyDown);
            this.mainTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mainTextBox_KeyPress);
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.button2);
            this.bottomPanel.Controls.Add(this.button1);
            this.bottomPanel.Controls.Add(this.btnSelectdir);
            this.bottomPanel.Controls.Add(this.btnGodir);
            this.bottomPanel.Controls.Add(this.btnNewdir);
            this.bottomPanel.Controls.Add(this.openGraffitiFormButton);
            this.bottomPanel.Controls.Add(this.setFontButton);
            this.bottomPanel.Controls.Add(this.setForeColorButton);
            this.bottomPanel.Controls.Add(this.setBackgroundButton);
            this.bottomPanel.Controls.Add(this.nextButton);
            this.bottomPanel.Controls.Add(this.preButton);
            this.bottomPanel.Controls.Add(this.delButton);
            this.bottomPanel.Controls.Add(this.newButton);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 461);
            this.bottomPanel.Margin = new System.Windows.Forms.Padding(4);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(1060, 72);
            this.bottomPanel.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(743, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 27);
            this.button2.TabIndex = 5;
            this.button2.Text = "保存到电脑";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.保存文本文件ToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(743, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 27);
            this.button1.TabIndex = 5;
            this.button1.Text = "保存到数据库";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnGodir_Click);
            // 
            // btnSelectdir
            // 
            this.btnSelectdir.Location = new System.Drawing.Point(30, 29);
            this.btnSelectdir.Name = "btnSelectdir";
            this.btnSelectdir.Size = new System.Drawing.Size(110, 31);
            this.btnSelectdir.TabIndex = 4;
            this.btnSelectdir.Text = "选择分类";
            this.btnSelectdir.UseVisualStyleBackColor = true;
            this.btnSelectdir.Visible = false;
            this.btnSelectdir.Click += new System.EventHandler(this.btnSelectdir_Click);
            // 
            // btnGodir
            // 
            this.btnGodir.Location = new System.Drawing.Point(305, 35);
            this.btnGodir.Name = "btnGodir";
            this.btnGodir.Size = new System.Drawing.Size(107, 30);
            this.btnGodir.TabIndex = 3;
            this.btnGodir.Text = "查看分类";
            this.btnGodir.UseVisualStyleBackColor = true;
            this.btnGodir.Click += new System.EventHandler(this.btnGodir_Click);
            // 
            // btnNewdir
            // 
            this.btnNewdir.Location = new System.Drawing.Point(305, 2);
            this.btnNewdir.Name = "btnNewdir";
            this.btnNewdir.Size = new System.Drawing.Size(107, 31);
            this.btnNewdir.TabIndex = 2;
            this.btnNewdir.Text = "新建分类";
            this.btnNewdir.UseVisualStyleBackColor = true;
            this.btnNewdir.Click += new System.EventHandler(this.btnNewdir_Click);
            // 
            // openGraffitiFormButton
            // 
            this.openGraffitiFormButton.Location = new System.Drawing.Point(635, 35);
            this.openGraffitiFormButton.Margin = new System.Windows.Forms.Padding(4);
            this.openGraffitiFormButton.Name = "openGraffitiFormButton";
            this.openGraffitiFormButton.Size = new System.Drawing.Size(100, 27);
            this.openGraffitiFormButton.TabIndex = 1;
            this.openGraffitiFormButton.Text = "涂鸦";
            this.openGraffitiFormButton.UseVisualStyleBackColor = true;
            this.openGraffitiFormButton.Click += new System.EventHandler(this.openGraffitiFormButton_Click);
            // 
            // setFontButton
            // 
            this.setFontButton.Location = new System.Drawing.Point(635, 4);
            this.setFontButton.Margin = new System.Windows.Forms.Padding(4);
            this.setFontButton.Name = "setFontButton";
            this.setFontButton.Size = new System.Drawing.Size(100, 27);
            this.setFontButton.TabIndex = 0;
            this.setFontButton.Text = "字体";
            this.setFontButton.UseVisualStyleBackColor = true;
            this.setFontButton.Click += new System.EventHandler(this.setFontButton_Click);
            // 
            // setForeColorButton
            // 
            this.setForeColorButton.Location = new System.Drawing.Point(419, 36);
            this.setForeColorButton.Margin = new System.Windows.Forms.Padding(4);
            this.setForeColorButton.Name = "setForeColorButton";
            this.setForeColorButton.Size = new System.Drawing.Size(100, 27);
            this.setForeColorButton.TabIndex = 0;
            this.setForeColorButton.Text = "前景色";
            this.setForeColorButton.UseVisualStyleBackColor = true;
            this.setForeColorButton.Click += new System.EventHandler(this.setForeColorButton_Click);
            // 
            // setBackgroundButton
            // 
            this.setBackgroundButton.Location = new System.Drawing.Point(419, 4);
            this.setBackgroundButton.Margin = new System.Windows.Forms.Padding(4);
            this.setBackgroundButton.Name = "setBackgroundButton";
            this.setBackgroundButton.Size = new System.Drawing.Size(100, 27);
            this.setBackgroundButton.TabIndex = 0;
            this.setBackgroundButton.Text = "背景色";
            this.setBackgroundButton.UseVisualStyleBackColor = true;
            this.setBackgroundButton.Click += new System.EventHandler(this.setBackgroundButton_Check);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(527, 35);
            this.nextButton.Margin = new System.Windows.Forms.Padding(4);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(100, 27);
            this.nextButton.TabIndex = 0;
            this.nextButton.Text = "下一个";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // preButton
            // 
            this.preButton.Location = new System.Drawing.Point(527, 3);
            this.preButton.Margin = new System.Windows.Forms.Padding(4);
            this.preButton.Name = "preButton";
            this.preButton.Size = new System.Drawing.Size(100, 27);
            this.preButton.TabIndex = 0;
            this.preButton.Text = "上一个";
            this.preButton.UseVisualStyleBackColor = true;
            this.preButton.Click += new System.EventHandler(this.preButton_Click);
            // 
            // delButton
            // 
            this.delButton.Location = new System.Drawing.Point(199, 33);
            this.delButton.Margin = new System.Windows.Forms.Padding(4);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(100, 29);
            this.delButton.TabIndex = 0;
            this.delButton.Text = "删除笔记";
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(199, 2);
            this.newButton.Margin = new System.Windows.Forms.Padding(4);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(100, 29);
            this.newButton.TabIndex = 0;
            this.newButton.Text = "新建笔记";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // noteFormMenuStrip
            // 
            this.noteFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.编辑ToolStripMenuItem,
            this.工具ToolStripMenuItem,
            this.MenuPrivilege,
            this.帮助ToolStripMenuItem});
            this.noteFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.noteFormMenuStrip.Name = "noteFormMenuStrip";
            this.noteFormMenuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.noteFormMenuStrip.Size = new System.Drawing.Size(1060, 28);
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
            this.字体FToolStripMenuItem,
            this.toolStripSeparator1,
            this.全选AToolStripMenuItem,
            this.复制CToolStripMenuItem,
            this.粘贴VToolStripMenuItem,
            this.toolStripSeparator2,
            this.日期ToolStripMenuItem});
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.编辑ToolStripMenuItem.Text = "编辑(&E)";
            // 
            // 前景色BToolStripMenuItem
            // 
            this.前景色BToolStripMenuItem.Name = "前景色BToolStripMenuItem";
            this.前景色BToolStripMenuItem.Size = new System.Drawing.Size(186, 24);
            this.前景色BToolStripMenuItem.Text = "背景色(&B)";
            this.前景色BToolStripMenuItem.Click += new System.EventHandler(this.setBackgroundButton_Check);
            // 
            // 前景色HToolStripMenuItem
            // 
            this.前景色HToolStripMenuItem.Name = "前景色HToolStripMenuItem";
            this.前景色HToolStripMenuItem.Size = new System.Drawing.Size(186, 24);
            this.前景色HToolStripMenuItem.Text = "前景色(&H)";
            this.前景色HToolStripMenuItem.Click += new System.EventHandler(this.setForeColorButton_Click);
            // 
            // 字体FToolStripMenuItem
            // 
            this.字体FToolStripMenuItem.Name = "字体FToolStripMenuItem";
            this.字体FToolStripMenuItem.Size = new System.Drawing.Size(186, 24);
            this.字体FToolStripMenuItem.Text = "字体(&F)";
            this.字体FToolStripMenuItem.Click += new System.EventHandler(this.setFontButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(183, 6);
            // 
            // 全选AToolStripMenuItem
            // 
            this.全选AToolStripMenuItem.Name = "全选AToolStripMenuItem";
            this.全选AToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.全选AToolStripMenuItem.Size = new System.Drawing.Size(186, 24);
            this.全选AToolStripMenuItem.Text = "全选(&A)";
            this.全选AToolStripMenuItem.Click += new System.EventHandler(this.全选AToolStripMenuItem_Click);
            // 
            // 复制CToolStripMenuItem
            // 
            this.复制CToolStripMenuItem.Name = "复制CToolStripMenuItem";
            this.复制CToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.复制CToolStripMenuItem.Size = new System.Drawing.Size(186, 24);
            this.复制CToolStripMenuItem.Text = "复制(&C)";
            this.复制CToolStripMenuItem.Click += new System.EventHandler(this.复制CToolStripMenuItem_Click);
            // 
            // 粘贴VToolStripMenuItem
            // 
            this.粘贴VToolStripMenuItem.Name = "粘贴VToolStripMenuItem";
            this.粘贴VToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.粘贴VToolStripMenuItem.Size = new System.Drawing.Size(186, 24);
            this.粘贴VToolStripMenuItem.Text = "粘贴(&V)";
            this.粘贴VToolStripMenuItem.Click += new System.EventHandler(this.粘贴VToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(183, 6);
            // 
            // 日期ToolStripMenuItem
            // 
            this.日期ToolStripMenuItem.Name = "日期ToolStripMenuItem";
            this.日期ToolStripMenuItem.Size = new System.Drawing.Size(186, 24);
            this.日期ToolStripMenuItem.Text = "日期";
            this.日期ToolStripMenuItem.Click += new System.EventHandler(this.日期ToolStripMenuItem_Click);
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
            // MenuPrivilege
            // 
            this.MenuPrivilege.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uploadToolStripMenuItem,
            this.translateToolStripMenuItem,
            this.wordToolStripMenuItem,
            this.execlToolStripMenuItem,
            this.emailToolStripMenuItem,
            this.语音ToolStripMenuItem,
            this.插入图片标注ToolStripMenuItem});
            this.MenuPrivilege.Enabled = false;
            this.MenuPrivilege.Name = "MenuPrivilege";
            this.MenuPrivilege.Size = new System.Drawing.Size(81, 24);
            this.MenuPrivilege.Text = "用户专享";
            this.MenuPrivilege.Visible = false;
            // 
            // uploadToolStripMenuItem
            // 
            this.uploadToolStripMenuItem.Name = "uploadToolStripMenuItem";
            this.uploadToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.uploadToolStripMenuItem.Text = "upload";
            // 
            // translateToolStripMenuItem
            // 
            this.translateToolStripMenuItem.Name = "translateToolStripMenuItem";
            this.translateToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.translateToolStripMenuItem.Text = "translate";
            // 
            // wordToolStripMenuItem
            // 
            this.wordToolStripMenuItem.Name = "wordToolStripMenuItem";
            this.wordToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.wordToolStripMenuItem.Text = "word";
            // 
            // execlToolStripMenuItem
            // 
            this.execlToolStripMenuItem.Name = "execlToolStripMenuItem";
            this.execlToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.execlToolStripMenuItem.Text = "excel";
            // 
            // emailToolStripMenuItem
            // 
            this.emailToolStripMenuItem.Name = "emailToolStripMenuItem";
            this.emailToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.emailToolStripMenuItem.Text = "email";
            // 
            // 语音ToolStripMenuItem
            // 
            this.语音ToolStripMenuItem.Name = "语音ToolStripMenuItem";
            this.语音ToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.语音ToolStripMenuItem.Text = "语音";
            // 
            // 插入图片标注ToolStripMenuItem
            // 
            this.插入图片标注ToolStripMenuItem.Name = "插入图片标注ToolStripMenuItem";
            this.插入图片标注ToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.插入图片标注ToolStripMenuItem.Text = "插入图片并标注";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于记事本ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 关于记事本ToolStripMenuItem
            // 
            this.关于记事本ToolStripMenuItem.Name = "关于记事本ToolStripMenuItem";
            this.关于记事本ToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.关于记事本ToolStripMenuItem.Text = "关于记事本";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(864, 1);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 25);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(822, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "搜索";
            // 
            // NoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 533);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.mainTextBox);
            this.Controls.Add(this.noteFormMenuStrip);
            this.MainMenuStrip = this.noteFormMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NoteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YourPad";
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
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 全选AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuPrivilege;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGodir;
        private System.Windows.Forms.Button btnNewdir;
        private System.Windows.Forms.Button btnSelectdir;
        private System.Windows.Forms.ToolStripMenuItem 复制CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 粘贴VToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 日期ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于记事本ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uploadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem translateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem execlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 语音ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 插入图片标注ToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

