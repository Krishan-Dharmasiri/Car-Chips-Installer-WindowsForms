using Chips.Installer.Engine;
using Chips.Installer.Engine.Interfaces;
using SimpleInjector;
using SimpleInjector.Lifestyles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chips.Installer.WindowsFormsApp
{
    static class Program
    {
        /// <summary>
        /// Private variable to hold the dependency injection container
        /// </summary>
        private static Container container;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Bootstrap();
            Application.Run(container.GetInstance<MainForm>());
        }

        private static void Bootstrap()
        {
            container = new Container();
            container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();

            //Register Types in the container
            container.Register<IChipManager, ChipManager>(Lifestyle.Singleton);
            //container.Register<IDataQuery, ExcelHandler>(Lifestyle.Singleton);
            //container.Register<IDataManager, DataManager>(Lifestyle.Singleton);
            container.Register<MainForm>(Lifestyle.Singleton);

            container.Verify();
        }
    }
}
