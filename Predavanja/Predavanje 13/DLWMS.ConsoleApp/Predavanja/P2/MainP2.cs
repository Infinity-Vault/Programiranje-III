using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.ConsoleApp.Predavanja.P2
{
    internal class MainP2
    {        
        public static void Pokreni()
        {
            //VrijednostiReference();
            //Nizovi();
            //PodrazumijevaneVrijednosti();
            //ProvjeraNullVrijednosti();
            //SlanjeParametara();
            //Dekonstrukcija();
            //Params();
            Indekseri();
        }
        private static void Indekseri()
        {
            var profesor = new Profesor(){KarticaId = 654987,ImePrezime = "Denis Music",GodinaRodjenja = 2000};
            Console.WriteLine(profesor);
            profesor[0] = 3;
            Console.WriteLine(profesor);
        }
        private static void Params()
        {
            Console.WriteLine($"Suma -> {Sumiraj(2, 8, 9, 6, 5)}");
            Console.WriteLine($"Suma -> {Sumiraj(2, 8, 9, 6, 5, 9, 9)}");
            Console.WriteLine($"Suma -> {Sumiraj(new int[] { 2, 8, 9, 6, 5, 9, 8 })}");                 
        }
        private static int Sumiraj(params int [] niz)
        {
            int suma = 0;
            for (int i = 0; i < niz.Length; i++)
                suma += niz[i];
            return suma;
        }
        private static int Sumiraj2(params int[] niz){ return niz.Sum();  }
        private static int Sumiraj3(params int[] niz) => niz.Sum();
        private static void Dekonstrukcija()
        {
            //var a = 10;
            //var ime = "Denis";
            //var notValid = new object(); 
            var obj = new Profesor()
            {
                KarticaId = 654987,
                ImePrezime = "Denis Music",
                GodinaRodjenja = 2000
            };

            //int godina, kartica;
            //string imePrezime;
            //obj.Deconstruct(out imePrezime, out godina, out kartica);

            //(string imePrezime, int godina, int kartica) = obj;

            var (imePrezime, godina, kartica) = obj;

        }
        private static void SlanjeParametara()
        {
            Profesor profesor = new Profesor();
            InicijalizujProfesora(out profesor);
            Console.WriteLine(profesor.KarticaId);

            int rezultat;// = 123;
            if(int.TryParse("123", out rezultat))
                Console.WriteLine($"Rezultat -> {rezultat}");
        }
        private static void InicijalizujProfesora(out Profesor obj)
        {
            obj = new Profesor()
            {
                KarticaId = 654987,
                ImePrezime = "Denis Music",
                GodinaRodjenja = 2000
            };
            //obj.GodinaRodjenja = 2020;
        }
        private static void ProvjeraNullVrijednosti()
        {
            Profesor profesor = GetProfesorByKaricaId(132654);            
            Console.WriteLine(profesor?.ImePrezime);

            string ime = profesor?.ImePrezime ?? "NOT SET";

            //uslov ? ako_je_uslov_tacan : ako_uslov_nije_tacan
        }
        private static Profesor GetProfesorByKaricaId(int karticaId)
        {
            //return null;
            return new Profesor() { KarticaId = karticaId,  ImePrezime = "Denis Music", GodinaRodjenja = 2000 };
        }
        private static void PodrazumijevaneVrijednosti()
        {
            int a = new int();

            Profesor profesor = null;
            if (profesor == null)
                profesor = new Profesor();

            int ? karticaId = null;
            if(karticaId.HasValue)
                Console.WriteLine(karticaId);

            Nullable<int> cardId = null;
            if (cardId.HasValue)
                Console.WriteLine(cardId);
        }
        private static void Nizovi()
        {
            Profesor[] profesori = new Profesor[3];
            for (int i = 0; i < profesori.Length; i++)
            {
                profesori[i] = new Profesor();
                profesori[i].GodinaRodjenja = 1990 + i;
                profesori[i].ImePrezime = $"Ime_{i}";
            }
            Asistent[] asistenti = new Asistent[3];
            for (int i = 0; i < asistenti.Length; i++)
            {
                asistenti[i].GodinaRodjenja = 2000 + i;
                asistenti[i].ImePrezime = $"Ime_{i}";
            }
        }
        private static void VrijednostiReference()
        {
            int a = new int();
            int b = a;
            b = 20;

            Profesor profesor1 = new Profesor() { ImePrezime = "Denis Music", GodinaRodjenja = 2000 };
            Profesor profesor2 = profesor1;
            Console.WriteLine("PROFESOR");
            Console.WriteLine(profesor1);
            Console.WriteLine(profesor2);
            profesor2.ImePrezime = "Jasmin Azemovic";
            Console.WriteLine(profesor1);
            Console.WriteLine(profesor2);

            Asistent asistent1 = new Asistent() { ImePrezime = "Goran Skondric", GodinaRodjenja = 2006 };
            Asistent asistent2 = asistent1;
            Console.WriteLine("ASISTENT");
            Console.WriteLine(asistent1);
            Console.WriteLine(asistent2);
            asistent1.ImePrezime = "Adil Joldic";
            Console.WriteLine(asistent1);
            Console.WriteLine(asistent2);
        }
    }
}
