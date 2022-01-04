using DLWMS.WinForms.P5;
using DLWMS.WinForms.P7;
using DLWMS.WinForms.P9;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.WinForms.DB
{
    internal class InMemoryDB
    {
        public static List<Korisnik> Korisnici = GenerisiKorisnike();
        public static List<P7.Student> Studenti = GenerisiStudente();
        public static List<P7.GodinaStudija> GodineStudija = GenerisiGodineStudija();
        public static List<P9.Spol> Spolovi = GenerisiSpolove();
        public static List<P9.Predmet> NPP = GenerisiPredmete();

        private static List<Predmet> GenerisiPredmete()
        {
            return new List<Predmet>() {
                new Predmet(){ Id = 1, Naziv="Programiranje I" },
                new Predmet(){ Id = 2, Naziv="Baze podataka" },
                new Predmet(){ Id = 3, Naziv="Matematika" },
                new Predmet(){ Id = 4, Naziv="Operativni sistemi" }
            };
        }

        private static List<Spol> GenerisiSpolove()
        {
            return new List<Spol>() {
                new Spol(){ Id = 1, Naziv="********" },
                new Spol(){ Id = 2, Naziv="Ženski" },
                new Spol(){ Id = 3, Naziv="Muški" }
            };
        }

        private static List<GodinaStudija> GenerisiGodineStudija()
        {
            return new List<GodinaStudija>() { 
                new GodinaStudija(){ Id = 1, Opis="1" },
                new GodinaStudija(){ Id = 2, Opis="2" },
                new GodinaStudija(){ Id = 3, Opis="3" },
                new GodinaStudija(){ Id = 4, Opis="4" }
            };
        }

        private static List<P7.Student> GenerisiStudente()
        {
            return new List<P7.Student>() { new P7.Student()
            {
                Id = 1,
                Ime = "Jasmin",
                Prezime = "Azemovic",
                DatumRodjenja = DateTime.Now,
                Email = "jasmin@edu.fit.ba",
                Lozinka = "jasmin",
                GodinaStudija = 1,
                Indeks = "IB150051",
                Slika = null,
                Aktivan = false
            }};
        }

        private static List<Korisnik> GenerisiKorisnike()
        {
            return new List<Korisnik>() { new Korisnik()
            {
                Id = 1,
                Ime = "Denis",
                Prezime = "Music",
                DatumRodjenja = DateTime.Now,
                KorisnickoIme = "denis",
                Lozinka = "denis",
                Aktivan = false
            }};         

            //var korisnik = new Korisnik()
            //{
            //    Id = 1,
            //    Ime = "Denis",
            //    Prezime = "Music",
            //    DatumRodjenja = DateTime.Now,
            //    KorisnickoIme = "denis",
            //    Lozinka = "denis",
            //    Aktivan = true
            //};
            //var lista = new List<Korisnik>();
            //lista.Add(korisnik);
            //return lista;
        }
    }
}
