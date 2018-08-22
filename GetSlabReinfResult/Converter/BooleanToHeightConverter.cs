using System;
using System.Globalization;
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
    public class BooleanToHeightMultiConverter : IMultiValueConverter  
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values[0] is Boolean && (bool)values[0])
            {
                return (bool)values[0] ? 260 + (int)values[1] *25 : 200;
            }
            return 200;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

}
