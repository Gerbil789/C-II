using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Customer : INotifyPropertyChanged
    {
        public int Id { get; set; }
        private string firstName;
        public string FirstName 
        { 
            get { return firstName; } 
            set 
            { 
                SetField(ref firstName, value);
            } 
        }

        private void SetField<T>(ref T field, T value, [CallerMemberName]string caller = null)
        {
            field = value;
            PropertyChanged?.Invoke(
                   this,
                   new PropertyChangedEventArgs(caller)
                );
        }
        private string lastName;
        public string LastName
        {
            get { return lastName; }
            set
            {
                SetField(ref lastName, value);
            }
        }
        public int Age { get; set; }

        public event PropertyChangedEventHandler? PropertyChanged;

        public static List<Customer> GetCustomers()
        {
            return new List<Customer>() {
                new Customer()
                {
                    Id = 1,
                    FirstName = "Jan",
                    LastName = "NovĂˇk",
                    Age = 40
                },
                new Customer()
                {
                    Id = 2,
                    FirstName = "Zuzana",
                    LastName = "BĂˇĹskĂˇ",
                    Age = 32
                },
                new Customer()
                {
                    Id = 3,
                    FirstName = "Petra",
                    LastName = "OstravskĂˇ",
                    Age = 15
                },
                new Customer()
                {
                    Id = 4,
                    FirstName = "Karel",
                    LastName = "Svoboda",
                    Age = 60
                }
            };
        }

    }
}
