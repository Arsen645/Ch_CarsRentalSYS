using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Formats.Asn1;
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

        public int BRANDID { get; set; }

        public int MODELID { get; set; }

        public int YEAROFMANUFACTURE { get; set; }

        public char STATUS { get; set; }

        public int CARCLASSID { get; set; }





        //No-argument constructor (using the multi-argument constructor via this reference)

        public Cars() : this("", 1, 1, 0, 'A', 0) { }


        //The multi-argument constructor

        public Cars(string PLATENO, int BRANDID, int MODELID, int YEAROFMANUFACTURE, char STATUS, int CARCLASSID)

        {

            this.PLATENO = PLATENO;

            this.BRANDID = BRANDID;

            this.MODELID = MODELID;

            this.YEAROFMANUFACTURE = YEAROFMANUFACTURE;

            this.STATUS = STATUS;

            this.CARCLASSID = CARCLASSID;



        }



        //ToString() to display the state of a Product object

        public override string ToString()
        {
            return "PLATENO: " + PLATENO + "\n" +
            "BRAND: " + BRANDID + "\n" +
            "MODEL: " + MODELID + "\n" +
            "YEAROFMANUFACTURE: " + YEAROFMANUFACTURE + "\n" +
            "STATUS: " + STATUS + "\n" +
            "CARCLASSID: " + CARCLASSID;
        }





        //return all the required Product data via a DataSet

        public static DataSet GetAllProducts()

        {

            //Define the SQL query to be executed

            string sqlQuery = "SELECT cars.Plateno AS Plateno, " +
            "br.BrandName AS Brand, " +
            "model.ModelName AS Model, " +
            "cars.YearOfManufacture AS YearOfManufacture, " +
            "cars.Status AS Status, " +
            "cc.ClassName AS CarClass " +
                " FROM Cars cars " +
                "JOIN CarBrands br " +
                "ON cars.BrandID = br.BrandID " +
                "JOIN CarModels model ON cars.ModelID = model.ModelID " +
                "JOIN CarClass cc ON cars.CarClassID = cc.ClassID " +
                "ORDER BY br.BrandName";


            //Execute the SQL query

            return Database.ExecuteMultiRowQuery(sqlQuery);
        }
    }
}