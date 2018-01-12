////using System;
////using System.Collections.Generic;
////using System.Linq;
////using System.Text;



////using System.Data;
////using System.Data.Sql;
////using System.Data.Odbc;
////using MySql.Data.MySqlClient;
////using System.IO;
////public class MySQLDataHelper : IDisposable
////{

////    string host = "127.0.0.1";
////    int port = 3306;
////    string uid = "root";
////    string password = "123456";
////    string dbname = "testforfileopert";

////    MySqlConnection conn = null;


////    // 构造函数 私有化
////    private MySQLDataHelper()
////    {
////        string connStr = "server=" + host
////                        + ";port=" + port
////                        + ";uid=" + uid
////                        + ";password=" + password
////                        + ";database=" + dbname;
////        conn = new MySqlConnection(connStr); //数据库连接 
////    }
////    // 单例模式
////    public static readonly MySQLDataHelper Instance = new MySQLDataHelper();

////    // 连接数据库
////    public Boolean ConnectToDB()
////    {
////        if (conn == null)
////            return false;
////        if (conn.State == System.Data.ConnectionState.Open)
////            return true;
////        try
////        {
////            conn.Open();
////        }
////        catch (Exception e)
////        {
////            return false;
////        }
////        return true;
////    }
////    //轻易不要这样用
////    public void Dispose()
////    {
////        if (conn != null)
////        {
////            conn.Dispose();
////            conn = null;
////        }
////    }

////    public DataTable GetDataTable(string sql)
////    {
////        if (conn != null)
////        {
////            if (conn.State == System.Data.ConnectionState.Open || ConnectToDB())
////            {
////                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
////                DataSet MyDataSet = new DataSet();
////                da.Fill(MyDataSet);
////                return MyDataSet.Tables[0];
////            }
////        }
////        return null;
////    }

////    //运行sql代码，只用于insert、update和delete，返回影响的行数
////    public int runSql(String sql)
////    {
////        if (conn != null)
////        {
////            if (conn.State == System.Data.ConnectionState.Open || ConnectToDB())
////            {
////                MySqlCommand cmd = new MySqlCommand(sql, conn);
////                return cmd.ExecuteNonQuery();
////            }
////        }
////        return 0;
////    }


////    /// <summary>
////    /// 运行SQL代码,这句话供Dragon来上传文件到表中；
////    /// </summary>
////    /// <param name="sql"></param>
////    /// <returns></returns>
////    public int upFile(String sql, Byte[] bytes, int curIndex, string fileName)
////    {
////        if (conn != null)
////        {
////            if (conn.State == System.Data.ConnectionState.Open || ConnectToDB())
////            {
////                MySqlCommand cmd = new MySqlCommand();
////                cmd.CommandText = sql;//这句需传参数;
////                cmd.CommandType = CommandType.Text;

////                cmd.Parameters.Add("@id", MySql.Data.MySqlClient.MySqlDbType.Int16);
////                cmd.Parameters.Add("@fileName", MySql.Data.MySqlClient.MySqlDbType.VarChar);
////                cmd.Parameters.Add("@filecontent", MySql.Data.MySqlClient.MySqlDbType.Blob);//这句需传参数;
////                cmd.Parameters[0].Value = curIndex;
////                cmd.Parameters[1].Value = fileName;
////                cmd.Parameters[2].Value = bytes;
////                cmd.Connection = conn;


////                return cmd.ExecuteNonQuery();


////            }
////        }
////        return 0;
////    }
////    /// <summary>
////    /// 用来从数据库下载文件
////    /// </summary>
////    /// <param name="sql">查询语句</param>
////    /// <param name="buffer">输出的字节数组，内含文件</param>
////    /// <returns></returns>
////    public long downFile(String sql, out byte[] buffer)
////    {
////        if (conn != null)
////        {
////            if (conn.State == System.Data.ConnectionState.Open || ConnectToDB())
////            {
////                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand();
////                cmd.CommandType = CommandType.Text;
////                cmd.CommandText = sql;
////                cmd.Connection = conn;
////                System.Data.Common.DbDataReader reader = cmd.ExecuteReader();
////                buffer = null;
////                if (reader.HasRows)
////                {
////                    reader.Read();
////                    long len = reader.GetBytes(0, 0, null, 0, 0);//1是picture
////                    buffer = new byte[len];
////                    len = reader.GetBytes(0, 0, buffer, 0, (int)len);
////                    //System.IO.MemoryStream ms = new System.IO.MemoryStream(buffer);
////                    //System.Drawing.Image iamge = System.Drawing.Image.FromStream(ms);
////                    //pictureBox1.Image = iamge;
////                    return len;
////                }
////            }
////        }
////        buffer = null;
////        return 0;

////    }

////    static void saveWord()
////    {
////        //MySQLDataHelper mdh = MySQLDataHelper.Instance;
////        //打开word文件并保存为字节数组;
////        string filePath = @"E:\资料\onedrive\文档\2015E8013261145_邓力.docx";
////        string fileName = filePath.Split('\\')[4];
////        FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
////        byte[] buffByte = new byte[fs.Length];
////        fs.Read(buffByte, 0, (int)fs.Length);
////        fs.Close();
////        fs = null;
////        int curIndex = 1;
////        string sql = "insert into testforfileopert.t_filesave values(?id,?fileName,?filecontent)";
////        MySQLDataHelper msdl = MySQLDataHelper.Instance;
////        int num = msdl.upFile(sql, buffByte, curIndex, fileName);
////        Console.WriteLine("num=" + num);

////    }
////    /// <summary>
////    /// 下载word文件到本地;
////    /// </summary>
////    static void downLoadWord()
////    {
////        //先从服务器下载数据;
////        string sql = "select fileContent from testforfileopert.t_filesave where id = 1";
////        byte[] bytes = null;
////        MySQLDataHelper mdhl = MySQLDataHelper.Instance;
////        long num = mdhl.downFile(sql, out bytes);
////        FileStream fs = new FileStream(@"D:\test.docx", FileMode.OpenOrCreate, FileAccess.Write);
////        fs.Write(bytes, 0, (int)num);
////        Console.WriteLine("下载上传num=" + num);
////        fs.Close();
////    }
////    static void Main(string[] args)
////    {
////        saveWord();

////        downLoadWord();
////    }

////}



//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Data;
//using System.Data.SqlClient;
//using System.Configuration;
////using System.Windows.Forms;
//namespace YourPad
//{
//    public class SqlClass
//    {
//        #region 构造函数
//        public SqlClass()
//        {

//        }
//        #endregion

//        #region 配置数据库连接字符串
//        public static string ConnectionString = ConfigurationSettings.AppSettings["Data Source=PC-20160909MFDB;Initial Catalog=NoteBook1;User ID=sa;Password=123456"];
//        #endregion

//        #region  执行SQL语句，返回Bool值

//        public bool ExecuteSQL(string sql)
//        {
//            SqlConnection con = new SqlConnection(SqlClass.ConnectionString);
//            SqlCommand cmd = new SqlCommand(sql, con);
//            try
//            {
//                con.Open();
//                cmd.ExecuteNonQuery();
//                return true;
//            }
//            catch
//            {
//                return false;
//            }
//            finally
//            {
//                con.Close();
//                con.Dispose();
//                cmd.Dispose();
//            }
//        }
//        #endregion

//        #region 执行SQL语句，返回SqlDataReader
//        /// <summary>
//        /// 执行SQL语句，返回SqlDataReader
//        /// </summary>
//        /// <param name="sql">要执行的SQL语句</param>
//        /// <returns>返回SqlDataReader，需手工关闭连接</returns>
//        public SqlDataReader GetReader(string sql)
//        {
//            SqlConnection con = new SqlConnection(SqlClass.ConnectionString);
//            SqlCommand cmd = new SqlCommand(sql, con);
//            SqlDataReader dr = null;
//            try
//            {
//                con.Open();
//                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
//            }
//            catch (Exception ex)
//            {
//                dr.Close();
//                con.Dispose();
//                cmd.Dispose();
//                throw new Exception(ex.ToString());
//            }
//            return dr;
//        }
//        #endregion

//        #region  执行SQL语句，返回DataSet
//        /// <summary>
//        /// 执行SQL语句，返回DataSet
//        /// </summary>
//        /// <param name="sql">要执行的SQL语句</param>
//        /// <param name="tablename">DataSet中要填充的表名</param>
//        /// <returns>返回dataSet类型的执行结果</returns>
//        public DataSet GetDataSet(string sql, string tablename)
//        {
//            DataSet ds = new DataSet();
//            SqlConnection con = new SqlConnection(SqlClass.ConnectionString);
//            SqlDataAdapter da = new SqlDataAdapter(sql, con);
//            try
//            {
//                da.Fill(ds, tablename);
//            }
//            catch (Exception ex)
//            {
//                throw new Exception(ex.ToString());
//            }
//            finally
//            {
//                con.Close();
//                con.Dispose();
//                da.Dispose();
//            }
//            return ds;
//        }
//        #endregion
