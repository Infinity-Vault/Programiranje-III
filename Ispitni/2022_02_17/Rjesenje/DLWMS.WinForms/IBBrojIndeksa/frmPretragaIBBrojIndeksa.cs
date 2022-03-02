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
            dgvStudent.AutoGenerateColumns = false;
            foreach (var p in _db.Studenti.ToList())
            {
                p.ImePrezime = p.ToString();
                p.ProsjecnaOcjena();
            }
            UcitajPodatke();
        }

        private void UcitajPodatke(List<Student>lista=null, bool posaljiPodatke=false)
        {
            if ((lista==null || lista.Count==0)&&posaljiPodatke==false)
            {
                dgvStudent.DataSource = _db.Studenti.ToList();
            }
            else
            {
                dgvStudent.DataSource = lista;
            }
        }

        private void txtPredmet_TextChanged(object sender, EventArgs e)
        {
            Pretrazivac();
        }


        private void cmbGodinaStudija_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pretrazivac();
        }
        private void Pretrazivac()
        {
            var filter = txtPredmet.Text.ToLower();
            var godina = int.Parse(cmbGodinaStudija.Text);
            List<Student> studentList = new List<Student>();
            if (txtPredmet.Text != String.Empty)
            {
                studentList = _db.Studenti.Where(s => godina == s.GodinaStudija).ToList();
                studentList = studentList
                    .Where(s => s.Ime.ToLower().Contains(filter) || s.Prezime.ToLower().Contains(filter)).ToList();
            }
            else
            {
                studentList = _db.Studenti.Where(s => godina == s.GodinaStudija).ToList();
            }
            UcitajPodatke(studentList,true);
        }

        private void dgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex<0)
            {
                return;
            }
            var kolona=dgvStudent.Columns[e.ColumnIndex];
            if (kolona is DataGridViewButtonColumn)
            {
                //var red = dgvStudent.Rows[e.RowIndex].DataBoundItem as Student;
                Form konsultacije =
                    new frmKonsultacijeIBBrojIndeksa(dgvStudent.Rows[e.RowIndex].DataBoundItem as Student);
                Hide();
                konsultacije.ShowDialog();
                Show();
            }
        }
    }
}
