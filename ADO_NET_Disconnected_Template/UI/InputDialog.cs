using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HW_ADO_25_09.UI
{
    public partial class InputDialog : Form
    {
        public string? Result { get; private set; }

        public InputDialog(string prompt, string[]? dropdownValues = null)
        {
            InitializeComponent(); // Дизайнер создал label, combobox и кнопки

            promptLabel.Text = prompt;

            if (dropdownValues != null && dropdownValues.Length > 0)
            {
                inputComboBox.Items.AddRange(dropdownValues);
                inputComboBox.DropDownStyle = ComboBoxStyle.DropDownList; // Только выбор
                inputComboBox.SelectedIndex = 0;
            }
            else
            {
                inputComboBox.DropDownStyle = ComboBoxStyle.DropDown; // Разрешаем ввод
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // Если пользователь нажал ОК (DialogResult.OK задан в свойствах кнопки)
            if (DialogResult == DialogResult.OK)
            {
                Result = inputComboBox.Text;
            }
            base.OnFormClosing(e);
        }
    }
}