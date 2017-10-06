using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KH_Template
{
    public class DatabaseModel
    {
        static SqlConnection Connection;
        public DatabaseModel()
        {
        }
        
        static void OpenConnection()
        {
            Connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Dbconnection"].ConnectionString);
            Connection.Open();
        }

        void CloseConnection()
        {
            Connection.Close();
        }
        public static void ExecuteNonQuery(string str)
        {
            OpenConnection();
            using (Connection)
            {
                using (SqlCommand cmd = new SqlCommand(str, Connection))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public static  DataTable ExecuteQuery(string str)
        {
            DataTable DT = new DataTable();
            OpenConnection();
            using (Connection)
            {
                using (SqlCommand cmd = new SqlCommand(str, Connection))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(DT);
                        da.Dispose();
                    }
                }
                return DT;
            }
        }

    }
}
