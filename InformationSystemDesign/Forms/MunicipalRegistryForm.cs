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

        public MunicipalRegistryForm(IController<MunicipalCard> controller)
        {
            InitializeComponent();
            _controller = controller;
            _sourceList = _controller.GetCards();
            _registryView.DataSource = _sourceList;
            _registryView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void _addButton_Click(object sender, EventArgs e)
        {
            var municipalCardForm = new MunicipalCardForm();
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
        }
}