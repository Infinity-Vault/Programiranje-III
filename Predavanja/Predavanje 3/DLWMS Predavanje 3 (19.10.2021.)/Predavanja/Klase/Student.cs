using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLWMS_Predavanje_3__19._10._2021._.Predavanja.Interfejsi;

namespace DLWMS_Predavanje_3__19._10._2021._.Predavanja.Klase
{
    internal class Student:Osoba,IStudent //Ovom linijom, klasi Student, klasa Osoba postaje bazna klasa, samim time preuzima sve od nje (metode i atribute/propertije);
    {
        //Kod C# ne postoji visetruko nasljedivanje kao u C++,medjutim mozemo nasljediti baznu klasu i neki interfejs;


        //Novi property iz interfejsa:

        public string KorisnickoIme { get; set; }
        public string Password { get; set; }
        public string Grad { get; set; }

        //Property specifican za Student class:
        public int Indeks { get; set; }

        public override void PredstaviSe()
        //Navedenu metodu override-amo kako bi dodali jos potrebne propertije;
        {
            Console.WriteLine($"Ja sam student {ImePrezime}, godiste {Godiste} sa brojem indeksa {Indeks}");
        }

        //Metode iz interfejsa:
        //Svaka metoda atribut ili property iz intefejsa mora biti u klasi proglasena kao public jer inace
        //ne garantujemo da ce se moci koristiti implementirana pravila (metode,propertiji,atributi) iz interfejsa pomocu tog objekta te klase;
        public bool PrijaviSe()
        {
            if (Password != null)//Ako figurativno password nije prazan;
            {
                Console.WriteLine($"Prijavio se student {ImePrezime}");
                return true;
            }
            return false;
        }

        public bool Odjava()
        {
            Console.WriteLine($"Odjavio se student {ImePrezime}");
            return true;
        }

        public bool PosaljiMailStudenskojSluzbi()
        {
            if (KorisnickoIme != null)//Ako banalno postoji korisnik;
            {
                Console.WriteLine($"Mail se salje...");
                return true;
            }
            return false;
        }
    }
}
