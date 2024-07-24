using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIProject
{
    public class TitleOrMemberCountConverter: IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            string title = values[0] as string;
            string memberCount = values[1] as string;


            if (string.IsNullOrEmpty(title))
            {
                return memberCount;
            }
            else
            {
                return title;
            }
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

    }
}

