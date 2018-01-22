using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace MasterDetailSample
{
    class BoolToSwitchingStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value != null)
            {
                if ((bool)value)
                    return "Disable";
                else
                    return "Enable";
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // throw new NotImplementedException();
            return Binding.DoNothing;
        }
    }
}
