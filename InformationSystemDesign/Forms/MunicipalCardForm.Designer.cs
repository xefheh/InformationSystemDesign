namespace InformationSystemDesign.Forms
{
    partial class MunicipalCardForm
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
            _signPicker = new DateTimePicker();
            _validatePicker = new DateTimePicker();
            _executorBox = new TextBox();
            _customerBox = new TextBox();
            _signLabel = new Label();
            _validateLabel = new Label();
            _executerLabel = new Label();
            _customerLabel = new Label();
            _okButton = new Button();
            _cancelButton = new Button();
            _deleteButton = new Button();
            SuspendLayout();
            // 
            // _signPicker
            // 
            _signPicker.Location = new Point(122, 12);
            _signPicker.Name = "_signPicker";
            _signPicker.Size = new Size(200, 23);
            _signPicker.TabIndex = 0;
            // 
            // _validatePicker
            // 
            _validatePicker.Location = new Point(122, 41);
            _validatePicker.Name = "_validatePicker";
            _validatePicker.Size = new Size(200, 23);
            _validatePicker.TabIndex = 1;
            // 
            // _executorBox
            // 
            _executorBox.Location = new Point(122, 70);
            _executorBox.Name = "_executorBox";
            _executorBox.Size = new Size(100, 23);
            _executorBox.TabIndex = 2;
            // 
            // _customerBox
            // 
            _customerBox.Location = new Point(122, 99);
            _customerBox.Name = "_customerBox";
            _customerBox.Size = new Size(100, 23);
            _customerBox.TabIndex = 3;
            // 
            // _signLabel
            // 
            _signLabel.AutoSize = true;
            _signLabel.Location = new Point(12, 18);
            _signLabel.Name = "_signLabel";
            _signLabel.Size = new Size(105, 15);
            _signLabel.TabIndex = 4;
            _signLabel.Text = "Дата заключения:";
            // 
            // _validateLabel
            // 
            _validateLabel.AutoSize = true;
            _validateLabel.Location = new Point(12, 47);
            _validateLabel.Name = "_validateLabel";
            _validateLabel.Size = new Size(87, 15);
            _validateLabel.TabIndex = 5;
            _validateLabel.Text = "Дата действия:";
            // 
            // _executerLabel
            // 
            _executerLabel.AutoSize = true;
            _executerLabel.Location = new Point(12, 73);
            _executerLabel.Name = "_executerLabel";
            _executerLabel.Size = new Size(84, 15);
            _executerLabel.TabIndex = 6;
            _executerLabel.Text = "Исполнитель:";
            // 
            // _customerLabel
            // 
            _customerLabel.AutoSize = true;
            _customerLabel.Location = new Point(12, 102);
            _customerLabel.Name = "_customerLabel";
            _customerLabel.Size = new Size(60, 15);
            _customerLabel.TabIndex = 7;
            _customerLabel.Text = "Заказчик:";
            // 
            // _okButton
            // 
            _okButton.DialogResult = DialogResult.OK;
            _okButton.Location = new Point(12, 134);
            _okButton.Name = "_okButton";
            _okButton.Size = new Size(75, 23);
            _okButton.TabIndex = 8;
            _okButton.Text = "ОК";
            _okButton.UseVisualStyleBackColor = true;
            // 
            // _cancelButton
            // 
            _cancelButton.DialogResult = DialogResult.Cancel;
            _cancelButton.Location = new Point(247, 134);
            _cancelButton.Name = "_cancelButton";
            _cancelButton.Size = new Size(75, 23);
            _cancelButton.TabIndex = 9;
            _cancelButton.Text = "Отмена";
            _cancelButton.UseVisualStyleBackColor = true;
            // 
            // _deleteButton
            // 
            _deleteButton.Location = new Point(342, 12);
            _deleteButton.Name = "_deleteButton";
            _deleteButton.Size = new Size(149, 23);
            _deleteButton.TabIndex = 10;
            _deleteButton.Text = "Удалить карточку";
            _deleteButton.UseVisualStyleBackColor = true;
            _deleteButton.Click += _deleteButton_Click;
            // 
            // MunicipalCardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 248);
            Controls.Add(_deleteButton);
            Controls.Add(_cancelButton);
            Controls.Add(_okButton);
            Controls.Add(_customerLabel);
            Controls.Add(_executerLabel);
            Controls.Add(_validateLabel);
            Controls.Add(_signLabel);
            Controls.Add(_customerBox);
            Controls.Add(_executorBox);
            Controls.Add(_validatePicker);
            Controls.Add(_signPicker);
            Name = "MunicipalCardForm";
            Text = "MunicipalCardForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker _signPicker;
        private DateTimePicker _validatePicker;
        private TextBox _executorBox;
        private TextBox _customerBox;
        private Label _signLabel;
        private Label _validateLabel;
        private Label _executerLabel;
        private Label _customerLabel;
        private Button _okButton;
        private Button _cancelButton;
        private Button _deleteButton;
    }
}