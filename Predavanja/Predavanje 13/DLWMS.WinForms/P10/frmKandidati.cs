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

namespace DLWMS.WinForms.P10
{
    public partial class frmKandidati : Form
    {

        /*
         ORM         
         */
        public frmKandidati()
        {
            InitializeComponent();
        }

        private void frmKandidati_Load(object sender, EventArgs e)
        {
            UcitajKandidate();
        }

        private void UcitajKandidate()
        {
            try
            {
                KonekcijaNaBazu db = new KonekcijaNaBazu();
                dgvKandidati.DataSource = db.Kandidati.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}{Environment.NewLine}" +
                    $" {ex.InnerException?.Message}");
            }
            
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                KonekcijaNaBazu db = new KonekcijaNaBazu();

                var kandidat = new Kandidat()
                {
                    Email = txtEmail.Text,
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text
                };
                db.Kandidati.Add(kandidat);
                db.SaveChanges();

                UcitajKandidate();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}{Environment.NewLine}" +
                    $" {ex.InnerException?.Message}");
            }
        }
    }

}
