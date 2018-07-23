using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPChallenge
{
    class ConcreteFactoryX : AbstractFactory
    {
        public ProductA createProductA()
        {
            ProductA  p = new ProductAX();
            return p;
        }

        public ProductB createProductB()
        {
            ProductB p = new ProductBX();
            return p;
        }
    }
}
