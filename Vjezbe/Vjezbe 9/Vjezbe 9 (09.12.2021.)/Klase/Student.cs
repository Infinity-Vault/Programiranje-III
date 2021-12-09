using System.Collections.Generic;

namespace Klase
{
    internal class Student
    {
        public int Id { get; set; }//Radi DB;
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int Godina { get; set; }
        public List<Predmet> Predmeti { get;set;}=new List<Predmet>();//Inicijalizujemo pri kreiranju propertija radi null reference exceptiona;
    }
}
