using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CarsRentalSYS
{
    public partial class updateCustomer : Form
    {
        int id;
        string name;
        string email;
        string phone;
        string password;
        public updateCustomer(int id, string name, string email, string phone, string password)
        {
            InitializeComponent();
            this.id = id;
            this.email = email;
            this.name = name;
            this.phone = phone;
            this.password = password;
        }

        private void updateCustomer_Load(object sender, EventArgs e)
        {
            txtName.Text = name;
            txtEmail.Text = email;
            txtPhone.Text = phone;
            txtPassword.Text = password;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adminHome menu = new adminHome();
            menu.Show();
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e) { 
            if (string.IsNullOrWhiteSpace(txtName.Text) || txtName.Text.Length > 25)
            {
                MessageBox.Show("Invalid Name");
                return;
            }
            if (!Regex.IsMatch(txtEmail.Text.Trim(), @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Email is not valid");
                return;
            }
            if (!txtPhone.Text.All(c => char.IsDigit(c) || c == '+' || c == '-' || c == ' ') || (txtPhone.Text.Length < 10))
            {
                MessageBox.Show("Phone is not valid");
                return;
            }
            if (txtPassword.Text.Trim().Length < 4)
            {
                MessageBox.Show("Password must be at least 4 symbols long ");
                txtPassword.Focus();
                return;
            }
            try
            {
                OracleConnection conn = Database.OpenConnection();

                string query = "Update Customers SET CUSTOMERNAME = :cCUSTOMERNAME, " +
                    "EMAIL = :cEMAIL, PHONE = :cPHONE, PASSWORD = :cPASSWORD " +
                    $"Where CUSTOMERID = {id}";

                OracleCommand cmd = new OracleCommand(query, conn);

                //cmd.Parameters.Add(":cCUSTOMERID", Convert.ToInt32(id));
                cmd.Parameters.Add(":cCUSTOMERNAME", txtName.Text);
                cmd.Parameters.Add(":cEMAIL", txtEmail.Text);
                cmd.Parameters.Add(":cPHONE", txtPhone.Text);
                cmd.Parameters.Add(":cPASSWORD", txtPassword.Text);

                cmd.ExecuteNonQuery();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                    MessageBox.Show("Updated successfully");
                else
                    MessageBox.Show("No record found to update.");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating customer: " + ex.Message);
            }
        }
    }
}
