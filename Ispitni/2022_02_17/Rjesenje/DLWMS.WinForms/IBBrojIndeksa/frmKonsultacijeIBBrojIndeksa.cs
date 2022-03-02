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
using DLWMS.WinForms.DB;
using DLWMS.WinForms.Reports;

namespace DLWMS.WinForms.IBBrojIndeksa
{
  
    public partial class frmKonsultacijeIBBrojIndeksa : Form
    {
        private KonekcijaNaBazu _db = DLWMSdb.Baza;
        private Student _student;
        public frmKonsultacijeIBBrojIndeksa()
        {
            InitializeComponent();
        }
        public frmKonsultacijeIBBrojIndeksa(Student noviStudent)
        {
            InitializeComponent();
            _student = noviStudent;
        }

        private void frmKonsultacijeIBBrojIndeksa_Load(object sender, EventArgs e)
        {
            dgvKonsultacije.AutoGenerateColumns = false;
            lblZahtjevZaKonsultacije.Text = $"Lista zahtjeva za konsultacije studenta: {_student}";
            cmbPredmet.DataSource = _db.Predmeti.ToList();
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            List<StudentiKonsultacije> lista = new List<StudentiKonsultacije>();
            foreach (StudentiKonsultacije sk in _db.StudentiKonsultacije.ToList())
            {
                if (sk.Student==_student)
                {
                    lista.Add(sk);
                }
            }
            dgvKonsultacije.DataSource= lista;
            this.Text = $"Broj zapisa konsultacija: {lista.Count}";
        }

        private void dgvKonsultacije_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex<0)
            {
                return;
            }

            var kolona = dgvKonsultacije.Columns[e.ColumnIndex];
            if (kolona is DataGridViewButtonColumn)
            {
                var red = dgvKonsultacije.Rows[e.RowIndex].DataBoundItem as StudentiKonsultacije;
                if (MessageBox.Show("Zelite li obrisati ovaj red ?","Brisanje !",MessageBoxButtons.YesNo,MessageBoxIcon.Information)==DialogResult.Yes)
                {
                    _db.StudentiKonsultacije.Remove(red);
                }
            }

            _db.SaveChanges();
            UcitajPodatke();
        }

        private void btnDodajZahtjev_Click(object sender, EventArgs e)
        {
            Form zahtjev = new frmNoviZahtjev(_student);
            Hide();
            zahtjev.ShowDialog();
            Show();
            UcitajPodatke();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            int brojDodanih = int.Parse(txtBrojZahtjeva.Text);
            var predmet = cmbPredmet.SelectedItem as Predmet;

            string dodavanja = "";
            Thread baza = new Thread(() =>
            {
                dodavanja = GenerisiPolozene(brojDodanih, predmet);
            });
            baza.Start();
            baza.Join();
            txtInfo.Text=dodavanja;
            UcitajPodatke();
        }

        private string GenerisiPolozene(int brojDodanih, Predmet predmet)
        {
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            string dodavanja = "";
            for (int i = 0; i < brojDodanih; i++)
            {
                var novaKonsultacija = new StudentiKonsultacije()
                {
                    Student = _student,
                    Predmet = predmet,
                    VrijemeOdrzavanja = DateTime.Now,
                    Napomena = $"Napomena: {_student.Id}",
                };
                _db.StudentiKonsultacije.Add(novaKonsultacija);
                dodavanja +=
                    $"Za {_student} dodat zahtjev za konsultacije -> {predmet} {DateTime.Now} {Environment.NewLine}";
            }

            _db.SaveChanges();
            Thread.Sleep(500);
            MessageBox.Show($"Uspjesno dodane {brojDodanih} konsultacije", "Uspjeh", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            return dodavanja;

        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            Form izvjestaj =
                new frmIzvjestaj(_db.StudentiKonsultacije.Where(s => s.Student.Id == _student.Id).ToList());
            Hide();
            izvjestaj.ShowDialog();
            Show();
        }
    }
}
