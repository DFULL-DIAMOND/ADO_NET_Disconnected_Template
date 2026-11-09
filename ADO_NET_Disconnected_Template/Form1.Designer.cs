namespace HW_ADO_25_09
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grid = new DataGridView();
            connectionLabel = new Label();
            actionLabel = new Label();
            queryPicker = new ComboBox();
            runButton = new Button();
            ((System.ComponentModel.ISupportInitialize)grid).BeginInit();
            SuspendLayout();
            // 
            // grid
            // 
            grid.AllowUserToAddRows = false;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid.Dock = DockStyle.Fill;
            grid.Location = new Point(0, 63);
            grid.Name = "grid";
            grid.ReadOnly = true;
            grid.Size = new Size(884, 483);
            grid.TabIndex = 0;
            // 
            // connectionLabel
            // 
            connectionLabel.Dock = DockStyle.Bottom;
            connectionLabel.Location = new Point(0, 546);
            connectionLabel.Name = "connectionLabel";
            connectionLabel.Size = new Size(884, 15);
            connectionLabel.TabIndex = 1;
            connectionLabel.Text = "Соединение";
            connectionLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // actionLabel
            // 
            actionLabel.Dock = DockStyle.Top;
            actionLabel.Location = new Point(0, 0);
            actionLabel.Name = "actionLabel";
            actionLabel.Size = new Size(884, 15);
            actionLabel.TabIndex = 2;
            actionLabel.Text = "Выберите действие:";
            // 
            // queryPicker
            // 
            queryPicker.Dock = DockStyle.Top;
            queryPicker.DropDownStyle = ComboBoxStyle.DropDownList;
            queryPicker.FormattingEnabled = true;
            queryPicker.Location = new Point(0, 15);
            queryPicker.Name = "queryPicker";
            queryPicker.Size = new Size(884, 23);
            queryPicker.TabIndex = 3;
            // 
            // runButton
            // 
            runButton.Dock = DockStyle.Top;
            runButton.Location = new Point(0, 38);
            runButton.Name = "runButton";
            runButton.Size = new Size(884, 25);
            runButton.TabIndex = 4;
            runButton.Text = "Выполнить";
            runButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            Controls.Add(grid);
            Controls.Add(runButton);
            Controls.Add(queryPicker);
            Controls.Add(actionLabel);
            Controls.Add(connectionLabel);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Магазин Чая";
            ((System.ComponentModel.ISupportInitialize)grid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView grid;
        private Label connectionLabel;
        private Label actionLabel;
        private ComboBox queryPicker;
        private Button runButton;
    }
}
