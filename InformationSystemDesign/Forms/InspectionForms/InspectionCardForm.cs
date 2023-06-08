using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InformationSystemDesign.Cards;
using InformationSystemDesign.Controllers;

namespace InformationSystemDesign.Forms
{
    public partial class InspectionCardForm : Form
    {
        private readonly AnimalCard _animal;

        public bool DeleteAction { get; private set; }

        public InspectionCardForm(AnimalCard animal)
        {
            DeleteAction = false;
            InitializeComponent();
            _removeButton.Visible = false;
            _animal = animal;
        }

        public InspectionCardForm(InspectionCard inspectionCard)
        {
            DeleteAction = false;
            InitializeComponent();
            _animal = inspectionCard.InspectedAnimal;
            _behavioursFeaturesBox.Text = inspectionCard.BehaviourFeatures;
            _animalConditionBox.Text = inspectionCard.AnimalCondition;
            _temperatureUpDown.Value = (decimal)inspectionCard.BodyTemperature;
            _skinBox.Text = inspectionCard.SkinCover;
            _woolConditionBox.Text = inspectionCard.WoolCondition;
            _injuresBox.Text = inspectionCard.Injures;
            _helpBox.Checked = inspectionCard.IsNeedHelp;
            _diagnosisBox.Text = inspectionCard.Diagnosis;
            _manipulationsBox.Text = inspectionCard.Manipulations;
            _healthBox.Checked = inspectionCard.IsAssignedHelp;
            _inspectionPicker.Value = inspectionCard.InspectionDate;
            _fioBox.Text = inspectionCard.DoctorFIO;
            _positionBox.Text = inspectionCard.DoctorPosition;
            _vetClinicBox.Text = inspectionCard.VetClinic;
            _municipalNumBox.Text = inspectionCard.MunicipalContract.Number.ToString();
        }

        public object[] GetInsectionParams() =>
            new object[]
            {
                _animal, _behavioursFeaturesBox.Text, _animalConditionBox.Text,
                (float)_temperatureUpDown.Value, _skinBox.Text, _woolConditionBox.Text,
                _injuresBox.Text, _helpBox.Checked, _diagnosisBox.Text, _manipulationsBox.Text,
                _healthBox.Checked, _inspectionPicker.Value, _fioBox.Text, _positionBox.Text,
                _vetClinicBox.Text, int.Parse(_municipalNumBox.Text)
            };

        private void _removeButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите\n удалить карту животного?", "Подтверждение",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            DeleteAction = true;
            Close();
        }
    }
}
