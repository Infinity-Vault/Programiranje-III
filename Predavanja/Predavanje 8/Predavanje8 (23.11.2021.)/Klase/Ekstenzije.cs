using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klase
{
    internal static class Ekstenzije
    {
        //Klasa koja ce da sadrzi ekstenzije nad ugradjenim tipovima podataka;
        //Ekstenzija je u sustini definisanje novog ponasanja odredjenog tipa podatka tj.
        //prosirenje njegovih funkcionalnosti;

        //NOTE
        //Sve ekstenzije moraju biti staticne kao i klasa u kojoj se one nalaze;
        public static string Enkripcija(this string poruka)//Ulazni parametar mora biti oznacen sa 'this' nakon cega slijedi neki od ugradjenih tipova podataka, kako bi se znalo da se ekstenzija vrsi nad objektom koji je pozvao metodu ekstenzije;
        {
            var povratniString = string.Empty;//Inicijalizovan na prazan string;
            var pattern = "abcdefghijklmnopqrstuvwxyz0123456789";//Neki pattern;
            //var patternReversed = pattern.Reverse();//Obrnuti pattern;Moze i ovako samo zbog nekog razloga postoji null reference exception...
            var patternReversed = "zyxwvutsrqponmlkjihgfedcba9876543210";
            foreach (var znak in poruka.ToLower())//Smanjimo ulazni string na sva mala slova jer su u patternu sva mala;
            {
                if (znak == pattern[pattern.IndexOf(znak)])//Ako je  karakter ulaznog niza pronadjen u patternu;
                    povratniString += patternReversed[pattern.IndexOf(znak)];//U povratni string smjesti karakter na toj lokaciji ali u obrnutom nizu;
            }
            return povratniString;//Vrati kreirani string;
        }

       // public static string ToBosnianTime(this DateTime datum)
       // {
       //     return datum.ToString("dd/mm/yy H:mm:ss");//Vrati string prosljedjenog datuma u specificiranom formatu
       // }

       //Kraci nacin sa body expressionom:
       public static string ToBosnianTime(this DateTime datum)=> datum.ToString("dd/mm/yy H:mm:ss");
    }
}
