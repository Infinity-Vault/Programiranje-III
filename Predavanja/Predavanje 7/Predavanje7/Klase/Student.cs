using System;
using System.Drawing;
namespace Predavanje7.Klase
{
    public class Student
    {
        //Propertiji:

        public int Id { get; set; }
        public int Godina { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime Rodjen { get; set; }
        public Image Slika { get; set; }
        public string Indeks { get; set; }
        public bool Aktivan { get; set; }
        public string Email { get; set; }
        public string Lozinka { get; set; }
        public string ImePrezime => Ime + " " + Prezime;
    }
}
