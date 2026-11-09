using HW_ADO_25_09.Data;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
using System.Data;

namespace HW_ADO_25_09.Queries
{
    internal class QueryRegistry
    {
        private static readonly Dictionary<string, QueryDefinition> _queries = new()
        {
            // ================= Your Queries =================
            ["1"] = new() { Sql = "SELECT * FROM dbo.YourDataTable" }
        };

        public static bool TryGet(string key, out QueryDefinition query)
            => _queries.TryGetValue(key, out query!);
    }
}
