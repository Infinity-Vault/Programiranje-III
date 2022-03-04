using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace cSharpIntroWinForms.IBBrojIndeksa
{
    public partial class frmIzvjestajIBBrojIndeksa : Form
    {
        private List<KorisniciPoruke> listaPoruka = new List<KorisniciPoruke>();
        
        public frmIzvjestajIBBrojIndeksa()
        {
            InitializeComponent();
        }
        public frmIzvjestajIBBrojIndeksa(List<KorisniciPoruke>lista)
        {
            InitializeComponent();
            listaPoruka=lista;
        }

        private void frmIzvjestajIBBrojIndeksa_Load(object sender, EventArgs e)
        {
            var rpc = new ReportParameterCollection();
            var rds = new ReportDataSource();

            var primalac = $" Poruke za korisnika:  {listaPoruka[0].Primaoc}";
            rpc.Add(new ReportParameter("KorisnikPoruka", primalac));

            var tblPoruke = new dsPoruke.PorukeDataTable();
            foreach (var p in listaPoruka)
            {
                var row = tblPoruke.NewPorukeRow();
                row.Id = p.Id.ToString();
                row.DatumSlanja = p.DatumVrijeme.ToString();
                row.Sadrzaj = p.SadrzajPoruke.ToString();
               // row.Slika = p.Slika;
                tblPoruke.AddPorukeRow(row);
            }
            rds.Name = "Poruke";
            rds.Value = tblPoruke;

            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.SetParameters(rpc);
            this.reportViewer1.RefreshReport();
        }
    }
}
