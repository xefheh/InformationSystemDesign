namespace InformationSystemDesign.Forms.OrganizationForms
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
            this._innLabel = new System.Windows.Forms.Label();
            this._fullNameLabel = new System.Windows.Forms.Label();
            this._kppLabel = new System.Windows.Forms.Label();
            this._regAddLabel = new System.Windows.Forms.Label();
            this._orgTypeLabel = new System.Windows.Forms.Label();
            this._ownerTypeLabel = new System.Windows.Forms.Label();
            this._cityLabel = new System.Windows.Forms.Label();
            this._innTextBox = new System.Windows.Forms.TextBox();
            this._fullNameTextBox = new System.Windows.Forms.TextBox();
            this._kppTextBox = new System.Windows.Forms.TextBox();
            this._addressBox = new System.Windows.Forms.TextBox();
            this._cityBox = new System.Windows.Forms.TextBox();
            this._typeOrgBox = new System.Windows.Forms.ComboBox();
            this._ownerTypeBox = new System.Windows.Forms.ComboBox();
            this._okButton = new System.Windows.Forms.Button();
            this._cancelButton = new System.Windows.Forms.Button();
            this._deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _innLabel
            // 
            this._innLabel.AutoSize = true;
            this._innLabel.Location = new System.Drawing.Point(45, 36);
            this._innLabel.Name = "_innLabel";
            this._innLabel.Size = new System.Drawing.Size(37, 15);
            this._innLabel.TabIndex = 0;
            this._innLabel.Text = "ИНН:";
            // 
            // _fullNameLabel
            // 
            this._fullNameLabel.AutoSize = true;
            this._fullNameLabel.Location = new System.Drawing.Point(45, 61);
            this._fullNameLabel.Name = "_fullNameLabel";
            this._fullNameLabel.Size = new System.Drawing.Size(137, 15);
            this._fullNameLabel.TabIndex = 1;
            this._fullNameLabel.Text = "Полное наименование:";
            // 
            // _kppLabel
            // 
            this._kppLabel.AutoSize = true;
            this._kppLabel.Location = new System.Drawing.Point(45, 87);
            this._kppLabel.Name = "_kppLabel";
            this._kppLabel.Size = new System.Drawing.Size(35, 15);
            this._kppLabel.TabIndex = 2;
            this._kppLabel.Text = "КПП:";
            // 
            // _regAddLabel
            // 
            this._regAddLabel.AutoSize = true;
            this._regAddLabel.Location = new System.Drawing.Point(45, 116);
            this._regAddLabel.Name = "_regAddLabel";
            this._regAddLabel.Size = new System.Drawing.Size(116, 15);
            this._regAddLabel.TabIndex = 3;
            this._regAddLabel.Text = "Адрес регистрации:";
            // 
            // _orgTypeLabel
            // 
            this._orgTypeLabel.AutoSize = true;
            this._orgTypeLabel.Location = new System.Drawing.Point(45, 146);
            this._orgTypeLabel.Name = "_orgTypeLabel";
            this._orgTypeLabel.Size = new System.Drawing.Size(104, 15);
            this._orgTypeLabel.TabIndex = 4;
            this._orgTypeLabel.Text = "Тип организации:";
            // 
            // _ownerTypeLabel
            // 
            this._ownerTypeLabel.AutoSize = true;
            this._ownerTypeLabel.Location = new System.Drawing.Point(45, 178);
            this._ownerTypeLabel.Name = "_ownerTypeLabel";
            this._ownerTypeLabel.Size = new System.Drawing.Size(86, 15);
            this._ownerTypeLabel.TabIndex = 5;
            this._ownerTypeLabel.Text = "ИП/Юр. лицо:";
            this._ownerTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _cityLabel
            // 
            this._cityLabel.AutoSize = true;
            this._cityLabel.Location = new System.Drawing.Point(45, 208);
            this._cityLabel.Name = "_cityLabel";
            this._cityLabel.Size = new System.Drawing.Size(114, 15);
            this._cityLabel.TabIndex = 6;
            this._cityLabel.Text = "Населённый пункт:";
            // 
            // _innTextBox
            // 
            this._innTextBox.Location = new System.Drawing.Point(215, 33);
            this._innTextBox.Name = "_innTextBox";
            this._innTextBox.Size = new System.Drawing.Size(168, 23);
            this._innTextBox.TabIndex = 7;
            // 
            // _fullNameTextBox
            // 
            this._fullNameTextBox.Location = new System.Drawing.Point(215, 58);
            this._fullNameTextBox.Name = "_fullNameTextBox";
            this._fullNameTextBox.Size = new System.Drawing.Size(168, 23);
            this._fullNameTextBox.TabIndex = 8;
            // 
            // _kppTextBox
            // 
            this._kppTextBox.Location = new System.Drawing.Point(215, 84);
            this._kppTextBox.Name = "_kppTextBox";
            this._kppTextBox.Size = new System.Drawing.Size(168, 23);
            this._kppTextBox.TabIndex = 9;
            // 
            // _addressBox
            // 
            this._addressBox.Location = new System.Drawing.Point(215, 113);
            this._addressBox.Name = "_addressBox";
            this._addressBox.Size = new System.Drawing.Size(168, 23);
            this._addressBox.TabIndex = 10;
            // 
            // _cityBox
            // 
            this._cityBox.Location = new System.Drawing.Point(215, 205);
            this._cityBox.Name = "_cityBox";
            this._cityBox.Size = new System.Drawing.Size(168, 23);
            this._cityBox.TabIndex = 11;
            // 
            // _typeOrgBox
            // 
            this._typeOrgBox.FormattingEnabled = true;
            this._typeOrgBox.Location = new System.Drawing.Point(215, 143);
            this._typeOrgBox.Name = "_typeOrgBox";
            this._typeOrgBox.Size = new System.Drawing.Size(168, 23);
            this._typeOrgBox.TabIndex = 12;
            // 
            // _ownerTypeBox
            // 
            this._ownerTypeBox.FormattingEnabled = true;
            this._ownerTypeBox.Location = new System.Drawing.Point(215, 175);
            this._ownerTypeBox.Name = "_ownerTypeBox";
            this._ownerTypeBox.Size = new System.Drawing.Size(168, 23);
            this._ownerTypeBox.TabIndex = 13;
            // 
            // _okButton
            // 
            this._okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._okButton.Location = new System.Drawing.Point(45, 247);
            this._okButton.Name = "_okButton";
            this._okButton.Size = new System.Drawing.Size(131, 23);
            this._okButton.TabIndex = 14;
            this._okButton.Text = "ОК";
            this._okButton.UseVisualStyleBackColor = true;
            // 
            // _cancelButton
            // 
            this._cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._cancelButton.Location = new System.Drawing.Point(182, 247);
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.Size = new System.Drawing.Size(120, 23);
            this._cancelButton.TabIndex = 15;
            this._cancelButton.Text = "Отмена";
            this._cancelButton.UseVisualStyleBackColor = true;
            // 
            // _deleteButton
            // 
            this._deleteButton.Location = new System.Drawing.Point(308, 247);
            this._deleteButton.Name = "_deleteButton";
            this._deleteButton.Size = new System.Drawing.Size(75, 23);
            this._deleteButton.TabIndex = 16;
            this._deleteButton.Text = "Удалить";
            this._deleteButton.UseVisualStyleBackColor = true;
            // 
            // OrganizationCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 318);
            this.Controls.Add(this._deleteButton);
            this.Controls.Add(this._cancelButton);
            this.Controls.Add(this._okButton);
            this.Controls.Add(this._ownerTypeBox);
            this.Controls.Add(this._typeOrgBox);
            this.Controls.Add(this._cityBox);
            this.Controls.Add(this._addressBox);
            this.Controls.Add(this._kppTextBox);
            this.Controls.Add(this._fullNameTextBox);
            this.Controls.Add(this._innTextBox);
            this.Controls.Add(this._cityLabel);
            this.Controls.Add(this._ownerTypeLabel);
            this.Controls.Add(this._orgTypeLabel);
            this.Controls.Add(this._regAddLabel);
            this.Controls.Add(this._kppLabel);
            this.Controls.Add(this._fullNameLabel);
            this.Controls.Add(this._innLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OrganizationCardForm";
            this.Text = "Карточка организации";
            this.ResumeLayout(false);
            this.PerformLayout();

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