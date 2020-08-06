using System;
using System.Windows.Controls;
using System.Windows.Data;

namespace Fishy.View
{
    public class MultiConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            Tuple<PasswordBox, PasswordBox> tuple = new Tuple<PasswordBox, PasswordBox>((PasswordBox)values[0], (PasswordBox)values[1]);
            return tuple;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
    public class MultiConverter2 : IMultiValueConverter
    {

        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            Tuple<Button, Button> tuple = new Tuple<Button, Button>((Button)values[0], (Button)values[1]);
            return tuple;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
