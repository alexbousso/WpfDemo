using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfDemo.DependencyAndAttachedProperties
{
    class MyBackgroundManager : DependencyObject
    {
        public static Brush GetBackground(DependencyObject obj)
        {
            return (Brush) obj.GetValue(BackgroundProperty);
        }

        public static void SetBackground(DependencyObject obj, Brush value)
        {
            obj.SetValue(BackgroundProperty, value);
        }

        public static readonly DependencyProperty BackgroundProperty = DependencyProperty.RegisterAttached(
            "Background", typeof(Brush), typeof(MyBackgroundManager),
                new UIPropertyMetadata(Brushes.Transparent, OnBackgroundChanged));

        private static void OnBackgroundChanged(DependencyObject obj, DependencyPropertyChangedEventArgs e)
        {
            Control control = obj as Control;
            if (control != null)
            {
                control.Background = (Brush) e.NewValue;
            }
        }
    }
}
