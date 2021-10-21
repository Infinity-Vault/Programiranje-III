using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezbe_2.Primjer1
{
    internal class DwarfPlanet:Planet
    {
        //Naslijedili smo klasu Planet stoga imamo sve njene propertije atribute i metode;

        
        //Override-ana metoda Info():
        public override void Info()
        {
            Console.WriteLine($"Dwarf planeta {Name} mase: {Mass}");
            //Skroz drugaciji ispis;
        }

        //Sve dok ne override-amo abstract metodu PopulatePlanets imacemo gresku:

        public override void PopulatePlanets(Tree[] trees)
        {
            Trees = new Tree[100];//Inicijaliziramo 100 default objekata Tree;
        }
    }
}
