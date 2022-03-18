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

        #region Ucitaj Podatke
        private void frmPretragaIBBrojIndeksa_Load(object sender, EventArgs e)
        {
            dgvStudent.AutoGenerateColumns = false;//da nam program ne bi sam pravio kolone
            foreach (Student p in _db.Studenti.ToList())
            {
                p.ImePrezime = p.ToString();//ImePrezime je property koji se nalazi u class Student, a class Studnet nam vraca ime i prezime studenta
                p.ProsjecnaOcjena();//Prosjecna ocjena je property koji se nalazi u class Student, gdje smo i izracunali prosjecnu ocjenu za svakog studenta
            }
            UcitajPodatke();//Ucitavanje nasih podataka iz baze
            cmbGodinaStudija.Text = "1";
        }

        private void UcitajPodatke(List<Student>lista=null,bool posaljiPodatke=false)
        {
            if ((lista==null || lista.Count==0)&&posaljiPodatke==false)
            {
                dgvStudent.DataSource = _db.Studenti.ToList();//dodajemo podatke u dgv iz nase baze
            }
            else
            {
                dgvStudent.DataSource = lista;
            }
        }
        #endregion

        #region Pretraga
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
            var filter = txtPredmet.Text.ToLower();//sve sto unesmo u nas txtPredmet da bude malim slovima .ToLower()

            var godina = int.Parse(cmbGodinaStudija.Text);//konverzija tekstualnog dijela u broj
            List<Student> studentList = new List<Student>();//pravimo novu listu
           
            if (txtPredmet.Text != string.Empty)//u slucaju da nam je nas txtPredmet prazan vrsit ce se pretraga studenata po odabranoj godini
            {
                studentList = _db.Studenti.Where(s => godina == s.GodinaStudija).ToList();
                studentList = studentList
                    .Where(s => s.Ime.ToLower().Contains(filter) || s.Prezime.ToLower().Contains(filter)).ToList();
            }
            else
            {
                studentList = _db.Studenti.Where(s => godina == s.GodinaStudija).ToList();
               
            }
            UcitajPodatke(studentList,true);//Ucitaj nase podatke ponovo sa novom listom i poslani podaci su true tjt da nam vrati njih u dgv i ako se desi kakvo brisanje da ponovo ucita
        }
        #endregion

        #region Button Konsultacije
        private void dgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Button Konsultacije treba da nam otvori novu formu Konsultacije i prikaze podatke samo o studentu na kojeg smo pritisnuli button Konsultacije
            if (e.RowIndex<0)
            {
                return;
            }
            var kolona=dgvStudent.Columns[e.ColumnIndex];
            if (kolona is DataGridViewButtonColumn)
            {
                //var red = dgvStudent.Rows[e.RowIndex].DataBoundItem as Student;
                Form konsultacije =
                    new frmKonsultacijeIBBrojIndeksa(dgvStudent.Rows[e.RowIndex].DataBoundItem as Student);//Prosljedimo mu studenta
                Hide();
                konsultacije.ShowDialog();
                Show();
            }
        }
        
        #endregion
    }
}
