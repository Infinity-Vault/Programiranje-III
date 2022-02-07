using Microsoft.Reporting.WinForms;
using System.Windows.Forms;

namespace DLWMS.WinForms.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {

        public frmIzvjestaji()
        {
            InitializeComponent();
        }            
     
        private void frmIzvjestaji_Load(object sender, System.EventArgs e)
        {

            var rpc = new ReportParameterCollection();
            var rds = new ReportDataSource();



            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.SetParameters(rpc);
            this.reportViewer1.RefreshReport();
        }
    }
}
