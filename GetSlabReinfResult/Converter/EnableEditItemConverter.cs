using System;
using System.Windows.Data;
using GetSlabReinfResult.ViewModel;

namespace GetSlabReinfResult.Converter
{
    public class EnableEditItemConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if ((value is string))
            {
                return (string)value == "Max" || (string)value == "Min" ? true : false;
            }
            return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {

            return (bool)value ? "" : "Max"; ;
        }
    }

}
