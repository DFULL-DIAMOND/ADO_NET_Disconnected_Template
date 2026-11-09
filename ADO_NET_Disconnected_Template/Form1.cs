using Microsoft.Data.SqlClient;
using System.Data;
using HW_ADO_25_09.Data;
using HW_ADO_25_09.Queries;
using HW_ADO_25_09.UI;

namespace HW_ADO_25_09
{
    public partial class Form1 : Form
    {
        private readonly DataAdapterRunner _adapterRunner;

        public Form1()
        {
            InitializeComponent();

            runButton.Click += OnRunClicked;
            _adapterRunner = new DataAdapterRunner(new WinFormsDataPresenter(grid));

            // Настраиваем ComboBox (пункты меню)
            queryPicker.Items.AddRange(new object[]
            {
                "1.  Вся информация о чаях",
                "2.  Все названия чаёв",
                "3.  Все зеленые чаи",
                "4.  Все черные чаи",
                "5.  Все чаи, кроме зеленых и чёрных",
                "6.  Чаи, вес которых не больше указанного",
                "7.  Минимальная себестоимость чая",
                "8.  Максимальная себестоимость чая",
                "9.  Средняя себестоимость чая",
                "10. Кол-во чаёв с минимальной себестоимостью",
                "11. Кол-во чаёв с максимальной себестоимостью",
                "12. Кол-во чаёв дороже средней себестоимости",
                "13. Количество единиц каждого вида чая"
            });
            queryPicker.SelectedIndex = 0;

            // Обновляем статус соединения (просто для красоты)
            connectionLabel.Text = "Отсоединенный режим (соединение по запросу)";
            connectionLabel.ForeColor = Color.Green;
        }

        private async void OnRunClicked(object? sender, EventArgs e)
        {
            string key = queryPicker.Text.Split('.')[0].Trim();
            if (!QueryRegistry.TryGet(key, out var query)) return;

            try
            {
                // 1. Собираем параметры (если нужны)
                string[]? dropdownValues = null;

                // Для получения DropdownValues нам нужно кратковременно подключиться
                if (!string.IsNullOrEmpty(query.DropdownSql))
                {
                    var list = new List<string>();
                    using var tempConn = new SqlConnection(ConnectionFactory.Build());
                    await tempConn.OpenAsync();
                    using var cmd = new SqlCommand(query.DropdownSql, tempConn);
                    using var reader = await cmd.ExecuteReaderAsync();
                    while (await reader.ReadAsync()) list.Add(reader.GetString(0));
                    dropdownValues = list.ToArray();
                }

                var prompt = new WinFormsUserPrompt();
                var inputs = prompt.Ask(query.Prompts, dropdownValues);
                if (inputs is null) return;

                var parameters = query.ParametersFactory(inputs);

                // 2. Выполняем сам запрос
                using var conn = new SqlConnection(ConnectionFactory.Build());
                await _adapterRunner.ExecuteAsync(conn, query, parameters);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}