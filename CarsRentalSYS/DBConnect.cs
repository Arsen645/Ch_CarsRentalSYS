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


        public static OracleDataReader ExecuteSingleRowQuery(string sql)
        {
            OracleConnection conn = new OracleConnection(connectionString);
            OracleCommand cmd = new OracleCommand(sql, conn);

            conn.Open();
            OracleDataReader dr = cmd.ExecuteReader();

            return dr;
        }

        public static void ExecuteNonQuery(string sql)
        {
            OracleConnection conn = new OracleConnection(connectionString);
            OracleCommand cmd = new OracleCommand(sql, conn);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static OracleDataReader ExecuteMultiRowQuery(string sql)
        {
            OracleConnection conn = new OracleConnection(connectionString);
            OracleCommand cmd = new OracleCommand(sql, conn);

            conn.Open();
            OracleDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            // CommandBehavior.CloseConnection ensures the connection closes when the reader is closed
            return dr;
        }
    }
}