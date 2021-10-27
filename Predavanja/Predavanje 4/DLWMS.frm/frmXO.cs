using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.frm
{
    public partial class frmXO : Form
    {
        //Kljucna rijec partial oznacava da se data klasa definise na vise razlicitih mjesta u datom namespace-u;
        //Vazno: Sve se radi o istoj klasi !;

        //Pravljenje propertija Brojac koji ce sluziti za pracenje redosljeda igranja:
        public int Brojac { get; set; } = 0;//Default je vec 0 svakako;

        //Pravljenje propertija za  igrace:
        public string Prvi { get; set; }
        public string Drugi { get; set; }

        //Kreiranje propertija za lokaciju pobjede:
        public string LokacijaPobjede { get; set; } = "";

        //Dflt ctor:
        public frmXO()
        {
            InitializeComponent();
        }

        //User def ctor:
        public frmXO(string prvi,string drugi):this()//Mozemo pozvati default ctor ovako;
        {
            //Da nismo pozvali dflt ctor morali bi smo uraditi poziv:
            //InitializeComponent();//kako bi se sve komponente loadale;

            Prvi=prvi;//Settujemo propertije;
            Drugi = drugi;
        }

        //Pravljenje metode koja ce Ispisivati ime trenutnog igraca:
        private void IspisiIgraca()
        {
            //Ako je brojac paran to je prvi igrac a ako je neparan to je drugi igrac;
            txtBoxTrenutni.Text=Brojac%2==0? Prvi:Drugi;
        }
        //Metoda koja se pozove na trigger loadanja forme xo:
        private void frmXO_Load(object sender, EventArgs e)
        {
            IspisiIgraca();//Kako bi se inicijalni (prvi) igrac ispisao;
        }

        
        //Dugme 01:
        private void btn01_Click(object sender, EventArgs e)
        {
            Odigraj(sender);
        }
        //Dugme 02:
        private void btn02_Click(object sender, EventArgs e)
        {
            Odigraj(sender);
        }
        //Dugme 03:
        private void btn03_Click(object sender, EventArgs e)
        {
            Odigraj(sender);
        }
        //Dugme 04:
        private void btn04_Click(object sender, EventArgs e)
        {
            Odigraj(sender);
        }
        //Dugme 05:
        private void btn05_Click(object sender, EventArgs e)
        {
            Odigraj(sender);
        }
        //Dugme 06:
        private void btn06_Click(object sender, EventArgs e)
        {
            Odigraj(sender);
        }
        //Dugme 07:
        private void btn07_Click(object sender, EventArgs e)
        {
            Odigraj(sender);
        }
        //Dugme 08:
        private void btn08_Click(object sender, EventArgs e)
        {
            Odigraj(sender);
        }
        //Dugme 09:
        private void btn09_Click(object sender, EventArgs e)
        {
            Odigraj(sender);
        }

        //Pravljenje metode odigraj:
        private void Odigraj(object sender)
        {
            var btn = sender as Button;//Ono sto dobijemo na trigger click gledamo kao objekat tipa Button;
            if (btn.Text == "")//Samo ako je prazno text polje moze se igrati na to polje;
            {
                if (Brojac % 2 == 0)//Ako je paran to je X;
                {
                    btn.Text = "X";//Postavi X;
                    Brojac++;//Uvecaj brojac;
                    IspisiIgraca();//Da bi znali koji je igrac;
                    if (ProvjeriPobjedu())//Ako je doslo do pobjede;
                    {
                        Dobitnik();
                        ResetujIgru(new Postavke(){Status=false,ResetColor=false,ResetText=false});
                        //Igru resetujemo na nacin da su sva polja sada disabled, boja se ne dira kao ni text;
                    }
                }
                else
                {
                    btn.Text = "O";//Postavimo O;
                    Brojac++;//Uvecamo brojac;
                    IspisiIgraca();//Da bi znali koji je igrac;
                    if (ProvjeriPobjedu())
                    {
                        Dobitnik();
                        ResetujIgru(new Postavke(){Status=false,ResetColor=false,ResetText=false});
                        //Igru resetujemo na nacin da su sva polja sada disabled, boja se ne dira kao ni text;
                    }
                }
            }
        }
        
        //Pravljenje metode ProvjeriPobjedu:
        private bool ProvjeriPobjedu()
        {
            //Provjeravamo na osnovu redova, kolona i dijagonale;
           return ProvjeriRedove() || ProvjeriKolone() || ProvjeriDijagonale();
        }

        //Generalna metoda provjera koja ce biti koristena za sve ostale provjere:
        private bool Provjera(Button prvi, Button drugi, Button treci)
        {
            //Prva provjera gdje odmah mozemo utvrditi ima li pobjednika jeste da li je
            //prvo polje,reda/kolone ili dijagonale neprazno;Onda ostala dva takodjer moraju biti jednaki prvom;
            if (prvi.Text != "" && prvi.Text == drugi.Text && prvi.Text == treci.Text)
            {
                prvi.BackColor = Color.Green;//Postavimo boje na zelenu;
                drugi.BackColor = Color.Green;
                treci.BackColor = Color.Green;
                Brojac = 0;//Reset brojaca;//Resetujemo brojac jer je igra sada gotova;
                return true;//Vratimo true;
            }
            return false;//Inace nema pobjede;
        }
        //Provjera po redovima:
        private bool ProvjeriRedove()
        {
            LokacijaPobjede = "Pobjeda se desila u redu!";//Spasimo lokaciju pobjede;
            return Provjera(btn01, btn02, btn03) || Provjera(btn04, btn05, btn06)
                                                 || Provjera(btn07, btn08, btn09);
        }
        //Provjera po kolonama:
        private bool ProvjeriKolone()
        {
            LokacijaPobjede = "Pobjeda se desila u koloni!";//Spasimo lokaciju pobjede;
            return Provjera(btn01, btn04, btn07) || Provjera(btn02, btn05, btn08)
                                                 || Provjera(btn03, btn06, btn09);
        }
        //Provjera po dijagonalama:
        private bool ProvjeriDijagonale()
        {
            LokacijaPobjede = "Pobjeda se desila na dijagonali!";//Spasimo lokaciju pobjede;
            return Provjera(btn01, btn05, btn09) || Provjera(btn07, btn05, btn03);
        }


        //Provjera koji je user dobio:
        private void Dobitnik()
        {
            var brojacX = 0;//Brojac za X;
            var brojacO = 0;//Brojac za O;

            for (int i = 0; i < Controls.Count; i++)//Prodjemo kroz sve kontrole u formi;
            {
                if (Controls[i].Text == "X")//Ispitamo da li je text te kontrole X
                    brojacX++;//Uvecamo odgovarajuci brojac;
                else if(Controls[i].Text == "O")//ili O;
                    brojacO++;//Uvecamo odgovarajuci brojac;
            }

            if (brojacX > brojacO)//Ako je X-eva vise
                txtBoxPobjednik.Text= Prvi;//Pobjedio je X;
            else
                txtBoxPobjednik.Text= Drugi;//Inace pobjedio je O;

            txtBoxLokacijaPobjede.Text = LokacijaPobjede;//Ispis gdje se pobjeda desila;
        }

        //Metoda koja resetuje igricu:
        private void ResetujIgru(Postavke postavke)//Primimo objekat postavke jer je modularan;
        {
             foreach (var kontrola in Controls)//Za svaku kontrolu na nasoj xo formi;
             {
                 if (kontrola is Button)//Ako je kontrola dugmic;
                 {
                     if (kontrola != btnReset)//ako taj trenutni dugmic nije dugmic za reset(jer njega ne zelimo disable);
                     {
                         var btn = kontrola as Button;//Kontrolu posmatramo kao dugmic;
                         btn.Enabled = postavke.Status;//Postane disabled ako je kraj ili enabled ako je start ponovni;
                         //if (postavke.ResetText)//Ako je kraj resetuje se, ako nije ostane na trenutnoj vrijednosti;
                         //    btn.Text = "";
                         //Moze se zapisati i sa:
                         btn.Text = postavke.ResetText ? "" : btn.Text;

                         if(postavke.ResetColor)//Ako je kraj ne diraju se boje ako je ponovni pocetak postave se na dflt boju;
                             btn.UseVisualStyleBackColor=true;
                     }
                 }
             }
             IspisiIgraca();
        }
        //Funkcija za poziv reseta igre:
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetujIgru(new Postavke(){Status=true,ResetColor=true,ResetText=true});
            //Resetujemo igru na trigger click buttona Reset, na nacin da su polja omogucena, boja i tekst resetovani; 
            txtBoxPobjednik.Text = "";//Pobrisemo starog pobjednika;
        }

    }

    //Neka klasa Postavke koja ce se koristiti kao parametar koji je modularan,
    //moze se koristiti u razlicite svrhe.
    //Npr kada se igra zavrsi zelimo da se disejblaju svi btn's ali ne zelimo da ih brisemo tj njihovu vrijednost
    //ili mjenjamo njihovu boju, dok kada pokrenemo novu igru to onda zelimo;
    internal class Postavke
    {
        public bool Status { get; set; }
        public bool ResetText { get; set; }
        public bool ResetColor { get; set; }
    }

}
