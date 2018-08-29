using System;
using System.Windows.Data;
using GetSlabReinfResult.ViewModel;

namespace GetSlabReinfResult.Converter
{
    public class IsEnabledRemoveButtonConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if ((value is LegendItemViewModel))
            {
                return (value as LegendItemViewModel) != null ? true : false;
            }
            return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {

            return (bool)value ? 0.01 : 0;
        }
    }

}
