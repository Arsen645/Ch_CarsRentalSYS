using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsRentalSYS
{
    public partial class listCustomers : Form
    {
        public listCustomers()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            this.Close();
        }
        private void showCustomersRateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showCustomerRates f1 = new showCustomerRates();
            f1.Show();
            this.Hide();
        }

        private void makeAReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            makeReservation f1 = new makeReservation();
            f1.Show();
            this.Hide();
        }



    }
}
