using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopNote
{
    public partial class FontForm : Form
    {
      
     
        Font font = Form.DefaultFont;
        private System.Drawing.Text.InstalledFontCollection objFont = new System.Drawing.Text.InstalledFontCollection();
        public Font Font {
            set {
                this.font = value;
                foreach (Object o in fontComboBox.Items)
                {
                    if (font.Name.Equals(o))
                        this.fontComboBox.SelectedItem = o;
                }
                foreach (Object o in this.sizeGroupBox.Controls)
                {
                    if (o is RadioButton)
                    {
                        if (((RadioButton)o).Text.Equals(((int)font.Size).ToString()))
                            ((RadioButton)o).Checked = true;
                    }
                }
                this.boldCheckBox.Checked = font.Bold;
                this.italicCheckBox.Checked = font.Italic;
                this.underlineCheckBox.Checked = font.Underline;
                this.strikeoutCheckBox.Checked = font.Strikeout;

            }
            get
            {
                FontStyle fs = 0;
                if (this.boldCheckBox.Checked)
                    fs |= FontStyle.Bold;
                if (this.italicCheckBox.Checked)
                    fs |= FontStyle.Italic;
                if (this.underlineCheckBox.Checked)
                    fs |= FontStyle.Underline;
                if (this.strikeoutCheckBox.Checked)
                    fs |= FontStyle.Strikeout;
                this.font = new Font(font, fs);
                return font;




            }
        
        
        }
        public FontForm()
        {
            InitializeComponent();
            okButton.DialogResult = DialogResult.OK;
            cancelButton.DialogResult = DialogResult.Cancel;
            this.AcceptButton = this.okButton;
            this.CancelButton = this.cancelButton;
            
        }



        private void fontComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            font = new Font(this.fontComboBox.SelectedItem.ToString(), font.Size, font.Style);
           
        }



        private void sizeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            int size = Convert.ToInt32(((RadioButton)sender).Text);
            font = new Font(this.font.OriginalFontName, size, font.Style);
        }

        private void styleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            FontStyle fs = 0;
            if (this.boldCheckBox.Checked)
                fs |= FontStyle.Bold;
            if (this.italicCheckBox.Checked)
                fs |= FontStyle.Italic;
            if (this.underlineCheckBox.Checked)
                fs |= FontStyle.Underline;
            if (this.strikeoutCheckBox.Checked)
                fs |= FontStyle.Strikeout;
            this.font = new Font(font, fs);
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Font = font;
        }

        private void FontForm_Load(object sender, EventArgs e)
        {
            foreach(System.Drawing.FontFamily i in objFont.Families)
            {
            fontComboBox.Items.Add(i.Name.ToString());
            }
        }
        public event EventHandler Apply;
        private void applyButton_Click(object sender, EventArgs e)
        {
            if (Apply != null)
                Apply(this, new EventArgs());
        }
        public bool ShowApply
        {
            get { return applyButton.Enabled; }
            set { applyButton.Enabled = value; }

        }


        private void button2_Click(object sender, EventArgs e)
        {
            GraffitiForm fontForm = new GraffitiForm();//跳转窗体
            fontForm.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            String path = Environment.GetFolderPath(Environment.SpecialFolder.Fonts);
            System.Diagnostics.Process.Start("explorer.exe", path);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {

        }     
    }
}
