using System.ComponentModel;
using InformationSystemDesign.Cards;

namespace InformationSystemDesign.Forms
{
    public partial class LocalityForm : Form
    {

        private readonly BindingList<LocalityCard> _cards;
        private List<LocalityCard> _choosenCities;

        public LocalityForm(BindingList<LocalityCard> cards)
        {
            InitializeComponent();
            _cards = cards;
            _choosenCities = new List<LocalityCard>();
            _localityView.CellDoubleClick += _viewCell_ClicketDobule;
            _localityView.DataSource = _cards;
            _localityView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public List<LocalityCard> GetLocalities() => _choosenCities;

        public void _viewCell_ClicketDobule(object sender, EventArgs e)
        {
            var currentRow = _localityView.SelectedRows[0];
            var localityName = (string)currentRow.Cells[0].Value;
            var currentCity = _cards.First(locality => locality.Name == localityName);
            if (!_choosenCities.Contains(currentCity))
            {
                currentRow.DefaultCellStyle.BackColor = Color.Gold;
                _choosenCities.Add(currentCity);
            }
            else
            {
                _choosenCities.Remove(currentCity);
                currentRow.DefaultCellStyle.BackColor = Color.Empty;
            }
            _localityView.ClearSelection();
        }
    }
}
