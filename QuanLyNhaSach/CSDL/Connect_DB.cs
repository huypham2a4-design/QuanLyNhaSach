using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QuanLyNhaSach.CSDL
{
    public class Connect_DB
    {
        SqlConnection conn;
        public Connect_DB()
        {
            conn = new SqlConnection("Data Source=DESKTOP-2M0HBI8;Initial Catalog=QUANLY_NHASACH;Integrated Security=True;Encrypt=False");
            
        }

        public SqlConnection get_connect()
        {
            return conn;
        }

        public void open_connect()
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
        }

        public void close_connect()
        {
            if (conn.State.ToString() == "Open")
            {
                conn.Close();
            }
        }
    }
}
