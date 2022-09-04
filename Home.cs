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
    }
}
