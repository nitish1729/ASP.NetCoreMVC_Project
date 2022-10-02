using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Reflection.PortableExecutable;

namespace ADODotNet
{
    public class ADOConnection
    {
        public void connect()
        {
            string cs = @"Data Source=DESKTOP-C3BQOGP\SQLEXPRESS;Initial Catalog=ComputerShop;Integrated Security = true;";
            SqlConnection conn = new SqlConnection(cs);
            String query = "Select * from Items";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
               SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader[0].ToString() + " " + reader[1].ToString() + " " + reader[2].ToString());
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                conn.Close();
                Console.ReadLine();
            }
        }
    }     
}
