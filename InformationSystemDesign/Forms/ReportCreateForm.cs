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
            var reportMaker = new ReportMaker(_controller);
            var report = reportMaker.MakeReport(dateTimePicker1.Value, dateTimePicker2.Value);
            new ReportForm(report).ShowDialog();
        }
    }
}
