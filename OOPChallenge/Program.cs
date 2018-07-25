using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace OOPChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //Address test = new Address(1, "linea1", "linea2", "bogota", "colombia", false);
            //Console.WriteLine(test.getAddress());

            AbstractFactory abstractFactoryX = new ConcreteFactoryX();
            Client client1 = new Client(abstractFactoryX);
            AbstractFactory abstractFactoryY = new ConcreteFactoryY();
            Client client2 = new Client(abstractFactoryY);
            Console.WriteLine("********* ConcreteFactoryX **********");  
            Console.WriteLine(client1.getProductADescription());
            Console.WriteLine(client1.getProductBDescription());
            Console.WriteLine("********* ConcreteFactoryY **********");
            Console.WriteLine(client2.getProductADescription());
            Console.WriteLine(client2.getProductBDescription());

        }
    }
}
