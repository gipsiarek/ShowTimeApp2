using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TimerApp.Model;
using TimerApp.Model.Abstract;
using TimerApp.ViewModel;

namespace TimerApp.Command
{
    public class DownToZeroCmd : AbstractCommand
    {
        DataSet ds;
        AddBaseTimerViewModel vm;

        public DownToZeroCmd(DataSet ds, AddBaseTimerViewModel vm)
        {
            this.ds = ds;
            this.vm = vm;
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
                    vm.NewBt.IsTimerDescending = !vm.NewBt.IsTimerDescending;
                };
            }
        }
    }
}
