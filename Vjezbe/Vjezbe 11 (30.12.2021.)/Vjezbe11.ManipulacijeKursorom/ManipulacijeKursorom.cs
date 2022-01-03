using System.Collections.Generic;
using System.IO;

namespace Vjezbe11.ManipulacijeKursorom
{
    public class ManipulacijeKursorom
    {
        //Metoda koja pise na odredjenoj liniji u fajlu:
        public static void PisiNaLiniju(string sadrzaj, int brojLinije)
        {
            using(var fajl=new FileStream("Kursor.txt",FileMode.OpenOrCreate))
            using(var citac=new StreamReader(fajl))
            using(var pisac=new StreamWriter(fajl))
            {
                var NoviFajl=new List<string>();//Napravimo praznu listu string-ova;

                while(citac.Peek()!=-1)//Sve dok fajl nije prazan;
                    NoviFajl.Add(citac.ReadLine());//Procitaj liniju i dodaj je;

                NoviFajl.Insert(brojLinije, sadrzaj);//Umetnemo sadrzaj u odredjenu liniju;
                fajl.Position=0;//Resetujemo poziciju kursora jer pisemo ponovno u fajl;
                pisac.Write(string.Join("\n",NoviFajl));//U nas inicijalni fajl sa delimiterom '\n - new line' upisemo sadrzaj nase liste string-ova NoviFajl;
            }
        }

        //Metoda koja pise na odredjenu lokaciju:
        public static void PisiNaLokaciju(string sadrzaj, int lokacija)
        {
            using(var fajl=new FileStream("Kursor.txt",FileMode.OpenOrCreate))
            using(var citac=new StreamReader(fajl))
            using(var pisac=new StreamWriter(fajl))
            {
                var TrenutniFajl=citac.ReadToEnd();//Procitamo citav fajl;
                var NoviFajl=TrenutniFajl.Insert(lokacija, sadrzaj);//Izvrsimo promjenu nad trenutnim fajlom i novi dobijeni spremimo u novi fajl;
                fajl.Position=0;//Resetujemo poziciju kursora jer pisemo ponovno u fajl;
                pisac.Write(NoviFajl);
            }
        }
    }
}
