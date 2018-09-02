using System;
using System.Windows;
using System.Windows.Data;

namespace GetSlabReinfResult.Converter
{
    public class NotNullToVisibilityConverter : IValueConverter 
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value !=null)
            {
                return Visibility.Visible;
            }
            return Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value is Visibility)
            {
                return new object();
            }
            return null;
        }
    }
}
