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
        private AnimalCard _animal;
        private MunicipalRegistryController _controller;

        public InspectionCardForm(AnimalCard animal, MunicipalRegistryController controller)
        {
            InitializeComponent();
            _controller = controller;
            _animal = animal;
        }

        public InspectionCard GetNewInspection()
        {
            return new InspectionCard()
            {
                InspectedAnimal = _animal,
                AnimalCondition = _animalConditionBox.Text,
                Injures = _injuresBox.Text,
                IsAssignedHelp = _healthBox.Checked,
                IsNeedHelp = _helpBox.Checked,
                SkinCover = _skinBox.Text,
                VetClinic = _vetClinicBox.Text,
                DoctorFIO = _fioBox.Text,
                DoctorPosition = _positionBox.Text,
                BodyTemperature = (float)_temperatureUpDown.Value,
                BehaviourFeatures = _behavioursFeaturesBox.Text,
                InspectionDate = _inspectionPicker.Value,
                Diagnosis = _diagnosisBox.Text,
                WoolCondition = _woolConditionBox.Text,
                Manipulations = _manipulationsBox.Text,
                MunicipalContract = _controller.GetCard(int.Parse(_municipalNumBox.Text))
            };
        }
    }
}
