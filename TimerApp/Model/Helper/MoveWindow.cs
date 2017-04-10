using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TimerApp.Model.Helper
{
    public static class MoveWindow
    {
        public static int SecondaryMonitorHeight { get; private set; }
        public static int SecondaryMonitorWidth { get; private set; }
        public static void MaximizeToSecondaryMonitor(this Window window)
        {
            var secondaryScreen = System.Windows.Forms.Screen.AllScreens.Where(s => !s.Primary).FirstOrDefault();

            if (secondaryScreen != null)
            {
                if (!window.IsLoaded)
                    window.WindowStartupLocation = WindowStartupLocation.Manual;

                var workingArea = secondaryScreen.WorkingArea;
                window.Left = workingArea.Left;
                window.Top = workingArea.Top;
                window.Width = workingArea.Width;
                window.Height = workingArea.Height;
                SecondaryMonitorWidth = workingArea.Width;
                SecondaryMonitorHeight = workingArea.Height;
                // If window isn't loaded then maxmizing will result in the window displaying on the primary monitor
                if (window.IsLoaded)
                    window.WindowState = WindowState.Maximized;
            }
            else
            {
                MessageBox.Show("Problem z wykryciem drugiego ekranu. Upewnij się że urządzenie jest poprawnie podłączone i uruchomione.",
                    "Uwaga");
            }
        }

        public static int getWidth
        {
            get
            {
                var secondaryScreen = System.Windows.Forms.Screen.AllScreens.Where(s => !s.Primary).FirstOrDefault();
                var workingArea = secondaryScreen.WorkingArea;
                return workingArea.Width;
            }
        }
        public static int getHeight
        {
            get
            {
                var secondaryScreen = System.Windows.Forms.Screen.AllScreens.Where(s => !s.Primary).FirstOrDefault();
                var workingArea = secondaryScreen.WorkingArea;
                return workingArea.Height;
            }
        }
    }
}
