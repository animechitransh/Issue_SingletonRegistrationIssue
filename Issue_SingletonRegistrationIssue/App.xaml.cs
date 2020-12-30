using Issue_SingletonRegistrationIssue.Views;
using ModuleA;
using ModuleA.Service;
using Prism.Ioc;
using Prism.Modularity;
using System.Windows;

namespace Issue_SingletonRegistrationIssue
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            //containerRegistry.Register<ITestService, TestService>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            base.ConfigureModuleCatalog(moduleCatalog);
            moduleCatalog.AddModule<ModuleAModule>();
        }
    }
}
