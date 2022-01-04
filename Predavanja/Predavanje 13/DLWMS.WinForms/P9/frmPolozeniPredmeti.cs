using DLWMS.WinForms.DB;
using DLWMS.WinForms.P11;
using DLWMS.WinForms.P5;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.P9
{
    public partial class frmPolozeniPredmeti : Form
    {
        private P7.Student student;

        KonekcijaNaBazu db = DLWMSdb.Baza;

        public frmPolozeniPredmeti(P7.Student student)//1
        {
            InitializeComponent();
            this.student = student;
            dgvPolozeniPredmeti.AutoGenerateColumns = false;
        }

        private void frmPolozeniPredmeti_Load(object sender, EventArgs e)
        {
            try
            {
                UcitajPolozenePredmete();
                UcitajPredmete();
                UcitajUloge();
                UcitajUlogeStudenta();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + ex.InnerException?.Message);
            }
        }

        private void UcitajUlogeStudenta()
        {
            dgvUloge.DataSource = null;
            dgvUloge.DataSource = student.Uloge.ToList();
        }

        private void UcitajUloge()
        {
            cmbUloge.DataSource = db.Uloge.ToList(); //InMemoryDB.NPP;
            cmbUloge.ValueMember = "Id";
            cmbUloge.DisplayMember = "Naziv";
        }

        private void UcitajPredmete()
        {
            cmbPredmeti.DataSource = db.Predmeti.ToList(); //InMemoryDB.NPP;
            cmbPredmeti.ValueMember = "Id";
            cmbPredmeti.DisplayMember = "Naziv";
        }

        private void UcitajPolozenePredmete()
        {
            dgvPolozeniPredmeti.DataSource = null;
            var polozeni = db.StudentiPredmeti.Include("Predmet").Where(s => s.Student.Id == student.Id).ToList(); //student.PolozeniPredmeti;
            dgvPolozeniPredmeti.DataSource = polozeni;
        }

        private void btnDodajPolozeni_Click(object sender, EventArgs e)
        {
            var nePostoji = PredmetNePostoji();
            if(nePostoji == false)
                MessageBox.Show("Predmet je već dodat!!!");
            if (ValidirajUnos() && nePostoji)
            {
                //var polozeni = new PolozeniPredmet()
                //{
                //    DatumPolaganja = dtpDatumPolaganja.Value,
                //    Id = student.PolozeniPredmeti.Count + 1,
                //    Ocjena = int.Parse(cmbOcjene.Text),
                //    Predmet = cmbPredmeti.SelectedItem as Predmet
                //};
                //student.PolozeniPredmeti.Add(polozeni);

                var polozeni = new StudentPredmet()
                {
                    DatumPolaganja = dtpDatumPolaganja.Value,
                    Ocjena = int.Parse(cmbOcjene.Text),
                    Predmet = cmbPredmeti.SelectedItem as Predmet,
                    Student = student,
                };
                //student.PolozeniPredmeti.Add(polozeni);
                db.StudentiPredmeti.Add(polozeni);
                db.SaveChanges();

                UcitajPolozenePredmete();
            }
        }

        private bool PredmetNePostoji()
        {
            var odabrani = cmbPredmeti.SelectedItem as Predmet;
            return student.PolozeniPredmeti.Where(predmet =>
                            predmet.Predmet.Id == odabrani.Id).Count() == 0;
        }

        private bool ValidirajUnos()
        {
            return Validator.ValidirajKontrolu(cmbPredmeti, err, Poruke.ObaveznaVrijednost)
                && Validator.ValidirajKontrolu(cmbOcjene, err, Poruke.ObaveznaVrijednost);
        }

        private void cmbPredmeti_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDodajUlogu_Click(object sender, EventArgs e)
        {
            try
            {
                Uloga uloga = cmbUloge.SelectedItem as Uloga;
                student.Uloge.Add(uloga);
                db.SaveChanges();
                UcitajUlogeStudenta();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnPrintajUvjerenje_Click(object sender, EventArgs e)
        {
            var dtoUjerenjeOPolozenim = new dtoUvjerenjeOPolozenim()
            {
                Indeks = student.Indeks,
                ImePrezime = $"{student.Ime} {student.Prezime}",
                Polozeni = dgvPolozeniPredmeti.DataSource as List<StudentPredmet>
            };
            var frmIzvjestaji = new P12.frmIzvjestaji(dtoUjerenjeOPolozenim);
            frmIzvjestaji.Show();

        }
    }
}
