using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;


namespace CarsRentalSYS
{
    public partial class addCar : Form
    {
        public addCar()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
                OracleConnection conn = Database.OpenConnection();
            
                string query = "INSERT INTO Cars (PlateNo, Brand, Model, YearOfManufacture, Status, CarClassID) " +
                               "VALUES (:PlateNo, :Brand, :Model, :Year, :Status, :CarClassID)";

                OracleCommand cmd = new OracleCommand(query, conn);

                cmd.Parameters.Add(":PlateNo", txtPlateNo.Text);
                cmd.Parameters.Add(":Brand", txtBrand.Text);
                cmd.Parameters.Add(":Model", txtModel.Text);
                cmd.Parameters.Add(":Year", int.Parse(txtYear.Text));
                cmd.Parameters.Add(":Status", txtStatus.Text);
                cmd.Parameters.Add(":CarClassID", int.Parse(txtClass.Text));

                    cmd.ExecuteNonQuery();
                
                    MessageBox.Show("Car saved successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error one: " + ex.Message);
                }
            }
            
        }

        
    }

