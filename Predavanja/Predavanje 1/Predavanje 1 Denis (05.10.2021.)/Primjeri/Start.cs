using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Predavanje_1_Denis__05._10._2021.Data;


namespace Predavanje_1_Denis__05._10._2021._.Primjeri
{
    //Modifier internal oznacava da je ono sto iza slijedi dosupno samo u tom assembly (u ovom slucaju namespace Start);
    internal class Start
    {
        public static void Pokreni()
        {

            OsnovniTipoviPodataka();
            KoristenjePointera();
            ValueIReference();
            PrimjerKlase();
        }

        private static void OsnovniTipoviPodataka()
        {
            int brojIndeksa = 200021;
            string imePrezime = "Rijad Azemi";
            string nazivSkole = "Gimnazija Obala";
            bool aktivanNaNastavi = true;
            if(aktivanNaNastavi)
                //Ovo je interpolation (citanje vrijednosti varijabli i spajanje teksta) isto moze biti uradjeno sa konkatenacijom (+);
                Console.WriteLine($"Student {imePrezime} je aktivan u svojoj skoli {nazivSkole} a njegov broj indeksa je {brojIndeksa}");
                //Obicna konkatenacija teksta i vrijednosti:
                //Console.WriteLine("Student" +imePrezime+" je aktivan u svojoj skoli "+nazivSkole+" a njegov broj indeksa je "+brojIndeksa);

        }

        private static void KoristenjePointera()
        {
            //Da bi pravilno koristili klasicne C++ pokazivace, kod gdje se koriste mora biti 
            //wrappan u unsafe{}. Takodjer u postavkama moramo odobriti izvrsavanje unsafe koda u nasem projektu!
            //Otici u Build>check unsafe;
            unsafe
            {
                int number = 565;
                int* pointerToNumber = &number;
                Console.WriteLine($"Broj prije promjene je: {*pointerToNumber}");
                *pointerToNumber = 656;
                Console.WriteLine($"Broj prije promjene je: {*pointerToNumber}");
            }
        }

        private static void ValueIReference()
        {
            //Kljucna rijec new u C# ne mora implicitno znaciti da je rijec o heap alociranoj memoriji;
            //Sve sto ne posjeduje referencu ce basically biti stack allocated, dok sve sto ima referencu
            //Ce biti heap allocated;

            //Varijabla broj je na stack-u i alocirana je sa vrijednoscu 5:
            int broj = 5;
            Console.WriteLine($"Broj: {broj}");

            //Varijabla denis je alocirana na heap-u kao i varijabla haris, jer obje imaju referencu;

            Student denis = new Student(200210, "Denis", "Music", 5, 8.70f, 8);
            Student haris = denis;
            Console.WriteLine($"Ime prvog studenta prije promjene: {denis.GetIme()}");
            Console.WriteLine($"Ime drugog studenta prije promjene: {haris.GetIme()}");
            haris.SetIme("DENIS");//Iako je mjenja ime na varijabli haris, ona ima referencu na varijablu denis,stoga se i na njoj promjeni;
            Console.WriteLine($"Ime prvog studenta nakon promjene: {denis.GetIme()}");
            Console.WriteLine($"Ime drugog studenta nakon promjene: {haris.GetIme()}");
        }

        private static void PrimjerKlase()
        {
            //Namespace klase koju pravimo bi trebao da se razlikuje od imena same klase,
            //Time se npr izbjegne da se namespace zove Student pa onda .Student klasa;
            Student haris = new Student();//Dflt ctor klase student;
            Student denis = new Student(2000201, "Denis", "Music", 5,6.56f,8);//User-def ctor;
            //Mjenjanje propertija:
            haris.Semestar = 3; 
            denis.ProsjekNaGodini = 8.70;//Right hand value je u ovom slucaju 8.70; (to je vrijednost kljucne rijeci value u propertiju);
            Console.WriteLine($"Ime i prezime prvog studenta na {denis.GetGodinaStudija()} godini studija  je {denis.GetIme()} {denis.GetPrezime()} !");
            //WriteLine metoda je preklopljena da ispise bilo koji objekat,medjutim ako je to korisnicki definisan
            //Objekat kao sto je u nasem slucaju, metodu je potrebno preklopiti;

            Console.WriteLine(denis);//Ispisat ce putanju do fajla u kojem je napisana klasa Student; Upravo zato jer nemamo preklopljenu metodu WriteLine;
            Console.WriteLine(haris);//Kada se preklopi izvrsit ce se kod koji je napisan u override-u WriteLine metode;

            //Jos jedan primjer jeste da se moze koristiti direktno adresiranje propertija u konstruktorima objekata
            //Na nacin: (ime:vrijednost),pri cemu ne moramo koristiti isti redosljed kao onaj naveden u ctor-u
            //Ali moramo sve direktno adresirati;

            Student primjer = new Student(ime: "Haris", indeks: 2000134, prezime: "Kordic", godinaStudija: 3,
                 semestar: 3, prosjekNaGodini: 3.45f);

            //Takodjer, ako idemo redosljedom kao u ctor-u, onda mozemo kombinovati direktno adresiranje
            //I obicne vrijednosti;
            Student primjer2 = new Student(indeks: 2000134, ime: "Haris", "Kordic", 3, 34.6, 4);


            //Object je bazni tip podatka u .NET-u koji moze poprimiti bilo koji value ili reference primitivni
            //Ili slozeni tip podatka;
            object sarajevo="Sarajevo";
            object tip=sarajevo.GetType();//Ugradjena metoda za provjeru tipa;
            Console.WriteLine($"Tip podakta Sarajevo je {tip}");//System.string;
            bool istinaIliNe=sarajevo.Equals(tip);//Ugradjena metoda za provjeru da li su dva objekta jednaka;
            Console.WriteLine($"Podatak 'tip' i podatak 'sarajevo' su isti (true)/razliciti (false): {istinaIliNe}");
        }
    }
}
