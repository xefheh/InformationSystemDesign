using InformationSystemDesign.Controllers;
using InformationSystemDesign.Interfaces;

namespace InformationSystemDesign.Forms
{
    public partial class ReportCreateForm : Form
    {
        private AnimalRegistryController _controller;

        public ReportCreateForm(AnimalRegistryController controller)
        {
            InitializeComponent();
            _controller = controller;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var reportMaker = new ReportMaker2(_controller);
            var report = reportMaker.MakeReport(dateTimePicker1.Value, dateTimePicker2.Value);
            var reportValues = report.ReportValues;
            var finishPrice = report.FinishPrice;
            new ReportForm(reportValues, finishPrice).ShowDialog();
        }
    }
}
