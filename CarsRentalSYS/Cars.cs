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

            return "Product ID: " + Id + "\tName: " + Name + "\tDescription: " +

            Description + "\tManufacturer: " + Manufacturer + "\nQuantity: " + Quantity + "\tPrice: " + Price + "\tTypecode: " + TypeCode;

        }





        //return all the required Product data via a DataSet

        public static DataSet GetAllProducts()

        {
          
            OracleConnection conn = Database.OpenConnection();

            string query = @"
    SELECT 
        cars.plateno        AS PLATENO,
    cars.carclassid     AS CARCLASSID,
    cars.brandid        AS BRANDID,
    cars.modelid        AS MODELID,
    carclass.classname  AS CLASSNAME,
    carbrands.brandname AS BRANDNAME,
    carmodels.modelname AS MODELNAME
    FROM cars
    JOIN carclass ON cars.carclassid = carclass.classid
    JOIN carbrands ON cars.brandid = carbrands.brandid
    JOIN carmodels ON cars.modelid = carmodels.modelid";

            OracleDataAdapter da = new OracleDataAdapter(query, conn);

            DataSet ds = new DataSet();
            da.Fill(ds);

            return ds;
        
    }
    }
}
