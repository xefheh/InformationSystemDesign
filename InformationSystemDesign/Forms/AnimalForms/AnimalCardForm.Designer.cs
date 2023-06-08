namespace InformationSystemDesign.Forms.AnimalForms
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
            this._labelAddress = new System.Windows.Forms.Label();
            this._animalTypeLabel = new System.Windows.Forms.Label();
            this._animalTypeBox = new System.Windows.Forms.ComboBox();
            this._sexLabel = new System.Windows.Forms.Label();
            this._sexBox = new System.Windows.Forms.ComboBox();
            this._bdLabel = new System.Windows.Forms.Label();
            this._bdPicker = new System.Windows.Forms.DateTimePicker();
            this._chipLabel = new System.Windows.Forms.Label();
            this._chipNumBox = new System.Windows.Forms.TextBox();
            this._nameLabel = new System.Windows.Forms.Label();
            this._nameBox = new System.Windows.Forms.TextBox();
            this._ownerFeaturesGroup = new System.Windows.Forms.GroupBox();
            this._chipCheck = new System.Windows.Forms.CheckBox();
            this._harnessCheck = new System.Windows.Forms.CheckBox();
            this._collarCheck = new System.Windows.Forms.CheckBox();
            this._clothesCheck = new System.Windows.Forms.CheckBox();
            this._photoPathBox = new System.Windows.Forms.TextBox();
            this._photoPathLab = new System.Windows.Forms.Label();
            this._pathButton = new System.Windows.Forms.Button();
            this._specBox = new System.Windows.Forms.TextBox();
            this._specLabel = new System.Windows.Forms.Label();
            this._okButton = new System.Windows.Forms.Button();
            this._showBox = new System.Windows.Forms.PictureBox();
            this._deleteButton = new System.Windows.Forms.Button();
            this._cancelButton = new System.Windows.Forms.Button();
            this._cityBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._ownerFeaturesGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._showBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _labelAddress
            // 
            this._labelAddress.AutoSize = true;
            this._labelAddress.Location = new System.Drawing.Point(24, 15);
            this._labelAddress.Name = "_labelAddress";
            this._labelAddress.Size = new System.Drawing.Size(43, 15);
            this._labelAddress.TabIndex = 0;
            this._labelAddress.Text = "Город:";
            // 
            // _animalTypeLabel
            // 
            this._animalTypeLabel.AutoSize = true;
            this._animalTypeLabel.Location = new System.Drawing.Point(24, 43);
            this._animalTypeLabel.Name = "_animalTypeLabel";
            this._animalTypeLabel.Size = new System.Drawing.Size(93, 15);
            this._animalTypeLabel.TabIndex = 2;
            this._animalTypeLabel.Text = "Тип животного:";
            // 
            // _animalTypeBox
            // 
            this._animalTypeBox.FormattingEnabled = true;
            this._animalTypeBox.Location = new System.Drawing.Point(157, 41);
            this._animalTypeBox.Name = "_animalTypeBox";
            this._animalTypeBox.Size = new System.Drawing.Size(196, 23);
            this._animalTypeBox.TabIndex = 3;
            // 
            // _sexLabel
            // 
            this._sexLabel.AutoSize = true;
            this._sexLabel.Location = new System.Drawing.Point(24, 73);
            this._sexLabel.Name = "_sexLabel";
            this._sexLabel.Size = new System.Drawing.Size(33, 15);
            this._sexLabel.TabIndex = 4;
            this._sexLabel.Text = "Пол:";
            // 
            // _sexBox
            // 
            this._sexBox.FormattingEnabled = true;
            this._sexBox.Location = new System.Drawing.Point(157, 70);
            this._sexBox.Name = "_sexBox";
            this._sexBox.Size = new System.Drawing.Size(196, 23);
            this._sexBox.TabIndex = 5;
            // 
            // _bdLabel
            // 
            this._bdLabel.AutoSize = true;
            this._bdLabel.Location = new System.Drawing.Point(24, 105);
            this._bdLabel.Name = "_bdLabel";
            this._bdLabel.Size = new System.Drawing.Size(87, 15);
            this._bdLabel.TabIndex = 6;
            this._bdLabel.Text = "Год рождения:";
            // 
            // _bdPicker
            // 
            this._bdPicker.Location = new System.Drawing.Point(157, 99);
            this._bdPicker.Name = "_bdPicker";
            this._bdPicker.Size = new System.Drawing.Size(196, 23);
            this._bdPicker.TabIndex = 7;
            // 
            // _chipLabel
            // 
            this._chipLabel.AutoSize = true;
            this._chipLabel.Location = new System.Drawing.Point(20, 131);
            this._chipLabel.Name = "_chipLabel";
            this._chipLabel.Size = new System.Drawing.Size(97, 15);
            this._chipLabel.TabIndex = 8;
            this._chipLabel.Text = "Номер эл. чипа:";
            // 
            // _chipNumBox
            // 
            this._chipNumBox.Location = new System.Drawing.Point(157, 128);
            this._chipNumBox.Name = "_chipNumBox";
            this._chipNumBox.Size = new System.Drawing.Size(196, 23);
            this._chipNumBox.TabIndex = 9;
            // 
            // _nameLabel
            // 
            this._nameLabel.AutoSize = true;
            this._nameLabel.Location = new System.Drawing.Point(24, 160);
            this._nameLabel.Name = "_nameLabel";
            this._nameLabel.Size = new System.Drawing.Size(113, 15);
            this._nameLabel.TabIndex = 10;
            this._nameLabel.Text = "Кличка животного:";
            // 
            // _nameBox
            // 
            this._nameBox.Location = new System.Drawing.Point(157, 157);
            this._nameBox.Name = "_nameBox";
            this._nameBox.Size = new System.Drawing.Size(196, 23);
            this._nameBox.TabIndex = 11;
            // 
            // _ownerFeaturesGroup
            // 
            this._ownerFeaturesGroup.Controls.Add(this._chipCheck);
            this._ownerFeaturesGroup.Controls.Add(this._harnessCheck);
            this._ownerFeaturesGroup.Controls.Add(this._collarCheck);
            this._ownerFeaturesGroup.Controls.Add(this._clothesCheck);
            this._ownerFeaturesGroup.Location = new System.Drawing.Point(359, 3);
            this._ownerFeaturesGroup.Name = "_ownerFeaturesGroup";
            this._ownerFeaturesGroup.Size = new System.Drawing.Size(260, 129);
            this._ownerFeaturesGroup.TabIndex = 12;
            this._ownerFeaturesGroup.TabStop = false;
            this._ownerFeaturesGroup.Text = "Наличие признаков владельца:";
            // 
            // _chipCheck
            // 
            this._chipCheck.AutoSize = true;
            this._chipCheck.Location = new System.Drawing.Point(6, 97);
            this._chipCheck.Name = "_chipCheck";
            this._chipCheck.Size = new System.Drawing.Size(48, 19);
            this._chipCheck.TabIndex = 3;
            this._chipCheck.Text = "Чип";
            this._chipCheck.UseVisualStyleBackColor = true;
            this._chipCheck.CheckedChanged += new System.EventHandler(this._chipCheck_CheckedChanged);
            // 
            // _harnessCheck
            // 
            this._harnessCheck.AutoSize = true;
            this._harnessCheck.Location = new System.Drawing.Point(6, 72);
            this._harnessCheck.Name = "_harnessCheck";
            this._harnessCheck.Size = new System.Drawing.Size(69, 19);
            this._harnessCheck.TabIndex = 2;
            this._harnessCheck.Text = "Шлейка";
            this._harnessCheck.UseVisualStyleBackColor = true;
            // 
            // _collarCheck
            // 
            this._collarCheck.AutoSize = true;
            this._collarCheck.Location = new System.Drawing.Point(6, 47);
            this._collarCheck.Name = "_collarCheck";
            this._collarCheck.Size = new System.Drawing.Size(79, 19);
            this._collarCheck.TabIndex = 1;
            this._collarCheck.Text = "Ошейник";
            this._collarCheck.UseVisualStyleBackColor = true;
            // 
            // _clothesCheck
            // 
            this._clothesCheck.AutoSize = true;
            this._clothesCheck.Location = new System.Drawing.Point(7, 22);
            this._clothesCheck.Name = "_clothesCheck";
            this._clothesCheck.Size = new System.Drawing.Size(68, 19);
            this._clothesCheck.TabIndex = 0;
            this._clothesCheck.Text = "Одежда";
            this._clothesCheck.UseVisualStyleBackColor = true;
            // 
            // _photoPathBox
            // 
            this._photoPathBox.Location = new System.Drawing.Point(157, 313);
            this._photoPathBox.Name = "_photoPathBox";
            this._photoPathBox.ReadOnly = true;
            this._photoPathBox.Size = new System.Drawing.Size(162, 23);
            this._photoPathBox.TabIndex = 13;
            // 
            // _photoPathLab
            // 
            this._photoPathLab.AutoSize = true;
            this._photoPathLab.Location = new System.Drawing.Point(68, 316);
            this._photoPathLab.Name = "_photoPathLab";
            this._photoPathLab.Size = new System.Drawing.Size(83, 15);
            this._photoPathLab.TabIndex = 14;
            this._photoPathLab.Text = "Путь до фото:";
            // 
            // _pathButton
            // 
            this._pathButton.Location = new System.Drawing.Point(24, 342);
            this._pathButton.Name = "_pathButton";
            this._pathButton.Size = new System.Drawing.Size(329, 23);
            this._pathButton.TabIndex = 15;
            this._pathButton.Text = "Выбрать путь до фото";
            this._pathButton.UseVisualStyleBackColor = true;
            this._pathButton.Click += new System.EventHandler(this._pathButton_Click);
            // 
            // _specBox
            // 
            this._specBox.Location = new System.Drawing.Point(157, 184);
            this._specBox.Name = "_specBox";
            this._specBox.Size = new System.Drawing.Size(196, 23);
            this._specBox.TabIndex = 17;
            // 
            // _specLabel
            // 
            this._specLabel.AutoSize = true;
            this._specLabel.Location = new System.Drawing.Point(24, 187);
            this._specLabel.Name = "_specLabel";
            this._specLabel.Size = new System.Drawing.Size(107, 15);
            this._specLabel.TabIndex = 16;
            this._specLabel.Text = "Особые приметы:";
            // 
            // _okButton
            // 
            this._okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._okButton.Location = new System.Drawing.Point(24, 371);
            this._okButton.Name = "_okButton";
            this._okButton.Size = new System.Drawing.Size(167, 23);
            this._okButton.TabIndex = 18;
            this._okButton.Text = "ОК";
            this._okButton.UseVisualStyleBackColor = true;
            // 
            // _showBox
            // 
            this._showBox.Location = new System.Drawing.Point(9, 19);
            this._showBox.Name = "_showBox";
            this._showBox.Size = new System.Drawing.Size(423, 276);
            this._showBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._showBox.TabIndex = 19;
            this._showBox.TabStop = false;
            // 
            // _deleteButton
            // 
            this._deleteButton.Location = new System.Drawing.Point(625, 43);
            this._deleteButton.Name = "_deleteButton";
            this._deleteButton.Size = new System.Drawing.Size(152, 23);
            this._deleteButton.TabIndex = 20;
            this._deleteButton.Text = "Удалить карту";
            this._deleteButton.UseVisualStyleBackColor = true;
            this._deleteButton.Click += new System.EventHandler(this._deleteButton_Click);
            // 
            // _cancelButton
            // 
            this._cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._cancelButton.Location = new System.Drawing.Point(197, 371);
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.Size = new System.Drawing.Size(156, 23);
            this._cancelButton.TabIndex = 21;
            this._cancelButton.Text = "Назад";
            this._cancelButton.UseVisualStyleBackColor = true;
            // 
            // _cityBox
            // 
            this._cityBox.FormattingEnabled = true;
            this._cityBox.Location = new System.Drawing.Point(157, 12);
            this._cityBox.Name = "_cityBox";
            this._cityBox.Size = new System.Drawing.Size(196, 23);
            this._cityBox.TabIndex = 23;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._showBox);
            this.groupBox1.Location = new System.Drawing.Point(359, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 301);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фотография:";
            // 
            // AnimalCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this._cityBox);
            this.Controls.Add(this._cancelButton);
            this.Controls.Add(this._deleteButton);
            this.Controls.Add(this._okButton);
            this.Controls.Add(this._specBox);
            this.Controls.Add(this._specLabel);
            this.Controls.Add(this._pathButton);
            this.Controls.Add(this._photoPathLab);
            this.Controls.Add(this._photoPathBox);
            this.Controls.Add(this._ownerFeaturesGroup);
            this.Controls.Add(this._nameBox);
            this.Controls.Add(this._nameLabel);
            this.Controls.Add(this._chipNumBox);
            this.Controls.Add(this._chipLabel);
            this.Controls.Add(this._bdPicker);
            this.Controls.Add(this._bdLabel);
            this.Controls.Add(this._sexBox);
            this.Controls.Add(this._sexLabel);
            this.Controls.Add(this._animalTypeBox);
            this.Controls.Add(this._animalTypeLabel);
            this.Controls.Add(this._labelAddress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AnimalCardForm";
            this.Text = "Карточка животного ";
            this._ownerFeaturesGroup.ResumeLayout(false);
            this._ownerFeaturesGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._showBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label _labelAddress;
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
        private ComboBox _cityBox;
        private GroupBox groupBox1;
    }
}