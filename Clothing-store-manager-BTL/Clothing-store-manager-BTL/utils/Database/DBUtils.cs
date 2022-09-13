using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clothing_store_manager_BTL.utils.Database
{
    internal class DBUtils
    {
        public static SqlConnection GetDBConnection()
        {
            string datasource = @"ADMIN\SQLEXPRESS";
            string database = "registration";
            string username = "";
            string password = "";
            return DBSQLServerUtils.GetDBConnection(datasource, database, username, password);
        }
    }
}
