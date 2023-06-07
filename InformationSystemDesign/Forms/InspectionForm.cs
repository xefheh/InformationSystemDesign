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

namespace InformationSystemDesign.Forms
{
    public partial class InspectionForm : Form
    {
        private readonly AnimalCard _animalCard;
        private readonly List<InspectionCard> _inspectionCards;

        public InspectionForm(AnimalCard card, IEnumerable<InspectionCard> inspectionCards)
        {
            InitializeComponent();
            _animalCard = card;
            _inspectionCards = inspectionCards.ToList();
            UpdateDataSource();
        }

        private void _addInspectionButton_Click(object sender, EventArgs e)
        {
            var inspectionCardForm = new InspectionCardForm(_animalCard);
            if (inspectionCardForm.ShowDialog() != DialogResult.OK) return;
            var inspectionCard = inspectionCardForm.GetNewInspection();
            _animalCard.InspectionCards ??= new List<InspectionCard>();
            _animalCard.InspectionCards.Add(inspectionCard);
            _inspectionCards.Add(inspectionCard);
            UpdateDataSource();
        }

        private void UpdateDataSource()
        {
            _inspectionGridView.DataSource = null;
            _inspectionGridView.DataSource = _inspectionCards;
        }
    }
}
