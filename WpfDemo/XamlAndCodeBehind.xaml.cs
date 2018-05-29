using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfDemo
{
    /// <summary>
    /// Interaction logic for XamlAndCodeBehind.xaml
    /// </summary>
    public partial class XamlAndCodeBehind : Window
    {
        public XamlAndCodeBehind()
        {
            InitializeComponent();

            AButton.Content = "Click me!";
            AButton.Click += AButtonOnClick;
        }

        private void AButtonOnClick(object sender, RoutedEventArgs routedEventArgs)
        {
            ToggleButton button = sender as ToggleButton;
            if (button == null || !button.IsChecked.HasValue)
            {
                return;
            }

            ATextBlock.Text = button.IsChecked.Value
                ? "The button is pressed"
                : "The button is not pressed";

        }
    }
}
