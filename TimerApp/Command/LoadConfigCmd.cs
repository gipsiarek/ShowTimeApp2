using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimerApp.Model;
using TimerApp.Model.Abstract;

namespace TimerApp.Command
{
    public class LoadConfigCmd : AbstractCommand
    {
        DataSet ds;
        public LoadConfigCmd(DataSet ds)
        {
            this.ds = ds;
        }
        public override Func<object, bool> CanExecuteAction
        {
            get
            {
                return (param) => { return true; };
            }
        }

        public override Action<object> ExecuteAction
        {
            get
            {
                return (param) =>
                {
                    OpenFileDialog ofd = new OpenFileDialog();
                    ofd.Filter = "ShowTime|*.e4e";
                    DialogResult res = ofd.ShowDialog();
                    if(res == DialogResult.OK)
                    {
                        ds.Css = new ConfigSettingsSerializer(ofd.FileName);
                        ds.Css.ReadConfigFile();

                    }
                };
            }
        }
    }
}
