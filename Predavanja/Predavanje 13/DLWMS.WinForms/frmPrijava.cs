using DLWMS.WinForms.DB;
using DLWMS.WinForms.P5;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms
{
    public partial class frmPrijava : Form
    {
        public frmPrijava()
        {
            InitializeComponent();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            var korisnickoIme = txtKorisnickoIme.Text;
            var lozinka = txtLozinka.Text;

            if (ValidirajUnos())
            {
                if (!string.IsNullOrWhiteSpace(korisnickoIme) && !string.IsNullOrWhiteSpace(lozinka))
                {

                    foreach (var korisnik in InMemoryDB.Korisnici)
                    {
                        if (korisnickoIme == korisnik.KorisnickoIme && lozinka == korisnik.Lozinka)
                        {
                            if (korisnik.Aktivan) { 
                                MessageBox.Show($"{Poruke.DobroDosli} {korisnik}");
                                DLWMSApp.PrijavljeniKorisnik = korisnik;
                            }
                            else
                                MessageBox.Show($"{korisnik} {Poruke.NalogNijeAktivan}");
                            return;
                        }
                    }
                    //for (int i = 0; i < InMemoryDB.Korisnici.Count; i++)
                    //{
                    //    var korisnik = InMemoryDB.Korisnici[i];
                    //    if (korisnickoIme == korisnik.KorisnickoIme && lozinka == korisnik.Lozinka)
                    //    {
                    //        if (korisnik.Aktivan)
                    //            MessageBox.Show($"{Poruke.DobroDosli} {korisnik}");
                    //        else
                    //            MessageBox.Show($"{korisnik} {Poruke.NalogNijeAktivan}");
                    //        return;
                    //    }
                    //}
                    MessageBox.Show($"{Poruke.KorisnickiNalogNePostoji}");
                }
            }
        }

        private bool ValidirajUnos()
        {
            return Validator.ValidirajKontrolu(txtKorisnickoIme, err, Poruke.ObaveznaVrijednost)
                && Validator.ValidirajKontrolu(txtLozinka,err, Poruke.ObaveznaVrijednost);            
        }

    

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var registracija = new frmRegistracija();
            registracija.Show();
        }
    }



    public class Poruke 
    {
        public const string NedozvoljenaOperacija = "Nedozvoljena operacija...";
        public const string PodaciNisuDostupni = "Zahtijevani podaci trenutno nisu dostupni.";
        public readonly string NedovoljnePrivilegije;// = "Nedozvoljena operacija..."
        public const string OslobadjamResurse = "Oslobadjam zauzete reseurse.";
        public const string DobroDosli = "Dobro dosli";
        public const string KorisnickiNalogNePostoji = "Korisnicki nalog ne postoji.";
        public const string NalogNijeAktivan = "Vas nalog nije aktivan. Molimo kontaktirajte...";
        public const string ObaveznaVrijednost = "Unos ove vrijednosti je obavezan!";
        public const string KorisnikUspjesnoDodat = "Podaci o korisniku uspjesno dodati!";
        public const string StudentUspjesnoDodat = "Podaci o studentu uspjesno dodati!";
        public const string StudentUspjesnoModifikovan = "Podaci o studentu uspjesno modifikovani!";








        public Poruke()
        {
            NedovoljnePrivilegije = "Nemate dovoljno privilegija...";
        }      
    }
}
