using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
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


            //WebClient wc = new WebClient();
            //Stream st = wc.OpenRead("http://185.15.44.87/jmjtest/ShowTimeAuth.zip");
            //StreamReader sr = new StreamReader(st);
            //var tmp = sr.ReadLine();
            ////if(x.StartsWith("DATA"))
            //long x = DateTime.Now.Ticks;
            //var xx = Convert.ToBase64String(BitConverter.GetBytes(x));

            //var xx2 = Convert.FromBase64String(xx);
            //var x2= BitConverter.ToInt64(xx2, 0);
        }
        
        protected override void OnExit(ExitEventArgs e)
        {
            base.OnExit(e);

        }
    }
}
