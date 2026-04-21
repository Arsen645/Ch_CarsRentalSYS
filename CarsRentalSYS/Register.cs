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

namespace CarsRentalSYS
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        int customerId = 0;

        private void Register_Load(object sender, EventArgs e)
        {
            
            try
                
            {
                OracleConnection conn = Database.OpenConnection();

                string query = "SELECT MAX(customerid) as custid from customers";

                OracleCommand cmd = new OracleCommand(query, conn);

                customerId = Convert.ToInt32(cmd.ExecuteScalar()) + 1;

                cmd.ExecuteNonQuery();



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error one: " + ex.Message);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
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

                string query = "INSERT INTO Customers (CUSTOMERID, CUSTOMERNAME, " +
                    "EMAIL, PHONE, PASSWORD) " +
                               "VALUES (:CUSTOMERID, :CUSTOMERNAME, :EMAIL, :PHONE, :PASSWORD)";

                OracleCommand cmd = new OracleCommand(query, conn);

                cmd.Parameters.Add(":CUSTOMERID", customerId);
                cmd.Parameters.Add(":CUSTOMERNAME", txtName.Text);
                cmd.Parameters.Add(":EMAIL", txtEmail.Text);
                cmd.Parameters.Add(":PHONE", txtPhone.Text);
                cmd.Parameters.Add(":PASSWORD", txtPassword.Text);


                cmd.ExecuteNonQuery();

                MessageBox.Show("Registered successfully");

                txtName.Clear();
                txtEmail.Clear();
                txtPhone.Clear();
                txtPassword.Clear();

                Global.Email = txtEmail.Text.Trim();
                Global.CustomerId = GetCustomerIdByEmail(txtEmail.Text.Trim());

                Form1 menu = new Form1();
                menu.Show();
                this.Close();


            }
            catch (OracleException ex)
            {
                if (ex.Number == 1) // ORA-00001
                {
                    MessageBox.Show("This Email already registered.");
                    txtEmail.Focus();
                }
                else
                {
                    MessageBox.Show("Oracle error: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error one: " + ex.Message);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            logIn menu = new logIn();
            menu.Show();
            this.Close();
        }

        private int GetCustomerIdByEmail(string email)
        {
            try
            {
                OracleConnection conn = Database.OpenConnection();
                string query = "SELECT customerid FROM customers WHERE email = :EMAIL";
                OracleCommand cmd = new OracleCommand(query, conn);
                cmd.Parameters.Add(":EMAIL", email);
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    return Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving customer ID: " + ex.Message);
            }
            return 0; // Return 0 or an appropriate default value if not found
        }
    }
}
