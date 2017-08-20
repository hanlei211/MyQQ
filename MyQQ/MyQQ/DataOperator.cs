using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MyQQ
{
    class DataOperator
    {
        //数据库连接字符串
        private static string connString = @"Data Source =DESKTOP-O2JC9JC ; Database =db_MyQQ ; User ID =sa; Pwd = Rjyx@123";
        //数据库连接对象
        public static SqlConnection connection = new SqlConnection(connString);

        public int ExecSQL(string sql) {
            SqlCommand commend = new SqlCommand(sql,connection);
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            int num = Convert.ToInt32(commend.ExecuteScalar());
            connection.Close();
            return num;
        }

        public int ExecSQLResult(string  sql)
        {
            SqlCommand commend = new SqlCommand(sql, connection);
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            int result = commend.ExecuteNonQuery();
            connection.Close();
            return result;
            
        }

        public DataSet GetDataSet(string sql)
        {
            SqlDataAdapter sqlda = new SqlDataAdapter(sql,connection);
            DataSet ds = new DataSet();
            sqlda.Fill(ds);
            return ds;
        }
    }
}
