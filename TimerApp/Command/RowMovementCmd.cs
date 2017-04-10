using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimerApp.Model;
using TimerApp.Model.Abstract;
using TimerApp.ViewModel;

namespace TimerApp.Command
{
    public class RowMovementCmd : AbstractCommand
    {
        DataSet ds;
        PlayListViewModel pvm;

        public RowMovementCmd(DataSet ds, PlayListViewModel pvm)
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
                     return pvm.SelectedTime != null &&
                         ((param.ToString() == "UP" && ds.TimesCollection.IndexOf(pvm.SelectedTime) != 0)
                         || (param.ToString() == "DOWN" && ds.TimesCollection.IndexOf(pvm.SelectedTime) != ds.TimesCollection.Count - 1)
                         );
                 };
            }
        }

        public override Action<object> ExecuteAction
        {
            get
            {
                return (param) =>
                {
                    int movement = 1;
                    if (param.ToString() == "UP")
                        movement = -1;
                    ds.TimesCollection.Move(ds.TimesCollection.IndexOf(pvm.SelectedTime), ds.TimesCollection.IndexOf(pvm.SelectedTime) + movement);
                    //OnPropertyChanged(() => ds.TimesCollection);
                    ds.TimesCollection = new System.Collections.ObjectModel.ObservableCollection<TimerRow>(ds.TimesCollection.ToList());

                };
            }
        }
    }
}
