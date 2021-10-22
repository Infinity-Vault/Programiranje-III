using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezbe_2.Primjer1
{
    internal class MainPrimjer1
    {
       public static void Pokreni()
       {
           PrimjerKonstanti();
           PrimjerReadOnlyIPrimjerAbstract();
       }

      

       //Primjer const:
       private static void PrimjerKonstanti()
       {
           MathConstants math = new MathConstants();
           //math.Pi;//Ne mozemo ovo uraditi jer je Pi static clan;Ne moze se preko reference pristupiti;

           //Ali isto tako posto jeste static, mozemo preko klase, bez istance pristupiti:

           Console.WriteLine($"Vrijednost Pi u klasi MathConstants je: {MathConstants.Pi}");
       }

       //Primjer readonly atributa i abstract keyword-a;
       private static void PrimjerReadOnlyIPrimjerAbstract()
       {
           //Posto je Planet abstract class ne mozemo praviti  njene instance:
           //Planet planeta = new Planet();//Greska;

           //Medjutim mozemo praviti reference, a posto je ona bazna klasa nasoj izvedenoj klasi
           //DwarfPlanet, moze biti inicijalizovanja njome;

           Planet planeta = new DwarfPlanet();//Readonly field 'Name' je pozvan ovdje za svoju inicijalizaciju;
           planeta.Info();//Override-ana metoda;

           //planeta.Name = "Neka planeta";//Ne mozemo jer je readonly field;Vec je postavljena inicijalna vrijednost u liniji 39;

           if(planeta.Alive())//Obicna metoda koju smo naslijedili iz bazne klase Planeta;
               Console.WriteLine($"Planeta {planeta.Name} je ziva !");

           planeta.PopulatePlanets(new Tree[100]);//Abstract metoda iz base class,override-ana;
           planeta.Mass = 28.2154846d;
           planeta.Info();
       }
    }
}
