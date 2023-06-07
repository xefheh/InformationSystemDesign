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
    public partial class OrganizationCardForm : Form
    {
        public OrganizationCardForm()
        {
            InitializeComponent();
            DeleteAction = false;
            _deleteButton.Visible = false;
            _typeOrgBox.DataSource = Enum.GetValues(typeof(OrganizationType));
            _ownerTypeBox.DataSource = Enum.GetValues(typeof(OwnerType));
        }

        public OrganizationCardForm(OrganizationCard organizationCard)
        {
            InitializeComponent();
            DeleteAction = false;
            _typeOrgBox.DataSource = Enum.GetValues(typeof(OrganizationType));
            _ownerTypeBox.DataSource = Enum.GetValues(typeof(OwnerType));
            _typeOrgBox.SelectedText = organizationCard.OrganizationType.ToString();
            _ownerTypeBox.SelectedText = organizationCard.OwnerType.ToString();
            _fullNameTextBox.Text = organizationCard.FullName;
            _innTextBox.Text = organizationCard.INN;
            _kppTextBox.Text = organizationCard.KPP;
            _addressBox.Text = organizationCard.RegAddress;
            _cityBox.Text = organizationCard.City;
        }

        public bool DeleteAction { get; private set; }

        public object[] GetOrganizationCardParams()
        {
            var inn = _innTextBox.Text;
            var fullName = _fullNameTextBox.Text;
            var kpp = _kppTextBox.Text;
            var address = _addressBox.Text;
            var organizationType = Enum.Parse<OrganizationType>(_typeOrgBox.SelectedItem.ToString());
            var ownerType = Enum.Parse<OwnerType>(_ownerTypeBox.SelectedItem.ToString());
            var city = _cityBox.Text;
            return new object[] { inn, fullName, kpp, address, organizationType, ownerType, city };
        }

        private void _deleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите\n удалить карту организации?", "Подтверждение",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            DeleteAction = true;
            Close();
        }
    }
}
