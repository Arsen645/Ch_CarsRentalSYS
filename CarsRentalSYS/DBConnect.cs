using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CarsRentalSYS
{
    //OracleConnection conn = new OracleConnection(Database.connectionString);
    class Database
    {
        public const string connectionString = "Data Source = oracle/orcl; User Id = T00271040; Password = dgukC#439jxy;"; //remainder of class code here }


        public static OracleConnection OpenConnection()
        {
            //Open an Oracle DB connection
            OracleConnection conn = new OracleConnection(Database.connectionString);

            conn.Open();

            return conn;
        }



        public static DataSet ExecuteMultiRowQuery(string query)
        {
            //Open a connection to an Oracle database
            OracleConnection conn = OpenConnection();

            //Formulate the DB request
            OracleCommand cmd = new OracleCommand(query, conn);

            //Use an OracleDataAdapter as a bridge between the DB and an in-memory
            //data structure (a DataSet in this case)
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Create the DataSet to hold results of the query
            DataSet ds = new DataSet();

            //Populate the DataSet with the results of the query
            //Note that Fill() will use the OracleCommand object to execute query
            da.Fill(ds);

            //Close DB connection
            conn.Close();

            return ds;
        }

        public static OracleDataReader ExecuteSingleRowQuery(string query)
        {
            //Open a connection to an Oracle database
            OracleConnection conn = OpenConnection();

            //Formulate the DB request
            OracleCommand cmd = new OracleCommand(query, conn);

            //Execute the query and atore the results in an OracleDataReader
            OracleDataReader dr = cmd.ExecuteReader();

            return dr;

        }


        public static void ExecuteNonQuery(string query)
        {
            //Open a connection to an Oracle database
            OracleConnection conn = OpenConnection();

            //Formulate the DB request
            OracleCommand cmd = new OracleCommand(query, conn);

            //Execute the DB non-query
            cmd.ExecuteNonQuery();

            //Close the DB connection
            conn.Close();

        }
    }
}