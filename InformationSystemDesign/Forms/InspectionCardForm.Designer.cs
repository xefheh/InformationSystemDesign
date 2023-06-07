namespace InformationSystemDesign.Forms
{
    partial class InspectionCardForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            _behavioursFeaturesBox = new TextBox();
            _animalConditionBox = new TextBox();
            _temperatureUpDown = new NumericUpDown();
            _skinBox = new TextBox();
            _woolConditionBox = new TextBox();
            label12 = new Label();
            _injuresBox = new TextBox();
            _helpBox = new CheckBox();
            _diagnosisBox = new TextBox();
            label6 = new Label();
            _manipulationsBox = new TextBox();
            label7 = new Label();
            _healthBox = new CheckBox();
            _fioBox = new TextBox();
            label8 = new Label();
            _positionBox = new TextBox();
            label9 = new Label();
            _vetClinicBox = new TextBox();
            label10 = new Label();
            _municipalNumBox = new TextBox();
            label11 = new Label();
            label13 = new Label();
            _inspectionPicker = new DateTimePicker();
            _okButton = new Button();
            _cancenButton = new Button();
            ((System.ComponentModel.ISupportInitialize)_temperatureUpDown).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 22);
            label1.Name = "label1";
            label1.Size = new Size(145, 15);
            label1.TabIndex = 0;
            label1.Text = "Особенности поведения:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 55);
            label2.Name = "label2";
            label2.Size = new Size(132, 15);
            label2.TabIndex = 1;
            label2.Text = "Состояние животного:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 95);
            label3.Name = "label3";
            label3.Size = new Size(108, 15);
            label3.TabIndex = 2;
            label3.Text = "Температура тела:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(61, 130);
            label4.Name = "label4";
            label4.Size = new Size(107, 15);
            label4.TabIndex = 3;
            label4.Text = "Кожные покровы:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(61, 192);
            label5.Name = "label5";
            label5.Size = new Size(88, 15);
            label5.TabIndex = 4;
            label5.Text = "Травмы, Раны:";
            // 
            // _behavioursFeaturesBox
            // 
            _behavioursFeaturesBox.Location = new Point(194, 19);
            _behavioursFeaturesBox.Name = "_behavioursFeaturesBox";
            _behavioursFeaturesBox.Size = new Size(449, 23);
            _behavioursFeaturesBox.TabIndex = 11;
            // 
            // _animalConditionBox
            // 
            _animalConditionBox.Location = new Point(194, 55);
            _animalConditionBox.Name = "_animalConditionBox";
            _animalConditionBox.Size = new Size(449, 23);
            _animalConditionBox.TabIndex = 12;
            // 
            // _temperatureUpDown
            // 
            _temperatureUpDown.DecimalPlaces = 1;
            _temperatureUpDown.Location = new Point(194, 93);
            _temperatureUpDown.Maximum = new decimal(new int[] { 45, 0, 0, 0 });
            _temperatureUpDown.Name = "_temperatureUpDown";
            _temperatureUpDown.Size = new Size(449, 23);
            _temperatureUpDown.TabIndex = 13;
            // 
            // _skinBox
            // 
            _skinBox.Location = new Point(194, 122);
            _skinBox.Name = "_skinBox";
            _skinBox.Size = new Size(449, 23);
            _skinBox.TabIndex = 14;
            // 
            // _woolConditionBox
            // 
            _woolConditionBox.Location = new Point(194, 151);
            _woolConditionBox.Name = "_woolConditionBox";
            _woolConditionBox.Size = new Size(449, 23);
            _woolConditionBox.TabIndex = 16;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(61, 151);
            label12.Name = "label12";
            label12.Size = new Size(114, 15);
            label12.TabIndex = 15;
            label12.Text = "Состояние шерcти:";
            // 
            // _injuresBox
            // 
            _injuresBox.Location = new Point(194, 184);
            _injuresBox.Name = "_injuresBox";
            _injuresBox.Size = new Size(449, 23);
            _injuresBox.TabIndex = 17;
            // 
            // _helpBox
            // 
            _helpBox.AutoSize = true;
            _helpBox.Location = new Point(66, 220);
            _helpBox.Name = "_helpBox";
            _helpBox.Size = new Size(146, 19);
            _helpBox.TabIndex = 19;
            _helpBox.Text = "Необходима помощь";
            _helpBox.UseVisualStyleBackColor = true;
            // 
            // _diagnosisBox
            // 
            _diagnosisBox.Location = new Point(214, 245);
            _diagnosisBox.Name = "_diagnosisBox";
            _diagnosisBox.Size = new Size(449, 23);
            _diagnosisBox.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(61, 253);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 20;
            label6.Text = "Диагноз:";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // _manipulationsBox
            // 
            _manipulationsBox.Location = new Point(214, 269);
            _manipulationsBox.Name = "_manipulationsBox";
            _manipulationsBox.Size = new Size(449, 23);
            _manipulationsBox.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(43, 277);
            label7.Name = "label7";
            label7.Size = new Size(165, 15);
            label7.TabIndex = 22;
            label7.Text = "Проведённые манипуляции:";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // _healthBox
            // 
            _healthBox.AutoSize = true;
            _healthBox.Location = new Point(62, 308);
            _healthBox.Name = "_healthBox";
            _healthBox.Size = new Size(131, 19);
            _healthBox.TabIndex = 24;
            _healthBox.Text = "Выписано лечение";
            _healthBox.UseVisualStyleBackColor = true;
            // 
            // _fioBox
            // 
            _fioBox.Location = new Point(216, 356);
            _fioBox.Name = "_fioBox";
            _fioBox.Size = new Size(449, 23);
            _fioBox.TabIndex = 26;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(63, 364);
            label8.Name = "label8";
            label8.Size = new Size(86, 15);
            label8.TabIndex = 25;
            label8.Text = "ФИО Доктора:";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // _positionBox
            // 
            _positionBox.Location = new Point(216, 385);
            _positionBox.Name = "_positionBox";
            _positionBox.Size = new Size(449, 23);
            _positionBox.TabIndex = 28;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(63, 393);
            label9.Name = "label9";
            label9.Size = new Size(119, 15);
            label9.TabIndex = 27;
            label9.Text = "Должность доктора:";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // _vetClinicBox
            // 
            _vetClinicBox.Location = new Point(216, 414);
            _vetClinicBox.Name = "_vetClinicBox";
            _vetClinicBox.Size = new Size(449, 23);
            _vetClinicBox.TabIndex = 30;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(63, 422);
            label10.Name = "label10";
            label10.Size = new Size(75, 15);
            label10.TabIndex = 29;
            label10.Text = "ВетКлиника:";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // _municipalNumBox
            // 
            _municipalNumBox.Location = new Point(253, 443);
            _municipalNumBox.Name = "_municipalNumBox";
            _municipalNumBox.Size = new Size(449, 23);
            _municipalNumBox.TabIndex = 32;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(43, 446);
            label11.Name = "label11";
            label11.Size = new Size(204, 15);
            label11.TabIndex = 31;
            label11.Text = "Номер муниципального контракта:";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(61, 330);
            label13.Name = "label13";
            label13.Size = new Size(85, 15);
            label13.TabIndex = 33;
            label13.Text = "Дата осмотра:";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // _inspectionPicker
            // 
            _inspectionPicker.Location = new Point(214, 327);
            _inspectionPicker.Name = "_inspectionPicker";
            _inspectionPicker.Size = new Size(200, 23);
            _inspectionPicker.TabIndex = 34;
            // 
            // _okButton
            // 
            _okButton.DialogResult = DialogResult.OK;
            _okButton.Location = new Point(205, 472);
            _okButton.Name = "_okButton";
            _okButton.Size = new Size(75, 23);
            _okButton.TabIndex = 35;
            _okButton.Text = "ОК";
            _okButton.UseVisualStyleBackColor = true;
            // 
            // _cancenButton
            // 
            _cancenButton.DialogResult = DialogResult.Cancel;
            _cancenButton.Location = new Point(406, 472);
            _cancenButton.Name = "_cancenButton";
            _cancenButton.Size = new Size(75, 23);
            _cancenButton.TabIndex = 36;
            _cancenButton.Text = "Отмена";
            _cancenButton.UseVisualStyleBackColor = true;
            // 
            // InspectionCardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 500);
            Controls.Add(_cancenButton);
            Controls.Add(_okButton);
            Controls.Add(_inspectionPicker);
            Controls.Add(label13);
            Controls.Add(_municipalNumBox);
            Controls.Add(label11);
            Controls.Add(_vetClinicBox);
            Controls.Add(label10);
            Controls.Add(_positionBox);
            Controls.Add(label9);
            Controls.Add(_fioBox);
            Controls.Add(label8);
            Controls.Add(_healthBox);
            Controls.Add(_manipulationsBox);
            Controls.Add(label7);
            Controls.Add(_diagnosisBox);
            Controls.Add(label6);
            Controls.Add(_helpBox);
            Controls.Add(_injuresBox);
            Controls.Add(_woolConditionBox);
            Controls.Add(label12);
            Controls.Add(_skinBox);
            Controls.Add(_temperatureUpDown);
            Controls.Add(_animalConditionBox);
            Controls.Add(_behavioursFeaturesBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "InspectionCardForm";
            Text = "InspectionCardForm";
            ((System.ComponentModel.ISupportInitialize)_temperatureUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox _behavioursFeaturesBox;
        private TextBox _animalConditionBox;
        private NumericUpDown _temperatureUpDown;
        private TextBox _skinBox;
        private TextBox _woolConditionBox;
        private Label label12;
        private TextBox _injuresBox;
        private CheckBox _helpBox;
        private TextBox _diagnosisBox;
        private Label label6;
        private TextBox _manipulationsBox;
        private Label label7;
        private CheckBox _healthBox;
        private TextBox _fioBox;
        private Label label8;
        private TextBox _positionBox;
        private Label label9;
        private TextBox _vetClinicBox;
        private Label label10;
        private TextBox _municipalNumBox;
        private Label label11;
        private Label label13;
        private DateTimePicker _inspectionPicker;
        private Button _okButton;
        private Button _cancenButton;
    }
}