using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TimerApp.Model;
using TimerApp.Model.Abstract;

namespace TimerApp.Command
{
    public class UploadConfigCmd : AbstractCommand
    {
        DataSet ds;

        public UploadConfigCmd (DataSet ds)
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
                    //WebClient wc = new WebClient();
                    //Stream st = wc.OpenRead("http://185.15.44.87/jmjtest/ShowTimeAuth.zip");
                    //StreamReader sr = new StreamReader(st);
                    //var tmp = sr.ReadLine();
                    ////if(x.StartsWith("DATA"))
                    //long x = DateTime.Now.Ticks;
                    //var xx = Convert.ToBase64String(BitConverter.GetBytes(x));
                    Microsoft.Win32.RegistryKey key;
                    key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("ShowTimeApp");
                    
                    MessageBox.Show($@"Nie zaimplementowano. adres {key.GetValue("Host")?.ToString()} 
                                        użytkownik {key.GetValue("User")?.ToString()}");
                };
            }
        }
    }
}
