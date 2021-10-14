using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezbe_1__14._10._2021._
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = 20;
            ProbaZaSlanjePoVrijednosti(a, b);
            Console.WriteLine(a);//10;
            Console.WriteLine(b);//20;
            ProbaZaSlanjePoreferenci(ref a, ref b);
            Console.WriteLine(a);//5;
            Console.WriteLine(b);//10;


            Person osoba = new Person()
            {
                ImePrezime = "Denis Music", 
                Godiste = 2001,
                DatumRodjenja = new DateTime(2001, 03, 02),
                Visina=2.6f,
                Jmbg = "124578951211"
            };
            Console.WriteLine(osoba);
            osoba.DatumRodjenja = new DateTime(2005, 06, 05);//Setter normalno postavi novu vrijednost jer je stara manja od trenutnog dana;
            Console.WriteLine(osoba);

            Person osoba2 = new Person()
            {
                ImePrezime = "Osoba Dva",
                Visina=2.6f,
                Godiste = 2001,
                Jmbg = "12545789452",
                DatumRodjenja = new DateTime(DateTime.Now.Year+1, DateTime.Now.Month+1, DateTime.Now.Day+1)
                //Linija gore simulira nepravilan datum;Ne moze biti veci od trenutnog;
            };
            Console.WriteLine(osoba2);
            osoba2.DatumRodjenja = new DateTime(DateTime.Now.Year + 1, DateTime.Now.Month + 1, DateTime.Now.Day + 1);
            //Linija gore simulira nepravilan datum;Ne moze biti veci od trenutnog;
            //Pozvace se u setteru sadasnja stvarna vrijednost dana;
            Console.WriteLine(osoba2);

            //Reference tipovi se po default salju sa referencom, nema potrebe za 'ref' kljucnom rijecju:
            PromjeniIme( osoba2);
            Console.WriteLine( osoba2);//Ime je Amar Kordic;

            Console.ReadLine();
        }

        //Slanje po vrijednosti:
        private static void ProbaZaSlanjePoVrijednosti(int a, int b)
        {
            a = 5;
            b = 10;
        }

        //Slanje po referenci:
        private static void ProbaZaSlanjePoreferenci(ref int a, ref int b)
        {
            a = 5;
            b = 10;
        }
        //Kreiranje klase Person:

        internal class Person
        {
            //Property ImePrezime sa default metodama get i set:
            public string ImePrezime {get;set;}

            //Property Godiste sa default metodama get i set:
            public int Godiste {get;set;}

            //Field i property se razlikuju;
            //Field je ustvari atribut klase, dok je property  metoda pomocu koje modifikujemo atribute;

            //Prije se property pisao da se posebno ima _atribut i posebno property Atribut za taj _atribut:

            private string _jmbg;

            public string Jmbg
            {
                get => _jmbg;
                set=>_jmbg=value;
            }
            //Danas se ovo vise ne koristi te imamo auto propertije koji su ujedno i atribut i property;
            //Npr:
            //Property za visinu:
            public float Visina { get; set; }

            //Kreiranje propertija  i atributa za datum rodjenja:
            private DateTime _datumRodjenja;
            public DateTime DatumRodjenja
            {
                //get => _datumRodjenja;
                get
                {
                    if (_datumRodjenja > DateTime.UtcNow)//Provjera vrati trenutni datum ako je proslijedjeni datum u _datumRodjenja veci od trenutnog (sto nije moguce u stvarnosti);
                        return DateTime.UtcNow;
                    else
                        return _datumRodjenja;
                }
                set
                {
                    if(_datumRodjenja<DateTime.UtcNow)//Ako je trenutna vrijednost  datuma manja od  vrijednosti tog dana , postavi da je datum jednak novoj vrijednosti koja se unese;
                        _datumRodjenja=value;//Gornji if nece dati da se mijenja vrijednost koja je veca od  vrijednosti objekta DateTime.utcNow;
                    //Ako je ona veca:
                    else
                       _datumRodjenja = DateTime.UtcNow;//Postavi je na trenutnu vrijednost dana;
                }
            }

            public override string ToString()
            {
                return
                    $" Ime i prezime osobe je: {ImePrezime}, godiste:{Godiste}, visina: {Visina}, JMBG: {Jmbg.ToUpper()}, datum rodjenja: {DatumRodjenja}";
                    //Na klasi string smo koristili  njenu inner metodu  da pretvori dati string u sva velika slova;
            }
        }
        //Promjeni ime objektu:
        private static void PromjeniIme( Person obj)
        {
            obj.ImePrezime = "Amar Kordic";
        }
    }
}
