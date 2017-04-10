using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TimerApp.Model
{
    [Serializable()]
    public class ConfigSettingsSerializer
    {
        ObservableCollection<TimerRow> playlist;
        SettingsClass settings;

        public ConfigSettingsSerializer()
        {
            this.settings = new SettingsClass();
            this.playlist = new ObservableCollection<TimerRow>();
        }
        public ConfigSettingsSerializer(ObservableCollection<TimerRow> time, SettingsClass settings)
        {
            this.settings = settings;
            this.playlist = time;
        }
        public ObservableCollection<TimerRow> PlayList
        {
            get
            {
                return playlist;
            }

            set
            {
                playlist = value;
            }
        }
        public SettingsClass Settings
        {
            get
            {
                return settings;
            }

            set
            {
                settings = value;
            }
        }

        public void SaveConfigFile()
        {
            using (Stream stream = File.Open("ConfigSetings.e4e", FileMode.Create))
            {
                //BinaryFormatter bin = new BinaryFormatter();
                XmlSerializer bin = new XmlSerializer(typeof(ConfigSettingsSerializer));
                bin.Serialize(stream, this);
                
            }
        }

        public void ReadConfigFile()
        {
            try
            {
                using (Stream stream = File.Open("ConfigSetings.e4e", FileMode.Open))
                {
                    XmlSerializer bin = new XmlSerializer(typeof(ConfigSettingsSerializer));
                    var tmp = (ConfigSettingsSerializer)bin.Deserialize(stream);
                    PlayList = new ObservableCollection<TimerRow>();
                    foreach (var item in tmp.PlayList)
                    {
                        PlayList.Add(new TimerRow(item.Name, item.Duration, item.Comments, item.IsTimerDescending, item.ShouldAlertFire));
                    } 
                    Settings = tmp.Settings;
                }
            } catch(FileNotFoundException)
            {
                
            }
        }
    }
}
