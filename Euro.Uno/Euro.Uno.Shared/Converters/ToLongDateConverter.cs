using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace Euro.Uno.Shared.Converters
{
    public class ToLongDateConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value == null)
                return null;

            var result = DateTime.TryParse(value.ToString(), out DateTime dateTime);

            if (!result)
                return null;

            return dateTime.ToString("dddd dd MMMM yyyy");
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
