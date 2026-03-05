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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void carClassesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void setCarTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            setCarType f1 = new setCarType();
            f1.Show();
            this.Hide();
        }

        private void removeCarTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveCarType f1 = new RemoveCarType();
            f1.Show();
            this.Hide();
        }

        private void changeCarTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeCarType f1 = new changeCarType();
            f1.Show();
            this.Hide();
        }

        private void addACarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addCar f1 = new addCar();
            f1.Show();
            this.Hide();
        }

        private void removeACarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            removeCar f1 = new removeCar();
            f1.Show();
            this.Hide();
        }

        private void makeAReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            makeReservation f1 = new makeReservation();
            f1.Show();
            this.Hide();
        }

        private void cancelAReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeReservation f1 = new changeReservation();
            f1.Show();
            this.Hide();
        }

        private void cancelAReservationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cancelReservation f1 = new cancelReservation();
            f1.Show();
            this.Hide();
        }

        private void registerACustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            registerCustomer f1 = new registerCustomer();
            f1.Show();
            this.Hide();
        }

        private void updateCustomerInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateCustomer f1 = new updateCustomer();
            f1.Show();
            this.Hide();
        }

        private void yearlyRToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void carDamageAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            generatyAnalysis f1 = new generatyAnalysis();
            f1.Show();
            this.Hide();
        }

        private void showCustomersRateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showCustomerRates f1 = new showCustomerRates();
            f1.Show();
            this.Hide();
        }

        private void repairCostAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            generateInvoice f1 = new generateInvoice();
            f1.Show();
            this.Hide();
        }

        private void listCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listCustomers f1 = new listCustomers();
            f1.Show();
            this.Hide();
        }
    }
}
