using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DesktopNote.Properties;
//using DesktopNote.DesktopNoteClass;
using System.Data.SqlClient;
using System.Collections;
using System.Threading;


namespace DesktopNote
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {

            InitializeComponent();
        }

        DAL.DBOperate operate = new DAL.DBOperate();
        SqlConnection conn = DAL.DBConnection.MyConnection();

        //验证用户
        private bool ValidateUser()
        { 
            try
            {
                string sql = string.Format("SELECT count(*) FROM Users WHERE Users_Id='{0}' AND Users_Pwd='{1}'", this.tbAccount.Text, this.tbPassword.Text);
                int result = operate.OperateDataScalar(sql);

                if (result > 0)
                {
                    MessageBox.Show("恭喜,登陆成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("不好意思,用户名或密码错误!");
                    return false;
                }
            }
            catch
            {
                MessageBox.Show("注册成功！");               
            }
            return false;           
        }

        


        private void linkLabelRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegister fm1 = new FormRegister();
            fm1.ShowDialog();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //登录按钮
            if (ValidateInput() && ValidateUser())
            {
                //打开窗体，隐藏本身
                NoteForm fmw = new NoteForm();
                this.Visible = false;
                fmw.ShowDialog();
                this.Close();
            }
        }

        private bool ValidateInput()
        {
            if (this.tbAccount.Text == "")
            {
                MessageBox.Show("账户不能为空！");
                this.tbAccount.Focus();
                return false;
            }
            else if (this.tbPassword.Text == "")
            { 
                MessageBox.Show("密码不能为空！");
                this.tbPassword.Focus();
                return false;
            }
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NoteForm fm1 = new NoteForm();
            this.Hide();
            fm1.ShowDialog();
            this.Close();
        }
    }
}
