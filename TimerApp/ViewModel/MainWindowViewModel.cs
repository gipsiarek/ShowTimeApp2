using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TimerApp.Command;
using TimerApp.Model;
using TimerApp.Model.Abstract;
using TimerApp.Model.Helper;
using TimerApp.View;

namespace TimerApp.ViewModel
{
    public class MainWindowViewModel : AbstractViewModel
    {
      
        AbstractViewModel timerVm;
        AbstractViewModel playListCtr;
        AbstractViewModel messageSenderCtr;
        PreviewSettingsViewModel settingsCtr;
        AddBaseTimerViewModel addTimerCtr;
        public PreviewSettingsViewModel PreviewSettingsViewModel;
        PresenterWindow presenterWindow;
        public PresenterWindow PWindow => presenterWindow;
        DataSet ds;
        public MainWindowViewModel()
        {
            ds = new DataSet(this);
            playListCtr = new PlayListViewModel(ds);
            timerVm = new PreviewViewModel(ds);
            messageSenderCtr = new MessageSenderViewModel(ds, (PreviewViewModel)timerVm);

            OpenPresenterWindow();
        }


        PreviewSettingsViewCmd previewSettingsViewCmd;
        public PreviewSettingsViewCmd PreviewSettingsViewCmd
        {
            get
            {
                if (previewSettingsViewCmd == null)
                    previewSettingsViewCmd = new PreviewSettingsViewCmd(ds);
                return previewSettingsViewCmd;
            }
        }

        private void OpenPresenterWindow()
        {
            presenterWindow = new PresenterWindow();
            presenterWindow.DataContext = this;
            presenterWindow.Closing += (s, e) =>
            {
                var result = MessageBox.Show("Na pewno zamknąć okno i wyłączyć aplikację?", "Uwaga", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                    Environment.Exit(0);
                else
                    e.Cancel = true;
            };
            presenterWindow.Show();
            MoveWindow.MaximizeToSecondaryMonitor(presenterWindow);
        }

        


        public AbstractViewModel TimerVm
        {
            get{return timerVm;}

            set
            {
                timerVm = value;
                OnPropertyChanged(() =>TimerVm);
            }
        }

        public AbstractViewModel PlayListCtr
        {
            get{return playListCtr;}

            set
            {
                playListCtr = value;
                OnPropertyChanged(() =>PlayListCtr);
            }
        }

        public AbstractViewModel MessageSenderCtr
        {
            get{return messageSenderCtr;}

            set
            {
                messageSenderCtr = value;
                OnPropertyChanged(() => messageSenderCtr);
            }

        }
        public PreviewSettingsViewModel SettingsCtr
        {
            get
            {
                if (settingsCtr == null) settingsCtr = new PreviewSettingsViewModel(ds);
                return settingsCtr;
            }
            set
            {
                settingsCtr = value;
                OnPropertyChanged(() => SettingsCtr);
            }
        }

        public AddBaseTimerViewModel AddTimerCtr
        {
            get
            {
                return addTimerCtr;
            }

            set
            {
                addTimerCtr = value;
                OnPropertyChanged(() => AddTimerCtr);
            }
        }
    }
   
}
