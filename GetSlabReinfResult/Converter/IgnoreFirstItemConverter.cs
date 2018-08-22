using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Data;
using GetSlabReinfResult.ViewModel;

namespace GetSlabReinfResult.Converter
{
    public class IgnoreFirstItemConverter : IValueConverter 
    {
        private LegendItemViewModel ignored;
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if ((value is double))
            {


                return (double)value == 0.01 ? true:false;
            }
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {

            return (bool)value ? 0.01 : 0; ;
        }
    }

}
