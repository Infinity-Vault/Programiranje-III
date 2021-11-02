using System;
using System.Drawing;
using System.Windows.Forms;
using Predavanje5.Classes;
using Predavanje5.DataBase;
using Predavanje5.Helpers;

namespace Predavanje_5__02._011._2021._
{
    public partial class frmRegistracija : Form
    {
        public frmRegistracija()
        {
            InitializeComponent();
        }

        //Metoda koja treba da doda novog korisnika u bazu podataka;
        private void btnRegistrujSe_Click(object sender, EventArgs e)
        {
            if(ValidirajUnos(txtBoxIme,txtBoxPrezime))//Ako su ispravni ime i prezime (korektnog formata);
            {
                //Kreiramo novog korisnika za dodati:
                var addNoviKorisnik = new Korisnik()
                {
                    Id = InternalMemoryDB.Korisnici.Count + 1, //Na ovaj nacin cemo inkrementovati id za jedan od broja vec postojecih korisnika (ako je korisnika u bazi 1--> 1+1=2 id novododanog je 2);
                    Ime = txtBoxIme.Text,//Preuzmemo ime;
                    Prezime = txtBoxPrezime.Text,//Preuzmemo prezime;
                    KorisnickoIme = txtBoxKorisnickoIme.Text,//Preuzmemo korisnicko ime;
                    Lozinka = txtBoxLozinka.Text,//Preuzmemo lozinku;
                    Aktivan = cbAktivan.Checked,//.Checked vrati true ili false;
                    Datumrodjenja = dtPickerDatumRodjenja.Value//.Value vrati vrijednost vremena;
                };
                InternalMemoryDB.Korisnici.Add(addNoviKorisnik);//Dodamo korisnika;
                MessageBox.Show($"{addNoviKorisnik} {Poruke.UspjesnoDodan}");//Obavjestenje da je korisnik dodan;
                this.Close();//Zatvorimo formu jer smo se uspjesno registrovali te se mozemo logirati;
            }
            else
                MessageBox.Show($"{Poruke.NeValidniPodaci}");//Slucaj da su ne validni ime i prezime;
            //Ovdje ne zatvaramo formu jer korisnik zeli popraviti svoje podatke;
        }
        //Metoda koja ce validirati oboje, i korisnicko ime i lozinku:
        private bool ValidirajUnos(Control ime,Control prezime)
        {
            return Validator.ValidirajKontrolu(ime, errorRegister, Poruke.ObaveznoPolje)
                   && Validator.ValidirajKontrolu(prezime, errorRegister, Poruke.ObaveznoPolje);
        }
        //Metoda koja ce da na promjenu teksta u polju ime i prezime generise korisnicko ime:
        private void GenerisiKorisnickoIme(object sender, EventArgs e)
        {
            //Generisanje vrsimo na nacin da samo spojimo inpute text box-ova te koristimo tolower metodu da sve mala
            //slova budu;
            //Note: oba inputa imaju pokazivac na ovu metodu kada im se okine event text input;
            txtBoxKorisnickoIme.Text = $"{txtBoxIme.Text}.{txtBoxPrezime.Text}".ToLower();
        }
        //Metoda koja ce da  oboji text box u crveno ako se podudare dva ista korisnicka imena;
        private void ProvjeriDuplikateKorisnickihImena(object sender, EventArgs e)
        {
            foreach (var korisnik in InternalMemoryDB.Korisnici)//Prodjemo kroz sve korisnike;
            {
               // if (korisnik.KorisnickoIme == txtBoxKorisnickoIme.Text)
               //     txtBoxKorisnickoIme.ForeColor = Color.Red;
               // else
               //     txtBoxKorisnickoIme.ForeColor = Color.Empty;//Dflt boja;

               //Kraci nacin:
               txtBoxKorisnickoIme.ForeColor =
                   (korisnik.KorisnickoIme == txtBoxKorisnickoIme.Text) ? Color.Red : Color.Empty;//Koristenje uslovnog operatora;
            }
        }
        //Metoda koja se izvrsi kada se forma pokrene:
        private void frmRegistracija_Load(object sender, EventArgs e)
        {
            cbAktivan.Checked=true;//Po defaultu novi korisnici su aktivni;
            txtBoxLozinka.Text = GenerisiPassword();//Generise im se lozinka;
        }
        //Metoda koja generise password:
        private string GenerisiPassword(int velicina=8)//Stavimo parametar koji  po dflt (ako se ne posalje nista) iznosi 8;
        {
            var password = "";//Prazni niz karaktera;
            var pattern = "djfjietfhegubsdjv83948329*#@&*!?<djiweq";//Niz karaktera za izvlacenje pojedinacnog karaktera;
            var rand = new Random();//Kreiramo objekat Rand klase;

            for (int i = 0; i < velicina; i++)//Vrtimo for onoliko koliko je zadano da lozinka bude duga, parametrom 'velicina';
            {
                var pozicijaKaraktera = rand.Next(0, pattern.Length);//Generisemo random integer u opsegu 0 do duzine niza pattern;
                password += pattern[pozicijaKaraktera];//Dodamo karakter na toj pociji u novi niz koristen za lozinku;
            }
            return password;//Vratimo novi niz karaktera (lozinku);
        }
    }
}
