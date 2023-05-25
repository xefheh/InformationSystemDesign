using System.ComponentModel;
using InformationSystemDesign.Cards;
using InformationSystemDesign.Interfaces;

namespace InformationSystemDesign.Forms
{
    public partial class MunicipalRegistryForm : Form
    {
        private readonly IController<MunicipalCard> _controller;
        private BindingList<MunicipalCard> _sourceList;

        public MunicipalRegistryForm(IController<MunicipalCard> controller)
        {
            InitializeComponent();
            _controller = controller;
            _sourceList = _controller.GetCards();
            _registryView.DataSource = _sourceList;
        }
    }
}