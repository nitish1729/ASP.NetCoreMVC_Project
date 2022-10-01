using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ADODotNet
{
    public class ADOConnection
    {
        public void connect()
        {
            string cs = @"Data Source=DESKTOP-C3BQOGP\SQLEXPRESS;Initial Catalog=master;Integrated Security = true;";
            SqlConnection conn = null;
            conn = new SqlConnection(cs);
            //DROP OR DELETE A DATABASE USING ADO.NET C#
            string query = "DROP DATABASE ComputerShop";
            SqlCommand cmd = new SqlCommand(query, conn);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Database Deleted Successfully");
            }
            catch(SqlException e)
            {
                Console.WriteLine("Error Generated. Details: " + e.ToString());
            }
            finally
            {
                conn.Close();
            }

        }
    }    
}
