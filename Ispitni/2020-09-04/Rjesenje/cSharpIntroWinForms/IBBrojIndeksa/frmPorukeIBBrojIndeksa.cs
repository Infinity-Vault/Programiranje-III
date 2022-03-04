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
    public partial class frmPorukeIBBrojIndeksa : Form
    {
        private KonekcijaNaBazu _db = DLWMS.DB;
        private Korisnik _korisnik;
        public frmPorukeIBBrojIndeksa()
        {
            InitializeComponent();
        }
        public frmPorukeIBBrojIndeksa(Korisnik korisnik)
        {
            InitializeComponent();
            _korisnik= korisnik;
        }
        private void frmPorukeIBBrojIndeksa_Load(object sender, EventArgs e)
        {
            dgvPoruke.AutoGenerateColumns = false;
            UcitajPodatke();
            lblKorisnikPoruka.Text = $"{_korisnik}";
        }

        private void UcitajPodatke()
        {
            List<KorisniciPoruke> korisnikPoruka = new List<KorisniciPoruke>();
            foreach (KorisniciPoruke bazaPoruka in _db.KorisniciPoruke.ToList())
            {
                ///dgvPoruka.DataSource = db.KorisniciPoruke.Where(s => s.Primaoc == _korisnk).ToList();
                if (bazaPoruka.Primaoc == _korisnik)
                {
                    korisnikPoruka.Add(bazaPoruka);
                }
            }
            dgvPoruke.DataSource = korisnikPoruka;
        }

        private void dgvPoruke_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex<0)
            {
                return;
            }
            var kolona = dgvPoruke.Columns[e.ColumnIndex];
            if (kolona is DataGridViewButtonColumn)
            {
                var red = dgvPoruke.Rows[e.RowIndex].DataBoundItem as KorisniciPoruke;
                if (MessageBox.Show("Da li ste sigurni da zelite obrisati ovaj red","Brisanje",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    _db.KorisniciPoruke.Remove(red);
                }
            }

            _db.SaveChanges();
            UcitajPodatke();
        }

        private void btnPoruka_Click(object sender, EventArgs e)
        {
            Form novaPoruka = new frmNovaPorukaIBBrojIndeksa(_korisnik);
            Hide();
            novaPoruka.ShowDialog();
            Show();
            UcitajPodatke();
        }

        private void dgvPoruke_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex<0)
            {
                return;
            }

            var novaPoruka = dgvPoruke.Rows[e.RowIndex].DataBoundItem as KorisniciPoruke;
            Form forma = new frmNovaPorukaIBBrojIndeksa(novaPoruka);
            Hide();
            forma.ShowDialog();
            Show();
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            Form izvjestaj =
                new frmIzvjestajIBBrojIndeksa(_db.KorisniciPoruke.Where(p => p.Primaoc.Id == _korisnik.Id).ToList());
            Hide();
            izvjestaj.ShowDialog();
            Show();
        }
    }
}
