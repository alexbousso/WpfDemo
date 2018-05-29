using System;
using System.Collections.Generic;
using System.IO;
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

namespace WpfDemo
{
    /// <summary>
    /// Interaction logic for Controls.xaml
    /// </summary>
    public partial class Controls : Window
    {
        private string poem = null;
        private IEnumerable<string> items = null;

        public Controls()
        {
            InitializeComponent();
            DataContext = this;
        }

        public string Poem
        {
            get
            {
                if (poem == null)
                {
                    poem = File.ReadAllText("Resources/Poem.txt");
                }
                return poem;
            }
        }

        public IEnumerable<string> Items
        {
            get
            {
                if (items == null)
                {
                    items = new[]
                    {
                        "Item 1",
                        "Item 2",
                        "Item 3",
                        "Item 4",
                        "Item 5",
                    };
                }
                return items;
            }
        }
    }
}
