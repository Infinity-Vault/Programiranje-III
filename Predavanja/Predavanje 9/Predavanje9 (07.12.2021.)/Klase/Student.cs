using System;
using System.Collections.Generic;
using System.Drawing;
namespace Klase
{
    public class Student
    {
        public int Id { get; set; }
        public int Godina { get; set; }
        public string Email { get; set; }
        public string Lozinka { get;set; }
        public string Indeks { get;set; }
        public string Ime { get;set; }
        public string Prezime { get; set; }
        public Image Slika { get;set; }
        public DateTime DatumRodjenja { get;set; }
        public bool Aktivan { get; set; }
        public Spol Spol { get; set;}
        public List<PolozeniPredmet> PolozeniPredmeti { get; set; }

        public string ImePrezime => Ime + " " + Prezime;
        //Dflt ctor:
        public Student()
        {
            PolozeniPredmeti = new List<PolozeniPredmet>();//Kako ne bi imali pri dodavanju null reference exceptiona;
        }
    }
}
