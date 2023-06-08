using InformationSystemDesign.Cards;
using InformationSystemDesign.Interfaces;
using InformationSystemDesign.ReportCreation;

namespace InformationSystemDesign.Forms.ReportForms
{
    public partial class ReportCreateForm : Form
    {
        private readonly IController<InspectionCard> _controller;
        public ReportCreateForm(IController<InspectionCard> controller)
        {
            InitializeComponent();
            _controller = controller;
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            var reportMaker = new ReportMaker(_controller);
            var report = reportMaker.MakeReport(_startPicker.Value, _endPicker.Value);
            new ReportForm(report).ShowDialog();
        }
    }
}
