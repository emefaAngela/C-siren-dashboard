﻿using System;
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
        public string conn = "";
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
