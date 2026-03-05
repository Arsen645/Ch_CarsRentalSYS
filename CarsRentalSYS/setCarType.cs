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
    public partial class setCarType : Form
    {
        String name;
        String description;
        int monthlyRate; 
        public setCarType()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 menu=new Form1();
            menu.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            name = txtClassName.Text;
            description = txtClassDescription.Text;
            monthlyRate = Convert.ToInt32(txtMonthlyRate.Text);

            if (txtClassName.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Class name must not contain numbers");
                txtClassName.Focus();
                return;
            }

            if (txtClassDescription.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Class description must not contain numbers");
                txtClassName.Focus();
                return;
            }

            if (!txtMonthlyRate.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Monthly rate must contain only numbers");
                txtClassName.Focus();
                return;

                
            }

            MessageBox.Show("Car type saved");
            txtClassName.Text = "";
            txtClassDescription.Text = "";
            txtMonthlyRate.Text = "";
        }

        private void txtClassName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtClassDescription_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void _TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtMonthlyRate_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
