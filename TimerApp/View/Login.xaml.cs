using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Windows;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;

namespace TimerApp.View
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        static string base64pubkey = "MIGfMA0GCSqGSIb3DQEBAQUAA4GNADCBiQKBgQCw2KypSQTfzzqok62BMhKshht3cL44fSiFT8fn2QgSC7ICbCN733jfQiciShs6DN26llER9XuG3oAx7aUyt1iTWlpuaI25CQstPfguzRwhvXk0t6AE6G / McOHtEjacrsfKTASdvFrXFPFQS + ppaAf2w7eyBJSuayKQYHoix0mP + wIDAQAB";
        RsaKeyParameters pubKey = PublicKeyFactory.CreateKey(Convert.FromBase64String(base64pubkey)) as RsaKeyParameters;
        byte[] signature;// = Convert.FromBase64String("kcBitiv4zYTXUqUyZSNDDieC9QkPEFBozyR+owzSwI4fBG15YKmIOKMAn77DRtNwyO3YfuNyKByck9MLuN2EO8YESHylBwJPmRd2z2y1sW8rkAIl/y8YFUWyAHZTiV4UuWUjOGvUV7LWQ6yK2mfVu5VH1s2HRrcDx+KolHpokTE=");
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

            byte[] msgString = null;
            string webData = WebRequestinJson(txbHost.Text, txbName.Text, txbPassword.Password.ToString(), out msgString);
            if (!string.IsNullOrEmpty(webData) && VerifySignature(msgString))
            {
                key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("ShowTimeApp");
                key.SetValue("Date", "DATA: "+webData.Split('|')[0]);
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




        public string WebRequestinJson(string url, string userName, string password, out byte[] msg)
        {
            var client = new HttpClient();

            var pairs = new List<KeyValuePair<string, string>>
                {
                    new KeyValuePair<string, string>("LoginForm[username]", userName),//"Marek Galla"
                    new KeyValuePair<string, string>("LoginForm[password]", password)//"Marek=1987"
                };

            var content = new FormUrlEncodedContent(pairs);
            msg = null;
            string data="";
            var response = client.PostAsync(url, content).Result;
            if (response.IsSuccessStatusCode )
            {
                var stringMsg= response.Content.ReadAsStringAsync().Result.Split(',');
                if (stringMsg.Length > 1)
                {
                    var signatureMsg = stringMsg[4].Split(':')[1];
                    signature = Convert.FromBase64String(signatureMsg.Substring(1, signatureMsg.Length - 3));

                    data = stringMsg[1].Substring(stringMsg[1].IndexOf(':') + 2).Trim('"') + "|"
                                + stringMsg[2].Split(':')[1].Trim('"') + "|" + stringMsg[3].Split(':')[1];
                    msg = Encoding.ASCII.GetBytes(data);

                    return data;
                }
            }
            return data;
        }
        //{"status":true,"datetime":"2017-05-16 20:15:46","version":"1.0.0.0","user_id":59,"sign":"Rwk6SumrzKBCDkkfD0XDC+mRAl5BzY3N/NvBFLcpzQRhd1EQof1Kzb6Oi3QSzp7NrgTFgRBGRGXP1wknUbdoLIACovyg7sG62I3P3QtGu0Jk8CSLx9dWj83wbHJcXoZqFSGPL10n3zbQGyUTp4S+Sir0vBk1U42ThI6eCvUaVfw="}
      
    }
}

