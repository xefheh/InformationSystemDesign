using System.ComponentModel;
using InformationSystemDesign.Cards;
using InformationSystemDesign.Exceptions;
using InformationSystemDesign.Interfaces;

namespace InformationSystemDesign.Forms.OrganizationForms
{
    public partial class OrganizationRegistryForm : Form
    {
        private readonly IController<OrganizationCard> _controller;
        private readonly BindingList<OrganizationCard> _sourceList;

        public OrganizationRegistryForm(IController<OrganizationCard> controller)
        {
            InitializeComponent();
            _controller = controller;
            _sourceList = _controller.GetCards();
            _registryView.DataSource = _sourceList;
            _registryView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void _addButton_Click(object sender, EventArgs e)
        {
            var organizationCardForm = new OrganizationCardForm();
            if (organizationCardForm.ShowDialog() != DialogResult.OK) return;
            try
            {
                _controller.AddCard(organizationCardForm.GetOrganizationCardParams());
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
            var organizationCard = GetCardFromSelectedRow();
            OpenCard(organizationCard);
        }

        private void OpenCard(OrganizationCard organizationCard)
        {
            var organizationCardForm = new OrganizationCardForm(organizationCard);
            var dialog = organizationCardForm.ShowDialog();
            try
            {
                if (organizationCardForm.DeleteAction) _controller.RemoveCard(organizationCard);
                if (dialog != DialogResult.OK) return;
                _controller.UpdateCard(organizationCard, organizationCardForm.GetOrganizationCardParams());
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

        private OrganizationCard GetCardFromSelectedRow()
        {
            var id = (string)_registryView.CurrentRow.Cells[0].Value;
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
            var organizationCard = _controller.GetCard(_idBox.Text);
            if (organizationCard != null)
            {
                OpenCard(organizationCard);
                return;
            }
            MessageBox.Show("Карты с таким номером не существует!", "Ошибка", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
}