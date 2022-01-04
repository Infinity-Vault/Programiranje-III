using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.ConsoleApp.Predavanja.P3
{
    internal class MainP3
    {
        static ILogger _logger;
        public static void Pokreni(ILogger logger)
        {
            //KonstanteReadOnly();
            // Nasljedjivanje();
            //Interfejsi();
            _logger = logger;
            //LoggerDemo();
            //RepositoryPristupPodacima();
            ImplementacijaPostojecihInterfejsa();
        }
        private static void ImplementacijaPostojecihInterfejsa()
        {
            //using (var citac = new StreamReader(" "))
            //{

            //}
            using (var citac = new Poruke())
            {

            }
        }
        private static void RepositoryPristupPodacima()
        {
            StudentRepository studentRepository = new StudentRepository();
            studentRepository.GetById(54);
            studentRepository.Insert(new Student() { Indeks = 564 });

            KorisnikRepository korisnikRepository = new KorisnikRepository();
            korisnikRepository.GetById(54);
            korisnikRepository.Insert(new Korisnik() { KorisnickoIme = "admin" });
        }
        private static void LoggerDemo()
        {
            try
            {
                throw new Exception("DEMO GRESKA");
            }
            catch (Exception ex)
            {
                _logger.Log(ex);
            }
        }
        private static void Interfejsi()
        {
            IKorisnik korisnik = new Korisnik();
            IStudent student = new Student();
            //IKorisnik notValid = new IKorisnik();

            //InterfejsInfo(korisnik);
            InterfejsInfo(new Student());
            InterfejsInfo(new Korisnik());
            _logger.Log("Zavrsena metoda Interfejsi()");
        }

        private static void InterfejsInfo(IKorisnik korisnik)
        {
            korisnik.Prijava();
            //korisnik.PrijaviIspit(123);
        }
        private static void Nasljedjivanje()
        {
            //Osoba denis = new Osoba();
            Osoba jasmin = new Student();

            //OsobaInfo(denis);
            OsobaInfo(jasmin);
        }

        private static void OsobaInfo(Osoba osoba)
        {
            if (osoba is Student)
            {
                var student = osoba as Student;
                student.Indeks = 3158;
            }
        }
        private static void KonstanteReadOnly()
        {
            Console.WriteLine(Poruke.NedozvoljenaOperacija);
        }
    }
}
