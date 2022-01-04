using DLWMS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.ConsoleApp.Predavanja
{
    internal class MainP1//P1
    {
        public static void Pokreni()
        {
            //TipoviPodataka();
            //Pokazivaci();
            //Klase();
            ValueIReference();
        }
        private static void ValueIReference()
        {
            int a = 10;
            int b = a;
            a = 2000;

            Student denis = new Student(200002, "Denis", "Music");
            Student student = denis;
            student.Ime = "Student";

            Console.WriteLine(denis);
            Console.WriteLine(denis.ToString());

            object objA = a;
            object objDenis = denis;

            Ispisi(objA);
            Ispisi(objDenis);
            Ispisi(denis);
        }
        private static void Ispisi(object obj)
        {
            throw new NotImplementedException();
        }
        private static void Klase()
        {
            Student denis = new Student(200002,"Denis","Music");
            Console.WriteLine(denis.GetIndeks());
            denis.SetIndeks(210012);
            Console.WriteLine(denis.GetIndeks());
            denis.Ime = "DENIS";
            Console.WriteLine(denis.Ime);

            Student jasmin = new Student( indeks: 200003, prezime: "Azemovic", ime: "Jasmin");            
        }
        private static void Pokazivaci()
        {
            int indeks = 210021;
            unsafe
            {
                int* pok = &indeks;
                *pok = 210022;
            }
        }
        private static void TipoviPodataka()
        {
            int indeks = 210021;
            string ime = "Denis";
            bool aktivan = true;
            double prosjek = 6.8;

            if(aktivan)
                Console.WriteLine($"{ime} je aktivan sa prosjekom {prosjek}");            
        }
    }
}
