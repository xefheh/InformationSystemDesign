using System.ComponentModel;
using InformationSystemDesign.Cards;
using InformationSystemDesign.Enumerators;

namespace InformationSystemDesign.Forms.AnimalForms
{
    public partial class AnimalCardForm : Form
    {
        private string _pathToPhoto;
        private byte[] _photo;
        public bool DeleteAction { get; private set; }

        public AnimalCardForm(BindingList<LocalityCard> localities)
        {
            DeleteAction = true;
            _photo = Array.Empty<byte>();
            InitializeComponent();
            _chipCheck_CheckedChanged(null, null);
            _cityBox.DataSource = localities;
            _deleteButton.Visible = false;
            _animalTypeBox.DataSource = Enum.GetValues(typeof(AnimalType));
            _sexBox.DataSource = Enum.GetValues(typeof(Sex));
        }

        public AnimalCardForm(AnimalCard animalCard, BindingList<LocalityCard> localities)
        {
            DeleteAction = false;
            InitializeComponent();
            _chipCheck_CheckedChanged(null, null);
            _cityBox.DataSource = localities;
            _animalTypeBox.DataSource = Enum.GetValues(typeof(AnimalType));
            _sexBox.DataSource = Enum.GetValues(typeof(Sex));
            _animalTypeBox.SelectedItem = animalCard.AnimalType;
            _sexBox.SelectedItem = animalCard.Sex;
            _cityBox.SelectedItem = animalCard.Locality;
            _photo = animalCard.Photo;
            foreach (var controller in _ownerFeaturesGroup.Controls.OfType<CheckBox>())
                controller.Checked =
                    animalCard.InternOwnerFeatures.Any(features => features.ToString() == controller.Text);
            _nameBox.Text = animalCard.Name;
            _bdPicker.Value = animalCard.BirthDate;
            _specBox.Text = animalCard.SpecialSigns;
            _chipNumBox.Text = animalCard.ChipNumber.ToString();
            using var ms = new MemoryStream(_photo);
            _showBox.Image = Image.FromStream(ms);
        }

        public object[] GetAnimalCardParams()
        {
            var animalType = Enum.Parse<AnimalType>(_animalTypeBox.SelectedItem.ToString());
            var sex = Enum.Parse<Sex>(_sexBox.SelectedItem.ToString());
            var address = (LocalityCard)_cityBox.SelectedItem;
            if (_pathToPhoto != null) _photo = File.ReadAllBytes(_pathToPhoto);
            int? chipNumber = (int.TryParse(_chipNumBox.Text, out var outNumber)) ? outNumber : null;
            var name = _nameBox.Text;
            var birthDate = _bdPicker.Value;
            var specialFeatures = _specBox.Text;
            var ownerFeatures = string.Join(",", _ownerFeaturesGroup.Controls.OfType<CheckBox>()
                .Where(control => control.Checked)
                .Select(control => Enum.Parse<OwnerFeatures>(control.Text))) + ",";
            return new object[]
            {
                address, animalType, sex, birthDate, chipNumber, name, _photo,
                specialFeatures, ownerFeatures
            };
        }


        private void _pathButton_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog
            {
                Filter = "Images|*.png;*.jpeg;*.gif;*.bmp;*.jpg"
            };
            if (ofd.ShowDialog() != DialogResult.OK) return;
            _pathToPhoto = ofd.FileName;
            _photoPathBox.Text = _pathToPhoto;
            _photo = File.ReadAllBytes(_pathToPhoto);
            using var ms = new MemoryStream(_photo);
            _showBox.Image = Image.FromStream(ms);
        }

        private void _deleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите\n удалить карту животного?", "Подтверждение",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            DeleteAction = true;
            Close();
        }

        private void _chipCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (_chipCheck.Checked)
            {
                _chipNumBox.Enabled = true;
            }
            else
            {
                _chipNumBox.Enabled = false;
                _chipNumBox.Text = "0";
            }
        }
    }
}
