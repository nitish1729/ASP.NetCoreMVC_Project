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
            string cs = @"Data Source=DESKTOP-C3BQOGP\SQLEXPRESS;Initial Catalog=ComputerShop;Integrated Security = true;";
            SqlConnection conn = null;
            conn = new SqlConnection(cs);
            //Inserting records in Table
            string query = "INSERT INTO Products (Name,Price,Date) VALUES('DVD Screen','$140','29 January 2017')";


            SqlCommand cmd = new SqlCommand(query, conn);

            //Pass values to Parameters
            cmd.Parameters.AddWithValue("@Name", "USB Keyboard");
            cmd.Parameters.AddWithValue("@Price", "$20");
            cmd.Parameters.AddWithValue("@Date", "25 May 2017");
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Records Inserted Successfully");
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
