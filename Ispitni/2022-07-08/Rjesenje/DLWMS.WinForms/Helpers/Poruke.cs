namespace DLWMS.WinForms
{
    public class Poruke 
    {
        public const string NedozvoljenaOperacija = "Nedozvoljena operacija...";
        public const string PodaciNisuDostupni = "Zahtijevani podaci trenutno nisu dostupni.";
        public readonly string NedovoljnePrivilegije;// = "Nedozvoljena operacija..."
        public  const string KrajRada = "Da li zelite zatvoriti aplikaciju?";
        public const string Pitanje = "Pitanje";
        public const string OslobadjamResurse = "Oslobadjam zauzete reseurse.";
        public const string DobroDosli = "Dobro dosli";
        public const string KorisnickiNalogNePostoji = "Korisnicki nalog ne postoji.";
        public const string NalogNijeAktivan = "Vas nalog nije aktivan. Molimo kontaktirajte...";
        public const string ObaveznaVrijednost = "Unos ove vrijednosti je obavezan!";
        public const string KorisnikUspjesnoDodat = "Podaci o korisniku uspjesno dodati!";
        public const string StudentUspjesnoDodat = "Podaci o studentu uspjesno dodati!";
        public const string StudentUspjesnoModifikovan = "Podaci o studentu uspjesno modifikovani!";

        public Poruke()
        {
            NedovoljnePrivilegije = "Nemate dovoljno privilegija...";
        }      
    }
}
