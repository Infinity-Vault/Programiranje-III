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

        #region Ucitaj Podatke
        private void frmKonsultacijeIBBrojIndeksa_Load(object sender, EventArgs e)
        {
            dgvKonsultacije.AutoGenerateColumns = false;
            lblZahtjevZaKonsultacije.Text = $"Lista zahtjeva za konsultacije studenta: {_student}";//Prikaz koji student je zatrazio konsultacije
            cmbPredmet.DataSource = _db.Predmeti.ToList();//da se u nasem cmbPredmeti ucitaju Predmeti koji se vec nalaze u bazi
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            List<StudentiKonsultacije> lista = new List<StudentiKonsultacije>();//pravimo novu listu 
            foreach (StudentiKonsultacije sk in _db.StudentiKonsultacije.ToList())
            {
                if (sk.Student==_student)//provjeravamo ako je student iz baze jednak studentu kojeg smo proslijedili
                {
                    lista.Add(sk);//dodajmo tog studenta
                }
            }
            dgvKonsultacije.DataSource= lista;//ucitavanje podatke 
            this.Text = $"Broj zapisa konsultacija: {lista.Count}";//Broj konsultacija u naslovu forme
        }

        #endregion

        #region Brisanje&DodajZahtjev&
        private void dgvKonsultacije_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex<0)//ako nemamo reda u nasem dgv samo return
            {
                return;
            }

            var kolona = dgvKonsultacije.Columns[e.ColumnIndex];
            if (kolona is DataGridViewButtonColumn)//ako je nasa kolona button
            {
                var red = dgvKonsultacije.Rows[e.RowIndex].DataBoundItem as StudentiKonsultacije;
                if (MessageBox.Show("Zelite li obrisati ovaj red ?","Brisanje !",MessageBoxButtons.YesNo,MessageBoxIcon.Information)==DialogResult.Yes)//postavljanje pitanja
                {
                    _db.StudentiKonsultacije.Remove(red);//brisanje oznacenog reda
                }
            }

            _db.SaveChanges();//sacuvamo 
            UcitajPodatke();//ponovo ucitamo
        }

        private void btnDodajZahtjev_Click(object sender, EventArgs e)
        {
            Form zahtjev = new frmNoviZahtjev(_student);//otvaranje nove forme
            Hide();
            zahtjev.ShowDialog();
            Show();
            UcitajPodatke();//ponovo ucitavanje
        }
        #endregion

        #region Thread
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            int brojDodanih = int.Parse(txtBrojZahtjeva.Text);//konvertovanje texta u broj
            var predmet = cmbPredmet.SelectedItem as Predmet;

            string dodavanja = "";
            Thread baza = new Thread(() =>
            {
                dodavanja = GenerisiPolozene(brojDodanih, predmet);
            });
            baza.Start();
            baza.Join();
            txtInfo.Text=dodavanja;//Ispisivanje poruke u nas txtInfo koji su podaci dodani
            UcitajPodatke();
        }
        private string GenerisiPolozene(int brojDodanih, Predmet predmet)
        {
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            string dodavanja = "";
            for (int i = 0; i < brojDodanih; i++)//broj dodanih predstavlja broj zahtjeva
            {
                var novaKonsultacija = new StudentiKonsultacije()//dodavanje zahtjeva za student,predmet,...
                {
                    Student = _student,
                    Predmet = predmet,
                    VrijemeOdrzavanja = DateTime.Now,
                    Napomena = $"Napomena: {_student.Id}",
                };
                _db.StudentiKonsultacije.Add(novaKonsultacija);//dodavanje novih konsultacija
                dodavanja +=
                    $"Za {_student} dodat zahtjev za konsultacije -> {predmet} {DateTime.Now} {Environment.NewLine}";//poruka da je dodano za tog studenta i taj predmet
            }

            _db.SaveChanges();//sacuvamo podatke
            Thread.Sleep(500);//Uspavanje threada na 500ms
            MessageBox.Show($"Uspjesno dodane {brojDodanih} konsultacije", "Uspjeh", MessageBoxButtons.OK,
                MessageBoxIcon.Information);//poruka da su podaci uspjesno dodani
            return dodavanja;

        }
        #endregion

        #region Izvjestaj

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            Form izvjestaj =
                new frmIzvjestaj(_db.StudentiKonsultacije.Where(s => s.Student.Id == _student.Id).ToList());
            Hide();
            izvjestaj.ShowDialog();
            Show();
        }
        

        #endregion
    }
}
