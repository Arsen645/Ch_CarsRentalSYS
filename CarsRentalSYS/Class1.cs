using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CarsRentalSYS
{
    internal class CarType
    {
        public int CarTypeID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double MonthlyRate { get; set; }

        public CarType() { 
        
        }

        public CarType(int carTypeID, string name, string description, int monthlyRate)
        {
            CarTypeID = carTypeID;
            Name = name;
            Description = description;
            MonthlyRate = monthlyRate;
        }

            public static int GetNextCarTypeID()
            {
                //Define the SQL query to be executed - only one value returned here
                string sqlQuery = "SELECT MAX(CLASSID) FROM CarClass";
    
                //Execute the query and return the result as an integer
                return Convert.ToInt32(Database.ExecuteSingleRowQuery(sqlQuery)[0]) + 1;
        }

        public void AddCarType()

        {

            string sqlQuery = "INSERT INTO Products VALUES (" +
         CarTypeID + ",'" +
    Name + "','" +
    Description + "'," +
    MonthlyRate + ")";

            Database.ExecuteNonQuery(sqlQuery);


        }
    }
}
