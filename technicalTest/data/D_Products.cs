using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace technicalTest.data
{
    public class D_Products
    {
        public DataTable Product_list(string cSearch)
        {
            OracleDataReader result;
            DataTable table = new DataTable();
            OracleConnection conn = new OracleConnection();
            try
            {
                conn = Connection.getInstance().createConnection();
                OracleCommand Command = new OracleCommand("product_search", conn);
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.Add("p_cursor_out", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                Command.Parameters.Add("p_search", OracleDbType.Varchar2).Value = cSearch;
                conn.Open();
                result = ((OracleRefCursor)Command.Parameters["p_cursor_out"].Value).GetDataReader();
                table.Load(result);
                return table;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally 
            { 
                if (conn.State==ConnectionState.Open) conn.Close();
            }
        }
    }
}
