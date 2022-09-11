using DLWMS.WinForms.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.IB200290
{
    public partial class frmPretragaIB200290 : Form
    {
        private KonekcijaNaBazu bp = DLWMSdb.Baza;
        private List<Student> novaListaStudenata;
        public frmPretragaIB200290()
        {
            InitializeComponent();
        }
        private void UcitajPodatke(List<Student> studenti = null)
        {
            if(studenti == null)
            {
                dgvStudenti.DataSource = null;
                dgvStudenti.DataSource = bp.Studenti.ToList();
            }
            else
            {
                dgvStudenti.DataSource = null;
                dgvStudenti.DataSource = studenti;
            }
        }

        private void frmPretragaIB200290_Load(object sender, EventArgs e)
        {
            cBSpol.DataSource = bp.Spolovi.ToList();
            cBSpol.SelectedIndex = 0;
            UcitajPodatke();
        }

        private void Pretraga()
        {
            var filter = txtPretraga.Text.ToLower();
            if (txtPretraga.Text == string.Empty && cBSpol.SelectedIndex == 0)
            {
                UcitajPodatke();
            }
            else if (txtPretraga.Text == string.Empty)
            {
                novaListaStudenata = bp.Studenti.Where(x => x.Spol.Id == (cBSpol.SelectedIndex + 1)).ToList();
                UcitajPodatke(novaListaStudenata);
            }
            else if (txtPretraga.Text != string.Empty && cBSpol.SelectedIndex == 0)
            {
                novaListaStudenata = bp.Studenti.Where(x => (x.Indeks.ToLower().Contains(filter))
                || (x.Ime.ToLower().Contains(filter))
                || (x.Prezime.ToLower().Contains(filter))).ToList();
                UcitajPodatke(novaListaStudenata);
            }
            else if (txtPretraga.Text != string.Empty) 
            {
                novaListaStudenata = bp.Studenti.Where(x => (x.Indeks.ToLower().Contains(filter)
                || x.Ime.ToLower().Contains(filter)
                || x.Prezime.ToLower().Contains(filter))
                && (x.Spol.Id == (cBSpol.SelectedIndex + 1))).ToList();
                UcitajPodatke(novaListaStudenata);
            }
        }

        private void cBSpol_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pretraga();
        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            Pretraga();
        }

        private void dgvStudenti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var odabraniStudent = dgvStudenti.SelectedRows[0].DataBoundItem as Student;
            if(e.ColumnIndex == 4)
            {
                var formaPoruka = new frmPorukeIB200290(odabraniStudent);
                Hide();
                formaPoruka.ShowDialog();
                Show();
            }
        }
    }
}
