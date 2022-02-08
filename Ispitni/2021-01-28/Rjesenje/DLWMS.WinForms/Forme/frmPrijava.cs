using DLWMS.WinForms.Entiteti;
using DLWMS.WinForms.Helpers;
using System;
using System.Windows.Forms;

namespace DLWMS.WinForms.Forme
{
    public partial class frmPrijava : Form
    {
        public frmPrijava()
        {
            InitializeComponent();
        }

        private void frmPrijava_Load(object sender, EventArgs e)
        {

        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            if (ValidirajUnos())
            {               
                foreach (var korisnik in InMemoryDB.Korisnici)
                {              
                    if (korisnik.KorisnickoIme == txtKorisnickoIme.Text &&
                        korisnik.Lozinka == txtLozinka.Text)
                    {
                        if(korisnik.Aktivan)
                            MessageBox.Show($"{Poruke.DobroDosli} {korisnik}");
                        else
                            MessageBox.Show($"{Poruke.KorisnickiNalogNijeAktivan}");
                        return;
                    }
                }
                MessageBox.Show(Poruke.KorisnikNePostoji);
            }
        }

        private bool ValidirajUnos()
        {
            return Validator.ValidirajKontrolu(txtKorisnickoIme, err, Poruke.ObaveznaVrijednost) &&
                Validator.ValidirajKontrolu(txtLozinka, err, Poruke.ObaveznaVrijednost);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegistracija frmRegistracija = new frmRegistracija();
            frmRegistracija.Show();
        }
    }
}
