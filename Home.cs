using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Siren
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        // method to get current time
        private void timer()
        {
            DateTime now = DateTime.Now;
            now.ToString("yyyy-MM-dd HH:mm:ss"); //Outputs 2014-04-08 12:50:35
            Currenttime.Text = now.ToString("HH:mm:ss");
            //System.Threading.Thread.Sleep(1000);

            //timer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            CreatePeriod createPeriod = new CreatePeriod();
            createPeriod.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            ManagePeriods managePeriods = new ManagePeriods();
            managePeriods.Show();
        }

        private void Currenttime_TextChanged(object sender, EventArgs e)
        {
            //DateTime now = DateTime.Now;
            //now.ToString("yyyy-MM-dd HH:mm:ss"); //Outputs 2014-04-08 12:50:35
            //Currenttime.Text= now.ToString("HH:mm:ss");

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }



        private void Home_Load(object sender, EventArgs e)
        {
            //DateTime now = DateTime.Now;
            //now.ToString("yyyy-MM-dd HH:mm:ss"); //Outputs 2014-04-08 12:50:35
           // Currenttime.Text = now.ToString("HH:mm:ss");

            // do recursion
            timer();

        }
    }
}
