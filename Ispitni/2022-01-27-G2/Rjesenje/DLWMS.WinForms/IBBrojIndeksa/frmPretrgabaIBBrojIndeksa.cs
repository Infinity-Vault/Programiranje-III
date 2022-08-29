using DLWMS.WinForms.DB;
using DLWMS.WinForms.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.IBBrojIndeksa
{
    public partial class frmPretrgabaIBBrojIndeksa : Form
    {
        public KonekcijaNaBazu _db = DLWMSdb.Baza;
        public frmPretrgabaIBBrojIndeksa()
        {
            InitializeComponent();
        }
        private void frmPretrgabaIBBrojIndeksa_Load(object sender, EventArgs e)
        {
            dgvOcjena.AutoGenerateColumns = false;
            cmbStudent.DataSource = _db.Studenti.ToList();
            UcitajPodatke();
        }

        private void UcitajPodatke(List<StudentiPredmeti>lista=null)
        {
            if(lista==null)
            {
                     dgvOcjena.DataSource = _db.StudentiPredmeti.ToList();
                    this.Text=$"Ukupno zapisa: { _db.StudentiPredmeti.ToList().Count.ToString()}";

            }
            else
            {
                dgvOcjena.DataSource = lista;
                this.Text = $"Ukupno zapisa: {lista.Count}";
            }
        }

        private void btnPretraga_Click(object sender, EventArgs e)
        {
            if(cmbOcjena.Text==string.Empty)
            {
                return;
            }
            int filter = int.Parse(cmbOcjena.Text);
           List<StudentiPredmeti> listaOcjena = new List<StudentiPredmeti>();
           listaOcjena = _db.StudentiPredmeti.Where(o => o.ocjena >= filter).ToList();
           // List<StudentiPredmeti> listaOcjena = _db.StudentiPredmeti.Where(o => o.ocjena >= filter).ToList();
            UcitajPodatke(listaOcjena);
        }

        private void dgvOcjena_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex<0)
            {
                return;
            }
            if(dgvOcjena.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                var seminarski = dgvOcjena.Rows[e.RowIndex].DataBoundItem as StudentiPredmeti;
                Form UcitajSeminarski = new frmSeminarskiIBBrojIndeksa(seminarski);
                Hide();
                UcitajSeminarski.ShowDialog();
                Show();
            }
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            Form izvjestaj = new frmIzvjestaj(dgvOcjena.DataSource as List<StudentiPredmeti>);
            Hide();
            izvjestaj.ShowDialog();
            Show();
        }

        private void btnTeorija_Click(object sender, EventArgs e)
        {
            Form teorija = new frmTeorijaIBBrojIndeksa();
            Hide();
            teorija.ShowDialog();
            Show();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            int brojDodanih = int.Parse(txtOcjena.Text);
            var student = cmbStudent.SelectedItem as Student;

            string dodavanja = "";
            Thread baza=new Thread(()=>
            {
                dodavanja = GenerisiPolozene(brojDodanih, student);
            });
            baza.Start();
            baza.Join();
            txtInfo.Text = dodavanja;

            UcitajPodatke();
        }
        private string GenerisiPolozene(int broj, Student student)
        {
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            string dodavanja = "";

            for(int i=0; i<broj; i++)
            {
                var predmet = _db.Predmeti.Find(rnd.Next(1, _db.Predmeti.ToList().Count + 1));
                var ocjena = rnd.Next(6, 11);

                var newPolozeni = new StudentiPredmeti()
                { 
                    Student=student,
                    Predmet=predmet,
                    DatumPolaganja=DateTime.Now,
                    ocjena=ocjena,
                };
                _db.StudentiPredmeti.Add(newPolozeni);
                dodavanja += $"Za {student} dodat polozeni -> {predmet} {ocjena} {Environment.NewLine}";
            }
            _db.SaveChanges();
            Thread.Sleep(500);
            MessageBox.Show($"Uspjesno dodano {broj} polozeni predmet!", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return dodavanja;
        }
    }
}
