using InformationSystemDesign.Cards;
using InformationSystemDesign.Registers;

namespace InformationSystemDesign.Interfaces
{
    internal class MainFormInitializer
    {
        private readonly Storage _storage;
        private readonly IRegistry<AnimalCard> _animalRegistry;
        private readonly IRegistry<MunicipalCard> _municipalRegistry;
        private readonly IRegistry<OrganizationCard> _organizationRegistry;
        private readonly User _user;

        public MainFormInitializer(InspectionContext inspectionContext, User user)
        {
            _storage = new Storage(inspectionContext);
            _animalRegistry = new AnimalRegistry(_storage);
            _municipalRegistry = new MunicipalRegistry(_storage);
            _organizationRegistry = new OrganizationRegistry(_storage);
            _user = user;
        }

        public void OpenMainForm() =>
            new Form1(_animalRegistry, _municipalRegistry, _organizationRegistry, _user).ShowDialog();
    }
}
