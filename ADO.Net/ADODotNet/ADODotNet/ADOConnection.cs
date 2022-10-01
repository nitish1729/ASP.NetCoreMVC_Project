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
            //Created a more table
            //string query = "INSERT INTO Products (Name, Price, Date) VALUES(@Name, @Price, @Date)";
            /*
            string query = @"create table dbo.Items
              (
               Name varchar(50) NULL,
               Price varchar(50) NULL,
               Date datetime NULL,
               );";
            */
            // Coping the records of Products into Items table
            string query = "INSERT INTO Items(Name,Price,Date) SELECT Name,Price,Date FROM Products";
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
                cmd.ExecuteNonQuery();
                Console.WriteLine("Records copied into Items table Successfully");
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
