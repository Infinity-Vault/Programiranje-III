using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Predavanje_1_Denis__05._10._2021._.Primjeri;

namespace Predavanje_1_Denis__05._10._2021._
{
    class Program
    {
        static void Main(string[] args)
        {
            //Neke razlike C++ i C#

           // //Niz args predstavlja argumente koji se u postavci projekta (u properties) mogu slati;
           // //Oni se takodjer mogu koristiti i njima se moze manipulisati u Main metodi;
           //
           //
           // //Ono sto je bilo cout u C++ je sada Console.WriteLine(); u C#:
           // Console.WriteLine("Ovo je neka poruka");




           //Primjer koda sa argumentima:
           for (int i = 0; i < args.Length; i++)
           {
               Console.WriteLine(args[i]);
           }
           //Primjer koda manipulisanjem sa razlicitim tipovima podataka,pointerima i klasama:
           Start.Pokreni();


           Console.ReadKey();//Ceka na neki input sa tastature (kako se ne bi konzola automatski zatvorila);
        }
    }
}
