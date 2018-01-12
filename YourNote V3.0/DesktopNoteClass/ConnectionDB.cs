using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace DesktopNote.DesktopNoteClass
{
    class ConnectionDB
    {
        public static string getConnectionString()
        {
            return "Data Source=laptop-agdq0scd;Initial Catalog=Pad_Users;Integrated Security=True";
            //public static SqlConnection con = new SqlConnection(sqlCon);
        }
    }
}
