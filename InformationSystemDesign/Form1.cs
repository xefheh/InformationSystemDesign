using InformationSystemDesign.Cards;
using InformationSystemDesign.Controllers;
using InformationSystemDesign.Forms;
using InformationSystemDesign.Interfaces;
using InformationSystemDesign.PermissionControllers;

namespace InformationSystemDesign
{
    public partial class Form1 : Form
    {
        private readonly IRegistry<AnimalCard> _animalRegistry;
        private readonly IRegistry<MunicipalCard> _municipalRegistry;
        private readonly IRegistry<OrganizationCard> _organizationRegistry;
        private readonly User _user;

        public Form1(IRegistry<AnimalCard> animalRegistry, IRegistry<MunicipalCard> municipalRegistry,
            IRegistry<OrganizationCard> organizationRegistry, User user)
        {
            InitializeComponent();
            _animalRegistry = animalRegistry;
            _municipalRegistry = municipalRegistry;
            _organizationRegistry = organizationRegistry;
            _user = user;
        }

        private void _animalRegistryButton_Click(object sender, EventArgs e)
        {
            new AnimalRegistryForm(new AnimalRegistryController(_animalRegistry,
                new AnimalPermissionAction(_user))).ShowDialog();
        }

        private void _municipalRegistryButton_Click(object sender, EventArgs e)
        {
            new MunicipalRegistryForm(new MunicipalRegistryController(_municipalRegistry,
                new MunicipalPermissionAction(_user))).ShowDialog();
        }

        private void _organizationRegistryButton_Click(object sender, EventArgs e)
        {
            new OrganizationRegistryForm(new OrganizationRegistryController(_organizationRegistry,
                new OrganizationPermissionAction(_user))).ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}