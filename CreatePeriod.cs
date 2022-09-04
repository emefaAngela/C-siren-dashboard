using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Siren
{
    public partial class CreatePeriod : Form
    {
        DBconnection dBconnection = new DBconnection();
        MySqlConnection connection = new MySqlConnection();
        MySqlCommand command = new MySqlCommand();
        public CreatePeriod()
        {
            InitializeComponent();
        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void saveperiod_btn_Click(object sender, EventArgs e)
        {
            String period_name = input_periodName.Text;
            String period_time = input_periodTime.Text;

            if(period_name!="" && period_time != "")
            {
                DBconnection dBconnection = new DBconnection();
                connection.Open();
                connection = new MySqlConnection(dBconnection.conn);
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "Insert into periods (period_name,period_time) values(?period_name,?period_time)";
                command.Parameters.AddWithValue(@period_name, "period_name");
                command.Parameters.AddWithValue(@period_time, "period_time");
                command.ExecuteNonQuery();
                connection.Close();




            }
            else
            {
                DBconnection dBconnection = new DBconnection();
                bool source_result = dBconnection.check_connection("Datasource = 127.0.0.1;  username=root;password=;database=siren_db;Allow User Variables=True");

                if (source_result == false)

                {

                    MessageBox.Show("Error in source connection");

                }
            }
        }
    }
}
