using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TimerApp.Model;
using TimerApp.Model.Abstract;
using TimerApp.View;
using TimerApp.ViewModel;

namespace TimerApp.Command
{
    public class PreviewSettingsViewCmd : AbstractCommand
    {
        DataSet ds;

        public PreviewSettingsViewCmd(DataSet ds)
        {
            this.ds = ds;
        }
        public override Func<object, bool> CanExecuteAction
        {
            get
            {
                return (param) =>
                {
                    return true;
                };
            }
        }

        public override Action<object> ExecuteAction
        {
            get
            {
                return (param) =>
                {
                    if (ds.Timer.IsRunning())
                    {
                        MessageBoxResult res = MessageBox.Show("Czy zatrzymać timer i uruchomić ustawienia panelu?", "Uwaga", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                        if (res == MessageBoxResult.Yes)
                        {
                            ds.Timer.Stop();
                            SettingsWindow settingsWindow = new SettingsWindow();
                            settingsWindow.DataContext = ds.Mvm;
                            settingsWindow.SizeToContent = SizeToContent.WidthAndHeight;
                            settingsWindow.Owner = Application.Current.MainWindow;
                            settingsWindow.ShowInTaskbar = false;
                            settingsWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
                            ds.OnRequestClose += (e) =>
                            {
                                settingsWindow.Close();
                            };
                            settingsWindow.ShowDialog();               
                        }
                    }
                    else
                    {
                        SettingsWindow settingsWindow = new SettingsWindow();
                        settingsWindow.DataContext = ds.Mvm;
                        settingsWindow.SizeToContent = SizeToContent.WidthAndHeight;
                        settingsWindow.Owner = Application.Current.MainWindow;
                        settingsWindow.ShowInTaskbar = false;
                        settingsWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
                        ds.OnRequestClose += (e) =>
                        {
                            settingsWindow.Close();
                        };
                        settingsWindow.ShowDialog();                            
                    }
                };
            }
        }
    }
}
