using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPChallenge
{
    class Order
    {
        private int id;
        private DateTime modified;
        private string shippingAddress;
        private double total;
        private List<LineItem> items;
        public void addItem(LineItem i)
        {
            this.items.Add(i);
        }
        public double setTotal()
        {
            foreach(LineItem item in this.items)
            {
                this.total =+ item.Price;
            }
            return this.total;
        }
    }
}
