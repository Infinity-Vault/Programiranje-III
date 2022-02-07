using cSharpIntroWinForms.P10;
using cSharpIntroWinForms.P8;
using cSharpIntroWinForms.P9;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharpIntroWinForms
{
    public partial class KorisniciAdmin : Form
    {

        KonekcijaNaBazu konekcijaNaBazu = DLWMS.DB;

        public KorisniciAdmin()
        {
            InitializeComponent();
            dgvKorisnici.AutoGenerateColumns = false;
        }

        private void KorisniciAdmin_Load(object sender, EventArgs e)
        {
            LoadData();
            txtPretraga.Select();
        }

        private void LoadData(List<Korisnik> korisnici = null)
        {
            try
            {
                dgvKorisnici.DataSource = null;
                dgvKorisnici.DataSource = korisnici ?? konekcijaNaBazu.Korisnici.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.InnerException?.Message);
            }
        }

        private void dgvKorisnici_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadData();
        }
    }
}
