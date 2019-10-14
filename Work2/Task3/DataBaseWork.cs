using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Work2.Task3
{
     class DataBaseWork
    {
        static string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\danila_malchikov\\source\\repos\\Work2\\Work2\\LocalDataBase.mdf;Integrated Security=True";
        SqlConnection connection = new System.Data.SqlClient.SqlConnection();
        
        private void CreateConnection()
        {
            connection.ConnectionString = connectionString;
            using (connection)
            {
                connection.
            }
        }
    }
}
