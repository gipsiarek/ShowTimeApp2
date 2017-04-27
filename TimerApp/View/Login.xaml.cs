using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
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
using TimerApp.Model.Helper;

namespace TimerApp.View
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
            Microsoft.Win32.RegistryKey key;
            key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("ShowTimeApp");
            txbHost.Text = key.GetValue("Host")?.ToString();
            txbName.Text = key.GetValue("User")?.ToString();
            
            
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.RegistryKey key;
            key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("ShowTimeApp");
            key.SetValue("User", txbName.Text );
            key.SetValue("Host", txbHost.Text);
            key.SetValue("Pass", Crypt.Encrypt(txbPassword.Password));
            key.Close();
            //CALL SERVICE FOR FILE

            //string response = WebRequestinJson(txbHost.Text, "");
            //var test = Crypt.Decrypt(response);
            //MessageBox.Show("TUTAJ NASTĄPI WYWOŁANIE Weba w celu zdobycia informacji o dacie");

            key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("ShowTimeApp");
            key.SetValue("Date", Crypt.Encrypt("DATA: 2017-04-27"));
            this.Close();
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        public string WebRequestinJson(string url, string userName, string password)
        {
            var client = new HttpClient();

            var pairs = new List<KeyValuePair<string, string>>
                {
                    new KeyValuePair<string, string>("LoginForm[username]", "Marek Galla"/*username*/),
                    new KeyValuePair<string, string>("LoginForm[password]", "Marek=1987"/*password*/)
                };

            var content = new FormUrlEncodedContent(pairs);

            var response = client.PostAsync(url, content).Result;
            string tmp = "";
            if (response.IsSuccessStatusCode)
            {
                tmp = response.Content.ReadAsStringAsync().Result;

            }

            return tmp;
        }
    }
}

