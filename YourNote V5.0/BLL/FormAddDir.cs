using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;

namespace BLL
{
    public class FormAddDir
    {
        DAL.DBOperate operate = new DAL.DBOperate();
        SqlConnection conn = DAL.DBConnection.MyConnection();
        DesktopNote.FormAddDir ad= new DesktopNote.FormAddDir();
        
        
        public int AddDir()
        { 
            string num = "0";
            string sql = String.Format("insert into dir values('{0}','{1}')",
                    ad.textBoxAddDir.Text, num);
            int result = operate.OperateDataQuery(sql);
            return result;
             }
        }
    }
}
