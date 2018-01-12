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
    public partial class FormAddNote : Form
    {
        public FormAddNote()
        {
            InitializeComponent();
        }

        DAL.DBOperate operate = new DAL.DBOperate();
        SqlConnection conn = DAL.DBConnection.MyConnection();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                FormDirectory frm= new FormDirectory();
                string sql = String.Format("insert into Note_info values('{0}','{1}','{2}')",
                    this.textBox1.Text,frm.richTextBoxContent.Text,this.comboBox1.Text);
                int result = operate.OperateDataQuery(sql);
                if (result > 0)
                {
                    MessageBox.Show("新建成功！", "恭喜", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("新建失败！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
