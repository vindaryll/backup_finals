using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace scratch_finals_18
{
    class Dbconnect
    {
        private MySqlConnection con = new MySqlConnection("server=127.0.0.1; user=root; database=db_g12 ; password=");
        public MySqlConnection GetCon() {
            return con;
        }
        public void OpenCon()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        public void CloseCon()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

    }
}
