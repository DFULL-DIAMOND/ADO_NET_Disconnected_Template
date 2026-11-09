using HW_ADO_25_09.UI;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace HW_ADO_25_09.Data
{
    internal class DataAdapterRunner
    {
        private readonly IDataPresenter _presenter;

        public DataAdapterRunner(IDataPresenter presenter)
        {
            _presenter = presenter;
        }

        public async Task ExecuteAsync(SqlConnection conn, QueryDefinition query, SqlParameter[] parameters)
        {
            using var cmd = new SqlCommand(query.Sql, conn);
            if (parameters.Length > 0)
                cmd.Parameters.AddRange(parameters);

            // Если это INSERT/UPDATE/DELETE
            if (query.IsAction)
            {
                int rows = await cmd.ExecuteNonQueryAsync();
                _presenter.ShowMessage($"Успешно! Затронуто строк: {rows}");
                return;
            }

            // Если это SELECT - используем отсоединенный режим (DataAdapter)
            using var adapter = new SqlDataAdapter(cmd);
            var dataTable = new DataTable();

            // Заполняем таблицу (делаем это в фоновом потоке, чтобы не вешать UI)
            await Task.Run(() => adapter.Fill(dataTable));

            // Отдаем готовую таблицу презентеру
            _presenter.ShowData(dataTable);
        }
    }
}
