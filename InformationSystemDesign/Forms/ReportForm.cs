using InformationSystemDesign.Interfaces;

namespace InformationSystemDesign.Forms
{
    public partial class ReportForm : Form
    {
        public ReportForm(List<ReportValue2> reportValues, double finishPrice)
        {
            InitializeComponent();
            _reportGridView.DataSource = reportValues;
            textBox1.Text = finishPrice.ToString();
        }
    }
}
