using System.ComponentModel;
using InformationSystemDesign.Cards;
using InformationSystemDesign.Exceptions;
using InformationSystemDesign.Interfaces;

namespace InformationSystemDesign.Forms
{
    public partial class InspectionRegistryForm : Form
    {
        private readonly AnimalCard _animalCard;
        private readonly IController<InspectionCard> _controller;
        private readonly BindingList<InspectionCard> _sourceList;

        public InspectionRegistryForm(AnimalCard card, IController<InspectionCard> controller)
        {
            InitializeComponent();
            _registryView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _animalCard = card;
            _controller = controller;
            _sourceList = _controller.GetCards();
            UpdateDataSource();
        }
        
        private void _addInspectionButton_Click(object sender, EventArgs e)
        {
            var inspectionCardForm = new InspectionCardForm(_animalCard);
            if (inspectionCardForm.ShowDialog() != DialogResult.OK) return;
            var inspectionCardParams = inspectionCardForm.GetInsectionParams();
            try
            {
                _controller.AddCard(inspectionCardParams);
            }
            catch (NullCardException)
            {
                MessageBox.Show($"Контракта с номером: {inspectionCardParams[15]} не существует!",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (PermissionException)
            {
                ShowPermitMessage();
            }
            catch (ValidationException)
            {
                ShowValidationMessage();
            }
            UpdateDataSource();
        }

        private void ShowValidationMessage() =>
            MessageBox.Show("Поля введены некоректно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

        private void UpdateDataSource()
        {
            _registryView.DataSource = null;
            _registryView.DataSource = _sourceList.Where(inspectionCard =>
                inspectionCard.InspectedAnimal == _animalCard).ToList();
        }

        private void _openButton_Click(object sender, EventArgs e)
        {
            if(_sourceList.Count == 0) return;
            var inspectionCard = GetCardFromSelectedRow();
            OpenCard(inspectionCard);
        }

        private InspectionCard GetCardFromSelectedRow()
        {
            var i = _registryView.CurrentRow.Index;
            return _sourceList[i];
        }

        private void ShowPermitMessage() =>
            MessageBox.Show("Недостаточно прав для данного действия!", "Ошибка", MessageBoxButtons.OK,
                MessageBoxIcon.Error);

        private void OpenCard(InspectionCard inspectionCard)
        {
            var inspectionCardForm = new InspectionCardForm(inspectionCard);
            var dialog = inspectionCardForm.ShowDialog();
            try
            {
                if (inspectionCardForm.DeleteAction)
                {
                    _controller.RemoveCard(inspectionCard);
                    UpdateDataSource();
                }

                if (dialog != DialogResult.OK) return;
                _controller.UpdateCard(inspectionCard, inspectionCardForm.GetInsectionParams());
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
    }
}
