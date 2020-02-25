using System;
using System.Windows.Data;

namespace TableTetaUI.Converter
{
    public class RoundDoubleConverter : IValueConverter 
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            int decimals;
            if (parameter is int)
                decimals = (int)parameter;
            else decimals= 2;

            if (value is double)
            {
                return Math.Round((double)value, decimals);
            }
            return 0;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return value;
        }
    }
}
