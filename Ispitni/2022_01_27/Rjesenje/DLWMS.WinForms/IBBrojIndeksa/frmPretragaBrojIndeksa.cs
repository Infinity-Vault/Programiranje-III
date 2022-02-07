using DLWMS.WinForms.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DLWMS.WinForms.Reports;

namespace DLWMS.WinForms.IBBrojIndeksa
{
    public partial class frmPretragaBrojIndeksa : Form
    {
        private KonekcijaNaBazu _db = DLWMSdb.Baza;
        public frmPretragaBrojIndeksa()
        {
            InitializeComponent();
        }
        private void frmPretragaBrojIndeksa_Load(object sender, EventArgs e)
        {
            dgvPredmet.AutoGenerateColumns = false;
          
            UcitajPredmete();
        }
        private void UcitajPredmete(List<StudentiPredmeti>lista =null)
        {
            if(lista==null || lista.Count==0)
            {

            dgvPredmet.DataSource = _db.StudentiPredmeti.ToList();
                this.Text = $"Ukupno zapisa: {_db.StudentiPredmeti.ToList().Count.ToString()}";
            }
            else
            {
                dgvPredmet.DataSource = lista;
                this.Text = $"Ukupno zapisa: {lista.Count}";
            }
        }

        private void txtPredmet_TextChanged(object sender, EventArgs e)
        {
            string filter = txtPredmet.Text.ToLower();

           
            List<StudentiPredmeti> listaPredmeta = new List<StudentiPredmeti>();

            listaPredmeta=_db.StudentiPredmeti.Where(s => s.Predmet.Naziv.ToLower().Contains(filter)).ToList();

            UcitajPredmete(listaPredmeta);
        }

        private void dgvPredmet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex<0)
            {
                return;
            }
           var col= dgvPredmet.Columns[e.ColumnIndex];
            if(col is DataGridViewButtonColumn)
            {
                var item = dgvPredmet.Rows[e.RowIndex].DataBoundItem as StudentiPredmeti;
                if(col.HeaderText=="Brisi Predmet")
                {
                    if (MessageBox.Show("Da li zelite izbrisai record ?","Brisanje",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
                    {
                    //var item = dgvPredmet.Rows[e.RowIndex].DataBoundItem as StudentiPredmeti;
                    _db.StudentiPredmeti.Remove(item);

                    }
                }
                else
                {
                    Form studentiSlikeForm = new frmStudentiSlike(item.Student);
                    Hide();
                    studentiSlikeForm.ShowDialog();
                    Show();
                }
            }
            _db.SaveChanges();
            UcitajPredmete();
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            Form izvjeztaj = new frmIzvjestaj(_db.StudentiPredmeti.ToList());
            Hide();
            izvjeztaj.ShowDialog();
            Show();
        }

        private void btnTeorija_Click(object sender, EventArgs e)
        {
            Form teorija = new frmTerorijaIBBrojIndeksa();
            teorija.ShowDialog();
        }

        private async void btnSuma_Click(object sender, EventArgs e)
        {
            int Od = int.Parse(txtOD.Text);
            int Do = int.Parse(txtDO.Text);
            double suma = 0;
            await Task.Run(() =>
            {
                for (int i = Od; i <= Do; i++)
                {
                    suma += i;
                }

            });

            Action akcija =()=>txtSuma.Text = suma.ToString();
            BeginInvoke(akcija);
        }
    }
}
