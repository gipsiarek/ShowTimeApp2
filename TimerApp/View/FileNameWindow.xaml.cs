using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using TimerApp.Model;

namespace TimerApp.View
{
    /// <summary>
    /// Interaction logic for FileNameWindow.xaml
    /// </summary>
    public partial class FileNameWindow : Window
    {
        DataSet ds;
        public FileNameWindow()
        {
            InitializeComponent();
        }

        public FileNameWindow(DataSet ds) 
        {
            this.ds = ds;
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txbConfigName.Text))
                MessageBox.Show("Najpierw podaj nazwę pliku która ma być widoczna na serwerze");
            else
            {
                ds.Css = new ConfigSettingsSerializer(ds.TimesCollection, ds.Settings);

                Microsoft.Win32.RegistryKey key;
                key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("ShowTimeApp");

                HttpClient client = new HttpClient();
                var pairs = new List<KeyValuePair<string, string>>
                    {
                        new KeyValuePair<string, string>("username", key.GetValue("User").ToString()),
                        new KeyValuePair<string, string>("password", key.GetValue("Pass").ToString()),
                        new KeyValuePair<string, string>("name", txbConfigName.Text),
                        new KeyValuePair<string, string>("content", ds.Css.GetXmlConfig()),
                    };

                var content = new FormUrlEncodedContent(pairs);

                var response = client.PostAsync(key.GetValue("Host").ToString() + "/admin/timer/create", content).Result;
                if (response.IsSuccessStatusCode)
                    MessageBox.Show("Ustawienie poprawnie wgrane na serwer.", "Poprawny eksport konfiguracji");
                else
                    MessageBox.Show("Błąd podczas synchronizacji ustawień. Spróbuj ponownie lub skontatuj się z administratorem", "Błąd");

                this.Close();
            }
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
