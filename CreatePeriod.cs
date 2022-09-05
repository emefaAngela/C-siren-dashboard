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
            this.Hide();
            Home home = new Home();
            home.Show();

        }

        private void saveperiod_btn_Click(object sender, EventArgs e)
        {
            String p_name = input_periodName.Text;
            String p_time = input_periodTime.Text;
            DateTime date = DateTime.Today;
           
            //date.ToString().ToString();

            if (p_name != "" && p_time != "")
            {
                DBconnection dBconnection = new DBconnection();
                //connection.Open();
                connection = new MySqlConnection(dBconnection.conn);
                connection.Open();
                command = new MySqlCommand("Insert into periods (period_name,period_time,date_of_creation) values(?p_name,?p_time,?date)", connection);

                command.Parameters.AddWithValue("?p_name", p_name);
                command.Parameters.AddWithValue("?p_time", p_time);
                command.Parameters.AddWithValue("?date", "date");


                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("A new Period has been created successfully");




            }
            else
            {
                //    DBconnection dBconnection = new DBconnection();
                //    bool source_result = dBconnection.check_connection("Datasource = 127.0.0.1;  username=root;password=;database=siren_db;Allow User Variables=True");

                //    if (source_result == false)

                //    {

                //        MessageBox.Show("Error in source connection");

                //        //}

                //}
                MessageBox.Show("Empty Fields");
            }
        }
    }
}
