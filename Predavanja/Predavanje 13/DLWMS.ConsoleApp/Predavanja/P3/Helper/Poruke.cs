using System;

namespace DLWMS.ConsoleApp.Predavanja.P3
{
    public class Poruke : IDisposable
    {
        public const string NedozvoljenaOperacija = "Nedozvoljena operacija...";
        public const string PodaciNisuDostupni = "Zahtijevani podaci trenutno nisu dostupni.";
        public readonly string NedovoljnePrivilegije;// = "Nedozvoljena operacija..."
        public const string OslobadjamResurse = "Oslobadjam zauzete reseurse.";

        public Poruke()
        {
            NedovoljnePrivilegije = "Nemate dovoljno privilegija...";
        }

        public void Dispose()
        {
            Console.WriteLine(OslobadjamResurse);
        }
    }
}
