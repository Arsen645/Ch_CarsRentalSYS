using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsRentalSYS
{
    public partial class adminHome : Form
    {
        public adminHome()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAnalysis_Click(object sender, EventArgs e)
        {
            
            generatyAnalysis f1 = new generatyAnalysis();
            f1.Show();
            this.Hide();
        
    }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            listCustomers f1 = new listCustomers();
            f1.Show();
            this.Hide();
        }

        private void btnReservations_Click(object sender, EventArgs e)
        {
            cancelReservation f1 = new cancelReservation();
            f1.Show();
            this.Hide();
        }

        private void btnCarTable_Click(object sender, EventArgs e)
        {
            removeCar f1 = new removeCar();
            f1.Show();
            this.Hide();
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            addCar f1 = new addCar();
            f1.Show();
            this.Hide();
        }

        private void btnRemoveType_Click(object sender, EventArgs e)
        {
            RemoveCarType f1 = new RemoveCarType();
            f1.Show();
            this.Hide();
        }

        private void btnCangeType_Click(object sender, EventArgs e)
        {
            changeCarType f1 = new changeCarType();
            f1.Show();
            this.Hide();
        }

        private void btnSetType_Click(object sender, EventArgs e)
        {
            setCarType f1 = new setCarType();
            f1.Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
            try
            {
                OracleConnection conn = Database.OpenConnection();

                string query = @"SELECT cars.PlateNo, cars.BrandID, cars.ModelID, cars.YearOfManufacture, cars.PricePerDay,
                                carclass.ClassName, carclass.Description, carmodels.ModelName AS Model,
                                carbrands.brandName AS Brand
                         FROM cars
                         JOIN carclass ON cars.carClassID = carclass.ClassID
                         JOIN carmodels ON cars.ModelID = carmodels.ModelID
                         JOIN carbrands ON cars.brandID = carbrands.brandID
                         WHERE cars.Status != 'D'
                         AND (
                            UPPER(cars.PlateNo) LIKE :search OR
                            cars.BrandID LIKE :search OR
                            carmodels.Modelname LIKE :search OR
                            UPPER(carbrands.Brandname) LIKE :search OR
                            cars.YearOfManufacture LIKE :search OR
                            UPPER(carclass.Description) LIKE :search OR
                            UPPER(carclass.ClassName) LIKE :search
                         )
                         ";

                OracleCommand cmd = new OracleCommand(query, conn);

                cmd.BindByName = true;
                string searchTerm = txtMainSearch.Text.ToUpper();
                cmd.Parameters.Add(":search", "%" + searchTerm + "%");

                OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                grvSearchResult.DataSource = dt;
                grvSearchResult.Columns["MODELID"].Visible = false;
                grvSearchResult.Columns["brandID"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching cars: " + ex.Message);
            }
        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logIn f1 = new logIn();
            f1.Show();
            this.Hide(); 
        }
    }
}
