using InformationSystemDesign.Cards;

namespace InformationSystemDesign.Forms
{
    public partial class MunicipalCardForm : Form
    {
        public MunicipalCardForm()
        {
            InitializeComponent();
            _deleteButton.Visible = false;
            DeleteAction = false;
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
            return new object[] { signDate, validateDate, executor, customer };
        }

        private void _deleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите\n удалить карту муниципального контракта?", "Подтверждение",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            DeleteAction = true;
            Close();
        }
    }
}
