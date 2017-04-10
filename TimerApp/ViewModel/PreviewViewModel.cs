using System;
using System.IO;
using System.Windows.Media;
using System.Xml.Serialization;
using TimerApp.Command;
using TimerApp.Model;
using TimerApp.Model.Abstract;

namespace TimerApp.ViewModel
{
    public class PreviewViewModel : AbstractViewModel
    {

        Brush previewBackgroundColor;
        Brush previewTextColor;
        Brush previewMessageColor;
        int fontSize;
        int messageFontSize;
        
        DataSet ds;
        public PreviewViewModel(DataSet ds)
        {
            this.ds = ds;
            previewBackgroundColor = new SolidColorBrush(ds.Settings.PreviewBackgroundColor);
            previewTextColor = new SolidColorBrush(ds.Settings.PreviewTextColor);
            previewMessageColor = new SolidColorBrush(ds.Settings.PreviewMessageColor);
            //previewTextColor = ds.Settings.PreviewTextColor;
            FontSize =ds.Settings.PreviewTimeFontSize;

        }

        public DataSet Ds => ds;



        public Brush PreviewBackgroundColor
        {
            get { return previewBackgroundColor; }
            set
            {
                previewBackgroundColor = value;
                OnPropertyChanged(() => PreviewBackgroundColor);
            }
        }

        public Brush PreviewTextColor
        {
            get { return previewTextColor; }
            set
            {
                previewTextColor = value;
                OnPropertyChanged(() => PreviewTextColor);
            }
        }

        public int FontSize
        {
            get{return fontSize;}
            set
            {
                fontSize = value;
                OnPropertyChanged(() => FontSize);
            }
        }

        public Brush PreviewMessageColor
        {
            get{return previewMessageColor;}
            set
            {
                previewMessageColor = value;
                OnPropertyChanged(() => PreviewMessageColor);
            }
        }

        public int MessageFontSize
        {
            get{return messageFontSize;}
            set
            {
                messageFontSize = value;
                OnPropertyChanged(() => MessageFontSize);
            }
        }

        public string Today { get { return DateTime.Now.Date.ToString("dd.MM.yyyy");} }
    }
}
