using InformationSystemDesign.Cards;
using InformationSystemDesign.Controllers;

namespace InformationSystemDesign.Forms
{
    public partial class InspectionForm : Form
    {
        private readonly AnimalCard _animalCard;
        private readonly MunicipalRegistryController _controller;

        public InspectionForm(AnimalCard card, MunicipalRegistryController controller)
        {
            InitializeComponent();
            _animalCard = card;
            _controller = controller;
            UpdateDataSource();
        }

        private void _addInspectionButton_Click(object sender, EventArgs e)
        {
            var inspectionCardForm = new InspectionCardForm(_animalCard, _controller);
            if (inspectionCardForm.ShowDialog() != DialogResult.OK) return;
            var inspectionCard = inspectionCardForm.GetNewInspection();
            _animalCard.InspectionCards ??= new List<InspectionCard>();
            _animalCard.InspectionCards.Add(inspectionCard);
            UpdateDataSource();
        }

        private void UpdateDataSource()
        {
            _inspectionGridView.DataSource = null;
            _inspectionGridView.DataSource = _animalCard.InspectionCards.ToList();
        }
    }
}
