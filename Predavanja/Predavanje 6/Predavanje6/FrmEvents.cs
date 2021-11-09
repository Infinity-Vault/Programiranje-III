using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Predavanje6
{
    public partial class FrmEvents : Form
    {
        public FrmEvents()
        {
            InitializeComponent();
        }


        //Primjer  kreiranja pokazivaca na metodu:

        //Kljucnom rjecju delegate oznacimo da ce potpis iza predstavljati pokazivac na metodu(e);
        //Sintaksa: delegate povratniTip  imePokazivaca  (ulazniParametri);

        private delegate void Notifikacija(string msg);//Kreirali smo "pokazivac" na bilo koju metodu koja postuje njegov potpis, znaci da je void i da prima string;
        //Ovo je slicno kao i pokazivaci na funkcije u C++;

        //Primjer kreiranja dogadjaja u koji ce se spremati svi nasi pokazivaci na metode;

        //Sintaksa: event tipPokazivaca imeDogadjaja;
        //Kljucna rijec event oznacava da ce to biti "niz" u koji ce se spremati svi pokazivaci na metode;

        private event Notifikacija NovaNotifikacija;//Kreiran niz u kojem cemo spremiti sve pokazivace na metode;Pokazivaci moraju biti Notifikacija jer event "niz" sprema takve vrste pokazivaca;


        //Metoda koja ce simulirati slanje nekih notifikacija:
        private void btnSendNotification_Click(object sender, EventArgs e)
        {
            NovaNotifikacija?.Invoke(txtBoxPrikaz.Text);//Iz niza ovog eventa dobicemo sve metode kojima je proslijedjen text iz naseg text boxa sa forme;Takodjer to moze biti nesto sto je hard kodirano tipa neka poruka;
            //Postoji mogucnost da nijedan checkBox nije oznacen, te samim time niz naseg eventa ce biti prazan,
            //a mi mu pokusavamo pristupiti i dolazi do null reference exceptiona;
            //Ovo se izbjegne na nacin da se prije poziva Invoke metode (koja se uvijek za svaki poziv bilo koje metoda implicitno pozove) 
            //stavimo operator provjere da li je objekat sa lijeva null (znak ?);
        }

        //Metode za razlicite godine fakulteta:
        private void PrvaGodina(string obavijest)
        {
            MessageBox.Show($"Na prvoj godini fakulteta {obavijest}");//Ispis poruke;
        }
        private void DrugaGodina(string obavijest)
        {
            MessageBox.Show($"Na drugoj godini fakulteta {obavijest}");
        }
        private void TrecaGodina(string obavijest)
        {
            MessageBox.Show($"Na trecoj godini fakulteta {obavijest}");
        }
        private void CetvrtaGodina(string obavijest)
        {
            MessageBox.Show($"Na cetvrtoj godini fakulteta {obavijest}");
        }

        //Generalna metoda za provjeru checkBoxova:
        private void ProvjeraKomeSeSaljeNotifikacija(CheckBox checkBox, Notifikacija notifikacija)
        {
            //Prvi parametar znamo da ce biti checkBox dok drugi je ustvari nas delegate (pokazivac) na metodu(e);

            if (checkBox.Checked)
                NovaNotifikacija += notifikacija;//Ako je oznacena kucica dodaj u niz pokazivac na metodu;
            else
                NovaNotifikacija -= notifikacija;//Ako nije oznacena kucica ukloni iz niza pokazivac na metodu;
        }
        //Gornju metodu mozemo koristiti za sva cetiri klika na checkBox:
        private void cbPrvaGodina_CheckedChanged(object sender, EventArgs e)
        {
            ProvjeraKomeSeSaljeNotifikacija(cbPrvaGodina, PrvaGodina);//Posaljemo checkBox prve godine i pok na metodu;
        }
        private void cbDrugaGodina_CheckedChanged(object sender, EventArgs e)
        {
            ProvjeraKomeSeSaljeNotifikacija(sender as CheckBox, DrugaGodina);//Mozemo i ovako poslati trenutno kliknuti checkBox;
        }
        private void cbTrecaGodina_CheckedChanged(object sender, EventArgs e)
        {
            ProvjeraKomeSeSaljeNotifikacija(sender as CheckBox, TrecaGodina);
        }
        private void cbCetvrtaGodina_CheckedChanged(object sender, EventArgs e)
        {
            ProvjeraKomeSeSaljeNotifikacija(sender as CheckBox, CetvrtaGodina);
        }
      //------------------------------------------------------------------------------------------------------//


      //Drugi primjer:
      private delegate int Operacija(int vrijednost);//Pokazivac na metodu koja vraca int i prima int;

      //Kreiranje dvije operacije na koje ce se moci pokazati gornjim delegatom:
      private int  Kvadriraj(int vrijednost) => vrijednost * vrijednost;//Expression oblik;//Isti potpis kao delegat;
      private int Kubiraj(int vrijednost)//Isti potpis kao delegat;
      {
          return vrijednost * vrijednost * vrijednost;
      }

      private void Calculator(Operacija operacija, params int[] operandi)//Primimo delegat i params int;
      {
          var result = 0;

          for (int i = 0; i < operandi.Length; i++)
          {
              result += operacija(operandi[i]);//Sacuvamo (dodajemo jedno na drugo) ono sto pokazivac na odredjenu metodu vrati;
          }
          txtBoxPrikaz.Text += result.ToString();//Prikazemo u nasem text box;
          txtBoxPrikaz.Text += Environment.NewLine;//Dodamo novu liniju;
      }


        //Metoda koja ce samo kalkulator na ucitavanju pozvati:
        private void FrmEvents_Load(object sender, EventArgs e)
        {
            Calculator(Kvadriraj, 2, 3, 5, 6);//Pomocu params mozemo posalti jedan int ili n njih;
            Calculator(Kubiraj, 3, 4, 6);
            //Primjer za Func:
            //Prvi argument je sta se prima a drugi sta se vraca metodom;
            Func<int, int> OperacijaZaFunc = Kvadriraj; //Kreirali smo pok na metodu koja prima int i vraca int;//Pokazuje na metodu Kvadriraj;
            Calculator2(OperacijaZaFunc, 2, 3, 5, 6);
            OperacijaZaFunc = Kubiraj;//Preusmjerimo na metodu kubiraj;
            Calculator2(OperacijaZaFunc, 3, 4, 6);

            //Saljemo samo ulazni tip argumenta, povratni je uvijek void;
            Action<string> NekaPoruka=NekaMetodaIspisa;//Kreiramo pokazivac na metodu koja prima string i void je povratnog tipa;
            NekaPoruka("Ovo je Action tip delegata koji je uvijek void povratnog tipa.");

            //Yield:
            YieldDemo();
        }

        //------------------------------------------------------------------------------------------------------//
        //Treci primjer:
        private event EventHandler Event;//Event se moze kreirati i ovako jer je EventHandler bazni event svima  te ce moci u svoj "niz" staviti bilo koji pok na metodu koja je void i ima parametre object i EventArgs; 
        private void NekaFunckija(object sender, EventArgs e)
        {
            Event?.Invoke(sender, e);
        }
        
        //Delegate mozemo kreirati i pomocu generickih klasa Func i Action;
        //Razlika je sto Func ne moze imati povratni tip void dok Action po defaultu prima povratni tip void i to je ujedno jedini povratni tip koji moze imati;

        //Primjer za Func:
        private void Calculator2(Func<int,int> operacija, params int[] operandi)
        {
            var result = 0;

            for (int i = 0; i < operandi.Length; i++)
            {
                result += operacija(operandi[i]);//Sacuvamo (dodajemo jedno na drugo) ono sto pokazivac na odredjenu metodu vrati;
            }
            txtBoxPrikaz.Text += result.ToString();//Prikazemo u nasem text box;
            txtBoxPrikaz.Text += Environment.NewLine;//Dodamo novu liniju;
        }

        //Primjer za Action:
        private void NekaMetodaIspisa(string poruka)
        {
            MessageBox.Show(poruka);
        }

        //Metoda koja se pokrene kada se forma zatvori:
        private void FrmEvents_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show($"Razlog zatvaranja forme je {e.CloseReason}");
        }
        //Metoda koja se pokrene kada se forma krene zatvarati:
        private void FrmEvents_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Niste jos unijeli sve podatke te forma ne moze da se zatvori!");
            e.Cancel = false;//bool vrijednost, false nece se dati da se zatvori, true dati ce da se zatvori;
        }


        //Kreiranje klase Student:

        internal class Student
        {
            //Kreiramo niz ocjena Studenta:
            public List<int> Ocjene { get; set;} = new List<int>(){6,6,7,7,8,9,10,10,5};//Odmah ih inicijalizujemo;

            public IEnumerator<int> GetEnumerator()//Svejedno je ili <int> ili samo IEnumerator jer je primitivni tip;
            {
                for (int i = 0; i < Ocjene.Count; i++)
                {
                    yield return Ocjene[i];//Kljucna rijec yield omogucava da se svakom novom iteracijom pamti prijasnja vrijednost brojaca iako se metoda iznova i iznova poziva;
                }
            }

            public string SortirajOcjene()
            {
                string prolazneOcjene="";//Pocetni prazni string;

                bool Sort(int ocjena)//Metoda koja sortira ocjene;
                {
                    if(ocjena>=6)//ako je prolazna vrati true ako nije vrati false;
                        return true;
                    return false;
                }
                var prolazne=Ocjene.Where(Sort);//Spremimo niz prolaznih ocj u  novu varijablu;
                foreach (var ocjena in prolazne)
                {
                    prolazneOcjene += $"{ocjena},";//Svaku ocjenu spremimo u string;
                }
                return prolazneOcjene;//Vratimo string;
            }
        }

        //Metoda koja ce demonstrirati svrhu yield:
        private void YieldDemo()
        {
            var student = new Student();//Kreiramo nekog default studenta;
            foreach (var ocjena in student)//Iteriramo kroz sve studente,medjutim implementirali smo GetEnumerator metodu IEnumerator interfejsa koja ce nam omoguciti da student moze biti numerisan na nacin da  ta metoda vrati sve ocjene tog studenta;U suprotnom ne mozemo foreach imati na student; GetEnumerator mora biti public kako bi se moglo pristupiti u foreach;
                txtBoxPrikaz.Text += $"{ocjena},";//Ispisemo ocjenu;
            txtBoxPrikaz.Text += Environment.NewLine;//Novi red;
            txtBoxPrikaz.Text += $"Prolazne ocjene su:{Environment.NewLine}";
            txtBoxPrikaz.Text+=$"{student.SortirajOcjene()}{Environment.NewLine}";//Ispisemo prolazne ocjene;
        }
    }
}
