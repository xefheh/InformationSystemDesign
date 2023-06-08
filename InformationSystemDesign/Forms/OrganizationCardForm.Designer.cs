namespace InformationSystemDesign.Forms
{
    partial class OrganizationCardForm
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
            _innLabel = new Label();
            _fullNameLabel = new Label();
            _kppLabel = new Label();
            _regAddLabel = new Label();
            _orgTypeLabel = new Label();
            _ownerTypeLabel = new Label();
            _cityLabel = new Label();
            _innTextBox = new TextBox();
            _fullNameTextBox = new TextBox();
            _kppTextBox = new TextBox();
            _addressBox = new TextBox();
            _cityBox = new TextBox();
            _typeOrgBox = new ComboBox();
            _ownerTypeBox = new ComboBox();
            _okButton = new Button();
            _cancelButton = new Button();
            _deleteButton = new Button();
            SuspendLayout();
            // 
            // _innLabel
            // 
            _innLabel.AutoSize = true;
            _innLabel.Location = new Point(45, 36);
            _innLabel.Name = "_innLabel";
            _innLabel.Size = new Size(37, 15);
            _innLabel.TabIndex = 0;
            _innLabel.Text = "ИНН:";
            // 
            // _fullNameLabel
            // 
            _fullNameLabel.AutoSize = true;
            _fullNameLabel.Location = new Point(45, 61);
            _fullNameLabel.Name = "_fullNameLabel";
            _fullNameLabel.Size = new Size(137, 15);
            _fullNameLabel.TabIndex = 1;
            _fullNameLabel.Text = "Полное наименование:";
            // 
            // _kppLabel
            // 
            _kppLabel.AutoSize = true;
            _kppLabel.Location = new Point(45, 87);
            _kppLabel.Name = "_kppLabel";
            _kppLabel.Size = new Size(35, 15);
            _kppLabel.TabIndex = 2;
            _kppLabel.Text = "КПП:";
            // 
            // _regAddLabel
            // 
            _regAddLabel.AutoSize = true;
            _regAddLabel.Location = new Point(45, 116);
            _regAddLabel.Name = "_regAddLabel";
            _regAddLabel.Size = new Size(116, 15);
            _regAddLabel.TabIndex = 3;
            _regAddLabel.Text = "Адрес регистрации:";
            // 
            // _orgTypeLabel
            // 
            _orgTypeLabel.AutoSize = true;
            _orgTypeLabel.Location = new Point(45, 146);
            _orgTypeLabel.Name = "_orgTypeLabel";
            _orgTypeLabel.Size = new Size(104, 15);
            _orgTypeLabel.TabIndex = 4;
            _orgTypeLabel.Text = "Тип организации:";
            // 
            // _ownerTypeLabel
            // 
            _ownerTypeLabel.AutoSize = true;
            _ownerTypeLabel.Location = new Point(45, 178);
            _ownerTypeLabel.Name = "_ownerTypeLabel";
            _ownerTypeLabel.Size = new Size(86, 15);
            _ownerTypeLabel.TabIndex = 5;
            _ownerTypeLabel.Text = "ИП/Юр. лицо:";
            _ownerTypeLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // _cityLabel
            // 
            _cityLabel.AutoSize = true;
            _cityLabel.Location = new Point(45, 208);
            _cityLabel.Name = "_cityLabel";
            _cityLabel.Size = new Size(114, 15);
            _cityLabel.TabIndex = 6;
            _cityLabel.Text = "Населённый пункт:";
            // 
            // _innTextBox
            // 
            _innTextBox.Location = new Point(215, 33);
            _innTextBox.Name = "_innTextBox";
            _innTextBox.Size = new Size(100, 23);
            _innTextBox.TabIndex = 7;
            // 
            // _fullNameTextBox
            // 
            _fullNameTextBox.Location = new Point(215, 58);
            _fullNameTextBox.Name = "_fullNameTextBox";
            _fullNameTextBox.Size = new Size(100, 23);
            _fullNameTextBox.TabIndex = 8;
            // 
            // _kppTextBox
            // 
            _kppTextBox.Location = new Point(215, 84);
            _kppTextBox.Name = "_kppTextBox";
            _kppTextBox.Size = new Size(100, 23);
            _kppTextBox.TabIndex = 9;
            // 
            // _addressBox
            // 
            _addressBox.Location = new Point(215, 113);
            _addressBox.Name = "_addressBox";
            _addressBox.Size = new Size(100, 23);
            _addressBox.TabIndex = 10;
            // 
            // _cityBox
            // 
            _cityBox.Location = new Point(215, 205);
            _cityBox.Name = "_cityBox";
            _cityBox.Size = new Size(100, 23);
            _cityBox.TabIndex = 11;
            // 
            // _typeOrgBox
            // 
            _typeOrgBox.FormattingEnabled = true;
            _typeOrgBox.Location = new Point(215, 143);
            _typeOrgBox.Name = "_typeOrgBox";
            _typeOrgBox.Size = new Size(121, 23);
            _typeOrgBox.TabIndex = 12;
            // 
            // _ownerTypeBox
            // 
            _ownerTypeBox.FormattingEnabled = true;
            _ownerTypeBox.Location = new Point(215, 175);
            _ownerTypeBox.Name = "_ownerTypeBox";
            _ownerTypeBox.Size = new Size(121, 23);
            _ownerTypeBox.TabIndex = 13;
            // 
            // _okButton
            // 
            _okButton.DialogResult = DialogResult.OK;
            _okButton.Location = new Point(45, 247);
            _okButton.Name = "_okButton";
            _okButton.Size = new Size(75, 23);
            _okButton.TabIndex = 14;
            _okButton.Text = "ОК";
            _okButton.UseVisualStyleBackColor = true;
            // 
            // _cancelButton
            // 
            _cancelButton.DialogResult = DialogResult.Cancel;
            _cancelButton.Location = new Point(166, 247);
            _cancelButton.Name = "_cancelButton";
            _cancelButton.Size = new Size(75, 23);
            _cancelButton.TabIndex = 15;
            _cancelButton.Text = "Отмена";
            _cancelButton.UseVisualStyleBackColor = true;
            // 
            // _deleteButton
            // 
            _deleteButton.Location = new Point(271, 247);
            _deleteButton.Name = "_deleteButton";
            _deleteButton.Size = new Size(75, 23);
            _deleteButton.TabIndex = 16;
            _deleteButton.Text = "Удалить";
            _deleteButton.UseVisualStyleBackColor = true;
            _deleteButton.Click += _deleteButton_Click;
            // 
            // OrganizationCardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(_deleteButton);
            Controls.Add(_cancelButton);
            Controls.Add(_okButton);
            Controls.Add(_ownerTypeBox);
            Controls.Add(_typeOrgBox);
            Controls.Add(_cityBox);
            Controls.Add(_addressBox);
            Controls.Add(_kppTextBox);
            Controls.Add(_fullNameTextBox);
            Controls.Add(_innTextBox);
            Controls.Add(_cityLabel);
            Controls.Add(_ownerTypeLabel);
            Controls.Add(_orgTypeLabel);
            Controls.Add(_regAddLabel);
            Controls.Add(_kppLabel);
            Controls.Add(_fullNameLabel);
            Controls.Add(_innLabel);
            Name = "OrganizationCardForm";
            Text = "Карточка организации";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label _innLabel;
        private Label _fullNameLabel;
        private Label _kppLabel;
        private Label _regAddLabel;
        private Label _orgTypeLabel;
        private Label _ownerTypeLabel;
        private Label _cityLabel;
        private TextBox _innTextBox;
        private TextBox _fullNameTextBox;
        private TextBox _kppTextBox;
        private TextBox _addressBox;
        private TextBox _cityBox;
        private ComboBox _typeOrgBox;
        private ComboBox _ownerTypeBox;
        private Button _okButton;
        private Button _cancelButton;
        private Button _deleteButton;
    }
}