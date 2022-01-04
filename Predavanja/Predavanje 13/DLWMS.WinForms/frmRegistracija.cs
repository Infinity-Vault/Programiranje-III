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
    public partial class frmRegistracija : Form
    {
        public frmRegistracija()
        {
            InitializeComponent();
        }

        private void btnRegistracija_Click(object sender, EventArgs e)
        {
            if (ValidirajUnos())
            {
                var noviKorisnik = new Korisnik()
                {
                    Id = InMemoryDB.Korisnici.Count + 1,
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text,
                    DatumRodjenja = dtpDatumRodjenja.Value,
                    KorisnickoIme = txtKorisnickoIme.Text,
                    Lozinka = txtLozinka.Text,
                    Aktivan = cbAktivan.Checked
                };
                InMemoryDB.Korisnici.Add(noviKorisnik);
                MessageBox.Show(Poruke.KorisnikUspjesnoDodat,"Informacija",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool ValidirajUnos()
        {
            return Validator.ValidirajKontrolu(txtIme, err, Poruke.ObaveznaVrijednost)
                && Validator.ValidirajKontrolu(txtPrezime, err, Poruke.ObaveznaVrijednost)
                && Validator.ValidirajKontrolu(txtKorisnickoIme, err, Poruke.ObaveznaVrijednost)
                && Validator.ValidirajKontrolu(txtLozinka, err, Poruke.ObaveznaVrijednost);
        }

        private void txtIme_TextChanged(object sender, EventArgs e)
        {
            GenerisiKorisnickoIme();
        }

        private void GenerisiKorisnickoIme()
        {
            txtKorisnickoIme.Text = $"{txtIme.Text}.{txtPrezime.Text}".ToLower();
        }

        private void txtPrezime_TextChanged(object sender, EventArgs e)
        {
            GenerisiKorisnickoIme();
        }

        private void txtKorisnickoIme_TextChanged(object sender, EventArgs e)
        {
            foreach (var korisnik in InMemoryDB.Korisnici)
            {
                if (korisnik.KorisnickoIme == txtKorisnickoIme.Text)
                {
                    txtKorisnickoIme.BackColor = Color.Red;
                    return;
                }                
            }
            txtKorisnickoIme.BackColor = Color.Empty;
        }

        private void frmRegistracija_Load(object sender, EventArgs e)
        {
            Text = txtLozinka.Text = Generator.GenerisLozinku();
        }

      
    }
    public class Generator
    {
        public  static string GenerisLozinku(int brojZnakova = 10)
        {
            var lozinka = "";
            var dozvoljeniKarakteri = "dasp98fdsdfja98fd#$&%&/(2356442";
            var rand = new Random();
            for (int i = 0; i < brojZnakova; i++)
            {
                int lokacijaZnaka = rand.Next(0, dozvoljeniKarakteri.Length);//20
                lozinka += dozvoljeniKarakteri[lokacijaZnaka];//2p#
            }
            return lozinka;



        }
    }
}
