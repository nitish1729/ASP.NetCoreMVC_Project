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
            string cs = @"Data Source=DESKTOP-C3BQOGP\SQLEXPRESS;Initial Catalog=bikesStores;Integrated Security = true;";
            SqlConnection conn = new SqlConnection(cs);
            String query = "Select * from production.categories";
            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query,cs);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "production.categories");
                Console.WriteLine(ds.GetXml());
                /*
                SqlCommand cmd = new SqlCommand(query, conn);
               SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader[0].ToString() + " " + reader[1].ToString() + " " + reader[2].ToString());
                }
                */
            }
            catch (Exception e)
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
