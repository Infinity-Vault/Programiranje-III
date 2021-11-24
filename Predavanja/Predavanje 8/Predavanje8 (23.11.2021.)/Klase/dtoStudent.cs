using System.Collections.Generic;
namespace Klase
{
    internal class dtoStudent
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public bool Aktivan { get; set;}

        //Dodamo ocjene samo ovdje na jednom mjestu nepotrebno je dirati metode koje koriste ovu klasu:
        public List<int> Ocjene { get; set; } = new List<int>();

    }
}
