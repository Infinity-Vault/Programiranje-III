using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Linq;
using System.Windows.Forms;
using Klase;

namespace Predavanje8__23._11._2021._
{
    public partial class frmPredavanje8 : Form
    {
        public frmPredavanje8()
        {
            InitializeComponent();
        }


        //Metoda koja ce se izvrsiti kada se forma ucita:
        private void frmPredavanje8_Load(object sender, EventArgs e)
        {
            VarIObject();
            Dynamic();
            TupleIDto();
            AnonimneVarijable();
            MetodeEkstenzije();
            AnonimneMetodeILinq();
        }

        //Metoda koja ce da prikaze princip anonimnih metoda/funkcija i princip rada Linq namespace-a:
        private void AnonimneMetodeILinq()
        {
            //Svrha anonimne metode jeste kao i kod anonimnih varijabli, a to je 
            //da se kreira metoda koja nema ime:

            var student = new Student() { Ime = "Haris", Prezime = "Kordic", Indeks = "IB200110" }; //Kreiramo studenta;

            //Recimo da zelimo izdvojiti sve ocjene vece od 6 od ovog studenta:

            //Prvi nacin:
            var prviRez = student.Ocjene.Where(VeceOdSest); //Saljemo metodu potpisa povratni tip bool ulazni tip int;
            var drugiRez =
                student.Ocjene.Where(ocjena => ocjena <= 6); //Pravimo anonimnu metodu pri pozivu metode Where;

            txtBoxPrikaz.Text += $"Ocjene vece od sest: {Environment.NewLine}";
            foreach (var ocjena in prviRez)
            {
                txtBoxPrikaz.Text += ocjena + " ";
                txtBoxPrikaz.Text += Environment.NewLine;
            }

            txtBoxPrikaz.Text += $"Ocjene manje ili jednake sest: {Environment.NewLine}";
            foreach (var ocjena in drugiRez)
            {
                txtBoxPrikaz.Text += ocjena + " ";
                txtBoxPrikaz.Text += Environment.NewLine;
            }
            //Sve ovo gore nam omogucava namespace Linq i njegove ekstendirane metode, tipa Where();


            //Primjer koristenja query jezika SQL:

            var brojevi = new List<int>()
                { 1, 5, 4, 7, 88, 58, 60, 25, 89, 954, 9, 5, 6, 22, 3, 5, 9, 6 }; //Neka lista brojeva;

            var rezultat =
                from broj in brojevi where broj > 30 select broj; //Odabiremo samo one brojeve koji su veci od 30;

            txtBoxPrikaz.Text += $"Brojevi veci od 30 su: {Environment.NewLine}";
            foreach (var broj in rezultat)
            {
                txtBoxPrikaz.Text += broj + " ";
                txtBoxPrikaz.Text += Environment.NewLine;
            }

            //Primjer sa studentima:
            var studenti = new List<Student>()//Kreiramo listu studenata;
            {
                new Student() { Ime = "Haris", Prezime = "Kordic", Indeks = "IB200110" },
                new Student() { Ime = "Goran", Prezime = "Skondric", Indeks = "IB200110" },
                new Student() { Ime = "Amra", Prezime = "Verdic" }
            };

            var studentiSaIndeksima = from s in studenti
                where s.Indeks != null
                select new { ime = s.Ime, prezime = s.Prezime };//Iz liste studenti uzmi sve studente ciji je indeks neprazan, te kreiraj anonimnu varijablu sa propertijem ime i prezime;

            txtBoxPrikaz.Text += $"Studenti sa validnim indeksima: {Environment.NewLine}";
            foreach (var s in studentiSaIndeksima)
            {
                txtBoxPrikaz.Text += s.ime + " " + s.prezime + Environment.NewLine;
            }
        }

        private bool VeceOdSest(int ocjena)//ili =>ocjena>6;
        {
            return ocjena > 6;
        }

        //Metoda koja ce da pokaze principe kreiranja i koristenja metoda ekstenzije nad nekim od ugradjenih tipova podataka:
        private void MetodeEkstenzije()
        {
            var ime = "Haris";//String;
            txtBoxPrikaz.Text += ime + Environment.NewLine;//Prije promjene;
            txtBoxPrikaz.Text += ime.Enkripcija() + Environment.NewLine;//Sa promjenom;

            txtBoxPrikaz.Text +=DateTime.Now.ToBosnianTime() + Environment.NewLine;//Primjer ekstenzije za DateTime tip;
        }
        //Metoda koja ce objasniti anonimne varijable i njihovu ulogu:
        private void AnonimneVarijable()
        {
            //Svrha anonimnih varijabla jeste da one nemaju neki tip vec su samo objekti lokalno kreirani;
            //Primjer:

            var person = new { Ime = "Amar", Prezime = "Djulkovic" };//Za razliku od direktnog adresiranja (kod tuple primjera), ovdje koristimo imePropertija = vrijednost;
            //person.Ime = "Adis";//Ovo ne mozemo uciniti jer su svi propertiji anonimnih objekata readonly;

            //Medjutim ovo mozemo:
            txtBoxPrikaz.Text += person.Ime +" "+ person.Prezime + Environment.NewLine;//Zato sto ne mijenjamo nigdje vrijednost;

            //NOTE:
            //Pored var mozemo koristiti i dynamic za deklarisanje anon. varijabli ali ne
            //mozemo koristiti object tj. mozemo ali necemo moci ni na koji nacin pristupiti obiljezjima koje smo kreirali, pa cak ni da ih samo procitamo;
        }
        //Metoda koja ce da objasni funkcionalnost Tuple-ova i dto (Data transfer objects):
        private void TupleIDto()
        {
            //Ideja tuple objekata jeste da su to setovi razlicitih vrijednosti;
            //Npr:
             (string,string,bool) tuple=("Ime","Prezime",true);
            //Po defaultu tuple ima obiljezja:
            var ime=tuple.Item1;
            //Medjutim mi mozemo direktnim adresiranjem reci kako zelimo da se koji el zove:
            var imenovaniTuple = (Ime:"Ime", Prezime:"Prezime", Aktivan:false);
            var prezime=imenovaniTuple.Prezime;

            var povratniTuple = TupleMetoda(imenovaniTuple);
            //Gornja metoda nije skalabilna i ako se promjeni ili doda neki tip u tuple, mora se sve mijenjati;
            //Zbog toga pravimo dto (Data transfer objekte) koje saljemo i primamo te ako dodje do dodavanja ili
            //Ulanjanja pojedinih elemenata ne mijenjamo nista u samim metodama  jer nema potrebe;

            var pametniTuple = PametnaTupleMetoda(new dtoStudent());

        }
        //Neka metoda koja radi nesto sa ulaznim tuple:
        private (string, string, bool) TupleMetoda((string, string, bool) tuple)
        {
            //Ova metoda je poprilicno nezgrapna jer je puno zagrada u ulaznim i povratnim tipovima;
            return tuple;
        }
        //Pametnija implementacija gornje metode:
        private dtoStudent PametnaTupleMetoda(dtoStudent tuple)
        {
            //Ako treba nesto se pojedinacno raditi sa nekim od tipova objekta npr ocjenama,
            //Moze se pristupiti ovdje;
            //tuple.Ocjene;
            return tuple;
        }
        //Metoda koja ce predstaviti funkcionalnost dynamic kljucne rijeci:
        public  void Dynamic()
        {
            //Kljucna rijec dynamic  nam omogucava da dinamicno mjenjamo tip podatka;
            //Takodjer moze biti poslan kao parametar nekoj metodi;
            //Dynamic omogucava pristup ne kreiranim metodama ili propertijima dok gresku tek dobijamo u runtime-u;
            dynamic varijabla = 12;//Int;
            varijabla = "12";//String;
            varijabla = new List<int>() { 1, 2, 3 };//Lista integer-a;

            //Za razliku od var, dynamic  varijabli moze da ne bude dodijeljena odma vrijednost:
            dynamic broj;
            broj = 5;

           // NekaMetoda(broj);//Poziv nepostojece metode;
           //
           // broj.Ime = "Neko Ime";//Dodijeljivanje nepostojecem propertiju;

            //Nigdje ne dobijamo gresku sve do runtime-a zato sto je sve ispravno napisati jer je ovo dynamic varijabla;


            //Koristenje sa dictionary:

            //Dictionary predstavlja kolekciju parova (istog ili razlicitog tipa) gdje prvi 
            //objekat para predstavlja kljuc a drugi vrijednost;

            var imenik = new Dictionary<string, string>();
            imenik.Add("061335452", "Haris");
            imenik.Add("061332452", "Omar");
            imenik.Add("061452452", "Denis");
            //Ispis svih osoba u imeniku:
            foreach (var person in imenik)
            {
                txtBoxPrikaz.Text += person.Key + " " + person.Value + Environment.NewLine;
            }
            txtBoxPrikaz.Text += imenik["061335452"] + Environment.NewLine;//Na osnovu kljuca dobijemo vrijednost;

           //Primjer ExpandoObject klase jeste da ona u sebi sadrzi interfejs IDictionary te u njega pohranjuje kljuceve i vrijednosti;
           dynamic osoba = new ExpandoObject();
           osoba.Ime = "Denis";//Dinamicki dodano u IDictionary;
           osoba.Prezime = "Music";//Dinamicki dodano u IDictionary;
           osoba.Student = new Student(){Ime="Amar",Prezime="Omanic"};//Mozemo dodati bilo koji tip podatka jer je ovo Dictionary <string,object> a object su svi tipovi podatka u C#;
           
           txtBoxPrikaz.Text += osoba.Ime + " " + osoba.Prezime + " "+ osoba.Student+ Environment.NewLine;
           //Da bi ovo gore radilo ne moze biti var ili ExpandoObject vec mora biti dynamic;
        }
        private void NekaMetoda(dynamic obj)//Metoda koja prima dynamic objekat;
        {
            obj.NepostojecaMetoda();//Nad ulaznim parametrom se pozove metoda koja ne postoji, medjutim nemamo upozorenja sve do runtime-a;
            //Ovo je moguce upravo zato jer je ulazni objekat dinamican;
        }

        //Metoda koja ce predstaviti funkcionalnost var i object keywords:
        private void VarIObject()
        {
            //Funkcionalnost keyword-a var jeste da automatski prepoznaje tip podatka sa lijeve strane 
            //te na taj nacin oslobadja programera da pise tip podatka na lijevoj strani;

            var broj = 10;
            var poruka = "Ovo je neka poruka";
            var ocjene = new List<int>() { 1, 2, 3, 4, 5 };

            //Kljucna rijec var funkcionise samo ako je sa desne strane poznat tip podatka tj. :
            //var obj;//Ovo nije moguce;

            //Kljucna rijec object predstavlja ustvari bazni objekt za svaki  objekt u C# programskom jeziku;
            //Sto znaci da bilo koji tip podatka moze postati object (logika kao bazni pokazivac koji pokazuje na izvedeni pokazivac);

            object broj2 = new int();
            //Sada kada pristupamo broj2 imamo sve metode koje ima object bazna klasa
            //Medjutim ako zelimo metode od izvedene klase int moramo posmatrati broj2 kao int objekat:

            broj2.GetHashCode();//Metoda object klase;
            (broj2 is int).CompareTo(true);//Metoda int klase;


            //Objekte mozemo stavljati kao parametre metodama, dok var ne mozemo jer nema smisla kada ne znamo kakav ce to parametar biti (kojeg tipa);

            Metoda(broj2);//Int
            Metoda(broj);//Int
            Metoda(ocjene);//List <int>

            object student = new Student();
            Metoda(student);//Saljemo apsolutno bilo koji tip;


            //Jos jedna svrha var jeste kada imamo duge deklaracije tipa:
            //Dictionary<KeyEventArgs, DataColumnChangeEventArgs> par = new Dictionary<KeyEventArgs, DataColumnChangeEventArgs>();
            //Se moze skratiti sa:
            var par= new Dictionary<KeyEventArgs, DataColumnChangeEventArgs>();
        }
        private void Metoda(object obj)//Metoda prima parametar tipa object sto nam omogucava da metodi posaljemo apsolutno bilo koji tip podatka;
        {
            //Neka implementacija;
            txtBoxPrikaz.Text+=(obj as Student)?.ToString();//Provjerimo da li je  poslani obj tipa student i ako nije null pristupimo njegovoj metodi ToString();
        }
    }
}
