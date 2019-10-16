using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Work2.Task3
{
     class DataBaseWork
     {
         private string mainSQLQuery =
             "with cte\r\nas\r\n(select\r\nr.Num, r.StopID, s.StopName from RoutesStreet r\r\njoin Stops s\r\non r.StopID = s.Id)\r\n\r\nselect r.Num\r\nfrom cte l\r\njoin cte r\r\non l.Num = r.Num\r\nwhere l.StopName LIKE 'HookMarket'\r\nand r.StopName LIKE 'MarketStation'";
        static string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\danila_malchikov\\source\\repos\\Work2\\Work2\\LocalDataBase.mdf;Integrated Security=True";
        SqlConnection connection = new System.Data.SqlClient.SqlConnection();
        
        private void CreateConnection()
        {
            connection.ConnectionString = connectionString;
            using (connection)
            {
                //connection.
            }
        }
    }
}
