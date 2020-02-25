using System;
using System.Windows.Data;

namespace TableTetaUI.Converter
{
    public class InvertBooleanConverter : IValueConverter 
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value is Boolean && (bool)value)
            {
                return !(bool)value;
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value is Boolean && (bool)value)
            {
                return !(bool)value;
            }
            return null;
        }
    }
}
