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
    public partial class removeCar : Form
    {
        public removeCar()
        {
            InitializeComponent();
        }
        
        private void removeCar_Load(object sender, EventArgs e)
        {

            grdCarsTable.DataSource = Cars.GetAllProducts().Tables[0];
            grdCarsTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            grdCarsTable.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            grdCarsTable.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            grdCarsTable.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Confirm remove", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                MessageBox.Show("Car Removed");
            }
            else
            {
                return;
            }
        }
        private void grdCarsTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            foreach (DataGridViewRow row in grdCarsTable.SelectedRows)
            {
                if (row.Cells[0].Value != null)
                {
                    var confirmResult = MessageBox.Show("Confirm remove", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirmResult == DialogResult.Yes)
                    {
                        try
                        {
                            OracleConnection conn = Database.OpenConnection();

                            string query = "DELETE FROM Cars WHERE PlateNo = :PlateNo";

                            OracleCommand cmd = new OracleCommand(query, conn);

                            cmd.Parameters.Add(":PlateNo", grdCarsTable.Rows[grdCarsTable.CurrentCell.RowIndex].Cells[0].Value);

                            cmd.ExecuteNonQuery();


                            //12-d-7654

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error one: " + ex.Message);
                        }
                        grdCarsTable.DataSource = Cars.GetAllProducts().Tables[0];
                        MessageBox.Show("Car Removed");
                    }
                    else
                    {
                        return;
                    }
                    
                }
            }
                
            }
        
        private void grdCarsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
