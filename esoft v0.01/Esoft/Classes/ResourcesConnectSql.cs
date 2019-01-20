using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Esoft
{
    class ResourcesConnectSql
    {
        public static SqlConnection GetSringsSql()
        {
            string datasource = @"DESKTOP-SN90PRJ\SQLEXPRESS";
            string database = "Praktika";
            return ResourcesConnectSql.GiveConnectSql(datasource, database);
        }

        public static SqlConnection GiveConnectSql(string datasource, string database)
        {
            string strCon = @"Data Source=" + datasource + ";Initial Catalog=" + database + ";Integrated Security=True";
            SqlConnection sqlCon = new SqlConnection(strCon);
            return sqlCon;
        }

    }
}
