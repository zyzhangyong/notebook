using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace DAL
{
    public class DBConnection
    {
        public static SqlConnection MyConnection()
        {
            //连接数据库 
            return new SqlConnection("Data Source=laptop-agdq0scd;Initial Catalog=Pad_Users;Integrated Security=True");
        }
    }
}
