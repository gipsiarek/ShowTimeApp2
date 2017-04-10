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
    public class WidthConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values != null
                && values.Count() == 3
                && values[0] is Grid
                && values[1] is SettingsClass
                && values[2] is ColumnDefinition
                )
            {

                var grid = (Grid)values[0];
                var settings = (SettingsClass)values[1];
                var row = (ColumnDefinition)values[2];
                if (settings.LogoGridColumn == int.Parse(row.Name[row.Name.Count() - 1].ToString()))
                {
                    return new GridLength(100 - (100 - settings.LogoWidth), GridUnitType.Star);
                }
                else
                {
                    return new GridLength(100 - settings.LogoWidth, GridUnitType.Star); 
                }
            }
            else return "*";
        }



        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

    }
}
