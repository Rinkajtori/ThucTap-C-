using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QuanLySieuThi
{
    class MyControl
    {
        public String ExecuteMyQuery(string query)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectSQL.connectionString))
                {
                    connection.Open();
                    SqlCommand commandAddNV = new SqlCommand(query, connection);
                    commandAddNV.ExecuteNonQuery();
                    connection.Close();
                    return "Success !!";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String ExecuteMyQueryScalar(string query)
        {
            string result;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectSQL.connectionString))
                {
                    connection.Open();
                    SqlCommand commandAddNV = new SqlCommand(query, connection);                   
                    result = (string)commandAddNV.ExecuteScalar();
                    connection.Close();
                    return result;
                }
            }
            catch (Exception ex)
            {
                return "ERROR"+ex.Message;
            }
        }
       
    }
}
