using System;
using System.Windows.Data;

namespace GetSlabReinfResult.Converter
{
    public class BooleanToHeightConverter : IValueConverter 
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value is Boolean && (bool)value)
            {
                return (bool)value?500:200;
            }
            return 200;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value is double && (double)value ==500)
            {
                return true;
            }
            return false;
        }
    }
}
