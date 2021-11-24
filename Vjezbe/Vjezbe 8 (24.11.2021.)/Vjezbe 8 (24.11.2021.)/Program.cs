using System;
using System.Collections.Generic;
using System.Linq;
namespace Vjezbe_8__24._11._2021._
{
    class Program
    { 
        //Primjer delegata:
        private delegate bool MojDelegat(int broj);

        //Primjer delegata i eventa:
        private delegate void Okidac(string poruka);
        //Event
        private static event Okidac Dogadjaj;
        static void Main(string[] args)
        {

            //Poziv manuelno sa MoveNext() i current:

            var number = GetIntegers(); //Dobijemo  IEnumerator kolekciju integera;

            while (number.MoveNext()) //Sa move next se krecemo po listi;
            {
                Console.WriteLine(number.Current + Environment.NewLine); //Sa current dobijemo trenutni clan;
            }
            //Enumeratori ne daju promjenu, oni su samo read only;Iteratori daju promjenu;

            //Primjer delegata:
            //Delegat je tip te se mora inizijalizirat;
            MojDelegat mojDelegat = IsPositive;//Inicijalizacija;
            mojDelegat += IsPositive;//Pretplatimo se;
            mojDelegat += IsPositive;
            mojDelegat += IsPositive;
            mojDelegat += IsPositive;
            mojDelegat += IsPositive;
            mojDelegat += IsPositive;

            Console.WriteLine(mojDelegat.Invoke(8));//Poziv delegata (citav niz i svaka pretplacena metoda se okine u ovom trenutku sa proslijedjenim parametrom);


            //Primjer eventa sa delegatom:
            //Dogadjaj (event) nije tip stoga se moze odmah dodati/oduzeti  na njega  bez inicijaliziranja;
            Dogadjaj += Print;//Pretplatimo se;
            Dogadjaj += Print;
            Dogadjaj += Print;

            Dogadjaj?.Invoke("Neka poruka");//Ispitamo da li je nulliran niz dogadaja  te ako nije Invokamo sve njegove subscribed metode sa ulaznim parametrom string;


            //Primjer za ekstenziju interfejsa,kada se uradi ekstenzija interfejsa onda svaka klasa koja implementira taj interfejs ce imati i tu ekstenziju;
            var brojevi = new List<int>() { 1, 4, 5, 7, 8, 9, 5, 66, 5, 4, 8 };//Kreiramo listu br;

            var rezultat = brojevi.Filtriraj(broj => broj >= 30);//Rezultat je nova lista filtrirana sa anonimnom metodom koja kaze da broj mora biti >= 30;
            //Ispis:
            foreach (var result in rezultat)
            {
                Console.WriteLine(result+Environment.NewLine);
            }
            //U filtriraj se moze proslijediti bilo koja metoda ili pokazivac koji prima int a vraca bool;
            //Primjer:

            bool FilterNeki(int br) => br >= 10;
            var noviRezultat=brojevi.Filtriraj<int>(FilterNeki);//<int> mozemo a i ne moramo navoditi jer je primitivni tip podatka pa se podrazumijeva;


            Console.ReadLine();
        }

        //Metoda za yield i enumeraciju:
        private static IEnumerator<int> GetIntegers()
        {
            var integers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 44, 55, 88, 99, 66, 55 };

            for (int i = 0; i < integers.Count; i++)
            {
                yield return integers[i]; //Yield pamti gdje je brojac na zadjnjem pozivu bio;
                //yield break;Ovime se zaustavi iteracija;
            }

            yield return 100;//Vracati mozemo i izvan for/foreach;
        }

        
        public static bool IsPositive(int broj)//Ili =>broj>=0;
        {
            return broj >= 0;
        }

        public static void Print(string poruka)
        {
            Console.WriteLine(poruka);
        }

    }
    //Klasa za kreiranje ekstenzija:
    public static class MyExtensions
    {
        public static IEnumerable<T> Filtriraj<T>(this IEnumerable<T> lista, Func<T, bool> filter)
        {
            return lista.Where(filter);
        }
    }
}
