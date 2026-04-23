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
    public partial class generatyAnalysis : Form
    {
        public generatyAnalysis()
        {
            InitializeComponent();
            cmbType.Items.Add("Rentals per month analysis");
            cmbType.Items.Add("Revenue per month analysis");
            cmbType.Items.Add("Car rental days per month analysis");
        }
        private void load_analysis(object sender, EventArgs e)
        {
            chtData.Visible = false;

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adminHome menu = new adminHome();
            menu.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            load_analysis(sender, e);
            string selected = cmbType.SelectedItem?.ToString();
            if (selected == "Rentals per month analysis")
            {

                FormRentalAnalysis_Load(sender, e);
            }
            else if (selected == "Revenue per month analysis")
            {
                FormRevenuelAnalysis_Load(sender, e);
            }
            else if (selected == "Car rental days per month analysis")
            {
                FormCarRentalAnalysis_Load(sender, e);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormRentalAnalysis_Load(object sender, EventArgs e)

        {
            try
            {
                string query = "SELECT TO_CHAR(StartDate, 'MM') AS Month, " +
                    "COUNT(*) AS TotalRentals " +
                    "FROM Rentals " +
                    "GROUP BY to_Char(StartDate,'MM') " +
                    "ORDER BY Month";


                DataSet ds = Database.ExecuteMultiRowQuery(query);


                //Initialise the arrays

                string[] months = { "JAN", "FEB", "MAR", "APR", "MAY", "JUN", "JUL", "AUG", "SEP", "OCT", "NOV", "DEC" };

                decimal[] amounts = new decimal[12]; //all set to zero



                //Next, save the amounts returned in query to the appropriate element in amounts[]

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)


                    amounts[Convert.ToInt32(ds.Tables[0].Rows[i][1]) - 1] =

                    Convert.ToDecimal(ds.Tables[0].Rows[i][0]);



                //decide if you want grid lines on the chart (none at present)

                chtData.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;

                chtData.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;


                chtData.Series[0].LegendText = "Number Of Rentals";


                //tie the arrays to the x and y axes of the chart

                chtData.Series[0].Points.DataBindXY(months, amounts);


                //the amounts will appear atop the bars in the chart


                chtData.Series[0].Label = "#VALY";


                chtData.Titles.Add("Rentals chart"); //Chart title

                chtData.ChartAreas[0].AxisX.Title = "Month"; //x-axis title

                chtData.ChartAreas[0].AxisY.Title = "Rentals"; //y-axis title


                chtData.Visible = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading rentals analysis: " + ex.Message);
            }
        }

        private void FormRevenuelAnalysis_Load(object sender, EventArgs e)

        {
            try
            {
                string query = "SELECT TO_CHAR(StartDate, 'MM') AS Month, " +
                    "SUM((rentals.FinishDate - rentals.StartDate + 1) * cars.PRICEPERDAY) AS revenue " +
                    "FROM Rentals JOIN Cars On rentals.CARPLATENO = cars.PLATENO " +
                    "GROUP BY to_Char(StartDate,'MM') " +
                    "ORDER BY Month";


                DataSet ds = Database.ExecuteMultiRowQuery(query);


                //Initialise the arrays

                string[] months = { "JAN", "FEB", "MAR", "APR", "MAY", "JUN", "JUL", "AUG", "SEP", "OCT", "NOV", "DEC" };

                decimal[] amounts = new decimal[12]; //all set to zero



                //Next, save the amounts returned in query to the appropriate element in amounts[]

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {

                    int monthIndex = Convert.ToInt32(ds.Tables[0].Rows[i][0]) - 1;
                    decimal revenue = Convert.ToDecimal(ds.Tables[0].Rows[i][1]);

                    amounts[monthIndex] = revenue;
                }


                //decide if you want grid lines on the chart (none at present)

                chtData.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;

                chtData.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;


                chtData.Series[0].LegendText = "Revenue";


                //tie the arrays to the x and y axes of the chart

                chtData.Series[0].Points.DataBindXY(months, amounts);


                //the amounts will appear atop the bars in the chart


                chtData.Series[0].Label = "#VALY";


                chtData.Titles.Add("Revenue chart"); //Chart title

                chtData.ChartAreas[0].AxisX.Title = "Month"; //x-axis title

                chtData.ChartAreas[0].AxisY.Title = "Revenue"; //y-axis title


                chtData.Visible = true;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading revenue analysis: " + ex.Message);
            }
        }

        private void FormCarRentalAnalysis_Load(object sender, EventArgs e)

        {
            try
            {
                string query = "SELECT CARPLATENO, " +
                    "SUM(FINISHDATE - STARTDATE) + 1 AS TotalDays " +
                    "FROM Rentals " +
                    "GROUP BY CARPLATENO ";


                DataSet ds = Database.ExecuteMultiRowQuery(query);


                //Initialise the arrays


                List<decimal> amounts = new List<decimal>();

                List<string> cars = new List<string>();



                //Next, save the amounts returned in query to the appropriate element in amounts[]

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {

                    cars.Add(ds.Tables[0].Rows[i][0].ToString());

                    amounts.Add(Convert.ToDecimal(ds.Tables[0].Rows[i][1]));
                }


                //decide if you want grid lines on the chart (none at present)

                chtData.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;

                chtData.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;


                chtData.Series[0].LegendText = "Total rental days per car";


                //tie the arrays to the x and y axes of the chart

                chtData.Series[0].Points.DataBindXY(cars, amounts);


                //the amounts will appear atop the bars in the chart


                chtData.Series[0].Label = "#VALY";


                chtData.Titles.Add("Rentals chart"); //Chart title

                chtData.ChartAreas[0].AxisX.Title = "Car"; //x-axis title

                chtData.ChartAreas[0].AxisY.Title = "Total days"; //y-axis title


                chtData.Visible = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading car rental days analysis: " + ex.Message);
            }
        }

        private void chtData_Click(object sender, EventArgs e)
        {

        }
    }
}