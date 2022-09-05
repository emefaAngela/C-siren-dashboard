using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Siren
{
    public partial class ManagePeriods : Form
    {
        DBconnection dBconnection = new DBconnection();
        MySqlConnection connection = new MySqlConnection();
        public ManagePeriods()
        {
            InitializeComponent();
            loaddata();
        }

        private void Home_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            Home home = new Home();
            home.Show();
        }
        public void loaddata()
        {
            connection = new MySqlConnection(dBconnection.conn);
            connection.Open();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "Select * from Periods";
            MySqlDataAdapter da = new MySqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Periods_dataGridView.DataSource = dt;
        }

        private void Periods_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
