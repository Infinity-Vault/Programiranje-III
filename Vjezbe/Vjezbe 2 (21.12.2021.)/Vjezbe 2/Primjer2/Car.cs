using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezbe_2.Primjer2
{
    internal class Car:ICar//Implementiramo ICar interface;
    {
        //Sve dok ne implementiramo date metode/atribute/ili propertije iz datog interfejsa, imacemo gresku;
        public void Info()
        {
            Console.WriteLine($"Ovo je auto");
        }
    }
}
