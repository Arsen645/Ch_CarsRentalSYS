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

                string query = "SELECT password FROM customers WHERE email = :EMAIL";

                OracleCommand cmd = new OracleCommand(query, conn);

                cmd.Parameters.Add(":EMAIL", txtEmail.Text.Trim());


                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    string password = result.ToString();
                    if (password == txtPassword.Text.Trim())
                    {
                        MessageBox.Show("Login successful");
                        Form1 menu = new Form1();
                        menu.Show();
                        this.Close();
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
    }
}
