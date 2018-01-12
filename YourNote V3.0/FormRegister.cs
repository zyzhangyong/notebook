using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using DesktopNote.DesktopNoteClass;

namespace DesktopNote
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {    
            try
            {
                String sqlString = ConnectionDB.getConnectionString();
                SqlConnection conn = new SqlConnection(sqlString);

                conn.Open();

                string Users_Type = this.comboBoxQuanxian.Text;

                string sql = String.Format("insert into Users values('{0}','{1}','{2}')",
                    this.textBoxAccount.Text,this.textBoxPwd.Text,Users_Type);

                SqlCommand cmd = new SqlCommand(sql, conn);
                //MessageBox.Show("ddddddd");
                //int result = (int)cmd.ExecuteScalar();
                int result=cmd.ExecuteNonQuery();
                //MessageBox.Show("ggggg"+result);
                if (result > 0)
                {
                    MessageBox.Show("恭喜你注册成功！", "恭喜",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //this.Close();
                }
                else
                {
                    MessageBox.Show("注册失败！");
                }
                DBHelper.con.Close();
                
                
            }
            catch
            {
                //MessageBox.Show("aaaaadddd");
                MessageBox.Show("用户名已经存在！请重新输入！");
                //throw;
            }
          
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {

        }

        private void btnRegisCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
