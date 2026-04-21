using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CarsRentalSYS
{
    internal class Customer
    {
        public int CUSTOMERID { get; set; }

        public string CUSTOMERNAME { get; set; }
        public string EMAIL { get; set; }
        public string PHONE { get; set; }
        public string PASSWORD { get; set; }

        public Customer()
        {

        }

        public Customer(int CUSTOMERID, string CUSTOMERNAME, string EMAIL, string PHONE, string PASSWORD)
        {
            this.CUSTOMERID = CUSTOMERID;
            this.CUSTOMERNAME = CUSTOMERNAME;
            this.EMAIL = EMAIL;
            this.PHONE = PHONE;
            this.PASSWORD = PASSWORD;
        }

        public static int GetNextCustomerID()
        {
            //Define the SQL query to be executed - only one value returned here
            string sqlQuery = "SELECT MAX(CUSTOMERID) FROM CUSTOMERS";

            //Execute the query and return the result as an integer
            return Convert.ToInt32(Database.ExecuteSingleRowQuery(sqlQuery)[0]) + 1;
        }

        public void AddCustomer()

        {

            string sqlQuery = "INSERT INTO CUSTOMERS VALUES (" +
         "CUSTOMERID" + ",'" +
    "CUSTOMERNAME" + "','" +
    "EMAIL" + "'," +
    "PASSWORD" + ",'" +
    "PHONE" + ")";

            Database.ExecuteNonQuery(sqlQuery);


        }

        public static DataSet GetAllProducts()

        {

            //Define the SQL query to be executed

            string sqlQuery = "SELECT CUSTOMERID, " +
            "CUSTOMERNAME, " +
            "EMAIL, " +
            "PHONE, " +
            "PASSWORD " +
                "FROM CUSTOMERS " +
                "ORDER BY CUSTOMERID";


            //Execute the SQL query

            return Database.ExecuteMultiRowQuery(sqlQuery);
        }

    }
}
