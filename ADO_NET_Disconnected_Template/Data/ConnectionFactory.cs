using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;

namespace HW_ADO_25_09.Data
{
    internal static class ConnectionFactory
    {
        public static string Build()
        {
            var builder = new SqlConnectionStringBuilder
            {
                DataSource = "(localdb)\\MSSQLLocalDB",
                InitialCatalog = "MyDatabase",
                IntegratedSecurity = true
            };
            return builder.ConnectionString;
        }
    }
}