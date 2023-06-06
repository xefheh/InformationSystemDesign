using InformationSystemDesign.Cards;
using InformationSystemDesign.Controllers;
using InformationSystemDesign.Forms;
using InformationSystemDesign.Interfaces;
using InformationSystemDesign.Registers;


namespace InformationSystemDesign
{
    internal static class Program
    {
        private static IRegistry<AnimalCard> s_animalRegistry;
        private static IRegistry<OrganizationCard> s_organizationRegistry;
        private static IRegistry<MunicipalCard> s_municipalRegistry;
        private static IController<AnimalCard> s_animalRegistryController;
        private static IController<OrganizationCard> s_organizationRegistryController;
        private static IController<MunicipalCard> s_municipalRegistryController;

        public static AnimalRegistryForm AnimalRegistryForm =>
            new (s_animalRegistryController);
        public static OrganizationRegistryForm OrganizationRegistryForm =>
            new (s_organizationRegistryController);
        public static MunicipalRegistryForm MunicipalRegistryForm =>
            new (s_municipalRegistryController);

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using var inspectionContext = new InspectionContext();
            var storage = InitializeStorage(inspectionContext);
            InitializeRegistries(storage);
            InitializeControllers();
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }

        private static Storage InitializeStorage(InspectionContext inspectionContext) => 
            new (inspectionContext.AnimalCards, inspectionContext.MunicipalCards,
                inspectionContext.OrganizationCards);

        private static void InitializeRegistries(Storage storage)
        {
            s_animalRegistry = new AnimalRegistry(storage);
            s_organizationRegistry = new OrganizationRegistry(storage);
            s_municipalRegistry = new MunicipalRegistry(storage);
        }

        private static void InitializeControllers()
        {
            s_animalRegistryController = new AnimalRegistryController(s_animalRegistry);
            s_organizationRegistryController = new OrganizationRegistryController(s_organizationRegistry);
            s_municipalRegistryController = new MunicipalRegistryController(s_municipalRegistry);
        }
    }
}