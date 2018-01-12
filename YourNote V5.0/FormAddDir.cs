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
    public partial class FormAddDir : Form
    {
        public FormAddDir()
        {
            InitializeComponent();
        }

        DAL.DBOperate operate = new DAL.DBOperate();
        SqlConnection conn = DAL.DBConnection.MyConnection();

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
                {
                    int result = operate.OperateDataQuery(sql);
                    if (result > 0)
                    {
                        MessageBox.Show("添加成功！", "恭喜", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("添加失败！");
                    }
                }
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
