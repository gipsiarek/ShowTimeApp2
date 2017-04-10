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
    public class AddNewPlayListItemCmd : AbstractCommand
    {
        DataSet ds;

        public AddNewPlayListItemCmd(DataSet ds)
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
                    bool was_error = false;
                    if (param != null && param is TimerRow)
                    {
                        var tmpParam = (TimerRow)param;
                        if ((tmpParam != null && !string.IsNullOrEmpty(tmpParam.Name) && tmpParam.Duration != 0) == false)
                        {
                            MessageBox.Show("Proszę uzupełnić nazwę i czas");
                            was_error = true;
                        }
                    }

                    if (!was_error)
                    {
                        if (param != null && param is TimerRow)
                        {
                            var btTmp = (TimerRow)param;
                            if (!ds.TimesCollection.Contains(btTmp))
                                ds.TimesCollection.Add(btTmp);
                            ds.TimesCollection = new System.Collections.ObjectModel.ObservableCollection<TimerRow>(ds.TimesCollection);
                            ds.CallCloseDialog(true);
                            ds.Css = new ConfigSettingsSerializer(ds.TimesCollection, ds.Settings);
                            ds.Css.SaveConfigFile();
                        }
                        else
                        {
                            ds.CallCloseDialog(false);
                        }
                        ds.Mvm.PlayListCtr = new PlayListViewModel(ds);
                    }
                };
            }
        }
    }
}
