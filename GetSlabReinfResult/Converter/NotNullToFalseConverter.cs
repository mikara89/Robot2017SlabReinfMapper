using System;
using System.Windows.Data;

namespace GetSlabReinfResult.Converter
{
    public class NotNullToFalseConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        { 
            if (value != null)
            {
                return false;
            }
            return true;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value is false)
            {
                return new object();
            }
            return null;
        }
    }
}
