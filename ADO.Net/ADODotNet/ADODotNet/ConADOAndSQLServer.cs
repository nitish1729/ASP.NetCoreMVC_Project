using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
namespace ADODotNet
{
    public class ConADOAndSQLServer
    {
        public void connect()
        {
            string cs = @"Data Source=DESKTOP-C3BQOGP\SQLEXPRESS;Initial Catalog=Students;Integrated Security = true;";
            SqlConnection conn = null;
            conn = new SqlConnection(cs);
            string query = "select * from student";
            SqlCommand cmd = new SqlCommand(query,conn);
            try
            {
                conn.Open();

                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    Console.WriteLine(sdr["Name"] + ",  " + sdr["Email"] + ",  " + sdr["join_date"]);
                }
                Console.WriteLine("data retrive  Successfully");
            }
            catch (SqlException e)
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





