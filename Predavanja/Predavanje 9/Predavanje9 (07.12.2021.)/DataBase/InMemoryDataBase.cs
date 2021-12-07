using System;
using System.Collections.Generic;
using Klase;

namespace DataBase
{
    internal static class InMemoryDataBase
    {
        public static List<Student> Studenti = GenerisiStudente();//Inicijalizujemo radi null ref exceptiona;
        public static List<Spol> Spolovi = GenerisiSpolove();//Inicijalizujemo radi null ref exceptiona;
        public static List<Predmet> Predmeti = GenerisiPredmete();//Inicijalizujemo radi null ref exceptiona;
        public static List<Godina> Godine = GenerisiGodine();//Inicijalizujemo radi null ref exceptiona;
        public static List<PolozeniPredmet> PolozeniPredmeti = new List<PolozeniPredmet>();//Inicijalizujemo radi null ref exceptiona;
        private static List<Godina> GenerisiGodine()
        {
            return new List<Godina>()
            {
                new Godina() { Id = 1, Naziv = "I" },
                new Godina() { Id = 2, Naziv = "II" },
                new Godina() { Id = 3, Naziv = "III" },
                new Godina() { Id = 4, Naziv = "IV" }
            };
        }

        private static List<Predmet> GenerisiPredmete()
        {
            return new List<Predmet>()
            {
                new Predmet() { Id = 1, Naziv = "PRI" },
                new Predmet() { Id = 2, Naziv = "PRII" },
                new Predmet() { Id = 3, Naziv = "PRIII" },
                new Predmet() { Id = 4, Naziv = "BPI" },
                new Predmet() { Id = 5, Naziv = "BPII" },
            };
        }

        private static List<Spol> GenerisiSpolove()
        {
            return new List<Spol>()
            {
                new Spol() { Id = 1, Opis = "Musko" },
                new Spol() { Id = 2, Opis = "Zensko" }
            };
        }

        private static List<Student> GenerisiStudente()
        {
            return new List<Student>()
            {
                new Student()
                {
                    Id = 1,
                    Ime = "Default",
                    Prezime = "Default",
                    Aktivan = true,
                    Indeks = "200000",
                    Lozinka = "Default",
                    Email = "default@edu.fit.ba",
                    Slika = null,
                    Spol = null,
                    DatumRodjenja = DateTime.Now
                }
            };
        }
    }
}
