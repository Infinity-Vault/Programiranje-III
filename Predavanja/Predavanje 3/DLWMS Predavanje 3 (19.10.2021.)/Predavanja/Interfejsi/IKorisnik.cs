using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS_Predavanje_3__19._10._2021._.Predavanja.Interfejsi
{
    internal interface IKorisnik
    {
        //Svrha interfejsa jeste da postavi 'sablon' metoda, atributa  i funkcionalnosti koje bi odredjena klasa mogla implementirati;
        //Interfejs nema definicije metoda/atributa/propertija vec ima samo njihove potpise;

        string KorisnickoIme { get;set; }//Property
        string Password { get; set; }//Property
        string Grad { get; set; }//Property

        bool PrijaviSe();//Metoda
        bool Odjava();//Metoda;

    }
}
