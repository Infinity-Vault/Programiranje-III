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
using DLWMS.WinForms.Izvjestaji;

namespace DLWMS.WinForms.IBBrojIndeksa
{
    public partial class frmScanIspitaIBBrojIndeksa : Form
    {
        private KonekcijaNaBazu _db = DLWMSdb.Baza;
        private Student _student;
        public frmScanIspitaIBBrojIndeksa()
        {
            InitializeComponent();
        }

        public frmScanIspitaIBBrojIndeksa(Student noviStudent)
        {
            InitializeComponent();
            _student= noviStudent;
        }
        private void frmScanIspitaIBBrojIndeksa_Load(object sender, EventArgs e)
        {
            lblStudent.Text = _student.ImePrezime;
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            var ispiti = new List<StudentiIspitiScan>();

            foreach (var ispitiScan in _db.StudentiIspitiScan.ToList())
            {
                if (ispitiScan.Student==_student)
                {
                    ispiti.Add(ispitiScan); 
                }
            }

            dgvIspiti.DataSource = ispiti;

        }

        private void btnDodajScanIspita_Click(object sender, EventArgs e)
        {
            var dodajScan = new frmNoviScanIspitaIBBrojIndeksa(_student);
            Hide();
            dodajScan.ShowDialog();
            Show();
            UcitajPodatke();
        }

        private void dgvIspiti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex<0)
            {
                return;
            }

            var kolona = dgvIspiti.Columns[e.ColumnIndex];
            if (kolona is DataGridViewButtonColumn)
            {
                var red = dgvIspiti.Rows[e.RowIndex].DataBoundItem as StudentiIspitiScan;
                if (red != null)
                {
                    if (MessageBox.Show("Da li zelite obrisati ?","Brisi",MessageBoxButtons.YesNo)==DialogResult.Yes)
                    {
                        _db.StudentiIspitiScan.Remove(red);
                        _db.SaveChanges();
                    }
                }
                else
                {
                    MessageBox.Show("Nije bilo moguce obrisati", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }
            UcitajPodatke();
            /*
            var dgv = sender as DataGridView;

            if (dgv != null && e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (dgv.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                {
                    var red = dgv.Rows[e.RowIndex].DataBoundItem as StudentiIspitiScan;
                    if (red != null)
                    {
                        if (MessageBox.Show("Da li zelite obrisati?", "Brisi", MessageBoxButtons.YesNo) ==
                            DialogResult.Yes)
                        {
                            _db.StudentiIspitiScan.Remove(red);
                            _db.SaveChanges();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nije bilo moguce obrisati", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }

            UcitajPodatke();*/
        }

        private void dgvIspiti_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex<0)
            {
                return;
            }

            var pregledajScan = dgvIspiti.Rows[e.RowIndex].DataBoundItem as StudentiIspitiScan;
            Form scan = new frmNoviScanIspitaIBBrojIndeksa(pregledajScan);
            Hide();
            scan.ShowDialog();
            Show();
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            var scanIspita = dgvIspiti.DataSource as List<StudentiIspitiScan>;
            var izvjestaj = new frmIzvjestaji(scanIspita);
            Hide();
            izvjestaj.ShowDialog();
            Show();
        }
    }
}
