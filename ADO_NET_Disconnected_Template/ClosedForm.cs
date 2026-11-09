using HW_ADO_25_09.Data;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HW_ADO_25_09
{
    public partial class ClosedForm : Form
    {
        private SqlConnection? _conn;
        private Form1? _mainForm;

        public ClosedForm()
        {
            InitializeComponent();

            // Подписываем кнопку на событие клика
            openButton.Click += OnOpenClicked;
        }

        private void OnOpenClicked(object? sender, EventArgs e)
        {
            try
            {
                // Если соединения нет или оно закрыто - создаем и открываем новое
                if (_conn is null || _conn.State != ConnectionState.Open)
                {
                    _conn?.Dispose();
                    _conn = new SqlConnection(ConnectionFactory.Build());
                    _conn.Open();
                }

                // Если главная форма еще не создана
                if (_mainForm is null)
                {
                    _mainForm = new Form1(this, _conn);
                    // Подписываемся на событие закрытия из Form1
                    _mainForm.DisconnectRequested += OnMainFormDisconnect;
                }

                _mainForm.Show();
                Hide(); // Скрываем окно подключения
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось подключиться: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Этот метод вызывается, когда в Form1 нажимают "0. Закрыть соединение"
        private void OnMainFormDisconnect()
        {
            if (_mainForm != null)
            {
                // Отписываемся от события и уничтожаем форму, чтобы память не текла
                _mainForm.DisconnectRequested -= OnMainFormDisconnect;
                _mainForm.Dispose();
                _mainForm = null;
            }
        }

        // Когда закрывают само окно подключения (крестиком)
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            _mainForm?.Dispose();
            if (_conn.State == ConnectionState.Open)
            {
                _conn.Close(); // КРИТИЧЕСКИ ВАЖНО: сначала закрываем сокет
            }
            _conn?.Dispose();
            base.OnFormClosing(e);
        }
    }
}
