using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Customers
{
    public class ViewModel: INotifyPropertyChanged
    {
        private List<Customer> customers;
        private int currentCustomer;
        public Command NextCustomer { get; private set; }
        public Command PreviousCustomer { get; private set; }
        public ViewModel()
        {
            this.currentCustomer = 0;
            _isAtStart = true;
            _isAtEnd = false;
            this.NextCustomer = new Command(this.Next, () => { return (this.customers.Count > 1 && !IsAtEnd); });
            this.PreviousCustomer = new Command(this.Previous, () => { return (this.customers.Count > 0 && !IsAtStart); });
            customers = new List<Customer>
            {                
                new Customer
                {
                    CustomerID = 1,
                    Title = "Mr",
                    FirstName = "John",
                    LastName = "Sharp",
                    EmailAddress = "john@contoso.com",
                    Phone = "111-1111"
                },
                new Customer
                {
                    CustomerID = 2,
                    Title = "Mrs",
                    FirstName = "Diana",
                    LastName = "Sharp",
                    EmailAddress = "diana@contoso.com",
                    Phone = "111-1112"
                },
                new Customer
                {
                    CustomerID = 3,
                    Title = "Mr",
                    FirstName = "Francesca",
                    LastName = "Sharp",
                    EmailAddress = "frankie@contoso.com",
                    Phone = "111-1113"
                }
            };
        }
        private void Next()
        {
            if(customers.Count - 1 > currentCustomer)
            {
                currentCustomer++;
                OnPropertyChanged(nameof(Current));
                _isAtStart = false;
                _isAtEnd = (customers.Count - 1 == currentCustomer);
            }
        }
        private void Previous()
        {
            if(currentCustomer > 0)
            {
                currentCustomer--;
                OnPropertyChanged(nameof(Current));
                _isAtEnd = false;
                _isAtStart = (currentCustomer == 0);
            }
        }
        private bool _isAtStart;
        public bool IsAtStart
        {
            get { return this._isAtStart; }
            set
            {
                this._isAtStart = value;
                OnPropertyChanged(nameof(IsAtStart));
            }
        }

        private bool _isAtEnd;
        public bool IsAtEnd
        {
            get { return this._isAtEnd; }
            set
            {
                this._isAtEnd = value;
                OnPropertyChanged(nameof(IsAtEnd));
            }
        }

        public Customer Current
        {
            get { return this.customers.Count > 0 ? this.customers[currentCustomer] : null; }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            if(PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
