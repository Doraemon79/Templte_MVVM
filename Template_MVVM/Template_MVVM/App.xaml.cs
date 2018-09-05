using Ninject;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Template_MVVM.ViewModels;

namespace Template_MVVM
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private IKernel container;
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var container = new StandardKernel();

            container.Bind<Window>().To<MainWindow>();

            MainWindow mw = new MainWindow();
            mw.DataContext = container.Get<MainViewModel>();

            mw.Show();
        }

        private void ComposeObjects()
        {
            Current.MainWindow = this.container.Get<MainWindow>();
        }

        private void ConfigureContainer()
        {
            this.container = new StandardKernel();

        }
    }
}
