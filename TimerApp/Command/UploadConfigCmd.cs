using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TimerApp.Model;
using TimerApp.Model.Abstract;
using TimerApp.View;

namespace TimerApp.Command
{
    public class UploadConfigCmd : AbstractCommand
    {
        DataSet ds;

        public UploadConfigCmd(DataSet ds)
        {
            this.ds = ds;
        }

        public override Func<object, bool> CanExecuteAction
        {
            get
            {
                return (param) =>
                 {
                     return true;
                 };
            }
        }

        public override Action<object> ExecuteAction
        {
            get
            {
                return (param) =>
                {
                    //ds.Css = new ConfigSettingsSerializer(ds.TimesCollection, ds.Settings);

                    //Microsoft.Win32.RegistryKey key;
                    //key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("ShowTimeApp");

                    //HttpClient client = new HttpClient();
                    //var pairs = new List<KeyValuePair<string, string>>
                    //{
                    //    new KeyValuePair<string, string>("username", key.GetValue("User").ToString()),
                    //    new KeyValuePair<string, string>("password", key.GetValue("Pass").ToString()), 
                    //    new KeyValuePair<string, string>("name", ds.Css.FileName),
                    //    new KeyValuePair<string, string>("content", ds.Css.GetXmlConfig()),                    
                    //};

                    //var content = new FormUrlEncodedContent(pairs);

                    //var response = client.PostAsync(key.GetValue("Host").ToString() + "/admin/timer/create", content).Result;
                    //if (response.IsSuccessStatusCode)
                    //    MessageBox.Show("Ustawienie poprawnie wgrane na serwer.", "Poprawny eksport konfiguracji");
                    //else
                    //    MessageBox.Show("Błąd podczas synchronizacji ustawień. Spróbuj ponownie lub skontatuj się z administratorem", "Błąd");

                    Window fileNameWindow = new FileNameWindow(ds);
                    fileNameWindow.ShowDialog();

                };
            }
        }
    }
}
