using System.ComponentModel;
using InformationSystemDesign.Cards;

namespace InformationSystemDesign.Forms
{
    public partial class MunicipalCardForm : Form
    {

        private readonly BindingList<LocalityCard> _localityCards;
        private List<LocalityCard> _choosenLocalityCards;

        public MunicipalCardForm(BindingList<LocalityCard> localityCards)
        {
            InitializeComponent();
            _deleteButton.Visible = false;
            DeleteAction = false;
            _localityCards = localityCards;
        }

        public MunicipalCardForm(MunicipalCard municipalCard)
        {
            InitializeComponent();
            _signPicker.Value = municipalCard.SignDate;
            _validatePicker.Value = municipalCard.ValidateDate;
            _executorBox.Text = municipalCard.Executor;
            _customerBox.Text = municipalCard.Customer;
            DeleteAction = false;
        }

        public bool DeleteAction { get; set; }

        public object[] GetMunicipalCardParams()
        {
            var signDate = _signPicker.Value;
            var validateDate = _validatePicker.Value;
            var executor = _executorBox.Text;
            var customer = _customerBox.Text;
            return new object[] { signDate, validateDate, executor, customer, _choosenLocalityCards };
        }

        private void _deleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите\n удалить карту муниципального контракта?", "Подтверждение",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            DeleteAction = true;
            Close();
        }

        private void _cityButton_Click(object sender, EventArgs e)
        {
            var localityForm = new LocalityForm(_localityCards);
            localityForm.ShowDialog();
            _choosenLocalityCards = localityForm.GetLocalities();
        }
    }
}
