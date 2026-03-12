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
        int monthlyRate; 
        int carclassId;
            CarType carType;
        public setCarType()
        {
            InitializeComponent();
        }

        private void FormAddProductLoad(object sender, EventArgs e)

        {

            //Get the next Product ID

            //Create car class

            carclassId = CarType.GetNextCarTypeID();//.ToString("0000");


            //Load TypeCodes into ComboBox



        }

        //public static int GetNextProdID()

        //{


        //    //Define the SQL query to be executed - only one value returned here

        //    string sqlQuery = "SELECT MAX(CLASSID) FROM CarClass";


        //    //Execute the SQL query

        //    OracleDataReader dr = Database.ExecuteSingleRowQuery(sqlQuery);


        //    //Does data reader contain a value or is it null?

        //    int nextId;


        //    dr.Read();


        //    if (dr.IsDBNull(0)) //the data reader is empty so no rows have yet been added to the table

        //        nextId = 1;

        //    else

        //        nextId = dr.GetInt32(0) + 1;


        //    //close the OracleDataReader and the DB connection

        //    dr.Close();


        //    return nextId;

        //}

        

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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

            int monthlyRate;

            if (!int.TryParse(txtMonthlyRate.Text, out monthlyRate))
            {
                MessageBox.Show("Monthly rate must contain only numbers");
                txtMonthlyRate.Focus();
                return;
            }

            CarType aCarType = new CarType(carclassId, txtClassName.Text, txtClassDescription.Text, Convert.ToInt32(txtMonthlyRate.Text));
                //,
    //txtClassName.Text,
    //txtClassDescription.Text,
    //Convert.ToDecimal(txtMonthlyRate.Text),

            aCarType.AddCarType();

            MessageBox.Show("Car type saved successfully");

            txtClassName.Clear();
            txtClassDescription.Clear();
            txtMonthlyRate.Clear();
        }

       

        private void txtClassName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtClassDescription_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void _TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtMonthlyRate_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
