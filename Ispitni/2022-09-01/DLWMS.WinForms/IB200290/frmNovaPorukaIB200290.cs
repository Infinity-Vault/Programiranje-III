using DLWMS.WinForms.DB;
using DLWMS.WinForms.Helpers;
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

namespace DLWMS.WinForms.IB200290
{
    public partial class frmNovaPorukaIB200290 : Form
    {
        KonekcijaNaBazu bp = DLWMSdb.Baza;
        private Student odabraniStudent;

        public frmNovaPorukaIB200290()
        {
            InitializeComponent();
        }

        public frmNovaPorukaIB200290(Student odabraniStudent) : this()
        {
            this.odabraniStudent = odabraniStudent;
        }

        private void frmNovaPorukaIB200290_Load(object sender, EventArgs e)
        {
            cBPredmet.DataSource = bp.Predmeti.ToList();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if(Validator.ValidirajKontrolu(cBPredmet,err,Poruke.ObaveznaVrijednost)
                && Validator.ValidirajKontrolu(txtSadrzaj,err,Poruke.ObaveznaVrijednost))
            {
                var novaPoruka = new StudentPoruka()
                {
                    Predmet = cBPredmet.SelectedItem as Predmet,
                    Sadrzaj = txtSadrzaj.Text,
                    Slika = (pBSlika.Image != null ? ImageHelper.FromImageToByte(pBSlika.Image) : null),
                    Student = odabraniStudent,
                    VrijemeKreiranja = DateTime.Now
                };
                bp.StudentiPoruke.Add(novaPoruka);
                bp.SaveChanges();
                MessageBox.Show("Uspjesno ste dodali poruku za odabranog studenta!");
                cBPredmet.SelectedIndex = 0;
                txtSadrzaj.Text = "";
                pBSlika.Image = null;
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pBSlika_Click(object sender, EventArgs e)
        {
            var slika = new OpenFileDialog();
            if (slika.ShowDialog() == DialogResult.OK) 
            {
                pBSlika.Image = Image.FromFile(slika.FileName);
            }
        }
    }
}
