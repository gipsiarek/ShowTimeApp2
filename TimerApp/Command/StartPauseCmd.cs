using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TimerApp.Model;
using TimerApp.Model.Abstract;
using TimerApp.Model.Helper;
using TimerApp.ViewModel;

namespace TimerApp.Command
{
    public class StartPauseCmd : AbstractCommand
    {
        DataSet ds;
        PlayListViewModel pvm;

        public StartPauseCmd(DataSet ds, PlayListViewModel pvm)
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
                    if (param != null && param is TimerRow)
                    {
                        var bt = (TimerRow)param;
                        if (ds.Timer.TimerRow == null)
                        {
                            ds.Timer = new BaseTimer(bt);
                            bt.State = changeBtState(bt.State);
                            ds.Timer.Start();
                        }
                        else if (ds.Timer.TimerRow == bt)
                        {
                            if (bt.State == ActionEnum.Stoped) ds.Timer = new BaseTimer(bt);
                            bt.State = changeBtState(bt.State);
                            if (bt.State == ActionEnum.Started)
                                ds.Timer.Start();
                            else
                                ds.Timer.Pause();
                        }
                        else
                        {
                            if (ds.Timer.IsRunning())
                            {
                                MessageBoxResult res = MessageBox.Show("Czas jest odliczany. Zatrzymać i uruchomić inny timer?", "Uwaga", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                                if(res == MessageBoxResult.Yes)
                                {
                                    ds.Timer.TimerRow.State = ActionEnum.Stoped;
                                    ds.Timer = new BaseTimer(bt);
                                    bt.State = changeBtState(bt.State);
                                    ds.Timer.Start();
                                }
                            }
                            else
                            {
                                ds.Timer = new BaseTimer(bt);
                                bt.State = changeBtState(bt.State);
                                ds.Timer.Start();
                            }
                        }
                    }
                };

            }
        }

        private ActionEnum changeBtState(ActionEnum state)
        {
            if (state == ActionEnum.Started)
                return ActionEnum.Paused;
            else if (state == ActionEnum.Paused || state == ActionEnum.Stoped)
                return ActionEnum.Started;
            else
                return ActionEnum.Stoped;
        }
    }
}
