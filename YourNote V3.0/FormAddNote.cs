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
    public partial class FormAddNote : Form
    {
        public FormAddNote()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                FormDirectory frm= new FormDirectory();
                String sqlString = ConnectionDB.getConnectionString();
                SqlConnection conn = new SqlConnection(sqlString);

                conn.Open();

                string sql = String.Format("insert into Note_info values('{0}','{1}','{2}')",
                    this.textBox1.Text,frm.richTextBoxContent.Text,this.comboBox1.Text);


                SqlCommand cmd = new SqlCommand(sql, conn);

                int result = (int)cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("恭喜您添加成功", "恭喜你啦", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("成功？不存在的！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //关闭数据库
                DBHelper.con.Close();
            }
        }
    }
}
