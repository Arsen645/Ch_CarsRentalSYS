using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CarsRentalSYS
{
    internal class reservations
    {
        

        public int CUSTOMERID { get; set; }

        public DateTime STARTDATE { get; set; }

        public DateTime FINISHDATE { get; set; }

        public string CARPLATENO { get; set; }

        public int RENTID { get; set; }

        public reservations() : this(0, DateTime.Now, DateTime.Now, "", 0)
        {
        }


        public reservations(int customerId, DateTime startDate, DateTime finishDate, string carPlateNo, int rentId)
        {
            this.CUSTOMERID = customerId;
            this.STARTDATE = startDate;
            this.FINISHDATE = finishDate;
            this.CARPLATENO = carPlateNo;
            this.RENTID = rentId;
        }

        public static DataSet GetAllReservations()

        {

            string sqlQuery = @"SELECT 
            r.RentID AS RentID,
            r.CustomerID AS CustomerID,
            r.StartDate AS StartDate,
            r.FinishDate AS FinishDate,
            c.Plateno AS PlateNo,
            br.BrandName AS Brand,
            m.ModelName AS Model,
            c.PricePerDay AS PricePerDay
        FROM Rentals r
        JOIN Cars c ON r.CarPlateNo = c.Plateno
        JOIN CarBrands br ON c.BrandID = br.BrandID
        JOIN CarModels m ON c.ModelID = m.ModelID
        ORDER BY r.RentID";



            return Database.ExecuteMultiRowQuery(sqlQuery);
        }
    }
}
