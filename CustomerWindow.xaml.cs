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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for CustomerWindow.xaml
    /// </summary>
    /// 
    public delegate void SaveCustomer(Customer c);
    public partial class CustomerWindow : Window
    {
        public Customer Customer { get; set; } = new Customer();
        public event SaveCustomer OnSave;
        public CustomerWindow()
        {
            InitializeComponent();
            this.DataContext = this.Customer;
        }

        private void Save(object sender, RoutedEventArgs e)
        {
            this.OnSave?.Invoke(this.Customer);
            this.Close();
        }
    }
}
