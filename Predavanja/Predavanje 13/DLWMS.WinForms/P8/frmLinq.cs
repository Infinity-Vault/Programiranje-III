using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.P8
{
    public partial class frmLinq : Form
    {
        public frmLinq()
        {
            InitializeComponent();
        }

        private void frmLinq_Load(object sender, EventArgs e)
        {
            //TipoviPodataka();
            //AnonimniTipovi();
            //ExMetode();
            Linq();
        }
        private bool FiltrirajOcjene1(int ocjena)//6
        {
            return ocjena > 7;
        }

        private bool FiltrirajOcjene2(int ocjena) => ocjena > 7;
        

        private void Linq()
        {
            var ocjene = new List<int>() { 6, 6, 7, 8, 9, 7 };
            var rezultat1 = ocjene.Where(FiltrirajOcjene1);
            var rezultat2 = ocjene.Where(FiltrirajOcjene2);           
            var rezultat3 = ocjene.Where (o => o > 7);

            Func<int, bool> func = o => o > 7;
            var rezultat4 = ocjene.Where(func);

            txtIspis.Text = string.Join(", ", rezultat4.ToList());


            /*
             SELECT *  
             FROM Customers
             WHERE Country ='Germany'
             */

            //var ocjene = new List<int>() { 6, 6, 7, 8, 9, 7 };
            //var rezultat = 
            //    from o in ocjene
            //    where o > 7
            //    select o;

            //var studenti = new List<Student>() {
            //    new Student(){Indeks = 150051},
            //    new Student(){Indeks = 160061},
            //    new Student(){Indeks = 170061},
            //};

            //var rezultat1 =
            //   from student in studenti
            //   where student.Indeks > 160000
            //   select new { 
            //       Ime = student.ImePrezime, 
            //       Prosjek = student.Ocjene.Sum()/ student.Ocjene.Count
            //   };

        }


        private void ExMetode()
        {
            var ime = "Denis Music";
            txtIspis.Text += ime.Enkripcija() + Environment.NewLine;
            txtIspis.Text += DateTime.Now.ToBIHFormat()  + Environment.NewLine;

        }

        private void AnonimniTipovi()
        {

            var obj = new { Ime = "Denis", GodinaStudija = 1 };

            var tuple = (indeks:150051,ime:"Denis Music",prosjek:6.8);
            tuple.ime = "Jasmin Azemovic";
            Tuplovi(new dtoStudent() { Indeks = 150051, Semestar = 1});

        }
        private dtoStudent Tuplovi (dtoStudent obj)
        {
            return obj;
        }

        private void TipoviPodataka()
        {
            object broj = 10;
            object ime = "Denis";
            object ocjene = new List<int>() { 6, 6, 7, 8, 9, 7 };

            var broj1 = 10;
            var ime1 = "Denis";            
            var ocjene1 = new List<int>() { 6, 6, 7, 8, 9, 7 };
            //Kolekcija<int, Student>
            Dictionary<string, string> fitImenik = new Dictionary<string, string>();
            fitImenik.Add("036281166", "Denis");
            fitImenik.Add("036281170", "Haris");

            var imenikIzuzetaka = new Dictionary<ExtenderProvidedPropertyAttribute, ArgumentOutOfRangeException>();

            dynamic obj;
            obj = 10;
            obj = "deset";
            obj = new Dictionary<ExtenderProvidedPropertyAttribute, ArgumentOutOfRangeException>();


            dynamic exObj = new ExpandoObject();            
            exObj.Ime = "Denis";
            exObj.Indeks = "IB150051";
            exObj.Ocjene = new List<int>();

            txtIspis.Text += exObj.Ime + Environment.NewLine;

            foreach (var property in exObj)
            {
                txtIspis.Text += property + Environment.NewLine;
            }
            
            foreach (var property in (IDictionary<string, object>)exObj)
            {
                txtIspis.Text += $"{property.Key} -> {property.Value}{ Environment.NewLine}";
            }

            //Metoda(broj);
            //Metoda(ocjene);

        }
        private void Metoda(dynamic obj)
        {
            obj.Prikazi();
        }
    }

    public static class MojeMetode
    {
        public static string Enkripcija(this string sadrzaj)
        {
            var povratna = string.Empty;
            var znakovi = "abcdefgijklmnoprstuvz0123456789 ";
            var obrnuti = " 9876543210zvutsrponmlkjigfedcba";
            //var obrnuti = znakovi.Reverse();
            foreach (var znak in sadrzaj.ToLower())//denis
            {
                int indeks = znakovi.IndexOf(znak);//4
                povratna += obrnuti[indeks];//76v3r
            }
            return povratna;
        }

        public static string ToBIHFormat(this DateTime dateTime)
        {
            return dateTime.ToString("dd/MM/yyyy hh:MM:ss");
        }

    }

    public class dtoStudent
    {
        public int Indeks { get; set; }
        public string ImePrezime { get; set; }
        public double Prosjek { get; set; }
        public int Semestar { get; set; }
    }
}
