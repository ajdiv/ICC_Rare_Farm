using IccRareFarm.Business;
using IccRareFarm.Repository;
using SimpleInjector;
using System;
using System.Windows.Forms;

namespace IccRareFarm.Presentation
{
    static class Program
    {
        private static Container container;
          
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Bootstrap();

            Application.Run(container.GetInstance<CharacterForm>());
        }

        private static void Bootstrap()
        {
            // Create the container
            container = new Container();

            // Register types
            container.Register<CharacterForm>();
            container.Register<CharacterTool>(Lifestyle.Singleton);
            container.Register<ICharacterRepo, CharacterRepo>(Lifestyle.Singleton);

            // Verify the container.
            container.Verify();
        }
    }
}
