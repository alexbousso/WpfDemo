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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfDemo.DataBinding;
using WpfDemo.DataResources;
using WpfDemo.DataTemplates;
using WpfDemo.DataTriggers;
using WpfDemo.Panels;

namespace WpfDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ShowWindow<T>() where T : Window, new()
        {
            Window w = new T();
            w.Closed += (sender, args) =>
            {
                Show();
            };
            w.Owner = this;
            Hide();
            w.Show();
        }

        private void ButtonBase_OnClick_Controls(object sender, RoutedEventArgs e)
        {
            ShowWindow<Controls>();
        }

        private void ButtonBase_OnClick_XamlAndCodeBehind(object sender, RoutedEventArgs e)
        {
            ShowWindow<XamlAndCodeBehind>();
        }

        private void ButtonBase_OnClick_Panels(object sender, RoutedEventArgs e)
        {
            ShowWindow<PanelsWindow>();
        }

        private void ButtonBase_OnClick_DependencyAndAttachedProperties(object sender, RoutedEventArgs e)
        {
            ShowWindow<DependencyAndAttachedProperties.DependencyAndAttachedProperties>();
        }

        private void ButtonBase_OnClick_Resources(object sender, RoutedEventArgs e)
        {
            ShowWindow<ResourcesWindow>();
        }

        private void ButtonBase_OnClick_DataBinding(object sender, RoutedEventArgs e)
        {
            ShowWindow<DataBindingWindow>();
        }

        private void ButtonBase_OnClick_DataTemplates(object sender, RoutedEventArgs e)
        {
            ShowWindow<DataTemplatesWindow>();
        }

        private void ButtonBase_OnClick_DataTriggers(object sender, RoutedEventArgs e)
        {
            ShowWindow<DataTriggersWindow>();
        }
    }
}
