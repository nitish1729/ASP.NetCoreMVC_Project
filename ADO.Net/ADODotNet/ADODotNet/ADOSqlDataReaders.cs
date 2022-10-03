using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ADODotNet
{
    public class ADOSqlDataReaders
    {
        public void Sqlreader()
        {
            string cs = @"Data Source=DESKTOP-C3BQOGP\SQLEXPRESS;Initial Catalog=StudentDB;Integrated Security = true;";
           SqlConnection conn = null;
            using (conn = new SqlConnection(cs))
            {
                // Creating the command object
                string query = "INSERT INTO students VALUES (101, 'Anurag', 'Anurag@dotnettutorial.net', '1234567890')" +
                    "INSERT INTO students VALUES (102, 'Priyanka', 'Priyanka@dotnettutorial.net', '2233445566')" +
                    "INSERT INTO students VALUES (103, 'Preety', 'Preety@dotnettutorial.net', '6655443322')" +
                    "INSERT INTO students VALUES (104, 'Sambit', 'Sambit@dotnettutorial.net', '9876543210')";
                SqlCommand cmd = new SqlCommand(query, conn);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Records Inserted Successfully");
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
