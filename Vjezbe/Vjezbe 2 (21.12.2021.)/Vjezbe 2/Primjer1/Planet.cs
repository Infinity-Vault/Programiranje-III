using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezbe_2.Primjer1
{
    internal abstract class Planet 
    {
        //Kada klasu proglasimo abstract, to znaci da ona ne moze biti instancirana vec da
        //moze imati samo svoje reference i pokazivace;

        //Primjer readonly atributa:
        //readonly atribut ne zahtijeva da se odmah pri deklaraciji inicijalizuje,
        //to se moze obaviti i u nekom od konstruktora, ali kada se jednom inicijalizuje,
        //vise se ne moze mijenjati, moze se samo citati;

        //Property ne moze biti proglasen sa readonly jer setter onda nema smisla i kompajler daje gresku;
        public readonly string Name;

        public Planet()//Dflt ctor;
        {
            Name = "Ime neke Planete";
        }

        public Planet(string name)//User def ctor;
        {
            Name = name;
        }


        public Tree[] Trees { get; set; }
        public  double Mass{get;set; } //= 22.4587415d;//Pored double stavimo d kao oznaku da kompajler zna da je double;

        //Ako metodu proglasimo  abstract, onda ona mora biti override-ovana u izvedenoj klasi,
        //u suprotnom imamo gresku i kod se ne moze kompajlirati;
        //Takodjer ne mozemo imati deklaraciju abstract metode, ona se pise u izvedenim klasama,
        //na taj nacin forsiramo izvedenu klasu da napravi implementaciju te metode. (slicno interface);
        //Jos jedna stvar jeste da metoda ne moze biti abstract ukoliko klasa u kojoj je ta metoda nije abstract;

        //Primjer abstract metode:

        public abstract void PopulatePlanets(Tree[] trees);
        
        //Primjer virtual metode:
        //Kljucna rijec virtual omogucava override-anje metode u izvedenoj klasi;
        public virtual void Info()
        {
            Console.WriteLine($"Planeta {Name}");
        }

        //Neka obicna metoda koja se nece moci override-ati (nema kljucnu rijec virtual):

        public bool Alive()
        {
            if (Name!=null)//Ako ime planete postoji tehnicki je ziva (test logika, nema pravog smisla);
                return true;
            return false;
        }
    }
}
