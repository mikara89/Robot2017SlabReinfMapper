using System;
using System.Globalization;
using System.Windows.Data;

namespace GetSlabReinfResult.Converter
{
    public class ConvertScaleTypeToInt : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is int) 
            {
                var val = (int)value;
                
                int par;
                int.TryParse((string)parameter, out par);
                if (val == par) return true;
            }
            return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool && (bool)value)
            {
                var val = (bool)value;
                int par;
                int.TryParse((string)parameter, out par);
                return par;
            }
            return null;
        }

    }
}
