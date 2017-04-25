using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TimerApp.Model;
using TimerApp.Model.Abstract;
using TimerApp.View;
using TimerApp.ViewModel;

namespace TimerApp.Command
{
    public class AddNewPlayListItemViewCmd : AbstractCommand
    {
        DataSet ds;
        public AddNewPlayListItemViewCmd(DataSet ds)
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
                    AddTimerWindow window = new AddTimerWindow();
                    ds.Mvm.AddTimerCtr = new AddBaseTimerViewModel(ds);
                    window.DataContext = ds.Mvm;
                    window.SizeToContent = System.Windows.SizeToContent.WidthAndHeight;
                    window.Owner = Application.Current.MainWindow;
                    window.WindowStartupLocation = WindowStartupLocation.CenterOwner;
                    window.ShowInTaskbar = false;
                    ds.OnRequestClose += (e) =>
                    {
                        window.Close();
                    };
                    window.ShowDialog();
                    //ds.Mvm.PlayListCtr = new AddBaseTimerViewModel(ds);
                };
            }
        }
    }
}
