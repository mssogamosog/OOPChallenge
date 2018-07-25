using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPChallenge
{
    class Client
    {
        ProductA productA;
        ProductB productB;

        public Client(AbstractFactory factory)
        {
            this.productA = factory.createProductA();
            this.productB = factory.createProductB();
        }

        public string getProductADescription()
        {
            return productA.getDescription();
        }
        public string getProductBDescription()
        {
            return productB.getDescription();
        }

    }
}
