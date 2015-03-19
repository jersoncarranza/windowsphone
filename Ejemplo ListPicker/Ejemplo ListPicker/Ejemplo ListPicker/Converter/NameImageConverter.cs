using System;
using System.Globalization;
using System.Windows.Media.Imaging;

namespace Ejemplo_ListPicker.Converter
{
    public class NameImageConverter : System.Windows.Data.IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string)
                return string.Format("/IMGS/{0}.jpg", (string)value);

            throw new NotSupportedException();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
