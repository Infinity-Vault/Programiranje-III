using DLWMS.WinForms.Entiteti;
using DLWMS.WinForms.Helpers;
using System;
using System.Linq;
using System.Windows.Forms;

namespace DLWMS.WinForms.Forme
{
    public partial class frmRegistracija : Form
    {
        public frmRegistracija()
        {
            InitializeComponent();
        }

        private void frmRegistracija_Load(object sender, EventArgs e)
        {
            UcitajLozinku();
        }

        private void UcitajLozinku()
        {
            txtLozinka.Text = GenerisiLozinku();
        }

        private string GenerisiLozinku(int brojZnakova = 15)
        {
            string novaLozinka = "";
            string dozvoljeniZnakovi = "a&sd5a4s6&5s-4df84345#$%&%$QASDFasdf98/$ojkas";
            Random random = new Random();
            for (int i = 0; i < brojZnakova; i++) {
                int lokacija = random.Next(0, dozvoljeniZnakovi.Length);
                novaLozinka += dozvoljeniZnakovi[lokacija];
            }
            return novaLozinka;            
        }
        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (ValidirajUnos()) {
                InMemoryDB.Korisnici.Add(new Korisnik()
                {
                    Id = InMemoryDB.Korisnici.Count + 1,
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text,
                    DatumRodjenja = dtpDatumRodjenja.Value,
                    KorisnickoIme = txtKorisnickoIme.Text,
                    Lozinka = txtLozinka.Text,
                    Aktivan = cbAktivan.Checked
                });
                MessageBox.Show(Poruke.KorisnikUspjesnoDodan);
                OcistiFormu();
            }
        }

        private void OcistiFormu()
        {
            txtIme.Text = txtPrezime.Text = txtKorisnickoIme.Text = txtLozinka.Text = "";
            cbAktivan.Checked = false;
        }

        private bool ValidirajUnos()
        {
            return
                Validator.ValidirajKontrolu(txtIme, err, Poruke.ObaveznaVrijednost) &&
                Validator.ValidirajKontrolu(txtPrezime, err, Poruke.ObaveznaVrijednost) &&
                Validator.ValidirajKontrolu(txtKorisnickoIme, err, Poruke.ObaveznaVrijednost) &&
                Validator.ValidirajKontrolu(txtLozinka, err, Poruke.ObaveznaVrijednost);

        }

        private void txtIme_TextChanged(object sender, EventArgs e)
        {
            GenerisiKorisnickoIme();
        }
        private void GenerisiKorisnickoIme()
        {
            string korisnickoIme = $"{txtIme.Text}.{txtPrezime.Text}";
            txtKorisnickoIme.Text = korisnickoIme.ToLower();
        }
        private void txtPrezime_TextChanged(object sender, EventArgs e)
        {
            GenerisiKorisnickoIme();
        }

        private void btnNovaLozinka_Click(object sender, EventArgs e)
        {
            UcitajLozinku();
        }
    }
}
