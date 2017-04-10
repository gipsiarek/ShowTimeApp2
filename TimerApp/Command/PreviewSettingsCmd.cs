using System;
using TimerApp.Model;
using TimerApp.Model.Abstract;
using TimerApp.ViewModel;

namespace TimerApp.Command
{
    public class PreviewSettingsCmd : AbstractCommand
    {
        DataSet ds;
        

        public PreviewSettingsCmd(DataSet ds)
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
                    //if (param != null && param is TimerRow)
                    //{
                    //    var tmpParam = (TimerRow)param;
                    //    return tmpParam != null
                    //            && !string.IsNullOrEmpty(tmpParam.Name) && tmpParam.Duration != 0;
                    //}else
                    //{
                    //    return param!=null && param.ToString() == "CANCEL";
                    //}
                    
                };
            }
        }

        public override Action<object> ExecuteAction
        {
            get
            {
                return (param) =>
                {
                    if (param == null || param.ToString() != "CANCEL")
                    {
                        ds.Settings.Save();                        
                        ds.CallCloseDialog(true);
                        ds.Css = new ConfigSettingsSerializer(ds.TimesCollection, ds.Settings);
                        ds.Css.SaveConfigFile();
                        ds.Mvm.TimerVm = new PreviewViewModel(ds);
                    }
                    else
                    {
                        ds.Mvm.PlayListCtr = new PlayListViewModel(ds);
                        ds.CallCloseDialog(false);
                    }

                };
            }
        }
    }
}
