using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  DLWMS_Predavanje_3__19._10._2021._.Predavanja.Interfejsi;


namespace DLWMS_Predavanje_3__19._10._2021._.Predavanja.Klase
{
    internal class MainP3
    {
       static ILogger _logger;//Kreiranje statickog loggera koji ce pratiti upise greski kroz citav namespace;
       //Mora biti static, jer su static metode sve dole , u kojima ce se pozivati;

        public static void Pokreni(ILogger logger) //Dobijemo neki od tri loggera koje ce biti prisutan u cijelom MainP3;
        {
            ConstIReadonly();
            Nasljedjivanje();
            Interfejsi();
            _logger = logger;//Prezumemo vrijednost proslijedjenog loggera;
            Logovanje();
            Repozitoriji();
            PrimjerPostojecihInterfejsa();
        }


        //Primjer za const i readonly keywords:
        private static void ConstIReadonly()
        {
            Console.WriteLine("POCETAK CONSTIREADONLY()");
            Poruke poruka = new Poruke();//Dflt ctor;
            Console.WriteLine(poruka.Recenica);//Ispise se vrijednost read only propertija;
            //poruka.Recenica = "Promjenjena recenica";//Dobijemo gresku da je ovaj property readonly field;
            //poruka.Konstanta;//Ovaj property uopste nije ni accessable jer je const;
            Console.WriteLine($"------------------------------------KRAJ-------------------------------------");
        }

        //Primjer nasljedjivanja klasa (inheritance):
        private static void Nasljedjivanje()
        {
            Console.WriteLine($"POCETAK NASLJEDJIVANJE()");
            //Znamo od prije da objekti bazne klase mogu biti inicijalizirani izvedenom dok obrnuto nije moguce;

            
            //Student notValid = new Osoba();//Greska jer pokusavamo inicijalizirati izvedenu klasu baznom !;

            //Normalni  obj tipa  klase  Osoba inicijaliziramo njegovom  klasom;
            Osoba osoba = new Osoba() { ImePrezime = "Neka osoba", Godiste = 2001 };

            //Objekat tipa bazne klase inicijaliziramo izvedenom klasom:
            Osoba student = new Student() { ImePrezime = "Denis Music", Godiste = 2001, Indeks = 200120,Password="nekipass123" };

            osoba.PredstaviSe();
            student.PredstaviSe();//Dodan atribut indeks;

            //Castamo studenta u interfejs IStudent te pristupamo metodama karakteristicnim za taj interfejs:
            //Bez castanja sa 'as' to nije moguce;
            if((student as IStudent).PrijaviSe())
                Console.WriteLine($"Prijava uspjesna !");
            if((student as IStudent).Odjava())
                Console.WriteLine($"Odjava uspjesna !");

            //Kljucna rijec is:
            //Kljucna rijec 'is' nam sluzi da vrsimo provjeru da li je neki objekat odredjenog tipa, npr:

            if(student is Osoba)//Bice true jer je student klasa koja ima base class Osoba;
                Console.WriteLine($"Student je ujedno i osoba");
            else if(student is Student)//I ovo bi bilo true, ali gornji if se izvrsi prvi pa ovaj else if ne moze da se izvrsi;
                Console.WriteLine($"Student je student");

            //klucna rijec as:
            //Kljucna rijec 'as'  je veoma slicna dynamiccast operatoru u jeziku C++, te time nam omogucava da
            //castamo objekte:

            var temp = student as Osoba;
            temp.OsobaInfo();//Pozovemo metodu klase Osoba;


            //Primjeri abstraktne klase i metoda:

            //Objekte abstraktne klase ne mozemo instancirati:
            //AbstractBaseClassOsoba abstraktnaKlasa = new AbstractBaseClassOsoba();//Greska jer nema instanciranja;

            //Medjutim mozemo kreirati reference i pokazivace tipa bazne abstraktne klase:

            AbstractBaseClassOsoba nekiStudent = new DerivedClassOsobaStudent()
                { Name = "Student Neki", Age = 2005, Indeks = 200154 };
            //Ovo je moguce jer je objekat bazne klase referenca (a ne instanca) na objekat izvedene klase;

            nekiStudent.PrikaziInformacije();
            nekiStudent.Info();
            Console.WriteLine($"------------------------------------KRAJ-------------------------------------");
            }

        private static void Interfejsi()
        {
            Console.WriteLine($"POCETAK INTERFEJSI");
            //Kod interfejsa,kao i kod klasa, interfejs koji je bazni  moze biti inicijalizovan  svim  klasama koje nasljedjuju taj interfejs ili neki njegov izvedeni interfejs:

            //Primjer baznog interfejsa inicijalizovanog klasom koja ima samo taj interfejs;
            IKorisnik korisnik = new Korisnik() { KorisnickoIme = "Amar Abaz", Password = "kakao123" };
            //Primjer baznog interfejsa inicijalizovanog  klasom koja ima izvedeni interfejs iz baznog interfejsa;
            IKorisnik student = new Student()
            {
                ImePrezime = "Haris Kordic", Godiste = 2001, Indeks = 200117, KorisnickoIme = "HarisK",
                Password = "kajoma123"
            };

            PosaljiKorisnikaNaServer(korisnik);
            PosaljiKorisnikaNaServer(student);
            Console.WriteLine($"------------------------------------KRAJ-------------------------------------");
        }
        //Funkcija koja 'salje' objekat na server:
        private static void PosaljiKorisnikaNaServer(IKorisnik obj)//Da smo za param stavili IStudent, mogli bi samo Studenta slati, jer nije bazni interfejs IStudent vec IKorisnik;
        {
            //Posto mozemo primiti dva tipa, Student i Korisnik, moramo ispitati koji je tip;
            if(obj is Korisnik)
                Console.WriteLine($"Saljem korisnika {obj.KorisnickoIme} na server...");
            else if (obj is Student)
            {
                var student = obj as Student;//Zelim da mi obj postane (casta se)  u studenta;
                //Na ovaj nacin mogu dobiti pristup svim obiljezjima klase Student, inace to ne bih mogao bez ovoga cast;
                Console.WriteLine($"Saljem studenta {student.ImePrezime} na server...");
            }
        }

        //Primjer logovanja greski pri exikuciji odredjenog dijela koda;
        private static void Logovanje()
        {
            Console.WriteLine($"POCETAK LOGOVANJE()");
            try
            {
                throw new Exception("Demo greska bacena exceptionu...");
            }
            catch (Exception greska)
            {
                _logger.Log(greska);//Loggujemo gresku;
            }

            //Mozemo logger i promijeniti ovdje:
            _logger = new DBLogger();//Sada ce loggirati na DB a ne na API;
            _logger.Log("Kraj logiranja u metodi Logovanje()");//Zahvaljujuci data extractoru moze se primiti 
                                                                      //bilo sta, ili string ili exception ili bilo sta jer je base class svim classama object koji mi primamo kao message u ILogger i u DataExtractor; 
            Console.WriteLine($"------------------------------------KRAJ-------------------------------------");
        }

        //Primjeri repozitorija:
        private static void Repozitoriji()
        {
            Console.WriteLine($"POCETAK REPOZITORIJI()");
            //Kreiramo repozitorij za studente:
            IRepository <Student> studentRepo = new Repository<Student>();
            //Sada imamo dostupne sve CRUD akcije nad objektom studentRepo:
            studentRepo.Create(new Student());//Kreiramo;
            Student student = new Student();
            if(studentRepo.Delete(student))//Obrisemo;
               Console.WriteLine($"Student uspjesno obrisan");
            studentRepo.GetById(1);//Vrati nekog studenta iz baze npr;
            if(studentRepo.Update(new Student() { ImePrezime = "Denis Music" }))//Update podataka;
                Console.WriteLine($"Student uspjesno update-ovan");

            //Takodjer se moze implementirat neka nova klasa koja ce nasljediti klasu Repository a samim time i interfejs IRepository:
            //Npr:

            KorisnikRepository repoKorisnika = new KorisnikRepository();
            repoKorisnika.Create(new Korisnik());//Imamo sve CRUD operacije iz IRepository interfejsa;
            Console.WriteLine($"------------------------------------KRAJ-------------------------------------");
            }

        //Primjer za vec implementisane interfejse:
        private static void PrimjerPostojecihInterfejsa()
        {
            Console.WriteLine($"POCETAK PRIMJERPOSTOJECIHINTERFEJSA()");
            //Kada zelimo da koristimo nesto externo za citanje i komunikaciju ili nesto slicno
            //mozemo uraditi sljedece:

            using(var podaci=new Poruke())//Da bi ovo radilo klasa mora imati mogucnost da se implicitno konvertuje u IDisposable;
            {
                Console.WriteLine($"Ovo je ispisano u using statementu, {podaci.Recenica}");
            }//U ovoj liniji koda, Dispose klase Poruke ce se pozvati i osloboditi sve sto se koristilo od strane klase Poruke;
            Console.WriteLine($"------------------------------------KRAJ-------------------------------------");
        }
    }

   
}
