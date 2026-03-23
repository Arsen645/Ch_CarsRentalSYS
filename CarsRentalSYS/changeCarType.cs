using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CarsRentalSYS
{
    public partial class changeCarType : Form
    {
        public changeCarType()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            this.Close();
        }

        private void removeCarTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtClassName.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Class name must not contain numbers");
                txtClassName.Focus();
                return;
            }

            if (txtClassDescription.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Class description must not contain numbers");
                txtClassDescription.Focus();
                return;
            }


            if (!double.TryParse(txtMonthlyRate.Text, out monthlyRate))
            {
                MessageBox.Show("Monthly rate must contain only numbers");
                txtMonthlyRate.Focus();
                return;
            }
            carclassId = int.Parse(txtCarClassId.Text);
            name = txtClassName.Text;
            description = txtClassDescription.Text;
            monthlyRate = double.Parse(txtMonthlyRate.Text);
            //carType = new CarType(carclassId, name, description, monthlyRate);

            //CarType aCarType = new CarType(carclassId, txtClassName.Text, txtClassDescription.Text, Convert.ToInt32(txtMonthlyRate.Text));
            try
            {
                OracleConnection conn = Database.OpenConnection();

                string query = "INSERT INTO carclass (CLASSID, CLASSNAME, DESCRIPTION, MONTHLYRATE) " +
                               "VALUES (:carclassId, :name, :description, :monthlyRate)";

                OracleCommand cmd = new OracleCommand(query, conn);

                cmd.Parameters.Add(":carclassId", carclassId);
                cmd.Parameters.Add(":name", name);
                cmd.Parameters.Add(":description", description);
                cmd.Parameters.Add(":monthlyRate", monthlyRate);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Car class saved successfully");
                //txtCarClassId.Clear();
                txtClassName.Clear();
                txtClassDescription.Clear();
                txtMonthlyRate.Clear();
                MessageBox.Show("Saved");
        }
    }
}
