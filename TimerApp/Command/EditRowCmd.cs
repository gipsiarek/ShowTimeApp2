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
    public class EditRowCmd : AbstractCommand
    {
        DataSet ds;
        public EditRowCmd(DataSet ds)
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
                return (param) => {
                    if (param is TimerRow) {
                        var bt = (TimerRow)param;
                        if (bt.IsRunning())
                        {
                            MessageBox.Show("Nie można edytować uruchomionego odliczania! ", "Uwaga");
                        }
                        else
                        {
                            AddTimerWindow window = new AddTimerWindow();
                            ds.Mvm.AddTimerCtr = new AddBaseTimerViewModel(ds, bt);
                            window.DataContext = ds.Mvm;
                            window.SizeToContent = SizeToContent.WidthAndHeight;
                            window.ShowInTaskbar = false;
                            window.Owner = Application.Current.MainWindow;
                            window.WindowStartupLocation = WindowStartupLocation.CenterOwner;
                            ds.OnRequestClose += (e) =>
                            {
                                window.Close();
                            };
                            window.ShowDialog();
                            
                        }
                    }
                };
            }
        }
    }
}
