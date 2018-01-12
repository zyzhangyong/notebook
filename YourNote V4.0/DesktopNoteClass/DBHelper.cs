using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace DesktopNote.DesktopNoteClass
{
    class DBHelper
    {
        private static string sqlCon = "Data Source=laptop-agdq0scd;Initial Catalog=Pad_Users;Integrated Security=True";
        public static SqlConnection con = new SqlConnection(sqlCon);

    }
}
