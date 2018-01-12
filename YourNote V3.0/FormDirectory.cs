using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DesktopNote.DesktopNoteClass;
using System.Data.SqlClient;

namespace DesktopNote
{
    public partial class FormDirectory : Form
    {

        
        public FormDirectory()
        {
            InitializeComponent();
        }

        DBOperate operate = new DBOperate();
        public string dataTableName = "";

        int colCount;

        private void getCobboboxList()
        {
            string connString = ConnectionDB.getConnectionString();

            List<string> list= new List<string>();

            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            //获取索引
            string sql = "select Note_dir from dir";
            SqlDataAdapter myAdapter = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            myAdapter.Fill(ds, "dirNum");
            int dirNum= ds.Tables["dirNum"].Rows.Count;
            ds.Dispose();

        }

        public void comboBoxDirNum_SelectedIndexChanged(object sender, EventArgs e)
        {

            getCobboboxList();

            string dirName = this.comboBoxDirName.Text;

            string connString = ConnectionDB.getConnectionString();
            SqlConnection conn = new SqlConnection(connString);

            string sql = String.Format("select Note_name from Note_info where Note_dir='{0}'", dirName);

            SqlDataAdapter myAdapter = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            myAdapter.Fill(ds, dirName);

            DGDir.DataSource = ds.Tables[dirName];
            colCount = DGDir.ColumnCount;
            ds.Dispose();
        }


        private void DGDir_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("您单击的是第" + (e.RowIndex + 1) + "行第" + (e.ColumnIndex + 1) + "列！");
            //MessageBox.Show("单元格的内容是：" + DGDir.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
            //MessageBox.Show("笔记名：" + DGDir.CurrentCell.Value);
            try
            {
                string noteValue = DGDir.CurrentCell.Value.ToString();

                string connString = ConnectionDB.getConnectionString();
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();
                string sql = String.Format("select Note_value from Note_info where Note_name='{0}'", noteValue);
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    richTextBoxContent.Text = (string)dr.GetValue(e.ColumnIndex);
                }
                dr.Close();
                conn.Close();
            }
            catch
            {
                MessageBox.Show("文本内容为空！");
            }
            //DGDir.CellContentClick += new DataGridViewCellEventHandler(DGDir_CellContentClick);
            //DGDir.CellDoubleClick+=new DataGridViewCellEventHandler(DGDir_CellDoubleClick);
        }

        private void buttonDirstore_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("你是认真的吗？","喂",MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                
                string mContent = richTextBoxContent.Text;  //获取修改后的富文本框里的内容
                
                string mName=(string)DGDir.SelectedCells[0].Value;  //获取被修改内容的笔记名
                
                //获取数据库连接字符串
                string connString = ConnectionDB.getConnectionString();
                SqlConnection conn = new SqlConnection(connString);
                
                conn.Open();        //开启数据库连接

                //设置Sql语句
                string sql = String.Format("update Note_info set Note_value='{0}' where Note_name='{1}'",mContent,mName);
                
                //执行Sql语句
                SqlCommand cmd = new SqlCommand(sql, conn);
                int result=cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("修改成功！");
                }

                conn.Close();       //关闭数据库连接
            }


        }


        private void buttonDirrename_Click(object sender, EventArgs e)
        {
            
        }

        private void FormDirectory_Load(object sender, EventArgs e)
        {
            dataTableName = comboBoxDirName.Text;
            string connString = ConnectionDB.getConnectionString();

            operate.BindDropdownlist("dir", comboBoxDirName, 0);
            operate.BindDropdownlist("dir", comboBoxMove, 0);

            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            string noteValue = DGDir.CurrentCell.Value.ToString();
            try
            {
                String sqlString = ConnectionDB.getConnectionString();
                SqlConnection conn = new SqlConnection(sqlString);

                conn.Open();
                
                string sql = String.Format("insert into note_info values('{0}','{1}','{2}')",
                    noteValue,this.richTextBoxContent.Text,this.comboBoxDirName.Text);


                SqlCommand cmd = new SqlCommand(sql, conn);
                int result = (int)cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("新建成功！", "恭喜", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("失败了");
                }
            }
            catch 
            {
                MessageBox.Show(noteValue+"笔记已存在！");
            }
            //finally
            //{
            //    //关闭数据库
            //    DBHelper.con.Close();
            //}
            comboBoxDirNum_SelectedIndexChanged(sender, e);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                String sqlString = ConnectionDB.getConnectionString();
                SqlConnection conn = new SqlConnection(sqlString);

                conn.Open();
                string noteValue = DGDir.CurrentCell.Value.ToString();
                string sql = String.Format("delete from Note_info where note_name='{0}'",
                    noteValue);

                
                SqlCommand cmd = new SqlCommand(sql, conn);
                int result = (int)cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("删除成功！", "恭喜你啦", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("失败了");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //finally
            //{
            //    //关闭数据库
            //    DBHelper.con.Close();
            //}
            comboBoxDirNum_SelectedIndexChanged(sender, e);
        }

        private void comboBoxMove_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MessageBox.Show("你是认真的吗？", "喂", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string noteValue = DGDir.CurrentCell.Value.ToString();
                try
                {
                    String sqlString = ConnectionDB.getConnectionString();
                    SqlConnection conn = new SqlConnection(sqlString);

                    conn.Open();

                    string sql = String.Format("insert into note_info values('{0}','{1}','{2}')",
                        noteValue, this.richTextBoxContent.Text, this.comboBoxMove.Text);

                    string sql1 = String.Format("delete from Note_info where note_name='{0}' and note_dir='{1}'",
                    noteValue,this.comboBoxDirName.Text);

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlCommand cmd1 = new SqlCommand(sql1,conn);
                    int result = (int)cmd.ExecuteNonQuery();
                    cmd1.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("移动成功！", "恭喜", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("失败了");
                    }
                }
                catch
                {
                    MessageBox.Show(noteValue + "笔记已存在！");
                }
                //finally
                //{
                //    //关闭数据库
                    
                //    DBHelper.con.Close();
                //}
                comboBoxDirNum_SelectedIndexChanged(sender, e);
                //this.comboBoxMove.Text = null;
            }
        }

        private void textBoxDirSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
