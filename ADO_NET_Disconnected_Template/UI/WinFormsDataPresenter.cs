using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace HW_ADO_25_09.UI
{
    internal class WinFormsDataPresenter : IDataPresenter
    {
        private readonly DataGridView _grid;

        public WinFormsDataPresenter(DataGridView grid)
        {
            _grid = grid;
        }

        public void ShowData(DataTable table)
        {
            _grid.DataSource = table; // Магия DataBinding
            _grid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        public void ShowError(string message)
            => MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

        public void ShowMessage(string message)
            => MessageBox.Show(message, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
