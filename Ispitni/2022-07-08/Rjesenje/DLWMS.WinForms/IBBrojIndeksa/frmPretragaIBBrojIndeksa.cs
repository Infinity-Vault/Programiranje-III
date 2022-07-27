using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DLWMS.WinForms.DB;

namespace DLWMS.WinForms.IBBrojIndeksa
{
    public partial class frmPretragaIBBrojIndeksa : Form
    {
        private KonekcijaNaBazu _db = DLWMSdb.Baza;
        public frmPretragaIBBrojIndeksa()
        {
            InitializeComponent();
        }

        private void frmPretragaIBBrojIndeksa_Load(object sender, EventArgs e)
        {
            dgvStudent.AutoGenerateColumns=false;
            foreach (var s in _db.Studenti.ToList())
            {
                s.ProsjecnaOcjena();
            }
            UcitajPodatke();
        }

        private void UcitajPodatke(List<Student> lista = null)
        {
            if (lista == null || lista.Count==0)
            {
                dgvStudent.DataSource = _db.Studenti.ToList();
            }
            else
            {
                dgvStudent.DataSource = lista;
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            Pretraga();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pretraga();
        }

        private void Pretraga()
        {
            var pretrazivac = txtEmail.Text.ToLower();
            if (txtEmail.Text==string.Empty)
            {
                UcitajPodatke();
                return;
            }

            List<Student> novaLista = new List<Student>();

            switch (cmbStatus.Text)
            {
                case "Svi statusi":
                    novaLista = _db.Studenti.Where(x => x.Email.ToLower().Contains(pretrazivac)).ToList();
                    break;
                case "Aktivan":
                    novaLista = _db.Studenti.Where(x =>( x.Email.ToLower().Contains(pretrazivac)) && x.Aktivan).ToList();
                    break;
                case "Neaktivan":
                    novaLista = _db.Studenti.Where(x => (x.Email.ToLower().Contains(pretrazivac)) && !x.Aktivan).ToList();
                    break;
            }
            UcitajPodatke(novaLista);
        }

        private void dgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex<0)
            {
                return;
            }
            var kolona = dgvStudent.Columns[e.ColumnIndex];
            if (kolona is DataGridViewButtonColumn)
            {
                var red = dgvStudent.Rows[e.RowIndex].DataBoundItem as Student;
                var konsultacije = new frmKonsultacijeIBBrojIndeksa(red);
                Hide();
                konsultacije.ShowDialog();
                Show();
            }
        }
    }
}
