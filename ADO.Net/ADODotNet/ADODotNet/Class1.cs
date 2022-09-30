using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ADODotNet
{
    public class Class1
    {
        public void ADOone()
        {
            string cs = "Data Source=DESKTOP-C3BQOGP\\SQLEXPRESS;Initial Catalog=TwoWheeleStores;Integrated Security = true;";
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(cs);
                string query = "INSERT INTO SalesCustomers(first_name, last_name, phone, email, street, city, state, zip_code) VALUES('Kasha','Todd',NULL,'kasha.todd@yahoo.com','910 Vine Street ','Campbell','CA',95008);" +
                    "INSERT INTO SalesCustomers(first_name, last_name, phone, email, street, city, state, zip_code) VALUES('Kerrie','O''neill',NULL,'kerrie.o''neill@gmail.com','69 Wellington Ave. ','Shirley','NY',11967);";
                SqlCommand cmd = new SqlCommand(query, con);
                // Opening Connection  
                con.Open();
                // Executing the SQL query  
                cmd.ExecuteNonQuery();
                // Displaying a message  
                Console.WriteLine("Record Inserted Successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                con.Close();
        }   }
    }
}
