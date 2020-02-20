using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace GetSlabReinfResult.Converter
{
    public class ConvertTrueToGetSlabData : IValueConverter 
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool)
            {
                return (bool)value ? "Get slab data" : "Cancel";
            }
            return new SolidColorBrush();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string)
            {
                return (value as string)== "Get slab data"? true:false;
            }
            return null;
        }
    }
    
}
