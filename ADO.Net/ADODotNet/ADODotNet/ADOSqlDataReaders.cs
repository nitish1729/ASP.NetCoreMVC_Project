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
                string query = "select * from students";
                SqlCommand cmd = new SqlCommand(query, conn);
                try
                {
                    // Opening Connection  
                    conn.Open();
                    // Executing the SQL query  
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        Console.WriteLine(sdr["Name"] + ",  " + sdr["Email"] + ",  " + sdr["Mobile"]);
                    }
                    Console.WriteLine("display the records Inserted Successfully");
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
