using System.Globalization;
using InformationSystemDesign.ReportCreation;

namespace InformationSystemDesign.Forms.ReportForms
{
    public partial class ReportForm : Form
    {
        public ReportForm(Report report)
        {
            InitializeComponent();
            _reportGridView.DataSource = report.ReportValues;
            _gerenalDiseasesBox.Text = report.GeneralPrice.ToString(CultureInfo.CurrentCulture);
            _generalInspectionBox.Text = report.GeneralDiseasesCount.ToString();
        }
    }
}
