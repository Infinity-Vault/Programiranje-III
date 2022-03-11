using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cSharpIntroWinForms.P10;
using cSharpIntroWinForms.P9;

namespace cSharpIntroWinForms.IBBrojIndeksa
{
    public partial class frmSlikeIBBrojIndeksa : Form
    {
        private Korisnik _korisnik;
        private KonekcijaNaBazu _db = DLWMS.DB;
        private int index = 0;
        public frmSlikeIBBrojIndeksa()
        {
            InitializeComponent();
        }
        public frmSlikeIBBrojIndeksa(Korisnik korisnik)
        {
            InitializeComponent();
            _korisnik = korisnik;
        }
        private void frmSlikeIBBrojIndeksa_Load(object sender, EventArgs e)
        {
            UcitajSliku();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()==DialogResult.OK)//preko openFileDialog dozvoljavamo korisniku da moze koristiti foldere na svom racunaru
            {
                var novaSlika = new KorisniciSlike();//nova slika da bude spremna za nasu novu kreiranu tabelu KorisniciSlike

                novaSlika.Slika = ImageHelper.FromImageToByte(Image.FromFile(openFileDialog1.FileName));//dodajemo sliku sa naseg racunara
                _korisnik.SlikeKorisnika.Add(new KorisniciSlike()//metoda koja omogucava dodavanje na nasu bazu
                {
                    Slika = novaSlika.Slika
                });

                _db.SaveChanges();
                MessageBox.Show($"Uspjesno ste dodali sliku");
                UcitajSliku();
             



            }
        }

        private void UcitajSliku()
        {
            if (_korisnik.SlikeKorisnika.Count()!=0)//Ako nam je ovdje razlicito od 0 to znaci da vec imamo sliku u nasoj bazi i samo je ucitamo
            {
                var slika = _korisnik.SlikeKorisnika[index];
                pictureBox1.Image = ImageHelper.FromByteToImage(slika.Slika);
            }
            else
            {
                MessageBox.Show($"Trenutni korisnik nema slike", "Upozorenje", MessageBoxButtons.OK);// u slucaju da nemamo slike ispsat cemo odgovarajucu poruku
            }
        }

        private void btnLijevo_Click(object sender, EventArgs e)
        {
            if (index!=0)
            {
                index--;
            }
            UcitajSliku();
        }

        private void btnDesno_Click(object sender, EventArgs e)
        {
            if (index!=_korisnik.SlikeKorisnika.Count-1)
            {
                index++;
            }
            UcitajSliku();
        }
    }
}
