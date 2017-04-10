using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using TimerApp.View;
using TimerApp.ViewModel;

namespace TimerApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            MainWindow app = new MainWindow();
            MainWindowViewModel mvm = new MainWindowViewModel();
            app.DataContext = mvm;
            app.Closing += (s, ee) =>
            {
                mvm.PWindow.Close();
                //var result = MessageBox.Show("Na pewno zamknąć okno i wyłączyć aplikację?", "Uwaga", MessageBoxButton.YesNo);
                ee.Cancel = true;

            };
            app.Show();

        }
        
        protected override void OnExit(ExitEventArgs e)
        {
            base.OnExit(e);

        }
    }
}
