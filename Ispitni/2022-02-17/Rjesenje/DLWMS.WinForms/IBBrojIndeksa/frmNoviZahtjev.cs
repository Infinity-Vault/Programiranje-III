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
using DLWMS.WinForms.P5;

namespace DLWMS.WinForms.IBBrojIndeksa
{
    public partial class frmNoviZahtjev : Form
    {
        private KonekcijaNaBazu _db = DLWMSdb.Baza;
        private Student _student;

        public frmNoviZahtjev()
        {
            InitializeComponent();
        }
        public frmNoviZahtjev(Student noviStudent)
        {
            InitializeComponent();
            _student = noviStudent;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            //Kada kliknemo button Odustani zatvara se forma NoviZahtjev i vraca nas na staru formu Konsultacije
           this.Close();
            Show();
        }

        private void frmNoviZahtjev_Load(object sender, EventArgs e)
        {
            cmbPredmet.DataSource = _db.Predmeti.ToList();//U cmbPremdet ucitavamo nase predmete koje vec imamo u bazi
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (!Validator.ValidirajKontrolu(txtNapomena,errorProvider1,"Morate unijeti napomenu"))
            {
                return;
            }
            var konsultacija = new StudentiKonsultacije()
            {
                Student = _student,
                Predmet = cmbPredmet.SelectedItem as Predmet,
                Napomena = txtNapomena.Text,
                VrijemeOdrzavanja = dtpDatumVrijeme.Value,
            };
            _db.StudentiKonsultacije.Add(konsultacija);//u bazu nasu dodajemo novu konsultaciju
            _db.SaveChanges();//sacuvamo podatke

            MessageBox.Show("Uspjesno");//poruka da su podaci uspjesno sacuvani
            Close();//zatvara se forma i vraca nas na formu konusltacije


        }
    }
}
