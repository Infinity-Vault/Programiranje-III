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
using DLWMS.WinForms.P5;
using DLWMS.WinForms.Reports;

namespace DLWMS.WinForms.IBBrojIndeksa
{
    public partial class frmKonsultacijeIBBrojIndeksa : Form
    {
        private Student red;
        private KonekcijaNaBazu _db = DLWMSdb.Baza;

        public frmKonsultacijeIBBrojIndeksa()
        {
            InitializeComponent();
        }

        public frmKonsultacijeIBBrojIndeksa(Student red):this()
        {
            this.red = red;
        }

        private void frmKonsultacijeIBBrojIndeksa_Load(object sender, EventArgs e)
        {
            lblLista.Text = $"Lista zahtjeva za konsultacijama studenta: {red.ImePrezime}";
            cmbPredmet.DataSource = _db.Predmeti.ToList();
            UcitajPodatke();
        }

       private void UcitajPodatke()
       {
           List<StudentKonsultacije> listaStudentKonsultacije = new List<StudentKonsultacije>();
            foreach (var sk in _db.StudentKonsultacije.ToList())
            {
                if (sk.Student.Id==red.Id)
                {
                    listaStudentKonsultacije.Add(sk);
                }
            }

            dgvKonsultacije.DataSource = listaStudentKonsultacije;
            this.Text = $"Broj zapisa za konsultacijama: {listaStudentKonsultacije.Count}";
        }

        private void dgvKonsultacije_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex<0)
            {
                return;
            }
            var kolona=dgvKonsultacije.Columns[e.ColumnIndex];
            if (kolona is DataGridViewButtonColumn)
            {
                var red=dgvKonsultacije.Rows[e.RowIndex].DataBoundItem as StudentKonsultacije;
                if (MessageBox.Show("Da li zelite obrisati ovaj red ?","Brisanje",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                _db.StudentKonsultacije.Remove(red);
                    
                }
                _db.SaveChanges();
                UcitajPodatke();
            }
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            dtoIzvjestaj dtoIzvjestaj = new dtoIzvjestaj()
            {
                ImePrezime = red.ImePrezime,
                StudentKonsultacije = dgvKonsultacije.DataSource as List<StudentKonsultacije>
            };
            var izvjestaj = new frmIzvjestaj(dtoIzvjestaj);
            Hide();
            izvjestaj.ShowDialog();
            Show();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (!Validator.ValidirajKontrolu(txtBrojZahtjeva, errorProvider1, Poruke.ObaveznaVrijednost))
            {
                return;
            }
            int brojDodanih = int.Parse(txtBrojZahtjeva.Text);
            var predmet = cmbPredmet.SelectedItem as Predmet;

            string dodavanja = "";
            Thread baza = new Thread(() =>
            {
                dodavanja = Generisi(brojDodanih, predmet);
            });
            baza.Start();
            baza.Join();
            txtInfo.Text=dodavanja;
            UcitajPodatke();
        }

        private string Generisi(int brojDodanih, Predmet predmet)
        {
            string dodavanja = "";
            for (int i = 0; i < brojDodanih; i++)
            {
                var novaKonsultacija = new StudentKonsultacije()
                {
                    Student = red,
                    Predmet = predmet,
                    VrijemeOdrzavanja = DateTime.Now,
                    Napomena = $"Napomena: {red.Id}",
                };
                _db.StudentKonsultacije.Add(novaKonsultacija);
                dodavanja +=
                    $"Za {red.ImePrezime} dodat zahtjev za konsultacije -> {predmet} {DateTime.Now} {Environment.NewLine}";
            }

            _db.SaveChanges();
            Thread.Sleep(500);
            MessageBox.Show($"Uspjesno {brojDodanih} konsultacije", "Uspjeh", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            return dodavanja;
        }

        private void btnDodajZahtjev_Click(object sender, EventArgs e)
        {
            var zahtjev = new frmNovaKonsultacijaIBBrojIndeksa(red);
            Hide();
            zahtjev.ShowDialog();
            Show();
            UcitajPodatke();
        }
    }

    public class dtoIzvjestaj
    {
        public string ImePrezime { get; set; }
        public List<StudentKonsultacije> StudentKonsultacije { get; set; }
    }

}
