using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Customer> Customers { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            this.Customers = new ObservableCollection<Customer>(Customer.GetCustomers());
            this.DataContext = this; //IMPORTANT!!!

        }

        private void AddCustomer(object sender, RoutedEventArgs e)
        {

            CustomerWindow win = new CustomerWindow();
            win.OnSave += x => this.Customers.Add(x);
            win.ShowDialog();
        }

        private void DeleteCustomer(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            Customer c = btn.DataContext as Customer;
            this.Customers.Remove(c);
        }

        private void AnonymizeCustomer(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            Customer c = btn.DataContext as Customer;
            c.FirstName = "***";
            c.LastName = "***";
        }
    }
}
