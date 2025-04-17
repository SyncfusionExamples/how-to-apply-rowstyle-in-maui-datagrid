using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfDataGridSample
{
    public class Converter : IValueConverter
    {       

        object IValueConverter.Convert(object value, Type targetType, object parameter, CultureInfo info)
        {
            int _value = (int)value;
            if (_value % 2 == 0)
                return Colors.Yellow;
            return Colors.Transparent;
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
