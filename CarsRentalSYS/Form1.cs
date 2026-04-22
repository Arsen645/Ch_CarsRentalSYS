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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int customerId = Global.CustomerId;
        DateTime startDate;
        DateTime finishDate;
        int rentalId = 1;
        string plateNo = "";
        int days;
        int pricePerDay;
        int totalPrice;
        private void form1_Load(object sender, EventArgs e)
        {

            
        }

        private void carClassesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void setCarTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            setCarType f1 = new setCarType();
            f1.Show();
            this.Hide();
        }

        private void removeCarTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveCarType f1 = new RemoveCarType();
            f1.Show();
            this.Hide();
        }

        private void changeCarTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeCarType f1 = new changeCarType();
            f1.Show();
            this.Hide();
        }

        private void addACarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addCar f1 = new addCar();
            f1.Show();
            this.Hide();
        }

        private void removeACarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            removeCar f1 = new removeCar();
            f1.Show();
            this.Hide();
        }

        

        private void cancelAReservationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cancelReservation f1 = new cancelReservation();
            f1.Show();
            this.Hide();
        }

        

        

        private void yearlyRToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void carDamageAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            generatyAnalysis f1 = new generatyAnalysis();
            f1.Show();
            this.Hide();
        }

        

       

        private void listCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listCustomers f1 = new listCustomers();
            f1.Show();
            this.Hide();
        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
            startDate = dtFromDate.Value;
            finishDate = dtToDate.Value;
            if (!(startDate <= finishDate))
            {
                MessageBox.Show("Finish date must be after start date");
                return;
            }
            try { 
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
                         AND NOT EXISTS (
                            SELECT *
                            FROM rentals
                            WHERE rentals.CarPlateNo = cars.PlateNo
                            AND rentals.StartDate <= :finishDate
                            AND rentals.FinishDate >= :startDate
                         )";

            OracleCommand cmd = new OracleCommand(query, conn);

                cmd.BindByName = true;
                string searchTerm = txtMainSearch.Text.ToUpper();
                cmd.Parameters.Add(":search", "%" + searchTerm + "%");
            cmd.Parameters.Add(":startDate", startDate);
            cmd.Parameters.Add(":finishDate", finishDate);
                
                OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                grvSearchResult.DataSource = dt;
                grvSearchResult.Columns["MODELID"].Visible = false;
                grvSearchResult.Columns["brandID"].Visible = false;
                if (!grvSearchResult.Columns.Contains("btnAdd"))
                {
                    DataGridViewButtonColumn btnAdd = new DataGridViewButtonColumn();
                    btnAdd.HeaderText = "Add";
                    btnAdd.Text = "Add";
                    btnAdd.UseColumnTextForButtonValue = true;
                    btnAdd.Name = "btnAdd";
                    grvSearchResult.Columns.Add(btnAdd);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching cars: " + ex.Message);
            }
        }

        private void updateACarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateCar f1 = new updateCar();
            f1.Show();
            this.Hide();
        }

        private void grvSearchResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = grvSearchResult.Rows[e.RowIndex];

            if (row.Cells[0].Value != null)
            {



                if (grvSearchResult.Columns[e.ColumnIndex].Name == "btnAdd")
                {
                    plateNo = row.Cells["PLATENO"].Value.ToString();
                    pricePerDay = Convert.ToInt32(row.Cells["PRICEPERDAY"].Value);
                    days = (finishDate.Date - startDate.Date).Days + 1;
                    totalPrice = days * pricePerDay;

                    var confirmResult = MessageBox.Show(
            $"Car: {plateNo}\n" +
            $"Days: {days}\n" +
            $"Price per day: €{pricePerDay}\n" +
            $"Total price: €{totalPrice}\n\n" +
            "Confirm rental?",
            "Confirm Rental",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

                    if (confirmResult == DialogResult.Yes)
                    {
                        add(plateNo);
                    }
                    else
                    {
                        return;
                    }

                }
                ////////////
            }
        
     
        
        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logIn f1 = new logIn();
            f1.Show();
            this.Hide();
        }

        private void add(string plateNo)
        {
            try
            {
                using (OracleConnection conn = Database.OpenConnection())
                {
                    string query = @" INSERT INTO Rentals 
                             (CUSTOMERID, STARTDATE, FINISHDATE, CARPLATENO, RENTID)
                             VALUES (:custId, :startDate, :finishDate, :plateNo, rental_seq.NEXTVAL)";
                    OracleCommand cmd = new OracleCommand(query, conn);
                    //cmd.Parameters.Add(":rentid", rental_seq.NEXTVAL);
                    cmd.BindByName = true;
                    cmd.Parameters.Add(":custId", customerId);
                    cmd.Parameters.Add(":startDate", startDate);
                    cmd.Parameters.Add(":finishDate", finishDate);
                    cmd.Parameters.Add(":plateNo", plateNo);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Rental created successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
