using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace MathStat.Styles
{
    public class ImageConverter : IValueConverter
    {
        public object Convert(
            object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                return new BitmapImage(new Uri(value.ToString(), UriKind.Relative));
            }
            throw new ArgumentException("ImageConverter value must be set");
        }

        public object ConvertBack(
            object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
