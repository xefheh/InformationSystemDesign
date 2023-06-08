using InformationSystemDesign.Cards;
using InformationSystemDesign.Controllers;
using InformationSystemDesign.Forms;
using InformationSystemDesign.Initialization;


namespace InformationSystemDesign
{
    internal static class Program
    {
        private static InspectionContext s_context;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            s_context = new InspectionContext();
            var userInformer = new UserInformer(s_context);
            ApplicationConfiguration.Initialize();
            Application.Run(new AuthorizationForm(userInformer));
        }

        public static MainFormInitializer CreateMainFormInitializer(User user) =>
            new MainFormInitializer(s_context, user);
    }
}