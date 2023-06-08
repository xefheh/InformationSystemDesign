using System.ComponentModel;
using InformationSystemDesign.Cards;
using InformationSystemDesign.Exceptions;
using InformationSystemDesign.Forms.InspectionForms;
using InformationSystemDesign.Interfaces;

namespace InformationSystemDesign.Forms.AnimalForms
{
    public partial class AnimalRegistryForm : Form
    {
        private readonly IController<AnimalCard> _controller;
        private readonly IController<InspectionCard> _inspectionRegistryController;
        private readonly BindingList<AnimalCard> _sourceList;

        public AnimalRegistryForm(IController<AnimalCard> controller, IController<InspectionCard> inspectionRegistryController)
        {
            InitializeComponent();
            _controller = controller;
            _sourceList = _controller.GetCards();
            _registryView.DataSource = _sourceList;
            _registryView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _inspectionRegistryController = inspectionRegistryController;
        }

        private void _addButton_Click(object sender, EventArgs e)
        {
            var animalCardForm = new AnimalCardForm(((ILocalityController)_controller).GetLocalities());
            if (animalCardForm.ShowDialog() != DialogResult.OK) return;
            try
            {
                _controller.AddCard(animalCardForm.GetAnimalCardParams());
            }
            catch (PermissionException)
            {
                ShowPermitMessage();
            }
            catch (ValidationException)
            {
                ShowValidationMessage();
            }
        }

        private void _openButton_Click(object sender, EventArgs e)
        {
            if (_sourceList.Count == 0) return;
            var animalCard = GetCardFromSelectedRow();
            OpenCard(animalCard);
        }

        private void OpenCard(AnimalCard animalCard)
        {
            var animalCardForm = new AnimalCardForm(animalCard, ((ILocalityController)_controller).GetLocalities());
            var dialog = animalCardForm.ShowDialog();
            try
            {
                if (animalCardForm.DeleteAction) _controller.RemoveCard(animalCard);
                if (dialog != DialogResult.OK) return;
                _controller.UpdateCard(animalCard, animalCardForm.GetAnimalCardParams());
                UpdateDataSource();
            }
            catch (PermissionException)
            {
                ShowPermitMessage();
            }
            catch (ValidationException)
            {
                ShowValidationMessage();
            }
        }

        private AnimalCard GetCardFromSelectedRow()
        {
            var id = (int)_registryView.CurrentRow.Cells[0].Value;
            return _controller.GetCard(id);
        }

        private void UpdateDataSource()
        {
            _registryView.DataSource = null;
            _registryView.DataSource = _sourceList;
        }

        private void ShowPermitMessage() =>
            MessageBox.Show("Недостаточно прав для данного действия!", "Ошибка", MessageBoxButtons.OK,
                MessageBoxIcon.Error);

        private void ShowValidationMessage() =>
            MessageBox.Show("Поля введены некоректно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

        private void _openByIdButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(_idBox.Text, out var id))
            {
                var animalCard = _controller.GetCard(id);
                if (animalCard != null)
                {
                    OpenCard(animalCard);
                    return;
                }
                MessageBox.Show("Карты с таким номером не существует!", "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Некоректный id!", "Ошибка", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        private void _inspectionButton_Click(object sender, EventArgs e)
        {
            if (_sourceList.Count == 0) return;
            var inspectionForm = new InspectionRegistryForm(GetCardFromSelectedRow(), _inspectionRegistryController);
            inspectionForm.ShowDialog();
        }
    }
}
