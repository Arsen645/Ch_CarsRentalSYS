using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CarsRentalSYS
{
    public partial class logIn : Form
    {
        public logIn()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register f1 = new Register();
            f1.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtEmail.Text) || !Regex.IsMatch(txtEmail.Text.Trim(), @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Email is not valid");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text) || txtPassword.Text.Trim().Length < 4)
            {
                MessageBox.Show("Password must be at least 4 symbols long!");
                txtPassword.Focus();
                return;
            }
            try
            {
                OracleConnection conn = Database.OpenConnection();

                string query = "SELECT customerid, password FROM customers WHERE email = :EMAIL";

                OracleCommand cmd = new OracleCommand(query, conn);

                cmd.Parameters.Add(":EMAIL", txtEmail.Text.Trim());

                OracleDataReader result = cmd.ExecuteReader();
                if (result.Read())
                {
                    string password = result["password"].ToString();
                    if (password == txtPassword.Text.Trim())
                    {

                        MessageBox.Show("Login successful");

                        Global.Email = txtEmail.Text.Trim();
                        Global.CustomerId = Convert.ToInt32(result["customerid"]);
                        Form1 main = new Form1();
                        main.Show();
                        this.Hide();
                        return;
                    }



                }

                MessageBox.Show("Invalid email or password");




            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }


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