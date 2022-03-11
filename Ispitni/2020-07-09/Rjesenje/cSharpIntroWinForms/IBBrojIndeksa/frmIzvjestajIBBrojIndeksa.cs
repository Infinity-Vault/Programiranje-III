using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cSharpIntroWinForms.P10;
using cSharpIntroWinForms.P9;
using Microsoft.Reporting.WinForms;

namespace cSharpIntroWinForms.IBBrojIndeksa
{
    public partial class frmIzvjestajIBBrojIndeksa : Form
    {
        private KonekcijaNaBazu _db = DLWMS.DB;
        private List<Korisnik> _korisnik = new List<Korisnik>();
        public frmIzvjestajIBBrojIndeksa()
        {
            InitializeComponent();
        }
        public frmIzvjestajIBBrojIndeksa(List<Korisnik>korisnik)
        {
            InitializeComponent();
            _korisnik = korisnik;
        }
        private void frmIzvjestajIBBrojIndeksa_Load(object sender, EventArgs e)
        {
            var rpc = new ReportParameterCollection();
            var rds = new ReportDataSource();

            var tblIzvjestaj = new dsIzvjestaj.IzvjestajDataTable();

            foreach (var k in _korisnik)
            {
                var red = tblIzvjestaj.NewIzvjestajRow();
                red.Ime = k.Ime.ToString();
                red.Prezime=k.Prezime.ToString();
                red.Spol=k.Spol.ToString();
                red.KorisnickoIme=k.KorisnickoIme.ToString();
                red.Administrator = k.Admin ? "Da" : "Ne";
                tblIzvjestaj.AddIzvjestajRow(red);
            }

            rds.Name = "Izvjestaj";
            rds.Value = tblIzvjestaj;

            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.SetParameters(rpc);


            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
