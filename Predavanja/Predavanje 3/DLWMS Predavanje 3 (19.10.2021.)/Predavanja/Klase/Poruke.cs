using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS_Predavanje_3__19._10._2021._.Predavanja.Klase
{
    internal class Poruke:IDisposable
    {
        //Kljucna rijec const od nas odmah zahtijeva da inicijaliziramo taj atribut,
        //te isto tako nakon sto je inicijaliziran, vise se ne moze mijenjati;
        //Takodjer const atribut su vec po prirodi staticki, stoga ne mora postojati instanca ovog objekta da  bi koristili njegov neki const atribut;
        public const string Konstanta = "Ovo je konstanta !";

        //Dok sa druge strane, kljucna rijec readonly nam omogucava da proglaseni atribut,
        //inicijaliziramo nekada nakon (npr. u ctoru);
        public readonly string Recenica;


        public Poruke()//Dflt ctor;
        {
            Recenica = "Ovo je neka readonly varijabla/atribut";
        }
        public Poruke(string recenica)//User def ctor;
        {
            Recenica = recenica;
        }

        //Moramo implementirati metodu Dispose radi IDisposable interfejsa:
        public void Dispose()
        {
            //Beznacajna implementacija:
            Console.WriteLine($"Brisanje koristenih podataka od strane klase Poruke...");
            //Inace bi se implementiralo npr zatvaranje fajla u koji se prethodno upisivalo i sl.
            //Svrha je da se oslobode svi resursi koji su bili koristeni od strane ove klase;
        }
    }
}
