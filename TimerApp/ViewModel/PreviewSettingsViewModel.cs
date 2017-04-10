using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimerApp.Command;
using TimerApp.Model;
using TimerApp.Model.Abstract;
using TimerApp.Model.Helper;

namespace TimerApp.ViewModel
{
    public class PreviewSettingsViewModel : AbstractViewModel
    {
        DataSet ds;
        PreviewSettingsCmd previewSettingsCmd;
        GetBgImageFileCmd getBgImageFileCmd;

        string logoFile;
        string bgFile;
        string alertFile;
        public string LogoFile
        {
            get { return logoFile; }
            set
            {
                logoFile = value;
                OnPropertyChanged(() => LogoFile);
            }
        }
        public string BgFile
        {
            get { return bgFile; }
            set
            {
                bgFile = value;
                OnPropertyChanged(() => BgFile);
            }
        } 

        public PreviewSettingsViewModel(DataSet ds)
        {
            this.ds = ds;
            this.logoFile = ds?.Settings?.LogoPreviewFile?.Split('\\')[ds.Settings.LogoPreviewFile.Count(x => x == '\\')];
            this.bgFile = ds?.Settings?.BackgroundPreviewFile?.Split('\\')[ds.Settings.BackgroundPreviewFile.Count(x => x == '\\')];
            this.alertFile = ds?.Settings?.AlertPreviewFile?.Split('\\')[ds.Settings.AlertPreviewFile.Count(x => x == '\\')];

        }
        public DataSet Ds => ds;

        public PreviewSettingsCmd PreviewSettingsCmd
        {
            get
            {
                if (previewSettingsCmd == null)
                    previewSettingsCmd = new PreviewSettingsCmd(ds);
                return previewSettingsCmd;
            }
            
        }

        public GetBgImageFileCmd GetBgImageFileCmd
        {
            get
            {
                if (getBgImageFileCmd == null)
                    getBgImageFileCmd = new GetBgImageFileCmd(ds, this);
                return getBgImageFileCmd;
            }
        }

        public string AlertFile
        {
            get{return alertFile;}
            set
            {
                alertFile = value;
                OnPropertyChanged(() => AlertFile);
            }
        }
    }
}
