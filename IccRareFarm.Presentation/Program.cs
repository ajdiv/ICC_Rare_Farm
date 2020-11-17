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
            // Commenting this out to avoid issues w/ .NET Core 3.1 and Windows Forms
            //Application.SetHighDpiMode(HighDpiMode.SystemAware);
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
            container.Register<CharacterForm>(Lifestyle.Singleton);
            container.Register<CharacterTool>(Lifestyle.Singleton);
            container.Register<ICharacterRepo, CharacterRepo>(Lifestyle.Singleton);

            // Verify the container.
            container.Verify();
        }
    }
}
