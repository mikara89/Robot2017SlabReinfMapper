using System;
using System.Globalization;
using System.Linq;
using System.Windows.Data;

namespace GetSlabReinfResult.Converter
{
    public class PathMultiValueConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return String.Format("{0}{1}", values[0], values[1]);
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            var obj2 = (value as string).Split('\\').Last();

            var obj1 = (value as string).Substring(0, (value as string).Length - obj2.Length);
            if (String.IsNullOrEmpty(obj2))
                obj2 = "noname.dxf";
            if (obj2.Length < 5)
                obj2 = obj2 + ".dxf";

            if (obj2.Length>=5 && obj2.Substring(obj2.Length-4,4)!= ".dxf")
                obj2 = obj2+".dxf";
            

            return new object[] { obj1, obj2 };
        }
    }
}
