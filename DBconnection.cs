using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace Siren
{
    class DBconnection
    {
        public  string conn = "Datasource = 127.0.0.1;  username=root;password=;database=siren_db;Allow User Variables=True";
        MySqlConnection connection = new MySqlConnection();
        MySqlCommand command = new MySqlCommand();
        public bool check_connection(string conn)

        {

            bool result = false;

            MySqlConnection connection = new MySqlConnection(conn);

            try

            {

                connection.Open();

                result = true;

                connection.Close();

            }

            catch

            {

                result = false;

            }

            return result;

        }
    }
}
