namespace HW_ADO_25_09
{
    partial class ClosedForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            openButton = new Button();
            connectionLabel = new Label();
            SuspendLayout();
            // 
            // openButton
            // 
            openButton.Dock = DockStyle.Bottom;
            openButton.Location = new Point(0, 71);
            openButton.Name = "openButton";
            openButton.Size = new Size(384, 40);
            openButton.TabIndex = 0;
            openButton.Text = "Открыть соединение";
            openButton.UseVisualStyleBackColor = true;
            // 
            // connectionLabel
            // 
            connectionLabel.Dock = DockStyle.Fill;
            connectionLabel.Font = new Font("Segoe UI", 12F);
            connectionLabel.ForeColor = Color.Red;
            connectionLabel.Location = new Point(0, 0);
            connectionLabel.Name = "connectionLabel";
            connectionLabel.Size = new Size(384, 71);
            connectionLabel.TabIndex = 1;
            connectionLabel.Text = "Соединение закрыто";
            connectionLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ClosedForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 111);
            Controls.Add(connectionLabel);
            Controls.Add(openButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ClosedForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Подключение";
            ResumeLayout(false);
        }

        #endregion

        private Button openButton;
        private Label connectionLabel;
    }
}