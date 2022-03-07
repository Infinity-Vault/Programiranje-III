using System.Collections.Generic;
using Microsoft.Reporting.WinForms;
using System.Windows.Forms;
using DLWMS.WinForms.IBBrojIndeksa;

namespace DLWMS.WinForms.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {
        private List<StudentiCovidTestovi> _lista = new List<StudentiCovidTestovi>();
        public frmIzvjestaji()
        {
            InitializeComponent();
        }

        public frmIzvjestaji(List<StudentiCovidTestovi> lista)
        {
            InitializeComponent();
            _lista=lista;
        }

        private void frmIzvjestaji_Load(object sender, System.EventArgs e)
        {

            var rpc = new ReportParameterCollection();
            var rds = new ReportDataSource();

            int brojac = 1;

            var tblTest = new dsTest.TestDataTable();

            foreach (var s in _lista)
            {
                var row = tblTest.NewTestRow();
                row.Rb = s.Id.ToString();
                row.Student = s.Student.ToString();
                row.Datum = s.Datum.ToString();
                row.Rezultat=s.Rezultat.ToString();
                row.NalazDostavljen = s.NalazDostavljen ? "Da" : "Ne";
                tblTest.AddTestRow(row);
            }

            rds.Name = "Test";
            rds.Value = tblTest;

            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.SetParameters(rpc);
            this.reportViewer1.RefreshReport();
        }
    }
}
