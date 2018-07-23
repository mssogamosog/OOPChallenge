using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPChallenge
{
    public class LineItem
    {
        private int quantity;
        private double price;
        private Product product;

        public int Quantity { get => quantity; set => quantity = value; }
        public double Price { get => price; set => price = value; }
        internal Product Product { get => product; set => product = value; }
    }
}
