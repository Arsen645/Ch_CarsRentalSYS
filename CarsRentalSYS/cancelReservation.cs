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
    public partial class cancelReservation : Form
    {
        public cancelReservation()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adminHome menu = new adminHome();
            menu.Show();
            this.Close();
        }

        private void cancelReservation_Load(object sender, EventArgs e)
        {
            grdReservations.DataSource = reservations.GetAllReservations().Tables[0];
            grdReservations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;    
            grdReservations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            if (!grdReservations.Columns.Contains("btnDelete"))
            {
                DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();    //https://stackoverflow.com/questions/
                btnDelete.HeaderText = "Delete";
                btnDelete.Text = "Delete";
                btnDelete.UseColumnTextForButtonValue = true;
                btnDelete.Name = "btnDelete";
                grdReservations.Columns.Add(btnDelete);

                //grdReservations.Columns.Add(btnDelete);
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Confirm remove", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                MessageBox.Show("Reservation Removed");
            }
            else
            {
                return;
            }
        }

        private void grdReservations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdReservations.Columns[e.ColumnIndex].Name == "btnDelete")
            {
                var confirmResult = MessageBox.Show("Confirm remove", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    deleteReservation();
                }
            }
        }

        

        private void deleteReservation()
        {
            try
            {
                OracleConnection conn = Database.OpenConnection();

                string query = "DELETE FROM RENTALS WHERE RENTID = :RENTID";

                OracleCommand cmd = new OracleCommand(query, conn);

                cmd.Parameters.Add(":RENTID", grdReservations.Rows[grdReservations.CurrentCell.RowIndex].Cells[0].Value);

                cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error one: " + ex.Message);
            }
            grdReservations.DataSource = reservations.GetAllReservations().Tables[0];
            MessageBox.Show("Reservation cancelled!");
        }
    }
}
