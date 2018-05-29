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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfDemo.DataBinding
{
    /// <summary>
    /// Interaction logic for DataBindingWindow.xaml
    /// </summary>
    public partial class DataBindingWindow : Window
    {
        private readonly Employee employee = new Employee {Name = "John Lee", Salary = 15000.0};

        public DataBindingWindow()
        {
            InitializeComponent();
            StackPanel.DataContext = employee;
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            employee.Salary += 1000.0;
            MessageBox.Show(string.Format("The salary of {0} was raised by $1000.00, now it stands on ${1:0.00}",
                employee.Name, employee.Salary));
        }
    }
}
