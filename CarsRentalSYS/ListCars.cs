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
    public partial class ListCars : Form
    {
        public ListCars()
        {
            InitializeComponent();
        }
        private void ListCars_Load(object sender, EventArgs e)
        {
            grdCars.MultiSelect = true;
            grdCars.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdCars.DataSource = Cars.GetAllProducts().Tables[0];
            grdCars.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            grdCars.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            grdCars.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            this.Close();
        }
        private void grdCars_CellClick(object sender, DataGridViewCellEventArgs e) { 
            //object carPlate = grdCars.Rows[grdCars.CurrentCell.RowIndex].Cells[0].Value;
            List<string> selectedCarPlates = new List<string>();

            foreach (DataGridViewRow row in grdCars.SelectedRows)
            {
                if (row.Cells[0].Value != null)
                {
                    selectedCarPlates.Add(row.Cells[0].Value.ToString());
                }
            }

            if (selectedCarPlates.Count == 0)
            {
                MessageBox.Show("Please select at least one car.");
                return;
            }

            // Process rental
            MessageBox.Show("Renting cars:\n" + string.Join(", ", selectedCarPlates));
        }
}
}

