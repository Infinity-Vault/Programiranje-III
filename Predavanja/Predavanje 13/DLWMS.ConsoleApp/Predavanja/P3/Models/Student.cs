using System;

namespace DLWMS.ConsoleApp.Predavanja.P3
{
    public class Student : Osoba, IStudent
    {
        public int Indeks { get; set; }
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }

        public override void PredstaviSe() { }

        public bool Prijava()
        {
            Console.WriteLine("STUDNET se prijavljuje...");
            return true;
        }

        public bool PrijaviIspit(int ispitId)
        {
            Console.WriteLine($"STUDNET prijavljuje ispit {ispitId}");
            return true;
        }
    }
}
