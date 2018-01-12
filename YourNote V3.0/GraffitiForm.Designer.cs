namespace DesktopNote
{
    partial class GraffitiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GraffitiForm));
            this.buttomPanel = new System.Windows.Forms.Panel();
            this.insertPicbutton = new System.Windows.Forms.Button();
            this.lineRadioButton = new System.Windows.Forms.RadioButton();
            this.rectangleRadioButton = new System.Windows.Forms.RadioButton();
            this.graffitiToolStrip = new System.Windows.Forms.ToolStrip();
            this.lineToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.rectangleToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.imageToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.closeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.buttomPanel.SuspendLayout();
            this.graffitiToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttomPanel
            // 
            this.buttomPanel.Controls.Add(this.insertPicbutton);
            this.buttomPanel.Controls.Add(this.lineRadioButton);
            this.buttomPanel.Controls.Add(this.rectangleRadioButton);
            this.buttomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttomPanel.Location = new System.Drawing.Point(0, 282);
            this.buttomPanel.Margin = new System.Windows.Forms.Padding(4);
            this.buttomPanel.Name = "buttomPanel";
            this.buttomPanel.Size = new System.Drawing.Size(379, 46);
            this.buttomPanel.TabIndex = 0;
            // 
            // insertPicbutton
            // 
            this.insertPicbutton.Location = new System.Drawing.Point(263, 14);
            this.insertPicbutton.Margin = new System.Windows.Forms.Padding(4);
            this.insertPicbutton.Name = "insertPicbutton";
            this.insertPicbutton.Size = new System.Drawing.Size(100, 29);
            this.insertPicbutton.TabIndex = 1;
            this.insertPicbutton.Text = "插入图片";
            this.insertPicbutton.UseVisualStyleBackColor = true;
            this.insertPicbutton.Click += new System.EventHandler(this.insertPicbutton_Click);
            // 
            // lineRadioButton
            // 
            this.lineRadioButton.AutoSize = true;
            this.lineRadioButton.Checked = true;
            this.lineRadioButton.Location = new System.Drawing.Point(108, 22);
            this.lineRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.lineRadioButton.Name = "lineRadioButton";
            this.lineRadioButton.Size = new System.Drawing.Size(58, 19);
            this.lineRadioButton.TabIndex = 0;
            this.lineRadioButton.TabStop = true;
            this.lineRadioButton.Text = "直线";
            this.lineRadioButton.UseVisualStyleBackColor = true;
            // 
            // rectangleRadioButton
            // 
            this.rectangleRadioButton.AutoSize = true;
            this.rectangleRadioButton.Location = new System.Drawing.Point(16, 22);
            this.rectangleRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.rectangleRadioButton.Name = "rectangleRadioButton";
            this.rectangleRadioButton.Size = new System.Drawing.Size(58, 19);
            this.rectangleRadioButton.TabIndex = 0;
            this.rectangleRadioButton.Text = "矩形";
            this.rectangleRadioButton.UseVisualStyleBackColor = true;
            // 
            // graffitiToolStrip
            // 
            this.graffitiToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lineToolStripButton,
            this.rectangleToolStripButton,
            this.imageToolStripButton,
            this.closeToolStripButton});
            this.graffitiToolStrip.Location = new System.Drawing.Point(0, 0);
            this.graffitiToolStrip.Name = "graffitiToolStrip";
            this.graffitiToolStrip.Size = new System.Drawing.Size(379, 25);
            this.graffitiToolStrip.TabIndex = 1;
            this.graffitiToolStrip.Text = "toolStrip1";
            this.graffitiToolStrip.Visible = false;
            // 
            // lineToolStripButton
            // 
            this.lineToolStripButton.Checked = true;
            this.lineToolStripButton.CheckOnClick = true;
            this.lineToolStripButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.lineToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lineToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("lineToolStripButton.Image")));
            this.lineToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lineToolStripButton.Name = "lineToolStripButton";
            this.lineToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.lineToolStripButton.Text = "toolStripButton1";
            this.lineToolStripButton.ToolTipText = "直线";
            this.lineToolStripButton.CheckedChanged += new System.EventHandler(this.lineToolStripButton_CheckedChanged);
            // 
            // rectangleToolStripButton
            // 
            this.rectangleToolStripButton.CheckOnClick = true;
            this.rectangleToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rectangleToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("rectangleToolStripButton.Image")));
            this.rectangleToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rectangleToolStripButton.Name = "rectangleToolStripButton";
            this.rectangleToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.rectangleToolStripButton.Text = "toolStripButton1";
            this.rectangleToolStripButton.ToolTipText = "矩形";
            this.rectangleToolStripButton.CheckedChanged += new System.EventHandler(this.rectangleToolStripButton_CheckedChanged);
            // 
            // imageToolStripButton
            // 
            this.imageToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.imageToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("imageToolStripButton.Image")));
            this.imageToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.imageToolStripButton.Name = "imageToolStripButton";
            this.imageToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.imageToolStripButton.Text = "toolStripButton2";
            this.imageToolStripButton.ToolTipText = "tool插入图片";
            this.imageToolStripButton.Click += new System.EventHandler(this.insertPicbutton_Click);
            // 
            // closeToolStripButton
            // 
            this.closeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.closeToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("closeToolStripButton.Image")));
            this.closeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.closeToolStripButton.Name = "closeToolStripButton";
            this.closeToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.closeToolStripButton.Text = "toolStripButton3";
            this.closeToolStripButton.ToolTipText = "tool关闭";
            this.closeToolStripButton.Click += new System.EventHandler(this.closeToolStripButton_Click);
            // 
            // GraffitiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 328);
            this.Controls.Add(this.graffitiToolStrip);
            this.Controls.Add(this.buttomPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GraffitiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GraffitiForm";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GraffitiForm_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GraffitiForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GraffitiForm_MouseMove);
            this.buttomPanel.ResumeLayout(false);
            this.buttomPanel.PerformLayout();
            this.graffitiToolStrip.ResumeLayout(false);
            this.graffitiToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel buttomPanel;
        private System.Windows.Forms.RadioButton lineRadioButton;
        private System.Windows.Forms.RadioButton rectangleRadioButton;
        private System.Windows.Forms.Button insertPicbutton;
        private System.Windows.Forms.ToolStrip graffitiToolStrip;
        private System.Windows.Forms.ToolStripButton lineToolStripButton;
        private System.Windows.Forms.ToolStripButton rectangleToolStripButton;
        private System.Windows.Forms.ToolStripButton imageToolStripButton;
        private System.Windows.Forms.ToolStripButton closeToolStripButton;
    }
}