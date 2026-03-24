using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CarsRentalSYS
{
    internal class Cars
    {







        public string PLATENO { get; set; }

        public string BRAND { get; set; }

        public string MODEL { get; set; }

        public int YEAROFMANUFACTURE { get; set; }

        public char STATUS { get; set; }

        public int CARCLASSID { get; set; }





        //No-argument constructor (using the multi-argument constructor via this reference)

        public Cars() : this("", "", "", 0, 'A', 0) { }


        //The multi-argument constructor

        public Cars(string PLATENO, string BRAND, string MODEL, int YEAROFMANUFACTURE, char STATUS, int CARCLASSID)

        {

            this.PLATENO = PLATENO;

            this.BRAND = BRAND;

            this.MODEL = MODEL;

            this.YEAROFMANUFACTURE = YEAROFMANUFACTURE;

            this.STATUS = STATUS;

            this.CARCLASSID = CARCLASSID;



        }



        //ToString() to display the state of a Product object

        public override string ToString()
        {
            return "PLATENO: " + PLATENO + "\n" +
            "BRAND: " + BRAND + "\n" +
            "MODEL: " + MODEL + "\n" +
            "YEAROFMANUFACTURE: " + YEAROFMANUFACTURE + "\n" +
            "STATUS: " + STATUS + "\n" +
            "CARCLASSID: " + CARCLASSID;
        }





        //return all the required Product data via a DataSet

        public static DataSet GetAllProducts()

        {

            //Define the SQL query to be executed

            string sqlQuery = "SELECT * " +

            "FROM cars ORDER BY brand";


            //Execute the SQL query

            return Database.ExecuteMultiRowQuery(sqlQuery);
        }
    }
}