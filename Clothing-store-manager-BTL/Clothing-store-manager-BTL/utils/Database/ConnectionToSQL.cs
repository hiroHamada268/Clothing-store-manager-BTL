using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Clothing_store_manager_BTL.Class
{
    
    public class ConnectionToSQL
    {
        SqlConnection Connection;
        SqlCommand Command;
        SqlDataAdapter DataAdapter;

        public void Connecting(string LinkSql)
        {
            Connection = new SqlConnection();
            Connection.ConnectionString = LinkSql;
        }
        public DataSet LoadDuLieu(string sql)
        {
            DataSet dataSet = new DataSet();
            DataAdapter = new SqlDataAdapter(sql, Connection);
            DataAdapter.Fill(dataSet);
            return dataSet;
        }
    }
}
