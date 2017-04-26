using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows;
using TimerApp.Model.Helper;
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

            //string zakryptowany;
            //string odkryptowany;
            // zakryptowany = Crypt.Encrypt(File.ReadAllText("verification.txt"));
            //File.WriteAllText("verificationCrypted.txt", zakryptowany);
            //odkryptowany = Crypt.Decrypt(File.ReadAllText("verificationCrypted.txt"));




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
            bool authorizationNeeded = false; 

            Microsoft.Win32.RegistryKey key;
            key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("ShowTimeApp");

            string dtString = key.GetValue("Date")?.ToString();
            if (string.IsNullOrEmpty(dtString))
            {
                authorizationNeeded = true;
                MessageBox.Show("Brak licencji. Zautoryzuj się w celu aktywacji na 2 dni.");
            }
            else
            {
                dtString = Crypt.Decrypt(dtString);
                if (string.IsNullOrEmpty(dtString) || dtString.Length != 16)
                {
                    authorizationNeeded = true;

                }
                else
                {
                    int year = int.Parse(dtString.Substring(6, 4));
                    int month = int.Parse(dtString.Substring(11, 2));
                    int day = int.Parse(dtString.Substring(14, 2));
                    DateTime dt = new DateTime(year, month, day);
                    if (dt.AddDays(2) < DateTime.Now)
                    {
                        authorizationNeeded = true;
                        MessageBox.Show("Licencja wygasła. Zautoryzuj się ponownie.");
                    }
                }
            }
            if (authorizationNeeded)
            {
                Login settingsWindow = new Login();
                settingsWindow.SizeToContent = SizeToContent.WidthAndHeight;
                settingsWindow.Owner = Application.Current.MainWindow;
                settingsWindow.ShowInTaskbar = false;
                settingsWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
                settingsWindow.ShowDialog();
            }
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
