using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Policy
{
    public class DBHelper
    {           
        static string connectionString = "data source = 113.106.88.209;initial catalog = air_man; user id = sa;password =410211;";  //连接字符串            

       private static SqlConnection connection;
        /// <summary>
        /// 初始化Connection对象
        /// </summary>

        public static SqlConnection Connection
        {
            get
            {
                if (connection == null)
                {
                    connection = new SqlConnection(connectionString);
                }
                return connection;
            }
        }

        /// <summary>
        /// 打开数据库连接
        /// </summary>
        public static void OpenConnection()
        {
            if (Connection.State == ConnectionState.Closed)
            {
                Connection.Open();
            }
            else if (Connection.State == ConnectionState.Broken)
            {
                Connection.Close();
                Connection.Open();
            }
        }

        /// <summary>
        /// 关闭数据库连接
        /// </summary>
        public static void CloseConnection()
        {
            if (Connection.State == ConnectionState.Open || Connection.State == ConnectionState.Broken)
            {
                Connection.Close();
            }
        }

        /// <summary>
        /// 根据sql语句，返回受影响的行数
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string sql)
        {
            SqlConnection connection = new SqlConnection(connectionString); //连接对象
            int result;        //返回结果
            try
            {
                connection.Open();    //打开数据库
                //命令对象
                SqlCommand cmd = new SqlCommand(sql, connection);

                //执行命令，返回结果
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                return -1;
            }
            finally
            {
                //关闭数据库
                connection.Close();
            }
            return result;
        }

        /// <summary>
        /// 获取读取器对象
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static SqlDataReader ExecuteReader(string sql)
        {
            SqlDataReader sdr;  //创建读取器对象
            //连接对象
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                //打开数据库
                connection.Open();
                //执行命令
                SqlCommand cmd = new SqlCommand(sql, connection);
                //获取读取器对象
                sdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                return null;
            }

            return sdr;
        }

        /// <summary>
        /// 根据sql语句获取数据表
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static DataTable GetTable(string sql)
        {
            //数据集
            DataTable dt = new DataTable();
            try
            {
                //连接对象
                SqlConnection connection = new SqlConnection(connectionString);

                //适配器对象
                SqlDataAdapter sda = new SqlDataAdapter(sql, connection);

                //填充数据集
                sda.Fill(dt);

            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                return null;
            }
            return dt;
        }

        /// <summary>
        /// 获得首行首列的值
        /// </summary>
        /// <returns></returns>
        public static object ExecuteScalar(string sql)
        {
            //连接对象
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                SqlCommand com = new SqlCommand(sql, connection);
                //int result = (int)com.ExecuteScalar();
                return com.ExecuteScalar();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                return -1;
            }
            finally 
            {
                connection.Close();
            }        
        }
    }
}
