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

        DBOperate operate = new DBOperate();
        SqlConnection conn = DesktopNote.DBConnection.MyConnection();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                FormDirectory frm= new FormDirectory();
                string sql = String.Format("insert into Note_info values('{0}','{1}','{2}')",
                    this.textBox1.Text,frm.richTextBoxContent.Text,this.comboBox1.Text);
                operate.OperateData(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
