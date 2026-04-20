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
    public partial class addCar : Form
    {
        public addCar()
        {
            InitializeComponent();
        }
        String brandID;
        public bool IsValidIrishPlate(string plate)
        {
            string pattern = @"^\d{2}-[A-Z]{1,2}-\d{1,5}$";
            return Regex.IsMatch(plate.ToUpper(), pattern);
        }

        

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            this.Close();
        }

        private void LoadCarClasses() //https://stackoverflow.com/questions //show carclasses in combo box
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
            try
            {
                OracleConnection conn = Database.OpenConnection();

                string query = "SELECT * FROM carbrands";

                OracleDataAdapter da = new OracleDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cboBrand.DataSource = dt;
                cboBrand.DisplayMember = "brandname"; // shown to user
                cboBrand.ValueMember = "brandid";
                // actual ID
                loadCarModels();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading car brands: " + ex.Message);
            }
            


        }
        private void loadCarModels() {
            try
            {
                OracleConnection conn = Database.OpenConnection();
                if (cboBrand.SelectedValue == null || cboBrand.SelectedValue is DataRowView)
                    return;
                string query = "SELECT * FROM CARMODELS where brandid = :cbrandID";

                OracleDataAdapter da = new OracleDataAdapter(query, conn);
                da.SelectCommand.Parameters.Add(new OracleParameter(":cbrandID", Convert.ToInt32(cboBrand.SelectedValue)));
                DataTable dt = new DataTable();
                da.Fill(dt);
                //MessageBox.Show(cboBrand.SelectedValue.ToString());
                cboModel.DataSource = dt;
                cboModel.DisplayMember = "MODELNAME"; // shown to user
                cboModel.ValueMember = "MODELID";     // actual ID
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No models found in database.");
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading car model: " + ex.Message);
            }
        }
        private void cboBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadCarModels();


        }

        private void addCar_Load(object sender, EventArgs e)
        {
            LoadCarClasses();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!IsValidIrishPlate(txtPlateNumber.Text))
            {
                MessageBox.Show("Invalid Irish car plate format. Example: 23-KY-1234");
                return;
            }
            if (txtYear.Text.Length != 4 || !int.TryParse(txtYear.Text, out _) )
            {
                MessageBox.Show("Please enter a valid 4-digit year.");
                return;
            }
            
            try
            {
                OracleConnection conn = Database.OpenConnection();

                string query = "INSERT INTO Cars (PlateNo, Brandid, Modelid, YearOfManufacture, Status, CarClassID, PRICEPERDAY) " +
                               "VALUES (:PlateNo, :Brand, :Model, :Year, :Status, :CarClassID, :Price)";

                OracleCommand cmd = new OracleCommand(query, conn);
                
                cmd.Parameters.Add(":PlateNo", txtPlateNumber.Text);
                cmd.Parameters.Add(":Brand", cboBrand.SelectedValue);
                cmd.Parameters.Add(":Model", cboModel.SelectedValue);
                cmd.Parameters.Add(":Year", int.Parse(txtYear.Text));
                
                cmd.Parameters.Add(":Status", 'A');
                cmd.Parameters.Add(":CarClassID", Convert.ToInt32(cmbCarClass.SelectedValue));
                cmd.Parameters.Add(":Price", int.Parse(txtPrice.Text));

                cmd.ExecuteNonQuery();

                MessageBox.Show("Car saved successfully");
                
                txtYear.Clear();
                txtPlateNumber.Clear();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error one: " + ex.Message);
            }
        }

        


    }
}
