using InformationSystemDesign.Cards;
using InformationSystemDesign.Controllers;
using InformationSystemDesign.Interfaces;
using InformationSystemDesign.Registers;
using Microsoft.EntityFrameworkCore;

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


        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var inspectionContext = new InspectionContext();
            InitializeRegistries(inspectionContext);
            InitializeControllers();
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
        private static void InitializeRegistries(InspectionContext inspectionContext)
        {
            s_animalRegistry = new AnimalRegistry(inspectionContext.AnimalCards);
            s_organizationRegistry = new OrganizationRegistry(inspectionContext.OrganizationCards);
            s_municipalRegistry = new MunicipalRegistry(inspectionContext.MunicipalCards);
        }
        private static void InitializeControllers()
        {
            s_animalRegistryController = new AnimalRegistryController(s_animalRegistry);
            s_organizationRegistryController = new OrganizationRegistryController(s_organizationRegistry);
            s_municipalRegistryController = new MunicipalRegistryController(s_municipalRegistry);
        }
    }
}