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

namespace WpfDemo.DataTemplates
{
    /// <summary>
    /// Interaction logic for DataTemplatesWindow.xaml
    /// </summary>
    public partial class DataTemplatesWindow : Window
    {
        private List<Employee> employees = new List<Employee>
        {
            new Employee {Name = "John Lee", Salary = 15000.0},
            new Employee {Name = "Chen Xun", Salary = 12000.0},
            new Employee {Name = "Israel Israeli", Salary = 14500.0},
        };

        public DataTemplatesWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        public IEnumerable<Employee> Employees
        {
            get { return employees; }
        }
    }
}
