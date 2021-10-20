using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  DLWMS_Predavanje_3__19._10._2021._.Predavanja.Interfejsi;

namespace DLWMS_Predavanje_3__19._10._2021._.Predavanja.Klase
{
    internal class Korisnik:IKorisnik//Implementiramo interfejs;
    {
        //Od korisnickog okruzenja sve vrijeme dok neke od metoda, atributa ili propertija nemamo 
        //implementirane, imati cemo upozorenje;


        //Propertiji iz interfejsa:
        public string KorisnickoIme { get;set; }
        public string Password { get;set; }
        public string Grad{get; set; }


        //Metode iz interfejsa:
        public bool PrijaviSe()
        {
            if (Password != null)//Ako figurativno password nije prazan;
            {
                Console.WriteLine($"Korisnik {KorisnickoIme} se prijavljuje");
                return true;
            }
            return false;
        }

        public bool Odjava()
        {
            Console.WriteLine($"Korisnik  {KorisnickoIme} se odjavljuje");
            return true;
        }
    }
}
