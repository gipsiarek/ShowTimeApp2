using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Xml.Serialization;
using TimerApp.Model.Abstract;
using TimerApp.Properties;

namespace TimerApp.Model
{
    //[XmlRootAttribute("Settings", Namespace = "TimerApp.Model.Helper", IsNullable = false)]
    [Serializable]
    public class SettingsClass : AbstractViewModel
    {
        Color previewBackgroundColor;
        Color previewTextColor;
        Color previewMessageColor;
        long previewAlertTime;
        PreviewAlertTypeEnum previewAlertType;
        PreviewLogoPositionEnum previewLogoPosition;
        int previewTimeFontSize;
        int previewMessageFontSize;
        string backgroundPreviewFile;
        string logoPreviewFile;
        string alertPreviewFile;
        int logoWidth;
        int logoHeight;

        public SettingsClass()
        {
            previewBackgroundColor = Settings.Default.PreviewBackgroundColor;
            previewTextColor = Settings.Default.PreviewTextColor;
            previewMessageColor = Settings.Default.PreviewMessageColor;
            previewAlertTime = Settings.Default.PreviewAlertTime;
            previewAlertType = setAlertType(Settings.Default.PreviewAlertType);

            previewLogoPosition = setLogoPosition(Settings.Default.PreviewLogoPosition);
            previewTimeFontSize = Settings.Default.PreviewTimeFontSize;
            previewMessageFontSize = Settings.Default.PreviewMessageFontSize;
            logoPreviewFile = Settings.Default.LogoPreviewFile;
            backgroundPreviewFile = Settings.Default.BackgroundPreviewFile;
            alertPreviewFile = Settings.Default.AlertPreviewFile;
            logoHeight = Settings.Default.LogoHeght;
            LogoWidth = Settings.Default.LogoWidth;
        }

        private PreviewAlertTypeEnum setAlertType(string previewAlertType)
        {
            if (PreviewAlertTypeEnum.BackgroundBlink.ToString() == previewAlertType)
                return PreviewAlertTypeEnum.BackgroundBlink;
            else if (PreviewAlertTypeEnum.Image.ToString() == previewAlertType)
                return PreviewAlertTypeEnum.Image;
            else
                return PreviewAlertTypeEnum.TextBlink;
        }

        private PreviewLogoPositionEnum setLogoPosition(string pos)
        {
            if (PreviewLogoPositionEnum.Left_Bottom.ToString() == pos)
                return PreviewLogoPositionEnum.Left_Bottom;
            else if (PreviewLogoPositionEnum.Left_Top.ToString() == pos)
                return PreviewLogoPositionEnum.Right_Top;
            else if (PreviewLogoPositionEnum.Right_Bottom.ToString() == pos)
                return PreviewLogoPositionEnum.Right_Bottom;
            else if (PreviewLogoPositionEnum.Left_Top.ToString() == pos)
                return PreviewLogoPositionEnum.Left_Top;
            return PreviewLogoPositionEnum.Right_Bottom;
        }

        public Color PreviewBackgroundColor
        {
            get { return previewBackgroundColor; }
            set
            {
                previewBackgroundColor = value;
                OnPropertyChanged(() => PreviewBackgroundColor);
            }
        }

        public Color PreviewTextColor
        {
            get { return previewTextColor; }
            set
            {
                previewTextColor = value;
                OnPropertyChanged(() => PreviewTextColor);
            }
        }
        public long PreviewAlertTime
        {
            get { return previewAlertTime; }
            set
            {
                previewAlertTime = value;
                OnPropertyChanged(() => PreviewAlertTime);
            }
        }

        public int PreviewTimeFontSize
        {
            get { return previewTimeFontSize; }
            set
            {
                previewTimeFontSize = value;
                OnPropertyChanged(() => PreviewTimeFontSize);
            }
        }

        public PreviewAlertTypeEnum PreviewAlertType
        {
            get { return previewAlertType; }
            set
            {
                previewAlertType = value;
                OnPropertyChanged(() => PreviewAlertTime);
            }
        }

        public PreviewLogoPositionEnum PreviewLogoPosition
        {
            get { return previewLogoPosition; }
            set
            {
                previewLogoPosition = value;
                OnPropertyChanged(() => PreviewLogoPosition);
                OnPropertyChanged(() => LogoGridRow);
                OnPropertyChanged(() => LogoGridColumn);
                OnPropertyChanged(() => ColspanForMessage);
                OnPropertyChanged(() => NonLogoSite);
                OnPropertyChanged(() => NonLogoColumn);
                OnPropertyChanged(() => LogoHorizontal);
                OnPropertyChanged(() => LogoVertical);
            }
        }

        public string BackgroundPreviewFile
        {
            get { return backgroundPreviewFile; }
            set
            {
                backgroundPreviewFile = value;
                OnPropertyChanged(() => BackgroundPreviewFile);
            }
        }

        public string LogoPreviewFile
        {
            get { return logoPreviewFile; }
            set
            {
                logoPreviewFile = value;
                OnPropertyChanged(() => LogoPreviewFile);
            }
        }

        public int LogoHeight
        {
            get { return logoHeight; }
            set
            {
                logoHeight = value;
                OnPropertyChanged(() => LogoHeight);
            }
        }

        public int LogoWidth
        {
            get { return logoWidth; }
            set
            {
                logoWidth = value;
                OnPropertyChanged(() => LogoWidth);
            }
        }

        public string AlertPreviewFile
        {
            get { return alertPreviewFile; }
            set
            {
                alertPreviewFile = value;
                OnPropertyChanged(() => AlertPreviewFile);
            }
        }

        public Color PreviewMessageColor
        {
            get { return previewMessageColor; }
            set
            {
                previewMessageColor = value;
                OnPropertyChanged(() => PreviewMessageColor);
            }
        }

        public int PreviewMessageFontSize
        {
            get { return previewMessageFontSize; }
            set
            {
                previewMessageFontSize = value;
                OnPropertyChanged(() => PreviewMessageFontSize);
            }
        }

        public void Save()
        {
            Settings.Default.PreviewBackgroundColor = PreviewBackgroundColor;
            Settings.Default.PreviewTextColor = PreviewTextColor;
            Settings.Default.PreviewMessageColor = PreviewMessageColor;
            Settings.Default.PreviewAlertTime = PreviewAlertTime;
            Settings.Default.PreviewAlertType = PreviewAlertType.ToString();
            Settings.Default.PreviewLogoPosition = PreviewLogoPosition.ToString();
            Settings.Default.PreviewTimeFontSize = PreviewTimeFontSize;
            Settings.Default.PreviewMessageFontSize = PreviewMessageFontSize;
            Settings.Default.BackgroundPreviewFile = BackgroundPreviewFile;
            Settings.Default.LogoPreviewFile = LogoPreviewFile;
            Settings.Default.AlertPreviewFile = AlertPreviewFile;
            Settings.Default.LogoWidth = LogoWidth;
            Settings.Default.LogoHeght = LogoHeight;

            Settings.Default.Save();
        }

        public int LogoGridColumn
        {
            get
            {
                return previewLogoPosition == PreviewLogoPositionEnum.Left_Bottom || previewLogoPosition == PreviewLogoPositionEnum.Left_Top ? 0 : 1;
            }
        }
        public int NonLogoColumn { get { return LogoGridColumn == 1 ? 0 : 1; } }
        public string NonLogoSite { get { return LogoGridColumn == 1 ? "Left" : "Right"; } }
        public string LogoHorizontal { get { return LogoGridColumn == 0 ? "Left" : "Right"; } }
        public string LogoVertical  { get { return LogoGridRow == 0 ? "Top" : "Bottom"; } }

        public int LogoGridRow
        {
            get
            {
                return previewLogoPosition == PreviewLogoPositionEnum.Right_Top || previewLogoPosition == PreviewLogoPositionEnum.Left_Top ? 0 : 1;
            }
        }

        public int ColspanForMessage { get { return LogoGridRow == 0 ? 2 : 1; } }
        public int MessageColumn { get { return ColspanForMessage == 2 ? 0 : NonLogoColumn; } }
    }
        
    public enum PreviewLogoPositionEnum
    {
        Left_Top = 1,
        Right_Top = 2,
        Left_Bottom = 3,
        Right_Bottom = 4

    }

    public enum PreviewAlertTypeEnum
    {
        TextBlink = 1,
        BackgroundBlink = 2,
        Image = 3
    }
}
