using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predavanje_1_Denis__05._10._2021.Data
{
    public class Student
    {
        private int _indeks;
        private string _ime;
        private string _prezime;
        private int _godinaStudija;
        private double _prosjekNaGodini;
        //Pravljenje property:

        //Property kod kojeg sami definisemo get i set mora imati atribut u klasi; (_prosjekNaGodini)
        public double ProsjekNaGodini
        {
           // get
           // {
           //     return _prosjekNaGodini;//Kod get vracamo vrijednost atributa;
           // }
           // set
           // {
           //     _prosjekNaGodini = value;//Kod set postavljamo na vrijednost koja se nadje na desnoj strani (to je kljucna rijec value);
           // }
           //Modernija sintaksa jeste da se koristi expression body:
           
           get =>  _prosjekNaGodini;
           set => _prosjekNaGodini = value;
        }
        //Property kod kojeg ostavimo default get set ne mora imati atribut u klasi:
        public int Semestar{ get; set; }
        //Kljucne rijeci get i set odrade sve sto bi i manuelno mi napisali;


        //Dflt ctor;
        public Student()
        {
            _indeks = 200000;
            _ime = "Not_Set";
            _prezime = "Not_Set";
            _godinaStudija = 0;
            _prosjekNaGodini = 0.0f;
            Semestar = 0;
        }

        //User-def ctor;
        public Student( int indeks, string ime, string prezime, int godinaStudija,double prosjekNaGodini,int semestar)
        {
            _indeks = indeks;
            _ime = ime;
            _prezime = prezime;
            _godinaStudija = godinaStudija;
            _prosjekNaGodini = prosjekNaGodini;
            Semestar=semestar;
        }

        //Dtor;
        ~Student()
        {

        }

        //Getteri:
        public int GetIndeks()
        {
            return _indeks;

        }

        public int GetGodinaStudija()
        {
            return _godinaStudija;

        }

         public string GetIme()
         {
             return _ime;
         }

         public string GetPrezime()
         {
             return _prezime;
         }
         //Setteri:
         public void SetIndeks(int value)
         {
            _indeks = value;
         }
         public void SetGodinaStudija(int value)
         {
             _godinaStudija = value;
         }

         public void SetIme(string value)
         {
             _ime = value;
         }
         public void SetPrezime(string value)
         {
             _prezime = value;
         }
        //Override metode ToString():
        public override string ToString()
        {
            //return base.ToString();// base predstavlja default baznu klasu svim klasama (objektima) .NET Framework-a;
            //string povratnaPoruka=($"Ime i prezime: {_ime}  {_prezime} " +
            //                       $"Broj indeksa: {_indeks}  " +
            //                       $"Semestar: {Semestar}  " +
            //                       $"Prosjek na godini: {ProsjekNaGodini}  ");
            //return povratnaPoruka;

            //Ili:

            return $"Ime i prezime: {_ime}  {_prezime}" +
                   $" Broj indeksa: {_indeks}  " +
                   $"Semestar: {Semestar} " +
                   $"Prosjek na godini: {ProsjekNaGodini}";
        }            
    }                
}                    
