using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ADODotNet
{
    public class FirstConnection
    {
        public void CreateConnection()
        {
            string cs = "Data Source=DESKTOP-C3BQOGP\\SQLEXPRESS;Initial Catalog=TestDB;Integrated Security = true;";
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(cs);
                string query = "insert into student (id, name,subject) values ('106', 'Kunall','Maths')";
                SqlCommand cmd = new SqlCommand(query, con);
                // Opening Connection  
                con.Open();
                // Executing the SQL query  
                cmd.ExecuteNonQuery();
                // Displaying a message  
                Console.WriteLine("Record Inserted Successfully");
                string query2 = "Select * from student";
                SqlCommand cmd2 = new SqlCommand(query, con);
                cmd2.ExecuteNonQuery();
                // Executing the SQL query  
                SqlDataReader sdr = cmd2.ExecuteReader();
                Console.WriteLine("read the  Inserted data");
                while (sdr.Read())
                {
                    // Displaying Record  
                    Console.WriteLine(sdr["id"] + " " + sdr["name"] + " " + sdr["subject"]);
                }

                if (con.State == ConnectionState.Open)
                { 
                    Console.WriteLine("SQL Connection has beem successfull:");
                    Console.ReadLine();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }  
}
