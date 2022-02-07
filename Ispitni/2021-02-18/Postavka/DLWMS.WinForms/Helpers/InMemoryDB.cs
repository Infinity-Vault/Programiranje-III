using DLWMS.WinForms.Entiteti;
using System;
using System.Collections.Generic;

namespace DLWMS.WinForms.Helpers
{
    public class InMemoryDB
    {
        public static List<Korisnik> Korisnici { get; set; }
        public static List<Student> Studenti { get; set; }
        public static List<Spol> Spolovi { get; set; }
        public static List<Predmet> NPP { get; set; }



        static InMemoryDB()
        {
            Korisnici = new List<Korisnik>();
            Studenti = new List<Student>();
            Spolovi = new List<Spol>();
            NPP = new List<Predmet>();

            UcitajBuildInKorisnike();
            UcitajBuildInStudente();
            UcitajSpolove();
            UcitajPredmete();
        }

        private static void UcitajPredmete()
        {
            NPP.Add(new Predmet() { Id = 1, Naziv = "Matematika" });
            NPP.Add(new Predmet() { Id = 2, Naziv = "Operativni sistemi" });
            NPP.Add(new Predmet() { Id = 3, Naziv = "Programiranje I" });
            NPP.Add(new Predmet() { Id = 4, Naziv = "Marketing" });
        }

        private static void UcitajSpolove()
        {
            Spolovi.Add(new Spol() { Id = 1, Naziv = "********" });
            Spolovi.Add(new Spol() { Id = 2, Naziv = "Ženski" });
            Spolovi.Add(new Spol() { Id = 3, Naziv = "Muški" });
        }

        private static void UcitajBuildInStudente()
        {
            Studenti.Add(new Student()
            {
                Id = 1,
                Ime = "Jasmin",
                Prezime = "Azemovic",
                DatumRodjenja = DateTime.Now,
                Email = "jasmin@fit.ba",
                Indeks = "IB150051",
                GodinaStudija = 1,
                Aktivan = true
            });

        }

        private static void UcitajBuildInKorisnike()
        {
            Korisnici.Add(new Korisnik()
            {
                Id = 1,
                Ime = "Denis",
                Prezime = "Music",
                DatumRodjenja = DateTime.Now,
                KorisnickoIme = "denis",
                Lozinka = "denis",
                Aktivan = true
            }) ;
            Korisnici.Add(new Korisnik()
            {
                Id = 2,
                Ime = "Goran",
                Prezime = "Skondric",
                DatumRodjenja = DateTime.Now,
                KorisnickoIme = "goran",
                Lozinka = "goran",
                Aktivan = true
            });
        }
    }
}
