using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace TimerApp.Model.Helper
{
    public class HeightConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values != null 
                && values.Count() == 3 
                && values[0] is Grid
                && values[1] is SettingsClass
                && values[2] is RowDefinition
                )
            {

                var grid = (Grid)values[0];
                var settings = (SettingsClass)values[1];
                var row = (RowDefinition)values[2];
                if(settings.LogoGridRow==int.Parse(row.Name[row.Name.Count()-1].ToString()))
                {
                    return new GridLength(100 - (100 - settings.LogoHeight), GridUnitType.Star); 
                }
                else
                {
                    return new GridLength(100 - settings.LogoHeight, GridUnitType.Star);
                }               
            }
            else return "*";
        }

        public object Convert(object value, Type TargetType, object parameter, CultureInfo culture)
        {
            int x = MoveWindow.getHeight;
            return x / 10;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
