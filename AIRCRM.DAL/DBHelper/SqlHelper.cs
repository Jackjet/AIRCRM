using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Xml;

namespace AIRCRM.DAL.DBHelper
{
    /// <summary>
    /// 
    /// </summary>
    public class SqlHelper
    {
        private static string _sqlConnectionString = ConfigurationManager.AppSettings["ConStr"];
        private static SqlConnection _sqlConnection;
        private static SqlCommand _sqlCommand;
        private static SqlCommandBuilder _sqlCommandBuilder;
        private static SqlDataAdapter _sqlDataAdapter;
        private static SqlDataReader _sqlDataReader;
        private static XmlReader _xmlReader = null;
        private static DataSet _dataSet;
        private static object objExecuteScalar = null;
        private static bool IsConnected = false;
        /// <summary>
        /// SQL Helper
        /// </summary>
        public static void Open()
        {
            if (!string.IsNullOrEmpty(SqlConnectionString))
            {
                _sqlConnection = new SqlConnection(SqlConnectionString);
                if (_sqlConnection.State == ConnectionState.Closed)
                {
                    _sqlConnection.Open();
                    IsConnected = true;
                }
            }

        }
        /// <summary>
        /// SQL Helper
        /// </summary>
        /// <param name="connectionString"></param>
        public static void Open(string connectionString)
        {
            if (!string.IsNullOrEmpty(connectionString))
            {
                _sqlConnection = new SqlConnection(connectionString);
                if (_sqlConnection.State == ConnectionState.Closed)
                {
                    _sqlConnection.Open();
                    IsConnected = true;
                }
            }

        }
        /// <summary>
        /// SQL连接字符串
        /// </summary>
        public static string SqlConnectionString
        {
            get { return _sqlConnectionString; }
            set { _sqlConnectionString = value; }
        }
        /// <summary>
        /// 对连接执行 Transact-SQL 语句并返回受影响的行数。
        /// </summary>
        /// <param name="sqlcmdtext"></param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string sqlcmdtext)
        {
            int i = 0;
            try
            {
                if (IsConnected)
                {
                    _sqlCommand = new SqlCommand(sqlcmdtext, _sqlConnection);
                    i = _sqlCommand.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                //throw new Exception(e.Message);
                Console.Write(e.Message);
                return 0;
            }
            return i;
        }
        /// <summary>
        /// 对连接执行 Transact-SQL 语句并返回受影响的行数。
        /// </summary>
        /// <param name="sqlcmdtext"></param>
        /// <param name="connection"></param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string sqlcmdtext, SqlConnection connection)
        {
            int i = 0;
            try
            {
                if (IsConnected)
                {
                    _sqlCommand = new SqlCommand(sqlcmdtext, connection);
                    i = _sqlCommand.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return i;
        }
        /// <summary>
        /// 将 CommandText 发送到 Connection 并生成一个 SqlDataReader。 
        /// </summary>
        /// <param name="sqlcmdtext"></param>
        /// <returns></returns>
        public static SqlDataReader ExecuteReader(string sqlcmdtext)
        {
            try
            {
                if (IsConnected)
                {
                    _sqlCommand = new SqlCommand(sqlcmdtext, _sqlConnection);
                    _sqlDataReader = _sqlCommand.ExecuteReader();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return _sqlDataReader;
        }
        /// <summary>
        /// 将 CommandText 发送到 Connection 并生成一个 SqlDataReader。 
        /// </summary>
        /// <param name="sqlcmdtext"></param>
        /// <param name="connection"></param>
        /// <returns></returns>
        public static SqlDataReader ExecuteReader(string sqlcmdtext, SqlConnection connection)
        {
            try
            {
                if (IsConnected)
                {
                    _sqlCommand = new SqlCommand(sqlcmdtext, connection);
                    _sqlDataReader = _sqlCommand.ExecuteReader();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return _sqlDataReader;
        }
        /// <summary>
        /// 将 CommandText 发送到 Connection，并使用 CommandBehavior 值之一生成一个 SqlDataReader。  
        /// </summary>
        /// <param name="sqlcmdtext"></param>
        /// <returns></returns>
        public static SqlDataReader ExecuteReader(string sqlcmdtext, CommandBehavior behavior)
        {
            try
            {
                if (IsConnected)
                {
                    _sqlCommand = new SqlCommand(sqlcmdtext, _sqlConnection);
                    _sqlDataReader = _sqlCommand.ExecuteReader(behavior);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return _sqlDataReader;
        }
        /// <summary>
        /// 将 CommandText 发送到 Connection，并使用 CommandBehavior 值之一生成一个 SqlDataReader。 
        /// </summary>
        /// <param name="sqlcmdtext"></param>
        /// <param name="connection"></param>
        /// <returns></returns>
        public static SqlDataReader ExecuteReader(string sqlcmdtext, SqlConnection connection, CommandBehavior behavior)
        {
            try
            {
                if (IsConnected)
                {
                    _sqlCommand = new SqlCommand(sqlcmdtext, connection);
                    _sqlDataReader = _sqlCommand.ExecuteReader(behavior);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return _sqlDataReader;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="commandType"></param>
        /// <param name="sqlcmdtext"></param>
        /// <param name="connection"></param>
        /// <returns></returns>
        public static SqlDataReader ExecuteReader(CommandType commandType, string sqlcmdtext, SqlConnection connection)
        {
            try
            {
                if (IsConnected)
                {
                    _sqlCommand = new SqlCommand(sqlcmdtext, connection);
                    _sqlCommand.CommandType = commandType;
                    _sqlDataReader = _sqlCommand.ExecuteReader();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return _sqlDataReader;
        }
        /// <summary>
        /// 执行查询，并返回查询所返回的结果集中第一行的第一列。  忽略其他列或行。
        /// </summary>
        /// <param name="sqlcmdtext"></param>
        /// <returns></returns>
        public static object ExecuteScalar(string sqlcmdtext)
        {
            try
            {
                if (IsConnected)
                {
                    _sqlCommand = new SqlCommand(sqlcmdtext, _sqlConnection);
                    objExecuteScalar = _sqlCommand.ExecuteScalar();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return objExecuteScalar ?? 0;
        }
        /// <summary>
        /// 执行查询，并返回查询所返回的结果集中第一行的第一列。  忽略其他列或行。
        /// </summary>
        /// <param name="sqlcmdtext"></param>
        /// <param name="connection"></param>
        /// <returns></returns>
        public static object ExecuteScalar(string sqlcmdtext, SqlConnection connection)
        {
            try
            {
                if (IsConnected)
                {
                    _sqlCommand = new SqlCommand(sqlcmdtext, connection);
                    objExecuteScalar = _sqlCommand.ExecuteScalar();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return objExecuteScalar;
        }
        /// <summary>
        /// 将 CommandText 发送到 Connection 并生成一个 XmlReader 对象。 
        /// </summary>
        /// <param name="sqlcmdtext"></param>
        /// <returns></returns>
        public static XmlReader ExecuteXmlReader(string sqlcmdtext)
        {
            try
            {
                if (IsConnected)
                {
                    _sqlCommand = new SqlCommand(sqlcmdtext, _sqlConnection);
                    _xmlReader = _sqlCommand.ExecuteXmlReader();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return _xmlReader;
        }
        /// <summary>
        /// 将 CommandText 发送到 Connection 并生成一个 XmlReader 对象。 
        /// </summary>
        /// <param name="sqlcmdtext"></param>
        /// <param name="connection"></param>
        /// <returns></returns>
        public static XmlReader ExecuteXmlReader(string sqlcmdtext, SqlConnection connection)
        {
            try
            {
                if (IsConnected)
                {
                    _sqlCommand = new SqlCommand(sqlcmdtext, connection);
                    _xmlReader = _sqlCommand.ExecuteXmlReader();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return _xmlReader;
        }
    }
}
