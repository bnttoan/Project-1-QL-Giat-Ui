using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HeThongGiatUi
{
    class Ketnoi
    {
        public static SqlConnection GetConnect(string datasource, string database, string username, string password)
        {
            String strConnect = @"Data Source= " + datasource +
                "; Initial Catalog= " + database +
                "; Persist Security Info = True; User ID= " + username +
                "; Password= " + password;
            SqlConnection connect = new SqlConnection(strConnect);
            connect.Open();
            return connect;
        }
        public static SqlConnection GetConnect(string datasource, string database)
        {
            String strConnect = @"Data Source= " + datasource +
            "; Initial Catalog= " + database + "; Integrated Security = SSPI";
            SqlConnection connect = new SqlConnection(strConnect);
            connect.Open();
            return connect;
        }
        public static SqlConnection GetConnect()
        {
            string datasource = @"ADMIN-PC\SQLEXPRESS";
            string database = "HeThongGiatUi";
            string username = "sa";
            string password = "123";
            return GetConnect(datasource, database);
        }
    }
}
