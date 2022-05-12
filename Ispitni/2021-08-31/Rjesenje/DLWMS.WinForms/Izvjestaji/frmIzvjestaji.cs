using System.Collections.Generic;
using System.Linq;
using Microsoft.Reporting.WinForms;
using System.Windows.Forms;
using DLWMS.WinForms.Helpers;
using DLWMS.WinForms.IBBrojIndeksa;

namespace DLWMS.WinForms.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {
        private List<StudentiIspitiScan> listaScans;
        public frmIzvjestaji()
        {
            InitializeComponent();
        }
        public frmIzvjestaji(List<StudentiIspitiScan> ispit)
        {
            InitializeComponent();
            listaScans = ispit;
        }
        private void frmIzvjestaji_Load(object sender, System.EventArgs e)
        {

            var rpc = new ReportParameterCollection();
            var rds = new ReportDataSource();

            var izjestaj = new dsIzvjestaj.IzvjestajDataTable();
            for (int i=0;i<listaScans.Count;i++)
            {
                var red = izjestaj.NewIzvjestajRow();
                red.Predmet=listaScans[i].Predmet.ToString();
                red.Napomena= listaScans[i].Napomena.ToString();
                red.Varanje = listaScans[i].Varanje == true ? "Da" : "Ne";
                izjestaj.Rows.Add(red);
            }

            rds.Name = "Izvjestaj";
            rds.Value = izjestaj;

            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.SetParameters(rpc);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, System.EventArgs e)
        {

        }
    }
}
