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

namespace CarsRentalSYS
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            try
            {
                //OracleConnection conn = Database.OpenConnection();

                //string query = "INSERT INTO Customers (CUSTOMERID, CUSTOMERNAME, " +
                //    "EMAIL, PHONE, PASSWORD) " +
                //               "VALUES (:CUSTOMERID, :CUSTOMERNAME, :EMAIL, :PHONE, :PASSWORD)";

                //OracleCommand cmd = new OracleCommand(query, conn);

                //cmd.Parameters.Add(":PlateNo", txtPlateNumber.Text);
                //cmd.Parameters.Add(":Brand", cboBrand.SelectedValue);
                //cmd.Parameters.Add(":Model", cboModel.SelectedValue);
                //cmd.Parameters.Add(":Year", int.Parse(txtYear.Text));

                //cmd.Parameters.Add(":Status", 'A');
                //cmd.Parameters.Add(":CarClassID", Convert.ToInt32(cmbCarClass.SelectedValue));
                //cmd.Parameters.Add(":Price", int.Parse(txtPrice.Text));

                //cmd.ExecuteNonQuery();

                //MessageBox.Show("Car saved successfully");

                //txtYear.Clear();
                //txtPlateNumber.Clear();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error one: " + ex.Message);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                //OracleConnection conn = Database.OpenConnection();

                //string query = "INSERT INTO Customers (CUSTOMERID, CUSTOMERNAME, " +
                //    "EMAIL, PHONE, PASSWORD) " +
                //               "VALUES (:CUSTOMERID, :CUSTOMERNAME, :EMAIL, :PHONE, :PASSWORD)";

                //OracleCommand cmd = new OracleCommand(query, conn);

                //cmd.Parameters.Add(":PlateNo", txtPlateNumber.Text);
                //cmd.Parameters.Add(":Brand", cboBrand.SelectedValue);
                //cmd.Parameters.Add(":Model", cboModel.SelectedValue);
                //cmd.Parameters.Add(":Year", int.Parse(txtYear.Text));

                //cmd.Parameters.Add(":Status", 'A');
                //cmd.Parameters.Add(":CarClassID", Convert.ToInt32(cmbCarClass.SelectedValue));
                //cmd.Parameters.Add(":Price", int.Parse(txtPrice.Text));

                //cmd.ExecuteNonQuery();

                //MessageBox.Show("Car saved successfully");

                //txtYear.Clear();
                //txtPlateNumber.Clear();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error one: " + ex.Message);
            }
        }
    }
}
