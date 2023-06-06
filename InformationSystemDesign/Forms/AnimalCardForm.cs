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
using InformationSystemDesign.Enumerators;

namespace InformationSystemDesign.Forms
{
    public partial class AnimalCardForm : Form
    {
        public AnimalCard AnimalCard { get; private set; }
        private string _pathToPhoto;

        public AnimalCardForm()
        {
            InitializeComponent();
            _animalTypeBox.DataSource = Enum.GetValues(typeof(AnimalType));
            _sexBox.DataSource = Enum.GetValues(typeof(Sex));
        }

        public void CreateAnimalCard()
        {
            var animalType = Enum.Parse<AnimalType>(_animalTypeBox.SelectedText);
            var sex = Enum.Parse<Sex>(_sexBox.SelectedText);
            var address = _addressTextBox.Text;
            var photo = File.ReadAllBytes(_pathToPhoto);
            var chipNumber = int.Parse(_chipLabel.Text);
            var name = _nameBox.Text;
            var birthDate = _bdPicker.Value;
            var specialFeatures = _specBox.Text;
            var ownerFeatures = string.Join(",", _ownerFeaturesGroup.Controls.OfType<CheckBox>()
                .Where(control => control.Checked)
                .Select(control => Enum.Parse<OwnerFeatures>(control.Name)));
            AnimalCard = new AnimalCard(address, animalType, sex, birthDate, chipNumber, name, photo,
                specialFeatures, ownerFeatures);
        }

        private void _pathButton_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            if (ofd.ShowDialog() != DialogResult.OK) return;
            _pathToPhoto = ofd.FileName;
            _photoPathBox.Text = _pathToPhoto;
        }
    }
}
