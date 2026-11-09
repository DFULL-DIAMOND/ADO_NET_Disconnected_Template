using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace HW_ADO_25_09.UI
{
    public interface IDataPresenter
    {
        void ShowData(DataTable table); // Новый метод для отсоединенного режима
        void ShowError(string message);
        void ShowMessage(string message);
    }

    public interface IUserPrompt
    {
        string[]? Ask(string[] prompts, string[]? dropdownValues = null);
    }
}
