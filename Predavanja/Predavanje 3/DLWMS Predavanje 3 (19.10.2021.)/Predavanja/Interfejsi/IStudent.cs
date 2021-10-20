using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DLWMS_Predavanje_3__19._10._2021._.Predavanja.Interfejsi
{
    internal interface IStudent:IKorisnik//Implementiramo sve iz interfejsa IKorisnik a onda samo nadodamo
                                         //jednu metodu kako ona ne bi morala postojati u IKorisniku jer nema smisla za taj interfejs (ova dodana metoda); 
    {
        //Interfejse ne nasljedjujemo njih implementiramo; Moguce je na novi interfejs implementirati stari;
        //Tada se stari ponasa kao sto se bazna klasa ponasa kod nasljedjivanja klasa;
        //Svrha ovoga jeste, ako imamo u interfejsu IKorisnik sve sto nam treba sem jedne metode npr
        // PosaljiMailStudenskojSluzbi(), koja odgovara za koristenje u klasi student ali ne i u klasi korisnik.
        //Moze se implementirati i samo u interfejsu IKorisnik, pa da se u interfejsu IKorisnik stavi ova metoda kao default-na
        //Ali time interfejsi gube smisao;

        bool PosaljiMailStudenskojSluzbi();//Metoda;
    }
}
