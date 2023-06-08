using System.ComponentModel;
using InformationSystemDesign.Cards;
using InformationSystemDesign.Controllers;
using InformationSystemDesign.Interfaces;

namespace InformationSystemDesign.Forms
{
    public partial class MunicipalRegistryForm : Form
    {
        private readonly IController<MunicipalCard> _controller;
        private readonly BindingList<MunicipalCard> _sourceList;
        private readonly BindingList<LocalityCard> _localityList;

        public MunicipalRegistryForm(IController<MunicipalCard> controller)
        {
            InitializeComponent();
            _controller = controller;
            _sourceList = _controller.GetCards();
            _localityList = ((MunicipalRegistryController)_controller).GetLocalities();
            _registryView.DataSource = _sourceList;
            _registryView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void _addButton_Click(object sender, EventArgs e)
        {
            var municipalCardForm = new MunicipalCardForm(((MunicipalRegistryController)_controller).GetLocalities());
            if (municipalCardForm.ShowDialog() != DialogResult.OK) return;
            try
            {
                _controller.AddCard(municipalCardForm.GetMunicipalCardParams());
            }
            catch (PermissionException)
            {
                ShowPermitMessage();
            }
        }

        private void _openButton_Click(object sender, EventArgs e)
        {
            if (_registryView.SelectedRows.Count == 0) return;
            var municipalCard = GetCardFromSelectedRow();
            OpenCard(municipalCard);
        }

        private void OpenCard(MunicipalCard municipalCard)
        {
            var municipalCardForm = new MunicipalCardForm(municipalCard);
            var dialog = municipalCardForm.ShowDialog();
            try
            {
                if (municipalCardForm.DeleteAction) _controller.RemoveCard(municipalCard);
                if (dialog != DialogResult.OK) return;
                _controller.UpdateCard(municipalCard, municipalCardForm.GetMunicipalCardParams());
                UpdateDataSource();
            }
            catch (PermissionException)
            {
                ShowPermitMessage();
            }
        }

        private MunicipalCard GetCardFromSelectedRow()
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

        private void _openByIdButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(_idBox.Text, out var id))
            {
                var municipalCard = _controller.GetCard(id);
                if (municipalCard != null)
                {
                    OpenCard(municipalCard);
                    return;
                }
                MessageBox.Show("Карты с таким номером не существует!", "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Некоректный id!", "Ошибка", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
}