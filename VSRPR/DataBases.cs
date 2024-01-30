using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace VSRPR
{
    internal class DataBases 
    {
        SqlConnection conn = new SqlConnection("Data Source=KAB511COMP11\\SQLEXPRESS;Initial Catalog=VSR;Integrated Security=True;TrustServerCertificate=True");

        public void OpenConnection()
        {
            if(conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public void CloseConnection()
        {
            if(conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }

        public SqlConnection GetConnection()
        {
            return conn;
        }

    }
}
