using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Data;
using System.Windows;

namespace monitor.Theme
{
    public class LabelDiskLessValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double angle = double.Parse(value.ToString()) * 360 / 100;
            double radius = 13.0;
            if (angle < 180.0)
            {
                double angleRad = (Math.PI / 180.0) * angle;
                //double s = Math.Round(36.436, 0);
                double x = Math.Round((radius * Math.Sin(angleRad)), 2);
                double y = Math.Round((radius * Math.Cos(angleRad)), 2);

                return new Point(radius + x, radius - y);
            }
            else
            {

                return new Point(radius, radius * 2);
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

    }
    public class LabelDiskMoreValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double angle = double.Parse(value.ToString()) * 360 / 100;
            double radius = 13.0;
            if (angle < 180.0)
            {
                return new Point(radius, radius);
            }
            else
            {
                double angleRad = (Math.PI / 180.0) * angle;
                double x = Math.Round((radius * Math.Sin(angleRad)), 2);
                double y = Math.Round((radius * Math.Cos(angleRad)), 2);

                return new Point(radius + x, radius - y);
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

    }
    public class LabelDiskPointValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double angle = double.Parse(value.ToString()) * 360 / 100;
            double radius = 13.0;
            if (angle < 180.0)
            {
                return new Point(radius, radius);
            }
            else
            {
                return new Point(radius, radius * 2);
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

    }

    public class TemperatureBackgroundHeightValueConverter : IMultiValueConverter
    {
        public object Convert(object[] value, Type targetType, object parameter, CultureInfo culture)
        {
            double uid = double.Parse(value[0].ToString());
            double maxHeight = double.Parse(value[1].ToString());
            double minHeight = double.Parse(value[2].ToString());
            double current = 0;
            current = 32 * (uid - minHeight) / (maxHeight - minHeight);
            return current;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

    }

}
