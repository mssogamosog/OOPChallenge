using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPChallenge
{
    class ShoppingCart
    {
        private List<LineItem> items;
        public void addItem(LineItem i)
        {
            this.items.Add(i);
        }
        public void cleanCart()
        {
            this.items = new List<LineItem>();
        }
    }
}
