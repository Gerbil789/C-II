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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for FormRow.xaml
    /// </summary>
    public partial class FormRow : UserControl
    {
        public string Label { get; set; }
        public string Value {
            get { return (string)GetValue(valProp); } 
            set { SetValue(valProp, value); }
        }

        private static DependencyProperty valProp = DependencyProperty.Register("Value",
            typeof(string), typeof(FormRow));
        public FormRow()
        {
            InitializeComponent();
            this.DataContext = this;
        }
    }
}
