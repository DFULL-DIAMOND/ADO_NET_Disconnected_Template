namespace HW_ADO_25_09.UI
{
    partial class InputDialog
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
            promptLabel = new Label();
            inputComboBox = new ComboBox();
            okButton = new Button();
            cancelButton = new Button();
            SuspendLayout();
            // 
            // promptLabel
            // 
            promptLabel.AutoSize = true;
            promptLabel.Location = new Point(12, 15);
            promptLabel.Name = "promptLabel";
            promptLabel.Size = new Size(38, 15);
            promptLabel.TabIndex = 0;
            promptLabel.Text = "label1";
            // 
            // inputComboBox
            // 
            inputComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            inputComboBox.FormattingEnabled = true;
            inputComboBox.Location = new Point(12, 40);
            inputComboBox.Name = "inputComboBox";
            inputComboBox.Size = new Size(346, 23);
            inputComboBox.TabIndex = 1;
            // 
            // okButton
            // 
            okButton.DialogResult = DialogResult.OK;
            okButton.Location = new Point(192, 70);
            okButton.Name = "okButton";
            okButton.Size = new Size(75, 23);
            okButton.TabIndex = 2;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Location = new Point(273, 70);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 3;
            cancelButton.Text = "Отмена";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // InputDialog
            // 
            AcceptButton = okButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = cancelButton;
            ClientSize = new Size(354, 101);
            Controls.Add(cancelButton);
            Controls.Add(okButton);
            Controls.Add(inputComboBox);
            Controls.Add(promptLabel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "InputDialog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Ввод";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label promptLabel;
        private ComboBox inputComboBox;
        private Button okButton;
        private Button cancelButton;
    }
}