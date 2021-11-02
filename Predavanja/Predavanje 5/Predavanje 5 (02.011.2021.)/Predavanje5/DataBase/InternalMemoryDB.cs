using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Predavanje5.Classes;

namespace Predavanje5.DataBase
{
    internal class InternalMemoryDB
    {
        //Staticna lista (prisutna bez potrebe da kreiramo objekat), koja ce sluziti za pohranu korisnika;
        public static List<Korisnik> Korisnici = InicijalizujKorisnika();



        //Metoda koja ce inicijalizirati jednog default korisnika:
        public static List<Korisnik> InicijalizujKorisnika()
        {
            //Duzi nacin:
           //var korisnik = new Korisnik()//Inicijalizujemo default korisnika sa njegovim obiljezjima;
           //{
           //    Id = 1,
           //    Ime = "Default",
           //    Prezime = "Default",
           //    KorisnickoIme = "DefaultD",
           //    Lozinka = "DefaultD",
           //    Datumrodjenja = DateTime.Now, //Uzme trenutno vrijeme;
           //    Aktivan = true
           //};
           //
           //var lista = new List<Korisnik>();//Napravimo pomocnu listu (lokalno);
           //lista.Add(korisnik);//Dodamo korisnika;
           //return lista;//Vratimo listu;


            //Kraci nacin:
            return new List<Korisnik>()//() zagrade pozovu ctor klase List, {} zagrade inicijaliziraju tu listu;
            {
                new Korisnik() //Inicijalizujemo default korisnika sa njegovim obiljezjima;
                {
                    Id = 1,
                    Ime = "Default",
                    Prezime = "Default",
                    KorisnickoIme = "DefaultD",
                    Lozinka = "DefaultD",
                    Datumrodjenja = DateTime.Now, //Uzme trenutno vrijeme;
                    Aktivan = true
                }//Moze biti koliko god objekata zelimo za inicijaliziranje;Odvajamo ih sa ,
            };
        }
    }
    
}
