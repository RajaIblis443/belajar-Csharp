using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Latih2_DB_CONNECT
{
    class Koneksi
    {
        

        public SqlConnection getConn()
        {
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = " Data Source = DESKTOP-B4NO5FL;  initial catalog=DB_Latihan; integrated security=true";
                return conn;
            }
        }
    }

}
