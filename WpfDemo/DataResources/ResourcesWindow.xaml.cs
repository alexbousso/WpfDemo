using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfDemo.DataResources
{
    /// <summary>
    /// Interaction logic for ResourcesWindow.xaml
    /// </summary>
    public partial class ResourcesWindow : Window
    {
        private SolidColorBrush brush = new SolidColorBrush(Colors.Salmon);

        public ResourcesWindow()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            SolidColorBrush tmpBrush = ((SolidColorBrush) Resources["MySolidBrush"]).Clone();
            Resources["MySolidBrush"] = brush;
            brush = tmpBrush;

        }
    }
}
