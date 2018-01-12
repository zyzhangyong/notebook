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

        DBOperate operate = new DBOperate();
        SqlConnection conn = DesktopNote.DBConnection.MyConnection();

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {    
            try
            {
                string Users_Type = this.comboBoxQuanxian.Text;
                string sql = String.Format("insert into Users values('{0}','{1}','{2}')",
                    this.textBoxAccount.Text,this.textBoxPwd.Text,Users_Type);
                operate.OperateData(sql);          
            }
            catch
            {
                MessageBox.Show("用户名已经存在！请重新输入！");
                this.Close();
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
