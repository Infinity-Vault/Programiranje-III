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
           this.Close();
            Show();
        }

        private void frmNoviZahtjev_Load(object sender, EventArgs e)
        {
            cmbPredmet.DataSource = _db.Predmeti.ToList();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            var konsultacija = new StudentiKonsultacije()
            {
                Student = _student,
                Predmet = cmbPredmet.SelectedItem as Predmet,
                Napomena = txtNapomena.Text,
                VrijemeOdrzavanja = dtpDatumVrijeme.Value,
            };
            _db.StudentiKonsultacije.Add(konsultacija);
            _db.SaveChanges();

            MessageBox.Show("Uspjesno");
            Close();


        }
    }
}
