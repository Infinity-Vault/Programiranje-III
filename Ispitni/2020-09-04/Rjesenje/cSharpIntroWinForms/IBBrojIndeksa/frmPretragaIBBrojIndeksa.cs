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
    public partial class frmPretragaIBBrojIndeksa : Form
    {
        private KonekcijaNaBazu _db = DLWMS.DB;
        public frmPretragaIBBrojIndeksa()
        {
            InitializeComponent();
        }

        private void frmPretragaIBBrojIndeksa_Load(object sender, EventArgs e)
        {
            UcitajPodatke(_db.KorisniciPredmeti.ToList());
        }

        private void UcitajPodatke(List<KorisniciPredmeti> lista)
        {

            dgvPredmet.DataSource = lista;
            lblProsjekOcjena.Text = $"Prosjecna ocjena je: {GetProsjek(lista)}";
            
         
            

        }

        private float GetProsjek(List<KorisniciPredmeti> lista)
        {
            float prosjek = 0.0f;

            foreach (KorisniciPredmeti p in lista)
            {
                prosjek += p.Ocjena;
            }

            if (lista.Count==0)
            {
                return prosjek;
            }

            return prosjek / lista.Count;
        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            var pretrazivac=txtPretraga.Text.ToLower();
            if (pretrazivac==string.Empty)
            {
                UcitajPodatke(_db.KorisniciPredmeti.ToList());
                return;
            }
            List<KorisniciPredmeti> newList = new List<KorisniciPredmeti>();
            newList = _db.KorisniciPredmeti.Where(p => p.Predmet.Naziv.ToLower().Contains(pretrazivac)).ToList();
            UcitajPodatke(newList);
        }

        private async void btnSuma_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtSuma.Text);
            int rezultat = 0;

            Action racun = () =>
            {
                for (int i = 1; i <= n; i++)
                {
                    rezultat += i;
                }
            };
            await Task.Run(racun);
            lblzracunataSuma.Text = rezultat.ToString();
        }

        private void dgvPredmet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex<0)
            {
                return;
            }

            var kolona = dgvPredmet.Columns[e.ColumnIndex];
            if (kolona is DataGridViewButtonColumn)
            {
                var red = dgvPredmet.Rows[e.RowIndex].DataBoundItem as KorisniciPredmeti;
                Form forma = new frmPorukeIBBrojIndeksa(red.Korisnik);
                Hide();
                forma.ShowDialog();
                Show();
            }
        }
    }
}
