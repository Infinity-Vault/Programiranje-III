using System;
using Vjezbe11.CSVFajl;
using Vjezbe11.KeyValue;
using Vjezbe11.ManipulacijeKursorom;
using Vjezbe11.Student;
using Vjezbe11.UpisIspis;

namespace Vjezbe_11__30._12._2021._
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Primjer za obicni upis i ispis iz txt fajla:");
            UpisIspis.PisiUFajl("Ovo je neka poruka");//Posaljemo sadrzaj;
            Console.WriteLine(UpisIspis.IspisiIzFajla("UpisIspis.txt"));//Posaljemo putanju do fajla;
            Console.WriteLine("----------------------------------------------");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Primjer za key value parove:");
            KeyValue.PisiUFajl(new Student() { Indeks=200121,Ime="Amar Alic"});//Pisemo u fajl;
            Console.WriteLine(KeyValue.CitajIzFajla("Studenti.txt"));//Citamo iz fajla;
            var rez=KeyValue.KreirajStudenteIzFajla("Studenti.txt");//Napravimo listu studenata iz ulaznog fajla;
            foreach (var student in rez)
            {
                Console.WriteLine(student);//Ispisemo studente;
            }
            Console.WriteLine("----------------------------------------------");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Pisanje i citanje u i iz CSV fajla:");
            CSVFajl.PisiUFajl("Ovo je neki sadrzaj za csv fajl");//Pisemo u csv fajl;
            Console.WriteLine( CSVFajl.CitajIzCsvFajla("CSVFajl.csv"));//Procitamo fajl;
            CSVFajl.PisiUFajlSaViseKolona("CSVFajlViseKolona.csv");//Pisemo u vise kolona;
            Console.WriteLine(CSVFajl.CitajIzCsvFajla("CSVFajlViseKolona.csv"));//Procitamo fajl;
            Console.WriteLine("----------------------------------------------");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine("Pisanje na odredjenu lokaciju ili odredjenu liniju u fajlu:");
            ManipulacijeKursorom.PisiNaLiniju("Ovo je neki sadrzaj", 0);
            ManipulacijeKursorom.PisiNaLokaciju("UBACENO",11);
            Console.WriteLine("----------------------------------------------");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            Console.ReadLine();
        }
    }
}
