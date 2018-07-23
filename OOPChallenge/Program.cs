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
            Address test = new Address(1, "linea1", "linea2", "bogota", "colombia", false);
            Console.WriteLine(test.getAddress());
        }
    }
}
