using System;
using System.Windows.Data;
using GetSlabReinfResult.ViewModel;

namespace GetSlabReinfResult.Converter
{
    public class IsTrueIfNotNullConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
             return value!= null ? true : false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {

            return (bool)value ? 0.01 : 0;
        }
    }

}
