using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace GetSlabReinfResult.Converter
{
    public class ConvertATypeToEnumAType : IValueConverter 
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is GenerateIsolines.A_Type)
            {
                var val = (GenerateIsolines.A_Type)value;
                var par= (parameter as string);
                return GenerateIsolines.FE.GetA_TypeAsString(val) == par;
            }
            return null;
          
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool && (bool)value)
            {
                var val = (bool)value;
                var par = GenerateIsolines.FE.GetStringAsA_Type((string)parameter);
                return par;
            }
            return null;
        }
    }
}
