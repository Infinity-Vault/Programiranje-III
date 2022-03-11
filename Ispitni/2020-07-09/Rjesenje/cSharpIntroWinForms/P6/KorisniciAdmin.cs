using cSharpIntroWinForms.P10;
using cSharpIntroWinForms.P8;
using cSharpIntroWinForms.P9;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cSharpIntroWinForms.IBBrojIndeksa;

namespace cSharpIntroWinForms
{
    public partial class KorisniciAdmin : Form
    {

        KonekcijaNaBazu _db = DLWMS.DB;

        public KorisniciAdmin()
        {
            InitializeComponent();
            dgvKorisnici.AutoGenerateColumns = false;
        }

        private void KorisniciAdmin_Load(object sender, EventArgs e)
        {
            LoadData();
            UcitajSpolove();
           // txtPretraga.Select();
        }

        private void LoadData(List<Korisnik> korisnici=null)
        {
            if (korisnici == null || korisnici.Count == 0)
            {

                dgvKorisnici.DataSource = _db.Korisnici.ToList();
            }
            else
            {
                dgvKorisnici.DataSource = korisnici;
            }
        }

        private void dgvKorisnici_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex<0)
            {
                return;
            }
            var kolona =dgvKorisnici.Columns[e.ColumnIndex];
            if (kolona is DataGridViewButtonColumn)
            {
                var red = dgvKorisnici.Rows[e.RowIndex].DataBoundItem as Korisnik;
                Form slike = new frmSlikeIBBrojIndeksa(red);
                Hide();
                slike.ShowDialog();
                Show();
            }
        }

        #region Pretraga


        private void UcitajSpolove()//Ucitavamo tabelu spolovi u nas cmbSpol
        {
            cmbSpol.DataSource = _db.Spolovi.ToList();
            cmbSpol.DisplayMember = "Naziv";
            cmbSpol.ValueMember = "Id";
        }
        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            Pretrazivac();
        }

        private void cmbSpol_SelectedIndexChanged(object sender, EventArgs e)//provjera po spolu kojeg smo odabrali
        {
            var odabraniSpol = cmbSpol.SelectedItem as Spolovi;
            var rezultat = _db.Korisnici.Where(x => x.Spol.Id == odabraniSpol.Id).ToList();
            LoadData(rezultat);
        }

        private void cbAdministrator_CheckedChanged(object sender, EventArgs e)//pretraga samo da li je Admin check ili nije
        {
            var rezultat = _db.Korisnici.Where(x => x.Admin == cbAdministrator.Checked).ToList();
            LoadData(rezultat);
        }

        private void Pretrazivac()
        {
            var trazeniPodatak = txtPretraga.Text.ToLower();
            var spol = cmbSpol.SelectedItem as Spolovi;
            List<Korisnik> noviKorisnik = new List<Korisnik>();

            if (txtPretraga.Text==string.Empty)//u slucaju da nam je nas textBox prazan onda ce se vrijednosti filtrirati samo po spolu i provjeravati da li smo check nas checkBox ili nismo
            {
                noviKorisnik = _db.Korisnici.Where(s => s.Spol.Id == spol.Id && s.Admin == cbAdministrator.Checked)
                    .ToList();
            }
            else//u slucaju da nam nas textBox nije prazan vrsi se provjera po imenu ili prezimenu
            {
                noviKorisnik = _db.Korisnici.Where(s =>
                    s.Ime.ToLower().Contains(trazeniPodatak) || s.Prezime.ToLower().Contains(trazeniPodatak)).ToList();
            }


            LoadData(noviKorisnik);
        }
        #endregion

        #region Racunanje Sume

        private async void btnSuma_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtSuma.Text);
            double rezultat = 0;
            Action akcija = () =>
            {
                for (int i = 1; i <= n; i++)
                {
                    rezultat += i;
                }
            };
            await Task.Run(akcija);

            txtSuma.Text = rezultat.ToString();

        }


        #endregion

        
        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            Form izvjestaj = new frmIzvjestajIBBrojIndeksa(_db.Korisnici.ToList());
            Hide();
            izvjestaj.ShowDialog();
            Show();
        }
    }
}
