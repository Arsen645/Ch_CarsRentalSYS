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
    public partial class listCustomers : Form
    {
        public listCustomers()
        {
            InitializeComponent();
        }

        public void listCustomers_Load(object sender, EventArgs e)
        {
            grdCustomers.DataSource = Customer.GetAllProducts().Tables[0];
            grdCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //grdCarsTable.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //grdCarsTable.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            grdCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
            btnEdit.HeaderText = "Edit";
            btnEdit.Text = "Change";
            btnEdit.UseColumnTextForButtonValue = true;
            btnEdit.Name = "btnEdit";
            grdCustomers.Columns.Add(btnEdit);


            // DELETE button
            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            btnDelete.HeaderText = "Delete";
            btnDelete.Text = "Delete";
            btnDelete.UseColumnTextForButtonValue = true;
            btnDelete.Name = "btnDelete";
            grdCustomers.Columns.Add(btnDelete);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adminHome menu = new adminHome();
            menu.Show();
            this.Close();
        }

        private void grdCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = grdCustomers.Rows[e.RowIndex];

            if (row.Cells[0].Value != null)
            {
                if (grdCustomers.Columns[e.ColumnIndex].Name == "btnEdit")
                {
                    int id = Convert.ToInt32(row.Cells["CUSTOMERID"].Value);
                    string name = row.Cells["CUSTOMERNAME"].Value.ToString();
                    string email = row.Cells["EMAIL"].Value.ToString();
                    string phone = row.Cells["PHONE"].Value.ToString();
                    string password = row.Cells["PASSWORD"].Value.ToString();

                    updateCustomer form = new updateCustomer(id,name,email,phone,password);
                    form.Show();
                    this.Close();
                }
                else if (grdCustomers.Columns[e.ColumnIndex].Name == "btnDelete")
                {


                    var confirmResult = MessageBox.Show("Confirm remove", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirmResult == DialogResult.Yes)
                    {
                        delete();
                    }
                    else
                    {
                        return;
                    }

                }
            }
        }
        private void delete()
        {
            try
            {
                OracleConnection conn = Database.OpenConnection();

                string query = $"DELETE FROM Customers WHERE Customerid = :Customerid";

                OracleCommand cmd = new OracleCommand(query, conn);

                cmd.Parameters.Add(":Customerid", grdCustomers.Rows[grdCustomers.CurrentCell.RowIndex].Cells["CUSTOMERID"].Value);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Customer Removed");

            }
            catch (OracleException ex)
            {

                MessageBox.Show("Cannot delete this record because related records exist. (Rentals table)");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error one: " + ex.Message);
            }
            grdCustomers.DataSource = Customer.GetAllProducts().Tables[0];
        }
    }
}
