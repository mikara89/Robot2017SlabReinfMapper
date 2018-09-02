using System;
using System.Globalization;
using System.Windows.Data;

namespace GetSlabReinfResult.Converter
{
    public class ConvertDrawingAsTypeToEnumAType : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is GenerateIsolines.DrawAsType)
            {
                var val = (GenerateIsolines.DrawAsType)value;
                var par = (parameter as string);
                var r= GenerateIsolines.DrawDxf.GetDrawAsTypeAsString(val) == par;
                return GenerateIsolines.DrawDxf.GetDrawAsTypeAsString(val) == par;
            }
            return null;

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool && (bool)value)
            {
                var val = (bool)value;
                var par = GenerateIsolines.DrawDxf.GetStringAsDrawAsType((string)parameter);
                return par;
            }
            return null;
        }
    }
}
