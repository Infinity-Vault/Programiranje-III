using System.IO;

namespace Vjezbe11.CSVFajl
{
    public static class CSVFajl
    {
        //CSV fajl je skracenica od comma separated values tipa fajla;Cesto je to Excel file;

        //Metoda koja kreira .csv fajl i pise u njega:
        public static void PisiUFajl(string sadrzaj)
        {
            StreamWriter pisac= File.AppendText("CSVFajl.csv");//Kreiramo StreamWriter objekat ako on vec ne postoji, a ako postoji samo se otvori;

            for (int i = 0; i < 100; i++)
                pisac.WriteLine(sadrzaj);
            pisac.Close();//Zatvorimo fajl jer nismo koristili using statement;UVIJEK SE ZATVARA FAJL NAKON KORISTENJA;
        }
        //Metoda koja pise u fajl ali pri tome kreira vise kolona:
        public static void PisiUFajlSaViseKolona(string putanja)
        {
            using(var pisac = File.AppendText(putanja))//Kreiramo StreamWriter objekat ako on vec ne postoji, a ako postoji samo se otvori;
            {
                pisac.WriteLine("Haris,Haris+i,Haris*i");//Napravimo tri kolone odvojene zarezima;
                for (int i = 0; i < 100; i++)
                    pisac.WriteLine($"Haris,Haris+{i},Haris*{i}");
            }//Ovdje oslobodimo  resurs (fajl) koji smo koristili tj. CSVFajlViseKolona.csv;
        }

        //Metoda koja cita fajl:
        public static string CitajIzCsvFajla(string putanja)
        {
            using(var citac=new StreamReader(putanja))
            {
                return citac.ReadToEnd();//Procitamo do kraja fajl;
            }
        }
    }
}
