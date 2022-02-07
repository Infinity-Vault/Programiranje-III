using cSharpIntroWinForms.P8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpIntroWinForms
{
    class DBInMemory
    {
        public static List<Korisnik> RegistrovaniKorisnici { get; set; }
        public static List<string> Spolovi { get; set; }
        public static List<Predmet> NPP2018 { get; set; }

        static DBInMemory()
        {
            RegistrovaniKorisnici = new List<Korisnik>();
            Spolovi = new List<string>();
            NPP2018 = new List<Predmet>();
            DodajPodrazumijevaneKorisnike();
            DodajSpolove();
            UcitajPredmeteNPP2018();
        }

        private static void UcitajPredmeteNPP2018()
        {
            for (int i = 1; i <= 20; i++)
                NPP2018.Add(new Predmet() { Id = i, Naziv = $"Predmet {i}" });
        }

        private static void DodajSpolove()
        {
            Spolovi.Add("Muški");
            Spolovi.Add("Ženski");
            Spolovi.Add("*****");
        }

        private static void DodajPodrazumijevaneKorisnike()
        {
            Korisnik k1 = new Korisnik() { Id = 1, Ime = "Denis", Prezime = "Music", KorisnickoIme = "denis", Lozinka = "denis" };
            Korisnik k2 = new Korisnik() { Id = 2, Ime = "Jasmin", Prezime = "Azemovic", KorisnickoIme = "jasmin", Lozinka = "jasmin" };
            RegistrovaniKorisnici.Add(k1);
            RegistrovaniKorisnici.Add(k2);
        }
    }


}
