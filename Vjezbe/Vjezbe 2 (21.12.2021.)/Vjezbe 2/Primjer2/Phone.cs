using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezbe_2.Primjer2
{
    internal class Phone:IPhone//Implementiramo IPhone interface;
    {
        //Implementirane metode/atributi ili propertiji iz interfejsa moraju imati kljucnu rijec public;
        //Inace kompajler daje gresku;
        public void Info()
        {
            Console.WriteLine($"Ovo je telefon");
        }
    }
}
