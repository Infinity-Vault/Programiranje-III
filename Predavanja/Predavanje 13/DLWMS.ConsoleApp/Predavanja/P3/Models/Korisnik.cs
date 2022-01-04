using System;

namespace DLWMS.ConsoleApp.Predavanja.P3
{
    public class Korisnik : IKorisnik
    {
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }

        public bool Prijava()
        {
            Console.WriteLine("KORISNIK se prijavljuje...");
            return true;
        }
    }
}
