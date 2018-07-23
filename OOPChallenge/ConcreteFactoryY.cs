using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPChallenge
{
    class ConcreteFactoryY : AbstractFactory
    {
        public ProductA createProductA()
        {
            ProductA p = new ProductAY();
            return p;
        }

        public ProductB createProductB()
        {
            ProductB p = new ProductBY();
            return p;
        }
    }
}
