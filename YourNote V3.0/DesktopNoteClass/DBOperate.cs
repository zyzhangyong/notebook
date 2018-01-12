using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Drawing;

namespace DesktopNote
{
    class DBOperate
    {
        SqlConnection conn = DBConnection.MyConnection();
        //操作数据库，执行各种SQL语句
        public int OperateData(string strSql)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(strSql, conn);
            int i = (int)cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }
        //执行各种存储过程
        public void OperateProc(ComboBox cb, Label lbl, RadioButton rd, string procName)//操作存储过程
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.CommandText = procName;
            cmd.Parameters.AddWithValue("@kcname", cb.Text);
            cmd.Parameters.AddWithValue("@n", 0.0);
            cmd.Parameters["@kcname"].Direction = ParameterDirection.Input;
            cmd.Parameters["@n"].Direction = ParameterDirection.Output;

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                lbl.Text = rd.Text + ":" + cmd.Parameters["@n"].Value.ToString();
                cmd.Parameters.Clear();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        public void BindDataGridView(DataGridView dgv, string sql)
        {//绑定DataGridView控件
            SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dgv.DataSource = ds.Tables[0];
            ds.Dispose();
        }

        public int HumanNum(string strsql)
        {//查找指定数据表的人数
            conn.Open();
            SqlCommand cmd = new SqlCommand(strsql, conn);
            int i = (int)cmd.ExecuteScalar();
            conn.Close();
            return i;
        }

        public DataSet GetTable(string sql)
        {//返回dataset
            SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            ds.Dispose();
            return ds;
        }

        public void BindDropdownlist(string strTable, ComboBox cb, int i)
        {//绑定下拉列表,参数“表”，“控件”，“列”
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from " + strTable, conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                cb.Items.Add(sdr[i].ToString());
            }
            conn.Close();
        }


        public void BindText(string strTable, TextBox tx, int i)
        {//绑定文本框,参数“表”，“控件”，“列”
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from " + strTable, conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read() == true)
            {
                tx.Text = string.Format("{0}", sdr[i]);
            }
            conn.Close();
        }

        public void BindDateTime(string strTable, DateTimePicker dt, int i)
        {//绑定日期控件,参数“表”，“控件”，“列”
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from " + strTable, conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read() == true)
            {
                dt.Format = DateTimePickerFormat.Short;
                dt.Value = Convert.ToDateTime(sdr[i]);
            }
            conn.Close();
        }


        public void BindCheckList(string strTable, CheckedListBox checklist, int i)
        {//绑定CheckList,参数“表”，“控件”，“列”
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from " + strTable, conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read() == true)
            {
                if (string.Format("{0}", sdr[i]) == "男")
                {
                    checklist.SetItemChecked(0, true);
                    checklist.SetItemChecked(1, false);
                }
                else
                {
                    checklist.SetItemChecked(0, false);
                    checklist.SetItemChecked(1, true);
                }
            }
            conn.Close();
        }


        public void BindKJ(string strTable, TextBox tx1, TextBox tx2, CheckedListBox checklist, DateTimePicker dt, TextBox tx3, ComboBox cb)
        {//绑定控件,参数“表”，“控件”，“列”

            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from " + strTable, conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read() == true)
            {
                tx1.Text = string.Format("{0}", sdr["sno"]);
                tx2.Text = string.Format("{0}", sdr["sname"]);
                if (string.Format("{0}", sdr["ssex"]) == "男")
                {
                    checklist.SetItemChecked(0, true);
                    checklist.SetItemChecked(1, false);
                }
                else
                {
                    checklist.SetItemChecked(0, false);
                    checklist.SetItemChecked(1, true);
                }
                dt.Format = DateTimePickerFormat.Short;
                dt.Value = Convert.ToDateTime(sdr["sbirthday"]);

                tx3.Text = string.Format("{0}", sdr["sage"]);
                //tx4.Text = string.Format("{0}", sdr["sdept"]);
                cb.Text = string.Format("{0}", sdr["sdept"]);
            }
            conn.Close();
        }

        public bool FindSno(string strTable, string snum)
        {//查找学号
            conn.Open();
            bool f = false;
            string fstr = "select * from " + strTable + " where sno='" + snum + "'";
            SqlCommand cmd = new SqlCommand(fstr, conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read() == true)
            {
                f = true;
            }
            conn.Close();
            return f;

        }
    }
}
