using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimerApp.Command;
using TimerApp.Model;
using TimerApp.Model.Abstract;

namespace TimerApp.ViewModel
{
    public class AddBaseTimerViewModel : AbstractViewModel
    {
        DataSet ds;
        TimerRow newBt;
        AddNewPlayListItemCmd addNewPlayListItemCmd;
        public AddBaseTimerViewModel(DataSet ds, TimerRow bt = null)
        {
            this.ds = ds;
            newBt = bt;
            if (bt != null)
            {
                var t = new TimeSpan(0, 0, (int)bt.Duration);
                DurationHours = t.Hours;
                DurationMinutes = t.Minutes;
                DurationSeconds = t.Seconds;
            }
        }

        public TimerRow NewBt
        {
            get{
                if (newBt == null)
                    newBt = new TimerRow();
                return newBt;
            }
            set
            {
                newBt = value;
                OnPropertyChanged(() => NewBt);
            }
        }

        public AddNewPlayListItemCmd AddNewPlayListItemCmd
        {
            get
            {
                if (addNewPlayListItemCmd == null)
                    addNewPlayListItemCmd = new AddNewPlayListItemCmd(ds);
                return addNewPlayListItemCmd;
            }
        }

        private FireAlertCmd fireAlertCmd;
        public FireAlertCmd FireAlertCmd
        {
            get
            {
                if (fireAlertCmd == null)
                    fireAlertCmd = new FireAlertCmd(ds, this);
                return fireAlertCmd;
            }
        }
        

        private DownToZeroCmd downToZeroCmd;
        public DownToZeroCmd DownToZeroCmd
        {
            get
            {
                if (downToZeroCmd == null)
                    downToZeroCmd = new DownToZeroCmd(ds, this);
                return downToZeroCmd;
            }
        }
        public int DurationHours
        {
            get { return durationHours; }

            set
            {
                durationHours = value;
                OnPropertyChanged(() => DurationHours);
                NewBt.Duration = DurationHours * 3600 + DurationMinutes * 60 + DurationSeconds;
            }
        }

        public int DurationMinutes
        {
            get { return durationMinutes; }

            set
            {
                durationMinutes = value;
                OnPropertyChanged(() => DurationMinutes);
                NewBt.Duration = DurationHours * 3600 + DurationMinutes * 60 + DurationSeconds;
            }
        }


        public int DurationSeconds
        {
            get { return durationSeconds; }

            set
            {
                durationSeconds = value;
                OnPropertyChanged(() => DurationSeconds);
                NewBt.Duration = DurationHours * 3600 + DurationMinutes * 60 + DurationSeconds;
            }
        }

        int durationHours;
        int durationMinutes;
        int durationSeconds;
    }
}
