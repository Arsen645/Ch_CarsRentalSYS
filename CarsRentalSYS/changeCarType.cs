using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CarsRentalSYS
{
    public partial class changeCarType : Form
    {
        public changeCarType()
        {
            InitializeComponent();
        }

        //try {
        //    OracleConnection conn = Database.OpenConnection();
        //cmbCarClass.DisplayMember = "ClassName";
        //cmbCarClass.ValueMember = "ClassId";
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error: " + ex.Message);
        //    }
        String name;
        String description;
        int carclassId;

        private void changeCarType_Load(object sender, EventArgs e)
        {

            try
            {
                OracleConnection conn = Database.OpenConnection();
                
                string query = "SELECT * FROM carclass";
                OracleDataAdapter da = new OracleDataAdapter(query, conn);

                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbCarClass.DataSource = dt;
                
                cmbCarClass.DisplayMember = "CLASSNAME";
                cmbCarClass.ValueMember = "CLASSID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load Error: " + ex.Message);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adminHome menu = new adminHome();
            menu.Show();
            this.Close();
        }

        private void removeCarTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            

            if (txtDescription.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Class description must not contain numbers");
                txtDescription.Focus();
                return;
            }


            
            carclassId = carclassId = Convert.ToInt32(cmbCarClass.SelectedValue);
            description = txtDescription.Text;
            //carType = new CarType(carclassId, name, description, monthlyRate);

            //CarType aCarType = new CarType(carclassId, txtClassName.Text, txtClassDescription.Text, Convert.ToInt32(txtMonthlyRate.Text));
            try
            {
                OracleConnection conn = Database.OpenConnection();

                string query = "UPDATE carclass SET CLASSNAME = :name, DESCRIPTION = :description " +
                                "WHERE CLASSID = :carclassId";

                OracleCommand cmd = new OracleCommand(query, conn);

                cmd.BindByName = true;

                cmd.Parameters.Add(":name", OracleDbType.Varchar2)
              .Value = cmbCarClass.Text;
                cmd.Parameters.Add(":description",description);
                cmd.Parameters.Add(":carclassId", carclassId);
                //conn.Open();
                cmd.ExecuteNonQuery();
                //int rows = cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Car class updated successfully");
                txtDescription.Clear();
                changeCarType_Load(sender, e); // Refresh the combo box to show updated data
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void cmbCarClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCarClass.SelectedItem is DataRowView row)
            {
                txtCarClassId.Text = row["CLASSID"].ToString();
                txtDescription.Text = row["DESCRIPTION"].ToString();
            }
        }

        private void txtCarClassId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtClassName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
