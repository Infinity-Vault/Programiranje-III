using System.Collections.Generic;
using System.IO;

namespace Vjezbe11.KeyValue
{
    public static class KeyValue
    {
        //Metoda za pisanje u fajl;
        public static void PisiUFajl(Student.Student student)//Proslijedimo studenta kojeg zelimo zapisati u fajl;
        {
            using(var fajl=new FileStream("Studenti.txt",FileMode.OpenOrCreate))
            using(var pisac=new StreamWriter(fajl))
            {
                pisac.WriteLine($"Id={student.Indeks}");//Upisemo info u fajl;
                pisac.WriteLine($"Ime={student.Ime}");
                //Stavljamo = kako bi poslije kod kreiranja studenata iz fajla mogli znati gdje da prepolovimo red texta;
            }
        }

        //Metoda za citanje iz fajla:
        public static string CitajIzFajla(string putanja)
        {
            using(var fajl=new FileStream(putanja,FileMode.OpenOrCreate))
            using(var citac=new StreamReader(fajl))
            {
                return citac.ReadToEnd();//Ispisem sve iz fajla;
            }
        }

        //Metoda koja vrati listu studenata formiranih na osnovu indeksa i imena upisanih u fajl:
        public static List<Student.Student> KreirajStudenteIzFajla(string putanja)
        {
            var studenti=new List<Student.Student>();//Kreiramo listu studenata;
            using(var fajl=new FileStream(putanja,FileMode.OpenOrCreate))
            using(var citac=new StreamReader(fajl))
            {
                while (citac.Peek() != -1)//Vrati -1 ako je kursor dosao do kraja fajla;
                {
                    var linija=citac.ReadLine();//Uzmemo liniju texta iz fajla;

                    var pozicijaIndeksa=linija.Split('=');//Prepolovimo liniju kada naidjemo na znak '=';

                    linija=citac.ReadLine();//Uzmemo liniju texta iz fajla;

                    var pozicijaImena=linija.Split('=');//Prepolovimo liniju kada naidjemo na znak '=';

                    //Kreiramo studenta i dodamo ga;
                    studenti.Add(new Student.Student() { Indeks=int.Parse(pozicijaIndeksa[1]),Ime=pozicijaImena[1]});//Uzmemo indeks 1 jer nama treba drugi element niza tj. vrijednost Indeks i Ime;
                }
            }
            return studenti;
        }
    }  
}
