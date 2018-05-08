﻿using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace DSACharacterSheet.Desktop.Converter
{
    public class BoolToInVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is bool))
                return Visibility.Collapsed;

            if ((bool)value == false)
                return Visibility.Visible;
            else
                return Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}