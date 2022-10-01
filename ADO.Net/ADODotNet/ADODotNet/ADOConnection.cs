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
            string cs = @"Data Source = DESKTOP-C3BQOGP\SQLEXPRESS; Initial Catalog = master;Integrated Security = true;";
            SqlConnection conn = null;
            
            try
            {
                conn = new SqlConnection(cs);
                //CREATE A DATABASE USING ADO.NET C#
                string query = "Create Database ComputerShop";
                SqlCommand cmd = new SqlCommand(query,conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Database Created Successfully");
                /*
                if (conn.State == ConnectionState.Open)
                {
                    Console.WriteLine("SQL Connection has beem successfull:");
                    Console.ReadLine();
                }
                */
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
