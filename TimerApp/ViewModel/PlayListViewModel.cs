using TimerApp.Command;
using TimerApp.Model;
using TimerApp.Model.Abstract;

namespace TimerApp.ViewModel
{
    public class PlayListViewModel : AbstractViewModel
    {

        TimerRow selectedTime;
        DataSet ds;
        public PlayListViewModel(DataSet ds)
        {
            this.ds = ds;
            if (ds.TimesCollection == null || ds.TimesCollection.Count == 0)
            {
                FillCollection();
            }
        }
        public DataSet Ds => ds;

        public TimerRow SelectedTime
        {
            get { return selectedTime; }
            set
            {
                selectedTime = value;
                if(!ds.Timer.IsRunning())
                    ds.Timer.SetTimerRow(selectedTime);
                OnPropertyChanged(() => SelectedTime);
            }
        }

        private void FillCollection()
        {
            TimerRow tmp = new TimerRow("Wstęp", 25, "Przykładowa", true, false);
            ds.TimesCollection.Add(tmp);
            tmp = new TimerRow("Rozwinięcie", 120, "Lista");
            ds.TimesCollection.Add(tmp);
            tmp = new TimerRow("Zakończenie", 30, "pa Czasów", false);
            ds.TimesCollection.Add(tmp);
            OnPropertyChanged(() => Ds.TimesCollection);
        }

        AddNewPlayListItemViewCmd addNewPlayListItemViewCmd;
        StartPauseCmd startPauseCmd;
        StopCmd stopCmd;
        EditRowCmd editRowCmd;
        DeleteRowCmd deleteRowCmd;
        RowMovementCmd rowMovementCmd;
        UploadConfigCmd uploadConfigCmd;
        public AddNewPlayListItemViewCmd AddNewPlayListItemViewCmd
        {
            get
            {
                if (addNewPlayListItemViewCmd == null)
                    addNewPlayListItemViewCmd = new AddNewPlayListItemViewCmd(ds);
                return addNewPlayListItemViewCmd;
            }
        }

        public StartPauseCmd StartPauseCmd
        {
            get
            {
                if (startPauseCmd == null)
                    startPauseCmd = new StartPauseCmd(ds, this);
                return startPauseCmd;
            }
        }

        public StopCmd StopCmd
        {
            get
            {
                if (stopCmd == null)
                    stopCmd = new StopCmd(ds, this);
                return stopCmd;
            }
        }

        public EditRowCmd EditRowCmd
        {
            get
            {
                if (editRowCmd == null)
                    editRowCmd = new EditRowCmd(ds);
                return editRowCmd;
            }            
        }
        public DeleteRowCmd DeleteRowCmd
        {
            get
            {
                if (deleteRowCmd == null)
                    deleteRowCmd = new DeleteRowCmd(ds);
                return deleteRowCmd;
            }
        }

        public RowMovementCmd RowMovementCmd
        {
            get
            {
                if (rowMovementCmd == null)
                    rowMovementCmd = new RowMovementCmd(ds, this);
                return rowMovementCmd;
            }
        }

        public UploadConfigCmd UploadConfigCmd
        {
            get
            {
                if (uploadConfigCmd == null)
                    uploadConfigCmd = new UploadConfigCmd(ds);
                return uploadConfigCmd;
            }            
        }
    }
}
