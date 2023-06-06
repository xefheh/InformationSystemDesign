using System.ComponentModel;
using InformationSystemDesign.Cards;
using InformationSystemDesign.Interfaces;

namespace InformationSystemDesign.Forms
{
    public partial class AnimalRegistryForm : Form
    {
        private readonly IController<AnimalCard> _controller;
        private BindingList<AnimalCard> _sourceList;

        public AnimalRegistryForm(IController<AnimalCard> controller)
        {
            InitializeComponent();
            _controller = controller;
            _sourceList = _controller.GetCards();
            _registryView.DataSource = _sourceList;
        }

        private void _addButton_Click(object sender, EventArgs e)
        {
            var animalCardForm = new AnimalCardForm();
            if (animalCardForm.ShowDialog() == DialogResult.OK)
                _controller.AddCard(animalCardForm.AnimalCard);
        }
    }
}
