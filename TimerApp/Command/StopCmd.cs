using System;
using System.Windows;
using TimerApp.Model;
using TimerApp.Model.Abstract;
using TimerApp.Model.Helper;
using TimerApp.ViewModel;

namespace TimerApp.Command
{
    public class StopCmd : AbstractCommand
    {
        DataSet ds;
        PlayListViewModel pvm;

        public StopCmd(DataSet ds, PlayListViewModel pvm)
        {
            this.ds = ds;
            this.pvm = pvm;
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
                    if (param != null && param is TimerRow && ds.Timer.TimerRow!=null)
                    {

                        var bt = (TimerRow)param;
                        if ( ds.Timer.IsRunning() && ds.Timer.TimerRow==bt)
                        {
                            MessageBoxResult res = MessageBox.Show("Czy na pewno zatrzymać i wyzerować timer?", "Uwaga", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                            if (res == MessageBoxResult.Yes)
                            {
                                //ds.Timer.TimerRow.State = ActionEnum.Stoped;
                                //ds.Timer = new BaseTimer(bt);
                                //bt.State = ActionEnum.Stoped;
                                ds.Timer.Stop();
                            }
                        }else
                        {
                            ds.Timer.Stop();
                        }
                    }
                };                
            }
        }
    }
}
