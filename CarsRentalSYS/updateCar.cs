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
    public partial class updateCar : Form
    {



        private string plateNo;
        private int classId;
        private int brandId;
        private int modelId;
        private int price;




        public updateCar(string plateNo)
        {
            InitializeComponent();
            this.plateNo = plateNo;
        }
        public updateCar()
        {
            InitializeComponent();
        }

        public void updateCar_Load(object sender, EventArgs e)
        {
            
            try
            {
                
                OracleConnection conn = Database.OpenConnection();
                string query = "SELECT * FROM cars";

                OracleDataAdapter da = new OracleDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cboPlate.DataSource = dt;
                cboPlate.DisplayMember = "PLATENO";
                cboPlate.ValueMember = "PLATENO";

                // CLASS
                OracleDataAdapter daClass = new OracleDataAdapter("SELECT classid, classname FROM carclass", conn);
                DataTable dtClass = new DataTable();
                daClass.Fill(dtClass);
                cboClass.DataSource = dtClass;
                cboClass.DisplayMember = "CLASSNAME";
                cboClass.ValueMember = "CLASSID";

                // BRAND
                OracleDataAdapter daBrand = new OracleDataAdapter("SELECT brandid, brandname FROM carbrands", conn);
                DataTable dtBrand = new DataTable();
                daBrand.Fill(dtBrand);
                cboBrand.DataSource = dtBrand;
                cboBrand.DisplayMember = "BRANDNAME";
                cboBrand.ValueMember = "BRANDID";

                // MODEL
                OracleDataAdapter daModel = new OracleDataAdapter("SELECT modelid, modelname FROM carmodels", conn);
                DataTable dtModel = new DataTable();
                daModel.Fill(dtModel);
                cboModel.DataSource = dtModel;
                cboModel.DisplayMember = "MODELNAME";
                cboModel.ValueMember = "MODELID";

                cboPlate.SelectedValue = plateNo;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load Error: " + ex.Message);
            }

            
        }

        private void cboClass_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboBrand_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboModel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void cboPlate_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                OracleConnection conn = Database.OpenConnection();
                string query = "SELECT carclassid, brandid, modelid, " +
                    "YEAROFMANUFACTURE, PRICEPERDAY FROM cars WHERE plateno = :plate";

                OracleCommand cmd = new OracleCommand(query, conn);
                cmd.Parameters.Add(":plate", cboPlate.SelectedValue.ToString());

                OracleDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    cboClass.SelectedValue = reader["CARCLASSID"];
                    cboBrand.SelectedValue = reader["BRANDID"];
                    cboModel.SelectedValue = reader["MODELID"];
                    txtYear.Text = reader["YEAROFMANUFACTURE"].ToString();
                    txtPrice.Text = reader["PRICEPERDAY"].ToString();
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adminHome menu = new adminHome();
            menu.Show();
            this.Close();
        }

        private void btnUpdateCarInfo_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtYear.Text.Length != 4 || !int.TryParse(txtYear.Text, out _) || int.Parse(txtYear.Text) < 1900 || int.Parse(txtYear.Text) > DateTime.Now.Year)
                {
                    MessageBox.Show("Please enter a valid 4-digit year.");
                    return;
                }
                if (string.IsNullOrEmpty(txtPrice.Text) || !int.TryParse(txtPrice.Text, out _))
                {
                    MessageBox.Show("Please enter a valid price.");
                    return;
                }
                int year = txtYear.Text != "" ? int.Parse(txtYear.Text) : 0;
                price = txtPrice.Text != "" ? int.Parse(txtPrice.Text) : 0;
                OracleConnection conn = Database.OpenConnection();

                string query = "UPDATE cars SET YEAROFMANUFACTURE = :year, " +
                    "CARCLASSID = :class, BRANDID = :brand, MODELID = :model, PRICEPERDAY = :cprice " +
                                "WHERE PLATENO = :plate";

                OracleCommand cmd = new OracleCommand(query, conn);

                cmd.BindByName = true;

                cmd.Parameters.Add(":class", OracleDbType.Int32)
              .Value = cboClass.SelectedValue;

                cmd.Parameters.Add(":brand", OracleDbType.Int32).Value =
    cboBrand.SelectedValue;
                cmd.Parameters.Add(":model", OracleDbType.Int32)
              .Value = cboModel.SelectedValue;

                cmd.Parameters.Add(":plate", OracleDbType.Varchar2)
              .Value = cboPlate.Text;
                cmd.Parameters.Add(":year", year);
                cmd.Parameters.Add(":cprice", price);
                //conn.Open();
                cmd.ExecuteNonQuery();
                //int rows = cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Car class updated successfully");
                updateCar_Load(sender, e);
                // Refresh the combo box to show updated data
                return;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Some field(s) are not valid. Please check the input.");
            }
            MessageBox.Show("Nothing was updated.");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
