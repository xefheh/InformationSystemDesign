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
            this._signPicker = new System.Windows.Forms.DateTimePicker();
            this._validatePicker = new System.Windows.Forms.DateTimePicker();
            this._executorBox = new System.Windows.Forms.TextBox();
            this._customerBox = new System.Windows.Forms.TextBox();
            this._signLabel = new System.Windows.Forms.Label();
            this._validateLabel = new System.Windows.Forms.Label();
            this._executerLabel = new System.Windows.Forms.Label();
            this._customerLabel = new System.Windows.Forms.Label();
            this._okButton = new System.Windows.Forms.Button();
            this._cancelButton = new System.Windows.Forms.Button();
            this._deleteButton = new System.Windows.Forms.Button();
            this._cityButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _signPicker
            // 
            this._signPicker.Location = new System.Drawing.Point(122, 12);
            this._signPicker.Name = "_signPicker";
            this._signPicker.Size = new System.Drawing.Size(200, 23);
            this._signPicker.TabIndex = 0;
            // 
            // _validatePicker
            // 
            this._validatePicker.Location = new System.Drawing.Point(122, 41);
            this._validatePicker.Name = "_validatePicker";
            this._validatePicker.Size = new System.Drawing.Size(200, 23);
            this._validatePicker.TabIndex = 1;
            // 
            // _executorBox
            // 
            this._executorBox.Location = new System.Drawing.Point(122, 70);
            this._executorBox.Name = "_executorBox";
            this._executorBox.Size = new System.Drawing.Size(100, 23);
            this._executorBox.TabIndex = 2;
            // 
            // _customerBox
            // 
            this._customerBox.Location = new System.Drawing.Point(122, 99);
            this._customerBox.Name = "_customerBox";
            this._customerBox.Size = new System.Drawing.Size(100, 23);
            this._customerBox.TabIndex = 3;
            // 
            // _signLabel
            // 
            this._signLabel.AutoSize = true;
            this._signLabel.Location = new System.Drawing.Point(12, 18);
            this._signLabel.Name = "_signLabel";
            this._signLabel.Size = new System.Drawing.Size(105, 15);
            this._signLabel.TabIndex = 4;
            this._signLabel.Text = "Дата заключения:";
            // 
            // _validateLabel
            // 
            this._validateLabel.AutoSize = true;
            this._validateLabel.Location = new System.Drawing.Point(12, 47);
            this._validateLabel.Name = "_validateLabel";
            this._validateLabel.Size = new System.Drawing.Size(87, 15);
            this._validateLabel.TabIndex = 5;
            this._validateLabel.Text = "Дата действия:";
            // 
            // _executerLabel
            // 
            this._executerLabel.AutoSize = true;
            this._executerLabel.Location = new System.Drawing.Point(12, 73);
            this._executerLabel.Name = "_executerLabel";
            this._executerLabel.Size = new System.Drawing.Size(84, 15);
            this._executerLabel.TabIndex = 6;
            this._executerLabel.Text = "Исполнитель:";
            // 
            // _customerLabel
            // 
            this._customerLabel.AutoSize = true;
            this._customerLabel.Location = new System.Drawing.Point(12, 102);
            this._customerLabel.Name = "_customerLabel";
            this._customerLabel.Size = new System.Drawing.Size(60, 15);
            this._customerLabel.TabIndex = 7;
            this._customerLabel.Text = "Заказчик:";
            // 
            // _okButton
            // 
            this._okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._okButton.Location = new System.Drawing.Point(12, 134);
            this._okButton.Name = "_okButton";
            this._okButton.Size = new System.Drawing.Size(75, 23);
            this._okButton.TabIndex = 8;
            this._okButton.Text = "ОК";
            this._okButton.UseVisualStyleBackColor = true;
            // 
            // _cancelButton
            // 
            this._cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._cancelButton.Location = new System.Drawing.Point(247, 134);
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.Size = new System.Drawing.Size(75, 23);
            this._cancelButton.TabIndex = 9;
            this._cancelButton.Text = "Отмена";
            this._cancelButton.UseVisualStyleBackColor = true;
            // 
            // _deleteButton
            // 
            this._deleteButton.Location = new System.Drawing.Point(342, 12);
            this._deleteButton.Name = "_deleteButton";
            this._deleteButton.Size = new System.Drawing.Size(149, 23);
            this._deleteButton.TabIndex = 10;
            this._deleteButton.Text = "Удалить карточку";
            this._deleteButton.UseVisualStyleBackColor = true;
            // 
            // _cityButton
            // 
            this._cityButton.Location = new System.Drawing.Point(342, 41);
            this._cityButton.Name = "_cityButton";
            this._cityButton.Size = new System.Drawing.Size(149, 23);
            this._cityButton.TabIndex = 11;
            this._cityButton.Text = "Города";
            this._cityButton.UseVisualStyleBackColor = true;
            this._cityButton.Click += new System.EventHandler(this._cityButton_Click);
            // 
            // MunicipalCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 248);
            this.Controls.Add(this._cityButton);
            this.Controls.Add(this._deleteButton);
            this.Controls.Add(this._cancelButton);
            this.Controls.Add(this._okButton);
            this.Controls.Add(this._customerLabel);
            this.Controls.Add(this._executerLabel);
            this.Controls.Add(this._validateLabel);
            this.Controls.Add(this._signLabel);
            this.Controls.Add(this._customerBox);
            this.Controls.Add(this._executorBox);
            this.Controls.Add(this._validatePicker);
            this.Controls.Add(this._signPicker);
            this.Name = "MunicipalCardForm";
            this.Text = "MunicipalCardForm";
            this.ResumeLayout(false);
            this.PerformLayout();
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
            Text = "Муниципальная карточка";
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
        private Button _cityButton;
    }
}