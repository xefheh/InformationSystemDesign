using System.ComponentModel;
using InformationSystemDesign.Cards;
using InformationSystemDesign.Interfaces;

namespace InformationSystemDesign.Forms
{
    public partial class OrganizationRegistryForm : Form
    {
        private readonly IController<OrganizationCard> _controller;
        private BindingList<OrganizationCard> _sourceList;

        public OrganizationRegistryForm(IController<OrganizationCard> controller)
        {
            InitializeComponent();
            _controller = controller;
            _sourceList = _controller.GetCards();
            _registryView.DataSource = _sourceList;
        }
    }
}