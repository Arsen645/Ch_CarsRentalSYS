using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace CarsRentalSYS
{
    public partial class setCarType : Form
    {
        String name;
        String description;
        double monthlyRate; 
        int carclassId;
        CarType carType;
        public setCarType()
        {
            InitializeComponent();
                generateCarClassId();
        }

        private void generateCarClassId()
        {
            try
            {
                OracleConnection conn = Database.OpenConnection();
                string query = "SELECT MAX(ClassID) FROM CarClass";
                OracleCommand cmd = new OracleCommand(query, conn);
                object result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    carclassId = Convert.ToInt32(result) + 1;
                }
                else
                {
                    carclassId = 1; // Start from 1 if no records exist
                }
                txtCarClassId.Text = carclassId.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating Car Class ID: " + ex.Message);
            }
        }







        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 menu=new Form1();
            menu.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtClassName.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Class name must not contain numbers");
                txtClassName.Focus();
                return;
            }

            if (txtClassDescription.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Class description must not contain numbers");
                txtClassDescription.Focus();
                return;
            }


            if (!double.TryParse(txtMonthlyRate.Text, out monthlyRate))
            {
                MessageBox.Show("Monthly rate must contain only numbers");
                txtMonthlyRate.Focus();
                return;
            }
            carclassId = int.Parse(txtCarClassId.Text);
             name = txtClassName.Text;
             description = txtClassDescription.Text;
             monthlyRate = double.Parse(txtMonthlyRate.Text);
             //carType = new CarType(carclassId, name, description, monthlyRate);

            //CarType aCarType = new CarType(carclassId, txtClassName.Text, txtClassDescription.Text, Convert.ToInt32(txtMonthlyRate.Text));
            try
            {
                OracleConnection conn = Database.OpenConnection();

                string query = "INSERT INTO carclass (CLASSID, CLASSNAME, DESCRIPTION, MONTHLYRATE) " +
                               "VALUES (:carclassId, :name, :description, :monthlyRate)";

                OracleCommand cmd = new OracleCommand(query, conn);

                cmd.Parameters.Add(":carclassId", carclassId);
                cmd.Parameters.Add(":name", name);
                cmd.Parameters.Add(":description", description);
                cmd.Parameters.Add(":monthlyRate", monthlyRate);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Car class saved successfully");
                //txtCarClassId.Clear();
                txtClassName.Clear();
                txtClassDescription.Clear();
                txtMonthlyRate.Clear();
                generateCarClassId(); // Generate a new Car Class ID for the next entry


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error one: " + ex.Message);
            }


            //aCarType.AddCarType();

            //MessageBox.Show("Car type saved successfully");

            //txtClassName.Clear();
            //txtClassDescription.Clear();
            //txtMonthlyRate.Clear();
        }

       

        

        private void txtCarClassId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
