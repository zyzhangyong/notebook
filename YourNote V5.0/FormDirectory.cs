using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using DesktopNote.DesktopNoteClass;
using System.Data.SqlClient;


namespace DesktopNote
{
    public partial class FormDirectory : Form
    {
        public FormDirectory()
        {
            InitializeComponent();
        }

        DAL.DBOperate operate = new DAL.DBOperate();
        SqlConnection conn = DAL.DBConnection.MyConnection();

        //DBOperate operate = new DBOperate();      
        //SqlConnection conn = DAL.DBConnection.MyConnection();
        public string dataTableName = "";

        public void comboBoxDirNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dirName = this.comboBoxDirName.Text;
            string sql = String.Format("select Note_name from Note_info where Note_dir='{0}'", dirName);
            operate.GetTable1(sql, dirName, DGDir);
        }

        //public void chooseCell()
        //{
        //    //MessageBox.Show("您单击的是第" + (e.RowIndex + 1) + "行第" + (e.ColumnIndex + 1) + "列！");
        //    //MessageBox.Show("单元格的内容是：" + DGDir.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
        //    //MessageBox.Show("笔记名：" + DGDir.CurrentCell.Value);
        //}

        private void DGDir_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {            
            try
            {
                string noteValue = DGDir.CurrentCell.Value.ToString();
                string sql = String.Format("select Note_value from Note_info where Note_name='{0}'", noteValue);
                    operate.DoubleClick(sql, richTextBoxContent, e);
            }
            catch(Exception ex)
            {
                MessageBox.Show("文本内容为空！"+ex.Message);
            }
            //DGDir.CellContentClick += new DataGridViewCellEventHandler(DGDir_CellContentClick);
            //DGDir.CellDoubleClick+=new DataGridViewCellEventHandler(DGDir_CellDoubleClick);
        }

        private void buttonDirstore_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("你是认真的吗？", "", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string mContent = richTextBoxContent.Text;  //获取修改后的富文本框里的内容
                string mName = (string)DGDir.SelectedCells[0].Value;  //获取被修改内容的笔记名

                try
                {
                    string sql = String.Format("update Note_info set Note_value='{0}' where Note_name='{1}'", mContent, mName);
                    int result = operate.OperateDataQuery(sql);
                    if (result > 0)
                    {
                        MessageBox.Show("保存成功！", "恭喜", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("保存失败！");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void FormDirectory_Load(object sender, EventArgs e)
        {
            dataTableName = comboBoxDirName.Text;
            operate.BindDropdownlist("dir", comboBoxDirName, 0);
            operate.BindDropdownlist("dir", comboBoxMove, 0);
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            string noteValue = DGDir.CurrentCell.Value.ToString();
            string dirName = this.comboBoxDirName.Text;
            try
            {
                string sql = String.Format("insert into note_info values('{0}','{1}','{2}')",
                    noteValue, this.richTextBoxContent.Text, this.comboBoxDirName.Text);
                int result=operate.OperateDataQuery(sql);
                if (result > 0)
                {
                    MessageBox.Show("新建成功！", "恭喜", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("新建失败！");
                }
            }
            catch
            {
                MessageBox.Show(noteValue + "   笔记已存在！");
            }
            comboBoxDirNum_SelectedIndexChanged(sender, e);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string noteValue = DGDir.CurrentCell.Value.ToString();
                string sql = String.Format("delete from Note_info where note_name='{0}'",
                    noteValue);
                int result=operate.OperateDataQuery(sql);
                if (result > 0)
                {
                    MessageBox.Show("删除成功！", "恭喜", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("删除失败！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            comboBoxDirNum_SelectedIndexChanged(sender, e);
        }

        private void comboBoxMove_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MessageBox.Show("你是认真的吗？", "", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string noteValue = DGDir.CurrentCell.Value.ToString();
                try
                {
                    string sql = String.Format("insert into note_info values('{0}','{1}','{2}')",
                        noteValue, this.richTextBoxContent.Text, this.comboBoxMove.Text);
                    string sql1 = String.Format("delete from Note_info where note_name='{0}' and note_dir='{1}'",
                    noteValue, this.comboBoxDirName.Text);
                    operate.OperateDataQuery(sql);
                    int result=operate.OperateDataQuery(sql1);
                    if (result > 0)
                    {
                        MessageBox.Show("移动成功！", "恭喜", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("移动失败！");
                    }
                }
                catch
                {
                    MessageBox.Show(noteValue + "   笔记已存在！");
                }
                comboBoxDirNum_SelectedIndexChanged(sender, e);
            }
        }
    }
}
