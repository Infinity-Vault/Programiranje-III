using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS_Predavanje_3__19._10._2021._.Predavanja.Klase
{
    internal class Osoba
    {
        //class Osoba ce biti bazna klasa stoga ima sljedece propertije:

        public string ImePrezime { get; set; }
        public int Godiste { get; set; }

        //klasa Osoba moze imati neku svoju zasebnu metodu tipa:
        public void OsobaInfo()
        {
            Console.WriteLine($"Ovo je osoba {ImePrezime}, godiste {Godiste}");
        }
        //A isto tako moze imati metodu oznacenu sa virtual koju je potrebno da izvedene klase override-aju sa svojom nekom custom implementacijom:
        public virtual void PredstaviSe()
        {
            Console.WriteLine($"Ja sam {ImePrezime}, godiste {Godiste} ");
        }
    }
}
