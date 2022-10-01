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
            //CREATE A TABLE USING C# ADO.NET
            string query = @"CREATE TABLE dbo.Products
                (
                    Name nvarchar(50) NULL,
                    Price nvarchar(50) NULL,
                     Date datetime NULL
                );";

            SqlCommand cmd = new SqlCommand(query, conn);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Table Created Successfully");
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
