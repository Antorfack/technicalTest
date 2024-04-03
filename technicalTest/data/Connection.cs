using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace technicalTest.data
{
    public class Connection{
        private static Connection? con;

        public Connection() { con = this; }

        public OracleConnection createConnection()
        {
            OracleConnection stringDB = new OracleConnection();
            try 
            {
                stringDB.ConnectionString = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=ebenitez)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XE)));User Id=BASEDATOS2;Password=BASEDATOS2;Connection Timeout=4;";
                //stringDB.ConnectionString = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=127.0.0.1)(PORT=5500)));User Id=BASEDATOS2;Password=BASEDATOS2;";
            }
            catch(Exception ex)
            {
                //stringDB = null;
                throw ex;
            }
            return stringDB;
        }

        public static Connection getInstance()
        {
            if (con == null)
            {
                con = new Connection();
            }
            return con;
        }
    }
}
