using System;
using System.Windows;
using TimerApp.Model;
using TimerApp.Model.Abstract;

namespace TimerApp.Command
{
    public class DeleteRowCmd : AbstractCommand
    {
        DataSet ds;
        public DeleteRowCmd(DataSet ds)
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
                    if (param is TimerRow)
                    {
                        var bt = (TimerRow)param;
                        if(bt.IsRunning())
                        {
                            MessageBox.Show("Nie można usunąć uruchomionego odliczania! ", "Uwaga");
                        }
                        else if(MessageBox.Show("Czy na pewno usunąć wpis? ", "Uwaga", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                        {
                            ds.TimesCollection.Remove(bt);                            
                            ds.TimesCollection = new System.Collections.ObjectModel.ObservableCollection<TimerRow>(ds.TimesCollection);
                            ds.Css = new ConfigSettingsSerializer(ds.TimesCollection, ds.Settings);
                            ds.Css.SaveConfigFile();
                        }
                        
                    }
                };
            }
        }
    }
}
