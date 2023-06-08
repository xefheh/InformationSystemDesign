using System.ComponentModel;
using InformationSystemDesign.Cards;
using InformationSystemDesign.Forms.AnimalForms;
using InformationSystemDesign.Forms.OrganizationForms;
using InformationSystemDesign.Forms.ReportForms;
using InformationSystemDesign.Interfaces;

namespace InformationSystemDesign.Forms
{
    public partial class MainForm : Form
    {
        private readonly IController<AnimalCard> _animalRegistryController;
        private readonly IController<MunicipalCard> _municipalRegistryController;
        private readonly IController<OrganizationCard> _organizationRegistryController;
        private readonly IController<InspectionCard> _inspectionRegistryController;

        public MainForm(IController<AnimalCard> animalRegistryController, IController<MunicipalCard> municipalRegistryController,
            IController<OrganizationCard> organizationRegistryController, IController<InspectionCard> inspectionRegistryController)
        {
            InitializeComponent();
            _animalRegistryController = animalRegistryController;
            _municipalRegistryController = municipalRegistryController;
            _organizationRegistryController = organizationRegistryController;
            _inspectionRegistryController = inspectionRegistryController;
        }

        private void _animalRegistryButton_Click(object sender, EventArgs e) =>
            new AnimalRegistryForm(_animalRegistryController, _inspectionRegistryController).ShowDialog();

        private void _municipalRegistryButton_Click(object sender, EventArgs e) =>
            new MunicipalRegistryForm(_municipalRegistryController).ShowDialog();

        private void _organizationRegistryButton_Click(object sender, EventArgs e) =>
            new OrganizationRegistryForm(_organizationRegistryController).ShowDialog();

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) => Application.Exit();

        private void _reportButton_Click(object sender, EventArgs e) => 
            new ReportCreateForm(_inspectionRegistryController).ShowDialog();
    }
}