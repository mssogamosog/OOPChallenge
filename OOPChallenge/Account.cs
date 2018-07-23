using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPChallenge
{
    class Account
    {
        private int id;
        private Customer customer;
        private AccountStatus accountStatus;
        private ShoppingCart shoppingCart;
        private List<Address> addresses;
        private List<PaymentMethod> paymentMethods;
        public void addMethod(PaymentMethod p)
        {
            this.paymentMethods.Add(p);
        }
        public void addAddress(Address a)
        {
            this.addresses.Add(a);
        }

        public void destroyMethods()
        {
            this.paymentMethods = new List<PaymentMethod>();
        }
        public void destroyAddresses()
        {
            this.addresses = new List<Address>();
        }
    }
}
