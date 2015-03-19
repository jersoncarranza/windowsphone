using System;
using System.Globalization;
using System.Windows.Media.Imaging;
using System.Windows.Media;

namespace Ejemplo_ListPicker.Converter
{
    public class ScuderiaColorConverter : System.Windows.Data.IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string)
            {
                switch ((string)value)
                {
                    case "Ferrari":
                        return new SolidColorBrush(Colors.Red);
                    case "McLaren":
                        return new SolidColorBrush(Colors.Gray);
                    case "RedBull":
                        return new SolidColorBrush(Colors.Blue);
                }
            }

            throw new NotSupportedException();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
