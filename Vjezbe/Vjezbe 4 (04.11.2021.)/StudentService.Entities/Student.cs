using System;
namespace StudentService.Entities
{
    public class Student:Entity//Nasljedimo class Entity kako bi imali njene propertije;
    {
        //Propertiji:

        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Indeks { get;set;}
        public int Semestar { get; set; }
        public DateTime Rodjen { get; set; }

        //Nacin da preko jednog Propertija izvucemo vrijednost od vise propertija:

       // public string ImePrezime
       // {
       //     get { return Ime + " " + Prezime; }
       //     set { ImePrezime = value; }
       // }

       //Drugi nacin jeste da se koristi expression body sintaksa:

       public string ImePrezime => Ime +" "+ Prezime;
    }
}
