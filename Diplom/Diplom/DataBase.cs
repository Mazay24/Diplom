using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Diplom
{
    internal class DataBase
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=MAZAY24\MSSQLSERVER01;Initial Catalog=Diplom;Integrated Security=True;Encrypt=False");

        public void openConnectoin()
        {
            sqlConnection.Open();
        }
        
        public void closeConnectoin() { sqlConnection.Close();}

        public SqlConnection getConnection()
        {
            return sqlConnection;
        }
    }
}
