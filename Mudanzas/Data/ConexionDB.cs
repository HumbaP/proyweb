﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Mudanzas.Data
{
    public class ConexionDB
    {
        private static SqlConnection conn;
        private static string connectionString = "Data Source=proyweb.cdrkjhnwuysd.us-west-2.rds.amazonaws.com;Initial Catalog=proyweb;User ID=admin;Password=adminadmin1234;MultipleActiveResultSets=True;";

        public static SqlConnection GetConnection()
        {
            if (conn == null)
            {
                conn = new SqlConnection(connectionString);
                conn.Open();
            }
            else if (conn.State != System.Data.ConnectionState.Open)
            {
                conn.Close();
                conn.Open();
            }
            return conn;
        }
    }
}
