using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;
using System.Xml.Serialization;
using TimerApp.Model.Abstract;
using TimerApp.Model.Helper;
using TimerApp.ViewModel;

namespace TimerApp.Model
{
    public class DataSet  : AbstractViewModel
    {
        MainWindowViewModel mvm;
        BaseTimer timer;
        SettingsClass settings;
        public delegate void MyEventEventHandler(bool res);
        public event MyEventEventHandler OnRequestClose;
        ConfigSettingsSerializer css;

        //DateTime start;
        //string timerDisplay;

        public DataSet(MainWindowViewModel mvm)
        {
            this.Mvm = mvm;
            timer = new BaseTimer();
            Css = new ConfigSettingsSerializer();
            Css.ReadConfigFile();
            TimesCollection = Css.PlayList;
            Settings = Css.Settings;
          
        }

        private ObservableCollection<TimerRow> LoadCollectionFromFile()
        {
            throw new NotImplementedException();
        }

        public MainWindowViewModel Mvm
        {
            get{return mvm;}
            set
            {
                mvm = value;
                OnPropertyChanged(()=>Mvm);
            }
        }

        ObservableCollection<TimerRow> timesCollection;
        string messageForPresenter;

        public ObservableCollection<TimerRow> TimesCollection
        {
            get { return timesCollection; }
            set
            {
                timesCollection = value;
                OnPropertyChanged(() => TimesCollection);
            }
        }

        internal void CallCloseDialog(bool result)
        {
            OnRequestClose(result);
        }

        public BaseTimer Timer
        {
            get{return timer;}
            set
            {
                timer = value;
                OnPropertyChanged(() => Timer);
            }
        }

        public SettingsClass Settings
        {
            get { return settings; }
            set
            {
                settings = value;
                OnPropertyChanged(() => Settings);
            }
        }

        public string MessageForPresenter
        {
            get{return messageForPresenter;}
            set
            {
                messageForPresenter = value;
                OnPropertyChanged(() => MessageForPresenter);
            }
        }

        internal ConfigSettingsSerializer Css
        {
            get
            {
                return css;
            }

            set
            {
                css = value;
            }
        }



    }
}
