using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace WindowsFormsApp1.DAO
{
    class DataProvider
    {
        private string connectionString = @"Data Source=LAPTOP-EFEOHQTE\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
        public DataTable ExecuteQuery(string query)
        {
            SqlConnection connection = new SqlConnection(connectionString);
           
            SqlCommand command = new SqlCommand(query,connection);
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.Fill(data);
            connection.Close();
            return data;
        }

    }
}

