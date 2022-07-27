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
    public partial class frmNovaKonsultacijaIBBrojIndeksa : Form
    {
        private Student red;
        private KonekcijaNaBazu _db = DLWMSdb.Baza;
        public frmNovaKonsultacijaIBBrojIndeksa()
        {
            InitializeComponent();
        }

        public frmNovaKonsultacijaIBBrojIndeksa(Student red):this()
        {
            this.red = red;
        }

        private void frmNovaKonsultacijaIBBrojIndeksa_Load(object sender, EventArgs e)
        {
            cmbPredmet.DataSource = _db.Predmeti.ToList();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
            Show();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (!Validator.ValidirajKontrolu(txtNapomena, errorProvider1, Poruke.ObaveznaVrijednost))
            {
                return;
            }

            var konsultacija = new StudentKonsultacije()
            {
                Student = red,
                Predmet = cmbPredmet.SelectedItem as Predmet,
                Napomena = txtNapomena.Text,
                VrijemeOdrzavanja = dtpVrijeme.Value

            };
            _db.StudentKonsultacije.Add(konsultacija);
            _db.SaveChanges();

            MessageBox.Show("Uspjesno");
            Close();
        }
    }
}
