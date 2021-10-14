using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.ConsoleApp.Predavanja.P2
{
    internal class MainP2
    {
        public static void Pokreni()
        {
            ValueIReference();
            Nizovi();
            Params();
            RazlicitaSlanjaParametara();
            Destrukcija();
            ProvjeravanjeNull_ova();
            SimulacijaApi();
        }



        //Primjer value i reference:
        private static void ValueIReference()
        {
            Console.WriteLine("ValueIReference() POCETAK");

            //Svi primitivni tipovi podataka se alociraju na stack-u, bez obzira sto postoji new kljucna rijec (ona samo zada default vrijednost tom tipu);
            int a = new int();//Alocirano na stack, iako koristimo 'new' keyword;
            int b;//Junk vrijednost opet alocirana na stack;

            //Svi User defined tipovi podataka (aka klase) se alociraju na heap, jer su alocirane referentno;

            Profesor denis = new Profesor(){ImePrezime= "Denis Music", Godiste= 2000 };//Sa {imePropertija=vrijednost} mozemo direktno uticati na konstruukciju objekta;
            Profesor novi = denis;
            Console.WriteLine("Ispis prije promjene na objektu novi:");
            Console.WriteLine(denis);
            Console.WriteLine(novi);
            novi.ImePrezime = "Novo ImePrezime";
            Console.WriteLine("Ispis poslije promjene na objektu novi:");
            //Promjena je vidljiva i na objektu denis, jer je po referenci proslijedjen;
            Console.WriteLine(denis);
            Console.WriteLine(novi);

            //Sa strukturama je isto kao i sa primitivnim tipovima podataka;
            //Nisu referentni, stoga nece biti alocirani na heap !
            Asistent adil = new Asistent() { ImePrezime = "Adil Joldic", Godiste = 2000 };
            Asistent novi2 = adil;//Ne dijele isti objekat (nema reference);
            Console.WriteLine("Ispis prije promjene na objektu novi2:");
            Console.WriteLine(adil);
            Console.WriteLine(novi2);
            novi2.ImePrezime = "Novi AdilJoldic";
            Console.WriteLine("Ispis poslije promjene na objektu novi2:");
            Console.WriteLine(adil);
            Console.WriteLine(novi2);//Samo ovdje se ime promjeni !;

            Console.WriteLine("----------------------------KRAJ----------------------------");
        }
        //Primjer nizova:
        private static void Nizovi()
        {

            Console.WriteLine("Nizovi() POCETAK");
            //Ako imamo niz koji je alociran na heapu tj tipa neke klase, njegovi pojedinacni elementi su na pocetku nulirani osim 
            //ako mi drugacije ne izvrsimo manuelnu alokaciju tipa (niz[i]=new Klasa(););

            Profesor[] niz = new Profesor[3];
            for (int i = 0; i < niz.Length; i++)//niz.Length je inner property nizova;
            {
                //Ako nemamo liniju ispod dolazi do: 'System.NullReferenceException: 'Object reference not set to an instance of an object.';
                niz[i] = new Profesor();
                niz[i].ImePrezime = $"Profesor_{i}";
                niz[i].Godiste = 2000 + i;
            }

            for (int i = 0; i < niz.Length; i++)
            {
                Console.WriteLine(niz[i]);
            }

            //Kod strukture nije potrebno raditi gore navedeno, jer su one alocirane na stack i samim time
            //nije potrebna manuelna alokacija pojedinacnih objekata, to je vec automatski uradjeno;

            Asistent[] niz2 = new Asistent[3];

            for (int i = 0; i < niz2.Length; i++)
            {
                //Property niza Godiste ce biti default 0 jer je int (primitive);
                //Property niza ImePrezime ce biti null jer je string klasa (user defined);
                niz2[i].ImePrezime = $"Asistent_{i}";
                niz2[i].Godiste = 1990 + i;
            }
            for (int i = 0; i < niz2.Length; i++)
            {
                Console.WriteLine(niz2[i]);
            }
            Console.WriteLine("----------------------------KRAJ----------------------------");

        }
        //Primjer za param:
        private static void Params()
        {
            Console.WriteLine("Params() POCETAK");
            //Poziv funkcije Sumiraj sa multiple overloadanim parametrima (ovu funkcionalnost omogucava param):
            Console.WriteLine(Sumiraj(1,5,4,7,8,9,6,5));
            Console.WriteLine(Sumiraj(1, 5, 4, 7, 8, 9, 6, 5,7,8,6));
            Console.WriteLine(Sumiraj(1, 5, 4,  7, 8, 6));
            Console.WriteLine("----------------------------KRAJ----------------------------");

        }

        private static int Sumiraj(params int[] niz) =>  niz.Sum();//Skraceni expression oblik pisanja  metode;
        // {ODKOMENTIRAJ;

        //Kljucna rijec params ce pokriti bilo koji broj integera proslijedjenih metodi Sumiraj();
        //Takodjer mozemo staviti da je param tipa object, sto bi pokrilo bilo koji tip podatka, i bilo koji broj parametara tog tipa;

        //Standardni nacin:
        // int suma = 0;
        // for (int i = 0; i < niz.Length; i++)
        // {
        //     suma += niz[i];
        // }
        // return suma;

        //Ili koristimo metodu sum za nizove:

        //return niz.Sum();

        //Zadnja opcija jeste da koristimo expression;
        //}ODKOMENTIRAJ;



        //Primjer slanja po referenci,in,out,i po value:
        private static void RazlicitaSlanjaParametara()
        {
            Console.WriteLine("RazlicitaSlanjaParametara() POCETAK");
            //Po defaultu, parametri se salju po vrijednosti:

            Profesor denis=null;//Nuliramo objekat;
            PrimjerPunjenjaObjektaPoVrijednosti(denis);//Poslano po vrijednosti;//Cak i okruzenje kaze da ce objekat denis uvijek biti null;
            Console.WriteLine(denis);//Nema nikakve promjene;Nema nikakvog ispisa;

            // Profesor denis2;//Ako ostavimo ovako, imamo gresku jer pristupamo i mjenjamo nesto sto nije ni inicijalizovano;
            Profesor denis2 = new Profesor(){ImePrezime="NOTSET",Godiste=0000};//Ovako postavimo obj na neke nase vrijednosti;
            PrimjerPunjenjaObjektaPoReferenci(ref denis2);
            Console.WriteLine(denis2);//Ima promjene;Pristupa se referenci stoga je sve vidljivo i van metode;


            //Kljucna rijec out zahtijeva da se proslijedjeni parametri inicijalizuju;

            int rezultat;
            
            if(int.TryParse("12dd3", out rezultat))//TryParse vraca bool na osnovu uspjesne ili neuspjesne konverzije, u out varijablu se pohrani konverzija;
                Console.WriteLine($"Konvertovani broj je: {rezultat}");
            else
                Console.WriteLine("Broj nije mogao biti konvertovan");

            //Primjer za in nacin slanja podataka:

            Profesor adil = new Profesor() { ImePrezime = "Adil Joldic", Godiste = 1990 };
            PrimjerPunjenjaObjektaSaIn(in adil);
            Console.WriteLine(adil);//Vidljive promjene;

            Console.WriteLine("----------------------------KRAJ----------------------------");

        }

        private static void PrimjerPunjenjaObjektaPoVrijednosti(Profesor obj)
        {
            if (obj != null)//Provjera da ne bi imali null reference exception;
            {
                obj.ImePrezime = "Denis Music";
                obj.Godiste = 2001;
            }
            //Ili 
            obj = new Profesor() { ImePrezime = "Novi Proferor", Godiste = 2006, BrojKartice = 124578 };
        }

        private static void PrimjerPunjenjaObjektaPoReferenci(ref Profesor obj)
        {
            obj.ImePrezime = "Denis Music 2";
            obj.Godiste = 2001;
        }

        private static void PrimjerPunjenjaObjektaSaIn(in Profesor obj)
        {
            //Kljucna rijec in nas sprjecava od nekih krucijalnih modifikacija objekta kao na primjer memorijske lokacije
            //Medjutim daje nam da mijenjamo osnovne propertije i njihove vrijednosti;

            //NEDOZVOLJENO:

            //obj = new Profesor();//Cannot asign to variable in Profesor because it's readonly;

            //DOZVOLJENO:

            obj.ImePrezime = "Adil Joldic Dva";
            obj.Godiste = 2005;
        }



        //Primjer za destrukciju objekata:
        private static void Destrukcija()
        {
            Console.WriteLine("Destrukcija() POCETAK");
            //Kljucna rijec var sluzi kao i 'auto' u C++, ne moramo znati povratni tip podatka, ona ga prepozna;
            var ime = "Neko ime";
            var godine = 2005;
            //var velicina;//Ovo nemoze jer nema u istoj liniji povratni tip, stoga ne zna sta da doceka;

            Profesor denis = new Profesor() { ImePrezime = "Denis Music", Godiste = 2001 };

            //Prvi nacin:
            //U lokalne varijable se izvrsi destrukcija objekta denis:
            string imePrezime;
            int godiste;
            int[] niz;
            int brojKartice;
            denis.Deconstruct(out imePrezime, out godiste, out niz, out brojKartice);
            Console.WriteLine(imePrezime);
            Console.WriteLine(godiste);
            Console.WriteLine($"Ocjene: {string.Join(",",niz)}, broj kartice: {brojKartice}");




            //Drugi nacin: Slican konceptu tuple:

            // Profesor novi = new Profesor(){ImePrezime="Novi profesor",Godiste=2000};
            // (string imePrez, int god, int[] ocj, int brKartice)=novi;
            // Console.WriteLine(imePrez);
            // Console.WriteLine(god);
            // Console.WriteLine($"Ocjene: {string.Join(",", ocj)}, broj kartice: {brKartice}");

            //Treci nacin, jos laksi:Kljucna rijec var zna koji ce tip podatka svako obiljezje bit;
            Profesor novi = new Profesor() { ImePrezime = "Novi profesor", Godiste = 2000 };
            var ( imePrez,  god, ocj, brKartice) = novi;
            Console.WriteLine(imePrez);
            Console.WriteLine(god);
            Console.WriteLine($"Ocjene: {string.Join(",", ocj)}, broj kartice: {brKartice}");
            Console.WriteLine("----------------------------KRAJ----------------------------");

        }

        //Primjer za povjeru null vrijednosti:
        private static void ProvjeravanjeNull_ova()
        {
            Console.WriteLine("ProvjeravanjeNull_ova() POCETAK");
            //Sve user defined tipove podatak mozemo 'nulirati' na nacin da koristimo null keyword;

            Profesor denis = null;
            if (denis == null)//Klasicna provjera;Takodjer mogli smo reci if(denis!=null);
            {
                denis = new Profesor();
                denis.ImePrezime = "Denis Music";
                denis.Godiste = 1998;
                Console.WriteLine(denis);
            }

            //Postoji nacin da se i primitivni tipovi podataka proglase null, medjutim moraju imati
            //operator ?  koji ce im omoguciti iako nisu referentni tipovi, da budu nullable;
            int? broj = null;
            if (broj == null)//Klasicna provjera;Takodjer mogli smo reci if(broj!=null);
            {
                broj = new int();//Ne kreira se na heap jer nije reference tip;Ovo ga samo stavi na default;
                broj = 5;
                Console.WriteLine($"Broj je: {broj}");
            }

            //Takodjer postoji genericka klasa koja se zove nullable:
            Nullable<int> visina=null;//Kraci oblik jeste onaj iznad int?;
            if (visina == null)
            {
                visina = 23;
                Console.WriteLine($"Visina je: {visina}");
            }


            //Jos jedan nacin provjere jeste da koristimo ?:
            Profesor azemi = new Profesor();
            if (azemi?.ImePrezime == null)//Pomocu operatora  ?  prije pristupa propertiju provjerimo njegovu vrijednost;
                azemi.ImePrezime = "NOT_SET";
            Console.WriteLine(azemi.ImePrezime);//NOT_SET;

            //Takodjer mozemo koristiti ternary operator (??) kod kojeg je sintaksa samo malo drugacija nego u C++;
            Profesor ahmet=null;
            Profesor ahmetKopija= ahmet ?? new Profesor();//Logika jeste da ce se u objekat ahmetKopija spremiti vrijednost objekta ahmet AKO ON NIJE NULL, a ako jeste inicijalizirat ce se novi default Profesor;
            Console.WriteLine(ahmetKopija);//Default vrijednosti;

            //Takodjer mozemo ispitivati pojedinacne propertije a ne citave objekte koristeci ternary operator, npr:
            //Ovime se najvise utice na broj if-ova;
            Profesor rijad = null;
            var imePrezime = rijad?.ImePrezime ?? "NotSet";//U string imePrezime se  pohrani ime objekta rijad ako ono nije null, ako jeste pohrani se string NotSet;
            Console.WriteLine(imePrezime);//NotSet;

            Console.WriteLine("----------------------------KRAJ----------------------------");

        }

        //Primjer ako API vrati null:
        private static void  SimulacijaApi()
        {
            Console.WriteLine("SimulacijaApi() POCETAK");
            //Testiranje propertija (Indeksera) klase Profesor;
            Profesor haris = new Profesor() { ImePrezime = "Haris Kordic", Godiste = 2001 };
            Console.WriteLine(haris);
            Console.WriteLine($"Ocjena na poziciji 2  prije promjene kod profesora Harisa je: {haris[1]}");//get;
            haris[1] = 1;//set;
            Console.WriteLine($"Ocjena na poziciji 2  nakon promjene kod profesora Harisa je: {haris[1]}");//get;

            //Testiranje ako neki izmisljeni API vrati null;
            Profesor denis = GetProfesorWithCardNumber(123456);
            //Ako je API vratio null bice Null reference exception (ukoliko se ne handle sa if-om )a ako ne radice kod okej:
            if (denis?.ImePrezime != null)
                denis.ImePrezime = "Novi Denis";
            Console.WriteLine(denis);
            Console.WriteLine("----------------------------KRAJ----------------------------");

        }

        private static Profesor GetProfesorWithCardNumber(int brojKartice)
        {
            return new Profesor()
            {
                ImePrezime = "Denis Music",
                Godiste = 2006,
                BrojKartice = brojKartice
            };
           // return null;//Slucaj da se vrati null sa API-ja;
        }

    }
}
