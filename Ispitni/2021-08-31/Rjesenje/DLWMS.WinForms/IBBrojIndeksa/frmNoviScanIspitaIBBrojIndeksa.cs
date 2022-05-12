using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DLWMS.WinForms.Entiteti;
using DLWMS.WinForms.Helpers;

namespace DLWMS.WinForms.IBBrojIndeksa
{
    public partial class frmNoviScanIspitaIBBrojIndeksa : Form
    {
        private KonekcijaNaBazu _db = DLWMSdb.Baza;
        private Student _student;
        private StudentiIspitiScan ispitiScan;
        public frmNoviScanIspitaIBBrojIndeksa()
        {
            InitializeComponent();
        }
        public frmNoviScanIspitaIBBrojIndeksa(Student noviStudent)
        {
            InitializeComponent();
            _student = noviStudent;

        }
        public frmNoviScanIspitaIBBrojIndeksa(StudentiIspitiScan ispitiScan)
        {
            InitializeComponent();
            this.ispitiScan = ispitiScan;
            LoadData(ispitiScan);

        }
        private void LoadData(StudentiIspitiScan scan)
        {
            cmbPredmet.Text = scan.Predmet.Naziv;
            txtNapomena.Text = scan.Napomena;

            if (scan.Slika != null)
            {
                pbSlika.Image = ImageHelper.FromByteToImage(scan.Slika);
            }

            cbVaranje.Checked = scan.Varanje;

            cmbPredmet.Enabled = false;
            txtNapomena.Enabled = false;
            cbVaranje.Enabled = false;
        }
        private void frmNoviScanIspitaIBBrojIndeksa_Load(object sender, EventArgs e)
        {
            cmbPredmet.DataSource = _db.Predmet.ToList();
        }

        private void pbSlika_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                pbSlika.Image = (Bitmap) Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btnSpasi_Click(object sender, EventArgs e)
        {
            if (!Validator.ValidirajKontrolu(txtNapomena,errorProvider1,"Obavezan unos")||!Validator.ValidirajKontrolu(pbSlika,errorProvider1,"Obavezan unos"))
            {
                return;
            }

            StudentiIspitiScan newScan = new StudentiIspitiScan();
            newScan.Student = _student;
            newScan.Predmet = cmbPredmet.SelectedItem as Predmet;
            newScan.Varanje = cbVaranje.Checked;
            newScan.Napomena = txtNapomena.Text;
            newScan.Slika = ImageHelper.FromImageToByte(pbSlika.Image);

            _db.StudentiIspitiScan.Add(newScan);
            _db.SaveChanges();

            MessageBox.Show("Uspjesno dodano", "Uspjeh", MessageBoxButtons.OK);
            Hide();
        }

        /* private void UcitajPodatke(StudentiIspitiScan scanIspiti)
         {


         }*/
    }
}
