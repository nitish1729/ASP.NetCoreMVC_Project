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
            /*
           //Created a more table
           //string query = "INSERT INTO Products (Name, Price, Date) VALUES(@Name, @Price, @Date)";

           string query = @"create table dbo.Items
             (
              Name varchar(50) NULL,
              Price varchar(50) NULL,
              Date datetime NULL,
              );";
           */
            // Coping the records of Products into Items table
            string query = "Insert_Record_Procedure";
            SqlCommand cmd = new SqlCommand(query, conn);
            /* .
            //Pass values to Parameters
            cmd.Parameters.AddWithValue("@Name", "USB Keyboard");
            cmd.Parameters.AddWithValue("@Price", "$20");
            cmd.Parameters.AddWithValue("@Date", "25 May 2017");
            */
            try
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Name", "SSD DRIVE"));
                cmd.Parameters.Add(new SqlParameter("@Price", "$300"));
                cmd.Parameters.Add(new SqlParameter("@Date", "25 August 14"));
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    Console.WriteLine("Records Inserted Successfully.");
                }

                /*SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine(dr["SPECIFIC_NAME"].ToString());
                }
                //cmd.ExecuteNonQuery();
                
                Console.WriteLine("Store Procedure Created Successfully");
                */
            }
            catch (SqlException e)
            {
                Console.WriteLine("Error Generated. Details: " + e.ToString());
            }
            finally
            {
                conn.Close();
                Console.ReadKey();
            }

        }
    }    
}
