using System;
using System.Windows.Threading;
using TimerApp.Model.Abstract;
using TimerApp.Model.Helper;

namespace TimerApp.Model
{
    public class BaseTimer : AbstractViewModel
    {
        DispatcherTimer timer;
        string timerDisplay;
        TimerRow timerRow;
        bool alertStarted;
        SettingsClass settings;
        
        bool isBackgroundBlinking;
        bool isForegroundBlinking;
        bool isBackgroundAlertFile;

        public BaseTimer()
        {
            DisplayTime(0);
            alertStarted = false;            
        }

        public BaseTimer(TimerRow timerRow) //: this()
        {
            this.timerRow = timerRow;
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 0, 1, 0);
            if (timerRow.IsTimerDescending)
                timer.Tick += (obj, ea) =>
                {
                    if (timerRow.RemainingSeconds-- == 0)
                        Stop();
                    else
                    {
                        TimerDisplay = DisplayTime(timerRow.RemainingSeconds);

                        if (!alertStarted)
                            CheckAndStartAlert(timerRow.RemainingSeconds);
                    }
                };
            else
                timer.Tick += (obj, ea) =>
                {
                    if (timerRow.SecondsPassed++ == timerRow.RemainingSeconds)
                        Stop();
                    else
                    {
                        TimerDisplay = DisplayTime(timerRow.SecondsPassed);

                        if (!alertStarted)
                            CheckAndStartAlert(timerRow.RemainingSeconds - timerRow.SecondsPassed);
                    }
                };
            
        }

        private void CheckAndStartAlert(long remainingSeconds)
        {
            if(timerRow.ShouldAlertFire && Settings.PreviewAlertTime > remainingSeconds)
            {
                alertStarted = true;
                if (Settings.PreviewAlertType == PreviewAlertTypeEnum.BackgroundBlink)
                    IsBackgroundBlinking = true;
                else if (Settings.PreviewAlertType == PreviewAlertTypeEnum.TextBlink)
                    IsForegroundBlinking = true;
                else if (Settings.PreviewAlertType == PreviewAlertTypeEnum.Image)
                    IsBackgroundAlertFile = true;
            }
        }

        public void SetTimerRow (TimerRow tr)
        {
            if (tr != null)
            {
                this.timerRow = tr;
                TimerDisplay = timerRow.IsTimerDescending ? DisplayTime(timerRow.RemainingSeconds) : DisplayTime(0);
            }
        }

        private string DisplayTime(long seconds)
        {
            if(seconds>=3600)
                return TimeSpan.FromSeconds(seconds).ToString(@"hh\:mm\:ss");
            else
                return TimeSpan.FromSeconds(seconds).ToString(@"mm\:ss");
        }

        public string TimerDisplay
        {
            get { return timerDisplay; }
            set
            {
                timerDisplay = value;
                OnPropertyChanged(() => TimerDisplay);
            }
        }

        SettingsClass Settings
        {
            get
            {
                if (settings == null)
                    settings = new SettingsClass();
                return settings;
            }
        }

        public TimerRow TimerRow
        {
            get{return timerRow;}
            set
            {
                timerRow = value;
                OnPropertyChanged(() => TimerRow);
            }
        }

        public bool IsForegroundBlinking
        {
            get{return isForegroundBlinking;}
            set
            {
                isForegroundBlinking = value;
                OnPropertyChanged(() => IsForegroundBlinking);
            }
        }

        public bool IsBackgroundBlinking
        {
            get{return isBackgroundBlinking;}
            set
            {
                isBackgroundBlinking = value;
                OnPropertyChanged(() => IsBackgroundBlinking);
            }
        }

        public bool IsBackgroundAlertFile
        {
            get { return isBackgroundAlertFile; }
            set
            {
                isBackgroundAlertFile = value;
                OnPropertyChanged(() => IsBackgroundAlertFile);
            }
        }

      

        public void Start()
        {
            timer.IsEnabled = true;
            timer.Start();
        }

        public void Pause()
        {
            timer.IsEnabled = false;
            IsBackgroundAlertFile = IsBackgroundBlinking = IsForegroundBlinking = alertStarted = false;
        }

        public void Stop()
        {
            if (timer != null)
            {
                timer.Stop();
                timer.IsEnabled = false;
                IsBackgroundAlertFile = IsBackgroundBlinking = IsForegroundBlinking = alertStarted = false;
                timerRow.State = ActionEnum.Stoped;
                timerRow.RemainingSeconds = timerRow.Duration;
                timerRow.SecondsPassed = 0;
            }
            
          //  TimerDisplay = timerRow.IsTimerDescending ? DisplayTime(timerRow.RemainingSeconds) : DisplayTime(0);
        }

        public bool IsRunning()
        {
            return timerRow!=null && (timerRow.State==ActionEnum.Paused || timerRow.State == ActionEnum.Started);
        }

    }

}
