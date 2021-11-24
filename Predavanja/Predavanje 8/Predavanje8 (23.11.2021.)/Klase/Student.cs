using System.Collections.Generic;
namespace Klase
{
    internal class Student
    {
        //Obiljezja:

        public string Indeks { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public List<int> Ocjene { get; set; } = new List<int>() { 6, 5, 8, 9, 9, 7, 8, 10, 6, 10, 10 };
        //Inicijalizujemo listu sa vec nekim ocjenama  studenta radi testiranja;

        //Override metode:
        public override string ToString() => Ime + " " + Prezime;
    }
}
