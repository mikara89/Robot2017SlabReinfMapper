using System;
using System.Windows.Data;

namespace GetSlabReinfResult.Converter
{
    public class StringToDoubleConverter : IValueConverter 
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value is string)
            {
                double r=0;
                if (Double.TryParse((string)value,out r))
                {
                    return r;
                }
                return null;
            }
            if (value is double)
            {
                return ((double)value).ToString();
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return Convert( value,  targetType,  parameter,culture);
        }
    }
}
