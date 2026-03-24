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
    }
}
