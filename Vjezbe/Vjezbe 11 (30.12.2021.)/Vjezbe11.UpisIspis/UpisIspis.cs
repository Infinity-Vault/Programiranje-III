using System.IO;

namespace Vjezbe11.UpisIspis
{
    public static class UpisIspis//Klasa moze biti static jer svakako nemamo njenih instanci;
    {
        //Ova klasa predstavlja jednostavni upis u fajl i ispis iz fajla;

        //Metoda koja pise u fajl;
        public static void PisiUFajl(string sadrzaj)
        {
            using(var fajl=new FileStream("UpisIspis.txt",FileMode.OpenOrCreate))//Kreiramo novi tekstualni fajl, svaki put kada se pozove ova metoda, ukoliko ne postoji fajl kreirati ce se novi, a ukoliko postoji otvoriti ce se taj postojeci;
            using(var pisac=new StreamWriter(fajl))//Nestujemo (ugnjezdimo) using u using statement;
            {
                pisac.WriteLine(sadrzaj);//Vise puta upisemo u fajl;
                pisac.WriteLine(sadrzaj);
                pisac.WriteLine(sadrzaj);
                pisac.WriteLine(sadrzaj);
                pisac.WriteLine(sadrzaj);
                pisac.WriteLine(sadrzaj);
            }//Ovdje se otpuste svi resursi (tipa fajl) koji su se koristili unutar using statementa;
        }
        public  static string IspisiIzFajla(string putanja)
        {
            using(var fajl=new FileStream(putanja,FileMode.OpenOrCreate))
            using(var ispis=new StreamReader(fajl))
            {
                return ispis.ReadToEnd();//Vrati kompletan sadrzaj fajla, od pocetka do kraja;
            }
        }
    }
}
