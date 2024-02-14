using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
    class Db
    {
        MySqlConnection con=new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=corona");
        public void OpenConnection()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }


        }

        public void CloseConnection()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }


        }

        public MySqlConnection GetConnection()
        {
            return con;
              

        }
    }
}
