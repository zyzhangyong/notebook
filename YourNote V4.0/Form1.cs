using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;


namespace DesktopNote
{
    public partial class NoteForm : Form
    {
        //int index = 0;
        //int indexUp = 0;
        //Boolean found = false;
        //Boolean foundUp = false;


        //private void loadNote()
        //{
        //    string workDirectory = Properties.Settings.Default.WorkDirectory;
        //    noteList.Clear();
        //    String[] txtFiles = Directory.GetFiles(workDirectory, "*.txt");
        //    foreach (String txtFile in txtFiles)
        //    {
        //        Note note = new Note();
        //        StreamReader tr = null;
        //        try
        //        {
        //            tr = new StreamReader(txtFile, Encoding.Default);
        //            note.Content = tr.ReadToEnd();
        //            noteList.Add(note);
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("出现打开异常:" + ex.Message);
        //        }
        //        finally {
        //            if (tr != null)
        //                tr.Close();
        //        }
        //    }
        //    if (noteList.Count != 0)
        //    {
        //        this.Tag = noteList[0];

        //    }
        //    else
        //    {
        //        newButton_Click(null, null);

        //    }
        //    this.refreshMainTextBox();
        //}



        private ArrayList noteList = new ArrayList();
        //private ArrayList nn = new ArrayList();
        private ArrayList definedCombinationList = new ArrayList();
        public void initDefinedCombinationList()
        {
            for (int i = 0; i < 9; i++)
            {
                DefinedCombination dc = new DefinedCombination();
                dc.Prefix = '/';
                dc.Replaced = (char)((int)'1' + i);
                dc.Replacement = (char)((int)'\x2460' + i);
                this.definedCombinationList.Add(dc);
            
            }
        }
        public NoteForm()
        {
            InitializeComponent();        
            setFontButton.Anchor = AnchorStyles.None;
            initDefinedCombinationList();


        }
        /*成为active状态时*/
        private void refreshMainTextBox()
        {
            if (this.Tag != null && this.Tag is Note)
            {
                Note currentNote = (Note)this.Tag;
                this.mainTextBox.Text = currentNote.Content;
                this.mainTextBox.BackColor = currentNote.BackColor;
                this.mainTextBox.ForeColor = currentNote.ForeColor;
                this.mainTextBox.Font = currentNote.Font;
            }
            this.Text = "记事本(" + (this.noteList.IndexOf(this.Tag) + 1) + "/" + this.noteList.Count + ")";
        }

        /*
         * 取消active状态时；
         * 暂存note的属性  */
        private void saveCurrentNote()
        {
            if (this.Tag != null && this.Tag is Note)
            {
                Note currentNote = (Note)this.Tag; //此时currentNote指的就是要不active的note
                currentNote.Content = this.mainTextBox.Text;
                currentNote.BackColor = this.mainTextBox.BackColor;
                currentNote.ForeColor = this.mainTextBox.ForeColor;
                currentNote.Font = this.mainTextBox.Font;
                currentNote.ModifyDateTime = DateTime.Now;
            }
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            Note newNote = new Note();
            newNote.CreateDateTime = DateTime.Now;   //独立标记每一个note
            this.Tag = newNote;
            noteList.Add(newNote);
            refreshMainTextBox();
            
        }

        //private void vv()
        //{
        //    if (this.Tag != null && this.Tag is Note)
        //    { 
        //        Note nnn=(Note)this.Tag;
        //        this.mainTextBox.Text = nnn.Content;

        //    }
        //    this.Text = "记事本（" + (this.noteList.IndexOf(this.Tag) + 1 )+ "/" + this.noteList.Count + ")";
        //}

        private void delButton_Click(object sender, EventArgs e)
        {
            int index = noteList.IndexOf(this.Tag);
            if (this.Tag != null && this.Tag is Note)
            {
                noteList.Remove(this.Tag);
            }
            if (noteList.Count > 0)                 //在当前note数目大于1的时候
            {
                //删除当前笔记的时候，定位到删除前的那一个笔记
                this.Tag = noteList[ (index-1) % noteList.Count]; 
                refreshMainTextBox();               //显示该tag下的笔记的属性
            }
            else
            {
                this.newButton.PerformClick();  //如果小于0，则新建笔记，是另一个按钮的交替单击事件生成按钮的单击事件
            }

        }
        /*选取上一个笔记*/
        private void preButton_Click(object sender, EventArgs e)
        {
            saveCurrentNote();
            int index = noteList.IndexOf(this.Tag);
            if (index >= 1)
                this.Tag = noteList[index - 1];
            refreshMainTextBox();
        }
        /*选取下一个笔记*/
        private void nextButton_Click(object sender, EventArgs e)
        {
            saveCurrentNote();
            int index = noteList.IndexOf(this.Tag);
            if (index + 1 < noteList.Count)
                this.Tag = noteList[index + 1];
            refreshMainTextBox();
        }


        private void NoteForm_Load(object sender, EventArgs e)
        {
            //newButton_Click(null, null);
            //this.loadNote();
            this.loadNoteFromXML();
            this.NoteForm_SizeChanged(null, null);
        }

        private void NoteForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("确定要退出吗？", "记事本",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                //this.saveNote();
                this.saveNoteToXML();
            }
        }

        private void setFontButton_Click(object sender, EventArgs e)
        {
            FontForm fontForm = new FontForm();
            //针对于应用按钮
            //fontForm.Font = this.mainTextBox.Font;
            //fontForm.Apply+=new EventHandler(fontForm_Apply);
            //fontForm.Apply += new EventHandler(fontForm_Apply);
            if (fontForm.ShowDialog() == DialogResult.OK)
                this.mainTextBox.Font = fontForm.Font;
            //fontForm.ShowDialog();

             // this.fontDialog1.ShowDialog();

        }
        //void fontForm_Apply(object sender, EventArgs e)
        //{
        //    this.mainTextBox.Font = ((FontForm)sender).Font;
        //}
      
        /*
         设置背景色
         */
        private void setBackgroundButton_Check(object sender, EventArgs e)
        {
            //调用颜色对话框
            ColorDialog cDialog = new ColorDialog();
            if (cDialog.ShowDialog() == DialogResult.OK)//如果对话框点击OK按钮的话，设置背景色
            {
                this.mainTextBox.BackColor = cDialog.Color;
            }

        }

        /*
         设置前景色
         */
        private void setForeColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog cDialog = new ColorDialog();
            if (cDialog.ShowDialog() == DialogResult.OK)
            {
                this.mainTextBox.ForeColor = cDialog.Color;
            }
        }

        private void mainTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (Control.ModifierKeys != Keys.Control)
                return;
            if (e.KeyCode == Keys.Up)
                this.Top -= 10;
            if (e.KeyCode == Keys.Down)
                this.Top += 10;
            if (e.KeyCode == Keys.Right)
                this.Left += 10;
            if (e.KeyCode == Keys.Left)
                this.Left -= 10;
        }

        private void mainTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = null;
            if (sender is TextBox)
            {
                textBox = (TextBox)sender;
            }
            else
            {
                return;
            }

            int ss = textBox.SelectionStart;
            if (ss == 0) return;
            foreach (DefinedCombination dc in this.definedCombinationList)
            {
                if(dc.Prefix == textBox.Text[ss - 1] && dc.Replaced == e.KeyChar)
                {
                    textBox.Text = textBox.Text.Remove(ss - 1, 1);
                    textBox.Text = textBox.Text.Insert(ss - 1, Convert.ToString(dc.Replacement));
                    textBox.SelectionStart = ss;
                    textBox.SelectionLength = 0;
                    e.Handled = true;
                }
            }
        }

        private void openGraffitiFormButton_Click(object sender, EventArgs e)
        {
            GraffitiForm graffitiForm = new GraffitiForm();
            graffitiForm.ShowDialog();
        }

        private void 工具ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 载入文本文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "文本文件|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //
                TextReader tr = null;
                if (this.Tag == null)
                    this.newButton_Click(null, null);
                Note currentNote = (Note)this.Tag;
                try
                {
                    //把从ofg.FileName读到的内容先放入StreamReader
                    tr = new StreamReader(ofd.FileName, Encoding.Default);
                    //然后将tr的内容写入当前的活跃的文本框里
                    currentNote.Content = tr.ReadToEnd();
                    
                    this.refreshMainTextBox();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("出现打开异常:" + ex.Message);
                }
                finally
                {
                    if (tr != null)
                        tr.Close();
                }
            }
        }

        private void 保存文本文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "文本文件|*.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                TextWriter tw = null;
                try
                {
                    saveCurrentNote();          //先保存当前tag里文本的content
                    //添加一个符合filter类型的文件，如果已经存在会追加，如果不存在则新建
                    tw = new StreamWriter(sfd.FileName, false, Encoding.Default);
                    //写入内容
                    tw.Write(((Note)this.Tag).Content);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("保存异常：" + ex.Message);
                }
                finally
                {
                    if (tw != null)
                        tw.Close();
                }
            }

        }

        private void NoteForm_SizeChanged(object sender, EventArgs e)
        {

        }

        private void saveNote()
        {
            for (int i = 0; i < this.noteList.Count; i++)
            {
                TextWriter tw = null;
                try
                {
                    saveCurrentNote();
                    tw = new StreamWriter(Properties.Settings.Default.WorkDirectory + "\\" + i + ".txt", false, Encoding.Default);
                    tw.Write(((Note)noteList[i]).Content);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("保存异常:" + ex.Message);

                }
                finally
                {
                    if (tw != null)
                        tw.Close();
                }
            }
      
        }
        private void saveNoteToXML()
        {
            this.saveCurrentNote();
            XmlTextWriter textWriter = null;
            try
            {
                textWriter = new XmlTextWriter(Application.StartupPath + "\\Notes.xml", null);
                textWriter.Formatting = Formatting.Indented;
                textWriter.WriteStartDocument();
                textWriter.WriteStartElement("Notes");
                foreach (Note note in noteList)
                {
                    textWriter.WriteStartElement("Notes");
                    textWriter.WriteElementString("Content", note.Content);
                    textWriter.WriteElementString("BackColor", note.BackColor.ToArgb().ToString());
                    textWriter.WriteElementString("CreateDateTime", note.CreateDateTime.ToString());
                    textWriter.WriteElementString("Font", note.Font.Name);
                    textWriter.WriteElementString("ForeColor", note.ForeColor.ToArgb().ToString());
                    textWriter.WriteElementString("ModifyDateTime", note.ModifyDateTime.ToString());
                    textWriter.WriteEndElement();
                }
                textWriter.WriteEndElement();
                textWriter.WriteEndDocument();
            }
            catch (Exception ex)
            {
                MessageBox.Show("保存异常：" + ex.Message);

            }
            finally {
                if (textWriter != null) ;
                textWriter.Close();
            }
        }
        private void loadNoteFromXML()
        {
            noteList.Clear();
            XmlTextReader textReader = null;
            try
            {
                textReader = new XmlTextReader(Application.StartupPath + "\\Notes.xml");
                while (textReader.Read())
                {
                    if (textReader.LocalName.Equals("Note") && textReader.NodeType == XmlNodeType.Element)
                    {
                        Note note = new Note();
                        textReader.Read();
                        note.Content = textReader.ReadElementString("Content");
                        textReader.Read();
                        note.BackColor = Color.FromArgb(Convert.ToInt32(textReader.ReadElementString("BackColor")));
                        textReader.Read();
                        note.CreateDateTime = DateTime.Parse(textReader.ReadElementString("CreateDateTime"));
                        textReader.Read();
                        note.Font = new Font(textReader.ReadElementString("Font"), this.Font.Size, this.Font.Style);
                        textReader.Read();
                        note.ForeColor = Color.FromArgb(Convert.ToInt32(textReader.ReadElementString("ForeColor")));
                        textReader.Read();
                        note.ModifyDateTime = DateTime.Parse(textReader.ReadElementString("ModifyDateTime"));
                        noteList.Add(note);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("载入异常：" + ex.Message);
            }
            finally
            {
                if (textReader != null)
                    textReader.Close();

            }
            if (noteList.Count != 0)
            {
                this.Tag = noteList[0];
            }
            else
            {
                newButton_Click(null, null);
            }
            this.refreshMainTextBox();
        }

        private void 全选AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.mainTextBox.SelectAll();
        }


        private void btnGodir_Click(object sender, EventArgs e)
        {
            FormDirectory frmGoDir = new FormDirectory();
            frmGoDir.ShowDialog();
        }

        private void btnNewdir_Click(object sender, EventArgs e)
        {
            FormAddDir frmAddDir = new FormAddDir();
            frmAddDir.ShowDialog();
        }

        private void btnSelectdir_Click(object sender, EventArgs e)
        {
            SelectDirectoryForm frmDirSele = new SelectDirectoryForm();
            frmDirSele.ShowDialog();
        }

        private void 复制CToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            this.mainTextBox.Copy();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormDirectory frmDir = new FormDirectory();
            frmDir.ShowDialog();
        }


        private void mainTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void 粘贴VToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.mainTextBox.Paste();
        }

        private void 日期ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(DateTime.now);
            MessageBox.Show("" + DateTime.Now);
        }

        //private void buttonFindNext_Click(object sender, EventArgs e)
        //{
        //    //MainForm mainform = (MainForm)Application.OpenForms["mainForm"];
        //    Note currentNote = (Note)this.Tag;

        //    for (; index <= this.mainTextBox.Text.Length - textBox1.Text.Length; index++)
        //        {
        //            this.mainTextBox.Select(index, textBox1.Text.Length);
        //            if (index == this.mainTextBox.Text.Length - textBox1.Text.Length)
        //            {
        //                if (!found)
        //                {
        //                    MessageBox.Show("找不到该字符串！");
        //                    break;
        //                }
        //                index = -1;
        //            }
        //            //if (!checkBoxCase.Checked)
        //            //{
        //            //    if (this.mainTextBox.SelectedText.ToLower().Equals(textBox1.Text.ToLower()))
        //            //    {
        //            //        this.mainTextBox.Focus();
        //            //        found = true;
        //            //        index++;
        //            //        break;
        //            //    }
        //            //}
        //            if (this.mainTextBox.SelectedText.Equals(textBox1.Text))
        //            {
        //                this.mainTextBox.Focus();
        //                index++;
        //                break;
        //            }
        //     }

        //}
      
    }
}
