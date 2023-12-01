using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace backbone
{
    class DbConnect
    {
        private MySqlConnection con = new MySqlConnection("server=127.0.0.1; user=root; database=db_g12 ; password=");

        public MySqlConnection Getcon() 
        { 
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
