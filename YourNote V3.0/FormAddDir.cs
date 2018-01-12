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
    public partial class FormAddDir : Form
    {
        public FormAddDir()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAddDir_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    string connString = ConnectionDB.getConnectionString();
            //    SqlConnection conn = new SqlConnection(connString);

            //    conn.Open();

            //    string sql = String.Format("insert into dir values('{0}','0')",
            //        this.buttonAddDir.Text);

            //    SqlCommand cmd = new SqlCommand(sql, conn);

            //    int result = (int)cmd.ExecuteScalar();

            //    if (result > 0)
            //    {
            //        MessageBox.Show("注册成功啦！", "恭喜", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //    else
            //    {
            //        MessageBox.Show("成功？不存在的！");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    throw;
            //}
            //finally
            //{
            //    DBHelper.con.Close();
            //}

            try
            {
                String sqlString = ConnectionDB.getConnectionString();
                SqlConnection conn = new SqlConnection(sqlString);

                conn.Open();

                string num="0";

                string sql = String.Format("insert into dir values('{0}','{1}')",
                    this.textBoxAddDir.Text,num);

                
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
                //throw;
            }
            finally
            {
                //关闭数据库
                DBHelper.con.Close();
            }
            
        }
    }
}
