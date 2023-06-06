using InformationSystemDesign.Cards;
using InformationSystemDesign.Enumerators;
using System.Data;

namespace InformationSystemDesign.Forms
{
    public partial class AnimalCardForm : Form
    {
        private string _pathToPhoto;
        private byte[] _photo;
        public bool DeleteAction { get; private set; }

        public AnimalCardForm()
        {
            DeleteAction = true;
            InitializeComponent();
            _deleteButton.Visible = false;
            _animalTypeBox.DataSource = Enum.GetValues(typeof(AnimalType));
            _sexBox.DataSource = Enum.GetValues(typeof(Sex));
        }

        public AnimalCardForm(AnimalCard animalCard)
        {
            DeleteAction = false;
            InitializeComponent();
            _animalTypeBox.DataSource = Enum.GetValues(typeof(AnimalType));
            _sexBox.DataSource = Enum.GetValues(typeof(Sex));
            _animalTypeBox.SelectedItem = animalCard.AnimalType;
            _sexBox.SelectedItem = animalCard.Sex;
            _addressTextBox.Text = animalCard.Address;
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
            var address = _addressTextBox.Text;
            if (_pathToPhoto != null)
                _photo = File.ReadAllBytes(_pathToPhoto);
            var chipNumber = int.Parse(_chipNumBox.Text);
            var name = _nameBox.Text;
            var birthDate = _bdPicker.Value;
            var specialFeatures = _specBox.Text;
            var ownerFeatures = string.Join(",", _ownerFeaturesGroup.Controls.OfType<CheckBox>()
                .Where(control => control.Checked)
                .Select(control => Enum.Parse<OwnerFeatures>(control.Text)));
            return new object[]
            {
                address, animalType, sex, birthDate, chipNumber, name, _photo,
                specialFeatures, ownerFeatures
            };
        }


        private void _pathButton_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "Images|*.png;*.jpeg;*.gif;*.bmp;*.jpg";
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
    }
}
