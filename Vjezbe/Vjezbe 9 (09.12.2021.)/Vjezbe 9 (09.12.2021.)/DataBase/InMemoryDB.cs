using Klase;
using System.Collections.Generic;

namespace DataBase
{
    internal static  class InMemoryDB
    {
        public static List<Student>Studenti=GenerisiDfltStudenta();
        public static List<Predmet> Predmeti=new List<Predmet>();//Kako ne bi imali null reference  exception;
        //Metoda koja ce da generise nekog studenta za dgv;
        private static List<Student> GenerisiDfltStudenta()
        {
            return new List<Student>()
            {
                new Student()
                {
                    Id=1,
                    Ime="Default",
                    Prezime="Default",
                    Godina=1,
                }
            };
        }
      
    }
}
