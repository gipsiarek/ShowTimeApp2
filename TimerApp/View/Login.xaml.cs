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
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using TimerApp.Model.Helper;

namespace TimerApp.View
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        static string base64pubkey = "MIGfMA0GCSqGSIb3DQEBAQUAA4GNADCBiQKBgQCw2KypSQTfzzqok62BMhKshht3cL44fSiFT8fn2QgSC7ICbCN733jfQiciShs6DN26llER9XuG3oAx7aUyt1iTWlpuaI25CQstPfguzRwhvXk0t6AE6G / McOHtEjacrsfKTASdvFrXFPFQS + ppaAf2w7eyBJSuayKQYHoix0mP + wIDAQAB";
        RsaKeyParameters pubKey = PublicKeyFactory.CreateKey(Convert.FromBase64String(base64pubkey)) as RsaKeyParameters;
        byte[] signature = Convert.FromBase64String("kcBitiv4zYTXUqUyZSNDDieC9QkPEFBozyR+owzSwI4fBG15YKmIOKMAn77DRtNwyO3YfuNyKByck9MLuN2EO8YESHylBwJPmRd2z2y1sW8rkAIl/y8YFUWyAHZTiV4UuWUjOGvUV7LWQ6yK2mfVu5VH1s2HRrcDx+KolHpokTE=");
        byte[] message;
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
            //key.SetValue("Pass", Crypt.Encrypt(txbPassword.Password));
            key.SetValue("Pass", txbPassword.Password);
            key.Close();
            //CALL SERVICE FOR FILE

            string msgString = "";
            message = WebRequestinJson(txbHost.Text, txbName.Text, txbPassword.Password.ToString(), out msgString);
            if (VerifySignature(message))
            {
                key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("ShowTimeApp");
                key.SetValue("Date", "DATA: 2017-05-27");
            }
            else
            {
                MessageBox.Show("Niestety wystąpił problem podczas pobierania licencji. Aplikacja zostanie zamknięta");

                Application.Current.Shutdown();
            }
            this.Close();
        }

        private bool VerifySignature(byte[] message)
        {
            ISigner sig = SignerUtilities.GetSigner("SHA1WithRSAEncryption");
            sig.Init(false, pubKey);
            sig.BlockUpdate(message, 0, message.Length);
            if (sig.VerifySignature(signature))
                return true;
            else
                return false;
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }




        public byte[] WebRequestinJson(string url, string userName, string password, out string msg)
        {
            var client = new HttpClient();

            var pairs = new List<KeyValuePair<string, string>>
                {
                    new KeyValuePair<string, string>("LoginForm[username]", "Marek Galla"/*username*/),
                    new KeyValuePair<string, string>("LoginForm[password]", "Marek=1987"/*password*/)
                };

            var content = new FormUrlEncodedContent(pairs);
            msg = "";
            var response = client.PostAsync(url, content).Result;
            if (response.IsSuccessStatusCode)
            {
                msg = response.Content.ReadAsStringAsync().Result;
                return response.Content.ReadAsByteArrayAsync().Result;
                
            }
            return null;
        }
      
    }
}

