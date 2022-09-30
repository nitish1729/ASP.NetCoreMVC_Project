using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ADODotNet
{
    public class connectionToSQL_Server
    {
        public void CreateTable()
        {
            string cs = "Data Source=DESKTOP-C3BQOGP\\SQLEXPRESS;Initial Catalog=bikesStores;Integrated Security = true;";
            SqlConnection conn = new SqlConnection(cs);
            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    Console.WriteLine("SQL Connection has beem successfull:");
                }
            }
            catch (Exception ex)
            {
                conn.Close();
            }
        }
    }
}
