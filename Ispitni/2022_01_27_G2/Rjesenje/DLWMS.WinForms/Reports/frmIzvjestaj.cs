using DLWMS.WinForms.IBBrojIndeksa;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.Reports
{
    public partial class frmIzvjestaj : Form
    {
        private List<StudentiPredmeti> listaIzvjestaja = new List<StudentiPredmeti>();
        public frmIzvjestaj()
        {
            InitializeComponent();
        }
        public frmIzvjestaj(List<StudentiPredmeti>noviIzvjestaj)
        {
            InitializeComponent();
            listaIzvjestaja = noviIzvjestaj;
        }
        private void frmIzvjestaj_Load(object sender, EventArgs e)
        {
            var rpc = new ReportParameterCollection();
            var rds = new ReportDataSource();
            var tbl = new dsPredemti.PredmetiDataTable();

            foreach(var rep in listaIzvjestaja)
            {
                var row = tbl.NewPredmetiRow();
                row.Rb = rep.Id.ToString();
                row.Ime_Prezime = rep.Student.ToString();
                row.Predmet = rep.Predmet.ToString();
                row.Datum = rep.DatumPolaganja.ToString();
                row.Ocjena = rep.ocjena.ToString();
                tbl.AddPredmetiRow(row);
            }
            double prosjek = listaIzvjestaja.Average(o => o.ocjena);
            string polozeno = $"Ukupno polozeno {listaIzvjestaja.Count} predmeta, a prosjecna ocjena je {prosjek}";
            rpc.Add(new ReportParameter("polozenoProsjek", polozeno));

            rds.Name = "Predmeti";
            rds.Value = tbl;

            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.SetParameters(rpc);
            this.reportViewer1.RefreshReport();
        }
    }
}
