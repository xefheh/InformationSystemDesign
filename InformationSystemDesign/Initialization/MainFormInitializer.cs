using System.ComponentModel;
using InformationSystemDesign.Cards;
using InformationSystemDesign.Controllers;
using InformationSystemDesign.Forms;
using InformationSystemDesign.Interfaces;
using InformationSystemDesign.PermissionControllers;
using InformationSystemDesign.Registers;
using InformationSystemDesign.StorageParts;

namespace InformationSystemDesign.Initialization
{
    internal class MainFormInitializer
    {
        private readonly IRegistry<AnimalCard> _animalRegistry;
        private readonly IRegistry<MunicipalCard> _municipalRegistry;
        private readonly IRegistry<OrganizationCard> _organizationRegistry;
        private readonly IRegistry<InspectionCard> _inspectionRegistry;
        private readonly User _user;

        public MainFormInitializer(InspectionContext inspectionContext, User user)
        {
            var storage = new Storage(inspectionContext);
            _animalRegistry = new AnimalRegistry(storage);
            _municipalRegistry = new MunicipalRegistry(storage);
            _organizationRegistry = new OrganizationRegistry(storage);
            _inspectionRegistry = new InspectionRegistry(storage);
            _user = user;
        }

        public void OpenMainForm() =>
            new MainForm(new AnimalRegistryController(_animalRegistry, new AnimalPermissionAction(_user)),
                new MunicipalRegistryController(_municipalRegistry, new MunicipalPermissionAction(_user)),
                new OrganizationRegistryController(_organizationRegistry, new OrganizationPermissionAction(_user)),
                new InspectionRegistryController(_inspectionRegistry, new AnimalPermissionAction(_user))).ShowDialog();
    }
}
