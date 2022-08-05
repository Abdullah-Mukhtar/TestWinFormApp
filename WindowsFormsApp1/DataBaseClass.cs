using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    class DataBaseClass
    {
        public static SqlConnection connect()
        {
            string connectionString = @"Data Source=DESKTOP-123\SQLEXPRESS;Initial Catalog=TestDB;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            return con;
        }
        public void executeInsertQuerry(string querry)
        {
            SqlConnection abc = connect();
            SqlCommand cmd = new SqlCommand(querry, abc);
            cmd.ExecuteNonQuery();
            abc.Close();
        }
    }
}
