using System;
using System.Windows;
using System.Xml.Serialization;
using TimerApp.Model.Abstract;
using TimerApp.Model.Helper;

namespace TimerApp.Model
{
    [Serializable()]
    public class TimerRow : AbstractViewModel
    {
        [XmlIgnore] ActionEnum state;
        string name;
        long duration;
        [XmlIgnore]long remainingSeconds;
        [XmlIgnore]long secondsPassed;
        string comments;
        bool isTimerDescending;
        bool shouldAlertFire;

        public TimerRow(string name, long duration, string comments, bool isTimerDescending = true, bool shouldAlertFire = true)
        {
            this.name = name;
            this.duration = duration;
            this.comments = comments;
            this.isTimerDescending = isTimerDescending;
            this.shouldAlertFire = shouldAlertFire;
            remainingSeconds = (int)duration;
            SecondsPassed = 0;
            state = ActionEnum.Stoped;

        }
        public TimerRow()
        {
            state = ActionEnum.Stoped;
            IsTimerDescending = true;
            ShouldAlertFire = true;
        }

        [XmlIgnore]
        public ActionEnum State
        {
            get { return state; }
            set
            {
                state = value;
                OnPropertyChanged(() => State);
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged(() => Name);
            }
        }

        public long Duration
        {
            get { return duration; }
            set
            {
                duration = value;
                OnPropertyChanged(() => Duration);
            }
        }

        public string Comments
        {
            get { return comments; }
            set
            {
                comments = value;
                OnPropertyChanged(() => Comments);
            }
        }

        [XmlIgnore]
        public long RemainingSeconds
        {
            get { return remainingSeconds; }
            set
            {
                remainingSeconds = value;
                OnPropertyChanged(() => RemainingSeconds);
            }
        }

        public bool IsTimerDescending
        {
            get { return isTimerDescending; }
            set
            {
                isTimerDescending = value;
                OnPropertyChanged(() => IsTimerDescending);
            }
        }

        [XmlIgnore]
        public long SecondsPassed
        {
            get { return secondsPassed; }
            set
            {
                secondsPassed = value;
                OnPropertyChanged(() => SecondsPassed);
            }
        }
        public bool ShouldAlertFire
        {
            get { return shouldAlertFire; }

            set
            {
                shouldAlertFire = value;
                OnPropertyChanged(() => ShouldAlertFire);
            }
        }

        public string DurationDisplay
        {
            get
            {
                if (Duration >= 3600)
                    return TimeSpan.FromSeconds(Duration).ToString(@"hh\:mm\:ss");
                else
                    return TimeSpan.FromSeconds(Duration).ToString(@"mm\:ss");
            }
        }


        public bool IsRunning()
        {
            return this != null && (this.State == ActionEnum.Paused || this.State == ActionEnum.Started);
        }
    }
}
