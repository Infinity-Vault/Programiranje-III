using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.ConsoleApp.Predavanja.P2
{
    internal class Profesor
    {

        //Dflt ctor:
       // public Profesor()
       // {
       //     //Ovo bi rijesilo slucaj pri samoj alokaciji (da ne bi bilo Null reference exceptiona) ali ne i pri vracanju 
       //     //necega sa servera ili API-ja npr, a da to bude ovaj objekat ali nuliran;
       //     ImePrezime = "NOT_SET";
       //     Godiste = 2000;
       // }

        //Kreiranje propertija za ime i prezime Profesora:
        public string ImePrezime { get; set; }

        //Kreiranje propertija za godiste Profesora:
        public int Godiste{ get; set; }

        //Kreiranje niza ocjena (koje je dao studentima) za svakog Profesora:

        private int[] Niz = new int[] { 1, 2, 3, 4, 5 };

        //Kreiranje propertija (Indeksatora) koji se kasnije koristi za manipulisanje niza ocjena:
        public int this[int lokacija]//This kljucna rijec predstavlja objekat koji je pozvao trenutno ovaj property;
        {
            //Moze i ovako:
            // get { return Niz[lokacija];}
            
            //Koristenje kraceg zapisa aka expression-a:
            get => Niz[lokacija];
            //Moze i ovako:
            // set
            // {
            //     Niz[lokacija] = value;//Value keyword je right hand value koju damo pri pozivu;
            // }

            //Koristenje kraceg zapisa aka expression-a:
            set => Niz[lokacija] = value;
        }

        //Dodavanje jednog Nullable propertija:

        public Nullable<int> BrojKartice { get; set; }//Moze se krace zapisati int?;

        public override string ToString()
        {
            //String.Join() metoda nam omoguci ispis bilo kojeg tipa objekta jer kao parametar prima
            //param niz tipa object (object je base class svim klasama .NET framework-a);
            return $"Ime i prezime  profesora: {ImePrezime}, godiste: {Godiste}, date ocjene:{string.Join(",", Niz)}, broj kartice: {BrojKartice}";
        }

        //Destruktor:
        //Svrha destruktora jeste da vrijednosti propertija objekta spasi (out) tj. njima inicijalizuje neke lokalne varijable;
        public void Deconstruct(out string imePrezime, out int godiste, out int[] niz,out int brojKartice)
        {
            //Mora se zvati Deconstruct, da bi metoda bila prepoznata kao destruktor;
            imePrezime = ImePrezime;
            godiste = Godiste;
            niz = Niz;
            brojKartice = BrojKartice.GetValueOrDefault();//Ne moze samo BrojKartice jer je on  tipa int? i ne moze convertat u int;
        }
    }
}
