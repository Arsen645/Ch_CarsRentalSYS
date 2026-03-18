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

        private void LoadCarClasses() //https://stackoverflow.com/questions
        {
            try
            {
                OracleConnection conn = Database.OpenConnection();

                string query = "SELECT ClassID, ClassName FROM CarClass";

                OracleDataAdapter da = new OracleDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbCarClass.DataSource = dt;
                cmbCarClass.DisplayMember = "ClassName"; // shown to user
                cmbCarClass.ValueMember = "ClassID";     // actual ID
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading car classes: " + ex.Message);
            }
        }

        private void addCar_Load(object sender, EventArgs e)
        {
            LoadCarClasses();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtYear.Text.Length != 4 || !int.TryParse(txtYear.Text, out _))
            {
                MessageBox.Show("Please enter a valid 4-digit year.");
                return;
            }
            if(!int.TryParse(txtPlateNo.Text, out _) || txtPlateNo.Text.Length < 1 || txtPlateNo.Text.Length > 8 || 
                txtPlateReg.Text.Length > 2 || txtPlateYear.Text.Length != 2 )
            {
                MessageBox.Show("Please enter a valid plate number.");
                return;
            }
            String plateNo = txtPlateYear.Text + "-" + txtPlateReg.Text + "-" + txtPlateNo.Text;
            try { 
                OracleConnection conn = Database.OpenConnection();
            
                string query = "INSERT INTO Cars (PlateNo, Brand, Model, YearOfManufacture, Status, CarClassID) " +
                               "VALUES (:PlateNo, :Brand, :Model, :Year, :Status, :CarClassID)";

                OracleCommand cmd = new OracleCommand(query, conn);

                cmd.Parameters.Add(":PlateNo", plateNo);
                cmd.Parameters.Add(":Brand", txtBrand.Text);
                cmd.Parameters.Add(":Model", txtModel.Text);
                cmd.Parameters.Add(":Year", int.Parse(txtYear.Text));
                cmd.Parameters.Add(":Status", "A");
                cmd.Parameters.Add(":CarClassID", Convert.ToInt32(cmbCarClass.SelectedValue));

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

