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
    public partial class RemoveCarType : Form
    {
        public RemoveCarType()
        {
            InitializeComponent();
        }

        private void RemoveCarType_Load(object sender, EventArgs e)
        {
            try
            {
                OracleConnection conn = Database.OpenConnection();

                string query = "SELECT * FROM carclass";
                OracleDataAdapter da = new OracleDataAdapter(query, conn);

                DataTable dt = new DataTable();
                da.Fill(dt);

                cboClassId.DataSource = dt;

                cboClassId.DisplayMember = "CLASSNAME";
                cboClassId.ValueMember = "CLASSID";
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

        private void button1_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Confirm remove","Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    OracleConnection conn = Database.OpenConnection();
                    string query = "DELETE FROM carclass WHERE CLASSID = :classId";
                    OracleCommand cmd = new OracleCommand(query, conn);
                    cmd.Parameters.Add(new OracleParameter("classId", cboClassId.SelectedValue));
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                MessageBox.Show("Car Class Removed");
            } else
            {
                return;
            }
        }

        private void cboClassId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
