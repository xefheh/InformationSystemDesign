namespace InformationSystemDesign.Forms
{
    partial class AnimalCardForm
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
            _labelAddress = new Label();
            _addressTextBox = new TextBox();
            _animalTypeLabel = new Label();
            _animalTypeBox = new ComboBox();
            _sexLabel = new Label();
            _sexBox = new ComboBox();
            _bdLabel = new Label();
            _bdPicker = new DateTimePicker();
            _chipLabel = new Label();
            _chipNumBox = new TextBox();
            _nameLabel = new Label();
            _nameBox = new TextBox();
            _ownerFeaturesGroup = new GroupBox();
            _chipCheck = new CheckBox();
            _harnessCheck = new CheckBox();
            _collarCheck = new CheckBox();
            _clothesCheck = new CheckBox();
            _photoPathBox = new TextBox();
            _photoPathLab = new Label();
            _pathButton = new Button();
            _specBox = new TextBox();
            _specLabel = new Label();
            _okButton = new Button();
            _showBox = new PictureBox();
            _deleteButton = new Button();
            _cancelButton = new Button();
            _ownerFeaturesGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_showBox).BeginInit();
            SuspendLayout();
            // 
            // _labelAddress
            // 
            _labelAddress.AutoSize = true;
            _labelAddress.Location = new Point(12, 20);
            _labelAddress.Name = "_labelAddress";
            _labelAddress.Size = new Size(43, 15);
            _labelAddress.TabIndex = 0;
            _labelAddress.Text = "Адрес:";
            // 
            // _addressTextBox
            // 
            _addressTextBox.Location = new Point(61, 17);
            _addressTextBox.Name = "_addressTextBox";
            _addressTextBox.Size = new Size(100, 23);
            _addressTextBox.TabIndex = 1;
            // 
            // _animalTypeLabel
            // 
            _animalTypeLabel.AutoSize = true;
            _animalTypeLabel.Location = new Point(12, 70);
            _animalTypeLabel.Name = "_animalTypeLabel";
            _animalTypeLabel.Size = new Size(93, 15);
            _animalTypeLabel.TabIndex = 2;
            _animalTypeLabel.Text = "Тип животного:";
            // 
            // _animalTypeBox
            // 
            _animalTypeBox.FormattingEnabled = true;
            _animalTypeBox.Location = new Point(111, 67);
            _animalTypeBox.Name = "_animalTypeBox";
            _animalTypeBox.Size = new Size(121, 23);
            _animalTypeBox.TabIndex = 3;
            // 
            // _sexLabel
            // 
            _sexLabel.AutoSize = true;
            _sexLabel.Location = new Point(34, 111);
            _sexLabel.Name = "_sexLabel";
            _sexLabel.Size = new Size(33, 15);
            _sexLabel.TabIndex = 4;
            _sexLabel.Text = "Пол:";
            // 
            // _sexBox
            // 
            _sexBox.FormattingEnabled = true;
            _sexBox.Location = new Point(111, 108);
            _sexBox.Name = "_sexBox";
            _sexBox.Size = new Size(121, 23);
            _sexBox.TabIndex = 5;
            // 
            // _bdLabel
            // 
            _bdLabel.AutoSize = true;
            _bdLabel.Location = new Point(34, 153);
            _bdLabel.Name = "_bdLabel";
            _bdLabel.Size = new Size(87, 15);
            _bdLabel.TabIndex = 6;
            _bdLabel.Text = "Год рождения:";
            // 
            // _bdPicker
            // 
            _bdPicker.Location = new Point(127, 147);
            _bdPicker.Name = "_bdPicker";
            _bdPicker.Size = new Size(200, 23);
            _bdPicker.TabIndex = 7;
            // 
            // _chipLabel
            // 
            _chipLabel.AutoSize = true;
            _chipLabel.Location = new Point(24, 192);
            _chipLabel.Name = "_chipLabel";
            _chipLabel.Size = new Size(97, 15);
            _chipLabel.TabIndex = 8;
            _chipLabel.Text = "Номер эл. чипа:";
            // 
            // _chipNumBox
            // 
            _chipNumBox.Location = new Point(132, 189);
            _chipNumBox.Name = "_chipNumBox";
            _chipNumBox.Size = new Size(100, 23);
            _chipNumBox.TabIndex = 9;
            // 
            // _nameLabel
            // 
            _nameLabel.AutoSize = true;
            _nameLabel.Location = new Point(24, 233);
            _nameLabel.Name = "_nameLabel";
            _nameLabel.Size = new Size(113, 15);
            _nameLabel.TabIndex = 10;
            _nameLabel.Text = "Кличка животного:";
            // 
            // _nameBox
            // 
            _nameBox.Location = new Point(143, 230);
            _nameBox.Name = "_nameBox";
            _nameBox.Size = new Size(100, 23);
            _nameBox.TabIndex = 11;
            // 
            // _ownerFeaturesGroup
            // 
            _ownerFeaturesGroup.Controls.Add(_chipCheck);
            _ownerFeaturesGroup.Controls.Add(_harnessCheck);
            _ownerFeaturesGroup.Controls.Add(_collarCheck);
            _ownerFeaturesGroup.Controls.Add(_clothesCheck);
            _ownerFeaturesGroup.Location = new Point(359, 17);
            _ownerFeaturesGroup.Name = "_ownerFeaturesGroup";
            _ownerFeaturesGroup.Size = new Size(200, 114);
            _ownerFeaturesGroup.TabIndex = 12;
            _ownerFeaturesGroup.TabStop = false;
            _ownerFeaturesGroup.Text = "Наличие признаков владельца:";
            // 
            // _chipCheck
            // 
            _chipCheck.AutoSize = true;
            _chipCheck.Location = new Point(6, 90);
            _chipCheck.Name = "_chipCheck";
            _chipCheck.Size = new Size(48, 19);
            _chipCheck.TabIndex = 3;
            _chipCheck.Text = "Чип";
            _chipCheck.UseVisualStyleBackColor = true;
            // 
            // _harnessCheck
            // 
            _harnessCheck.AutoSize = true;
            _harnessCheck.Location = new Point(6, 72);
            _harnessCheck.Name = "_harnessCheck";
            _harnessCheck.Size = new Size(69, 19);
            _harnessCheck.TabIndex = 2;
            _harnessCheck.Text = "Шлейка";
            _harnessCheck.UseVisualStyleBackColor = true;
            // 
            // _collarCheck
            // 
            _collarCheck.AutoSize = true;
            _collarCheck.Location = new Point(6, 47);
            _collarCheck.Name = "_collarCheck";
            _collarCheck.Size = new Size(79, 19);
            _collarCheck.TabIndex = 1;
            _collarCheck.Text = "Ошейник";
            _collarCheck.UseVisualStyleBackColor = true;
            // 
            // _clothesCheck
            // 
            _clothesCheck.AutoSize = true;
            _clothesCheck.Location = new Point(6, 22);
            _clothesCheck.Name = "_clothesCheck";
            _clothesCheck.Size = new Size(68, 19);
            _clothesCheck.TabIndex = 0;
            _clothesCheck.Text = "Одежда";
            _clothesCheck.UseVisualStyleBackColor = true;
            // 
            // _photoPathBox
            // 
            _photoPathBox.Location = new Point(123, 313);
            _photoPathBox.Name = "_photoPathBox";
            _photoPathBox.ReadOnly = true;
            _photoPathBox.Size = new Size(162, 23);
            _photoPathBox.TabIndex = 13;
            // 
            // _photoPathLab
            // 
            _photoPathLab.AutoSize = true;
            _photoPathLab.Location = new Point(34, 316);
            _photoPathLab.Name = "_photoPathLab";
            _photoPathLab.Size = new Size(83, 15);
            _photoPathLab.TabIndex = 14;
            _photoPathLab.Text = "Путь до фото:";
            // 
            // _pathButton
            // 
            _pathButton.Location = new Point(39, 342);
            _pathButton.Name = "_pathButton";
            _pathButton.Size = new Size(246, 23);
            _pathButton.TabIndex = 15;
            _pathButton.Text = "Выбрать путь до фото";
            _pathButton.UseVisualStyleBackColor = true;
            _pathButton.Click += _pathButton_Click;
            // 
            // _specBox
            // 
            _specBox.Location = new Point(143, 269);
            _specBox.Name = "_specBox";
            _specBox.Size = new Size(100, 23);
            _specBox.TabIndex = 17;
            // 
            // _specLabel
            // 
            _specLabel.AutoSize = true;
            _specLabel.Location = new Point(24, 272);
            _specLabel.Name = "_specLabel";
            _specLabel.Size = new Size(107, 15);
            _specLabel.TabIndex = 16;
            _specLabel.Text = "Особые приметы:";
            // 
            // _okButton
            // 
            _okButton.DialogResult = DialogResult.OK;
            _okButton.Location = new Point(39, 382);
            _okButton.Name = "_okButton";
            _okButton.Size = new Size(167, 23);
            _okButton.TabIndex = 18;
            _okButton.Text = "ОК";
            _okButton.UseVisualStyleBackColor = true;
            // 
            // _showBox
            // 
            _showBox.Location = new Point(365, 162);
            _showBox.Name = "_showBox";
            _showBox.Size = new Size(423, 276);
            _showBox.SizeMode = PictureBoxSizeMode.StretchImage;
            _showBox.TabIndex = 19;
            _showBox.TabStop = false;
            // 
            // _deleteButton
            // 
            _deleteButton.Location = new Point(636, 12);
            _deleteButton.Name = "_deleteButton";
            _deleteButton.Size = new Size(152, 23);
            _deleteButton.TabIndex = 20;
            _deleteButton.Text = "Удалить карту";
            _deleteButton.UseVisualStyleBackColor = true;
            _deleteButton.Click += _deleteButton_Click;
            // 
            // _cancelButton
            // 
            _cancelButton.DialogResult = DialogResult.Cancel;
            _cancelButton.Location = new Point(212, 382);
            _cancelButton.Name = "_cancelButton";
            _cancelButton.Size = new Size(73, 23);
            _cancelButton.TabIndex = 21;
            _cancelButton.Text = "Назад";
            _cancelButton.UseVisualStyleBackColor = true;
            // 
            // AnimalCardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(_cancelButton);
            Controls.Add(_deleteButton);
            Controls.Add(_showBox);
            Controls.Add(_okButton);
            Controls.Add(_specBox);
            Controls.Add(_specLabel);
            Controls.Add(_pathButton);
            Controls.Add(_photoPathLab);
            Controls.Add(_photoPathBox);
            Controls.Add(_ownerFeaturesGroup);
            Controls.Add(_nameBox);
            Controls.Add(_nameLabel);
            Controls.Add(_chipNumBox);
            Controls.Add(_chipLabel);
            Controls.Add(_bdPicker);
            Controls.Add(_bdLabel);
            Controls.Add(_sexBox);
            Controls.Add(_sexLabel);
            Controls.Add(_animalTypeBox);
            Controls.Add(_animalTypeLabel);
            Controls.Add(_addressTextBox);
            Controls.Add(_labelAddress);
            Name = "AnimalCardForm";
            Text = "AnimalCardForm";
            _ownerFeaturesGroup.ResumeLayout(false);
            _ownerFeaturesGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)_showBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label _labelAddress;
        private TextBox _addressTextBox;
        private Label _animalTypeLabel;
        private ComboBox _animalTypeBox;
        private Label _sexLabel;
        private ComboBox _sexBox;
        private Label _bdLabel;
        private DateTimePicker _bdPicker;
        private Label _chipLabel;
        private TextBox _chipNumBox;
        private Label _nameLabel;
        private TextBox _nameBox;
        private GroupBox _ownerFeaturesGroup;
        private CheckBox _clothesCheck;
        private CheckBox _collarCheck;
        private CheckBox _chipCheck;
        private CheckBox _harnessCheck;
        private TextBox _photoPathBox;
        private Label _photoPathLab;
        private Button _pathButton;
        private TextBox _specBox;
        private Label _specLabel;
        private Button _okButton;
        private PictureBox _showBox;
        private Button _deleteButton;
        private Button _cancelButton;
    }
}