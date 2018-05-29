using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace WpfDemo.Panels
{
    /// <summary>
    /// Interaction logic for PanelsWindow.xaml
    /// </summary>
    public partial class PanelsWindow : Window, INotifyPropertyChanged
    {
        private int selectedIndex;

        public PanelsWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        public int SelectedIndex
        {
            get { return selectedIndex; }
            set
            {
                selectedIndex = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void ListBoxItem_OnSelected_DockPanel(object sender, RoutedEventArgs e)
        {
            Presenter.Content = new DockPanelControl();
        }

        private void ListBoxItem_OnSelected_StackPanel(object sender, RoutedEventArgs e)
        {
            Presenter.Content = new StackPanelControl();
        }

        private void ListBoxItem_OnSelected_WrapPanel(object sender, RoutedEventArgs e)
        {
            Presenter.Content = new WrapPanelControl();
        }

        private void ListBoxItem_OnSelected_Grid(object sender, RoutedEventArgs e)
        {
            Presenter.Content = new GridControl();
        }

        private void ListBoxItem_OnSelected_Canvas(object sender, RoutedEventArgs e)
        {
            Presenter.Content = new CanvasControl();
        }

        private void ListBoxItem_OnSelected_RadialPanel(object sender, RoutedEventArgs e)
        {
            Presenter.Content = new RadialPanelControl();
        }
    }
}
