using System;
using System.Windows.Forms;
using Predavanje5.Helpers;
using Predavanje5.DataBase;


namespace Predavanje_5__02._011._2021._
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        //Metoda za logiranje:
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Preuzmemo vrijednosti u lokalne varijable:
            var korisnickoIme = txtBoxKorisnickoIme.Text;
            var lozinka=txtBoxLozinka.Text;

            if (ValidirajUnos(txtBoxKorisnickoIme, txtBoxLozinka))
            {
                foreach (var korisnik in InternalMemoryDB.Korisnici)//Za svakog korisnika u nasoj bazi korisnika
                {
                    if (korisnik.KorisnickoIme == korisnickoIme && korisnik.Lozinka == lozinka)//provjeri da li postoji sa ovim credentials;
                    {
                        if (korisnik.Aktivan) //Korisnik postoji i aktivan je;//Ako je aktivan
                        {
                            MessageBox.Show($"{Poruke.DobroDosli} {korisnik}");//Ispisi poruku dobrodoslice;
                            return;//Odmah mozemo zavrsiti;
                        }
                        else //Korisnik nije aktivan;
                        {
                            MessageBox.Show($"{Poruke.NeAktivanKorisnik}");//Obavijesti da nije aktivan;
                            return;//Takodjer mozemo odmah zavrsiti;
                        }
                    }
                }
                //Ako se prodje kroz citavu bazu i nije nadjen korisnik sa tim credentials,korisnik ne postoji:
                MessageBox.Show($"{Poruke.NePostojeciKorisnik}");//Obavijesti da korisnik ne postoji;
            }
        }
        //Metoda koja ce validirati oboje, i korisnicko ime i lozinku:
        private bool ValidirajUnos(Control korisnickoIme,Control lozinka)
        {
            return Validator.ValidirajKontrolu(korisnickoIme, errorLogin, Poruke.ObaveznoPolje)
                   && Validator.ValidirajKontrolu(lozinka, errorLogin, Poruke.ObaveznoPolje);
        }
        //Metoda koja pokrece kreiranje tj registrovanje novog korisnika;
        private void llblRegistracija_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //llbl--> linkedLabel;
            //Kreiranje nove forme:
            var registracija = new frmRegistracija();
            registracija.ShowDialog();//Pokrenemo kao dijaloski okvir kako korisnik ne bi mogao raditi druge radnje dok je otvoren ovaj prozor;
        }
    }
}
