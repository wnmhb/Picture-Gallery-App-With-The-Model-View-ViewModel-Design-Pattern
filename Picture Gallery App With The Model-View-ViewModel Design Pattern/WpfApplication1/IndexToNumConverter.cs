using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Data;

namespace WpfApplication1
{
    public class IndexToNumConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            int n = 0;
            if (value != null)
            {
                Int32.TryParse(value.ToString(), out n);
            }
            return n + 1;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            int n = 0;
            if (value != null)
            {
                Int32.TryParse(value.ToString(), out n);
            }
            return n - 1;
        }
    }
}
