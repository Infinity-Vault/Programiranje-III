using DLWMS.WinForms.DB;
using DLWMS.WinForms.P9;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.P7
{
    public partial class frmStudenti : Form
    {

        KonekcijaNaBazu db = DLWMSdb.Baza; //new KonekcijaNaBazu();
        public frmStudenti()
        {
            InitializeComponent();
            dgvStudenti.AutoGenerateColumns = false;
        }

        private void frmStudenti_Load(object sender, EventArgs e)
        {
            UcitajStudente();
        }

        private void UcitajStudente(List<Student> podaci = null)
        {
            dgvStudenti.DataSource = null;
            //dgvStudenti.DataSource = podaci ?? db.Studenti.Include("Spol").ToList(); //InMemoryDB.Studenti;
            dgvStudenti.DataSource = podaci ?? db.Studenti.ToList(); //InMemoryDB.Studenti;

        }

        private void btnNoviStudent_Click(object sender, EventArgs e)
        {
            var forma = new frmNoviStudent();
            if (forma.ShowDialog() == DialogResult.OK)
                UcitajStudente();
        }

        private void dgvStudenti_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var student = dgvStudenti.SelectedRows[0].DataBoundItem as Student;
            Form forma = null;
            if (student != null)
            {
                if(dgvStudenti.CurrentCell is DataGridViewButtonCell)
                    forma = new frmPolozeniPredmeti(student);
                else 
                    forma  = new frmNoviStudent(student);
                if (forma.ShowDialog() == DialogResult.OK)
                    UcitajStudente();
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {

            //ver 5
            UcitajStudente(db.Studenti.Where(FiltrirajStudente).ToList());

            //ver 4 
            //UcitajStudente(InMemoryDB.Studenti.Where(FiltrirajStudente).ToList());


            //ver 3 
            //UcitajStudente(InMemoryDB.Studenti.Where(
            //    student => student.Ime.ToLower().Contains(txtFilter.Text)
            //    || student.Prezime.ToLower().Contains(txtFilter.Text)).ToList());

            //ver 2 
            //var filter = txtFilter.Text;
            //var rezultat = InMemoryDB.Studenti.Where(
            //    student => student.Ime.ToLower().Contains(filter)
            //    || student.Prezime.ToLower().Contains(filter)).ToList();           
            //UcitajStudente(rezultat);


            //ver 1 
            //var filter = txtFilter.Text;
            //var rezultat = new List<Student>();

            //foreach (var student in InMemoryDB.Studenti)
            //{
            //    if (student.Ime.ToLower().Contains(filter) || student.Prezime.ToLower().Contains(filter))
            //        rezultat.Add(student);
            //}
            //UcitajStudente(rezultat);
        }

        private bool FiltrirajStudente(Student student)
        {
            return student.Ime.ToLower().Contains(txtFilter.Text) || student.Prezime.ToLower().Contains(txtFilter.Text);
        }

        private void dgvStudenti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
