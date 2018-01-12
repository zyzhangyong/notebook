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

        DBOperate operate = new DBOperate();
        SqlConnection conn = DesktopNote.DBConnection.MyConnection();

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAddDir_Click(object sender, EventArgs e)
        {
            try
            {
                string num = "0";
                string sql = String.Format("insert into dir values('{0}','{1}')",
                    this.textBoxAddDir.Text, num);
                if (this.textBoxAddDir.Text == "")
                    MessageBox.Show("分类名不能为空！");
                else
                    operate.OperateData(sql);
            }
            catch
            {
                MessageBox.Show("分类已存在！请重新输入！");
            }
        }

        private void FormAddDir_Load(object sender, EventArgs e)
        {

        }
    }
}
