using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cSharpIntroWinForms.P10;
using cSharpIntroWinForms.P9;

namespace cSharpIntroWinForms.IBBrojIndeksa
{
    public partial class frmNovaPorukaIBBrojIndeksa : Form
    {
        private KonekcijaNaBazu _db = DLWMS.DB;
        private KorisniciPoruke _novaPoruka;
        private Korisnik _korisnik;
        public frmNovaPorukaIBBrojIndeksa()
        {
            InitializeComponent();
        }
        public frmNovaPorukaIBBrojIndeksa(KorisniciPoruke novaPoruka)
        {
            InitializeComponent();
            _novaPoruka=novaPoruka;
            UcitajPodatke();
        }
        public frmNovaPorukaIBBrojIndeksa(Korisnik korisnik)
        {
            InitializeComponent();
            _korisnik = korisnik;
            btnSpasi.Enabled = true;
        }

        private void frmNovaPorukaIBBrojIndeksa_Load(object sender, EventArgs e)
        {
            if (_novaPoruka!=null)
            {
                txtPrimaoc.Text = _novaPoruka.Primaoc.Ime + " " + _novaPoruka.Primaoc.Prezime;
            }
            else
            {
                txtPrimaoc.Text = _korisnik.Ime + " " + _korisnik.Prezime;
            }
        }

        private void UcitajPodatke()
        {
            txtSadrzaj.Enabled = false;
            pbSlika.Enabled = false;
            btnSpasi.Enabled=false;

            txtSadrzaj.Text = _novaPoruka.SadrzajPoruke;
            pbSlika.Image = ImageHelper.FromByteToImage(_novaPoruka.Slika);

        }

        private void pbSlika_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                pbSlika.Image = (Bitmap) Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btnSpasi_Click(object sender, EventArgs e)
        {
            if (!Validator.ObaveznoPolje(txtSadrzaj,err,"Obavezan unos"))
            {
                return;
            }

            var noviKorisniPoruka = new KorisniciPoruke()
            {
                DatumVrijeme = DateTime.Now.ToString(),
                Primaoc = _korisnik,
                SadrzajPoruke = txtSadrzaj.Text,
                Slika = ImageHelper.FromImageToByte(pbSlika.Image)
            };

            _db.KorisniciPoruke.Add(noviKorisniPoruka);
            _db.SaveChanges();

            MessageBox.Show("Uspjesno dodano");
            Close();
        }
    }
}
