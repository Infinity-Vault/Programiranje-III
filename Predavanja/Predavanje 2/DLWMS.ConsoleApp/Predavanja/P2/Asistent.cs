using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.ConsoleApp.Predavanja.P2
{
    internal struct  Asistent
    {
        //User-def ctor:
       // public Asistent(int godiste)
       // {
       //     //Strukture ne mogu imati ctor bez parametara;
              //Zato sto su strukture 'value'  tip podatka, stoga ne moze se konstruisati bez nekih parametara proslijedjenih (tj. bez vrijednosti), 
              //odnosno jednostavnije receno, ne moze se desiti da je 'value' tip null;
       //     Godiste = godiste;
       //     ImePrezime="NOT_SET";
       // }
        public int Godiste{ get; set; }
        public string ImePrezime{ get; set; }

        public override string ToString()
        {
            return $"Ime i prezime asistenta:{ImePrezime}, godiste:{Godiste} ";
        }
    }
}
