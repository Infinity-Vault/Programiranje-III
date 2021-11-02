using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predavanje5.Classes
{
    internal class Korisnik
    {

        //Pravljenje propertija:
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime Datumrodjenja { get; set; }//Objekat klase DateTime;
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
        public bool Aktivan { get; set; }

        public override string ToString()//Prepisemo metodu za ispis objekta tipa Korisnik;
        {
            return $" {Ime} {Prezime}";
        }
        //Dflt ctor nema svrhe jer je svakako generisan u C#;
    }
}
