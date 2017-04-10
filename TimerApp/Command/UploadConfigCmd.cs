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
                    MessageBox.Show("Nie zaimplementowano. Brak adresów i metod");
                };
            }
        }
    }
}
