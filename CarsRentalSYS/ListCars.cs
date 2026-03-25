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
        private void grdStock_CellClick(object sender, DataGridViewCellEventArgs e) { 
            object carPlate = grdCars.Rows[grdCars.CurrentCell.RowIndex].Cells[0].Value;
            MessageBox.Show("You have selected car with plate number: " + carPlate);
        }
    }
}
