using System.Collections.Generic;
using Microsoft.Reporting.WinForms;
using System.Windows.Forms;
using DLWMS.WinForms.IspitIB123456.Entiteti;

namespace DLWMS.WinForms.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {

        #region Forma
        private dtoPrintajIB123456 Print;
        public frmIzvjestaji(dtoPrintajIB123456 print = null)
        {
            InitializeComponent();
            this.Print = print;
        }
        #endregion
        #region Pravljenje izvjestaja:
        private void frmIzvjestaji_Load(object sender, System.EventArgs e)
        {

            var rpc = new ReportParameterCollection();
            var rds = new ReportDataSource();

            var tbl = new List<object>();

            for (int i = 0; i < Print.Studenti.Count; i++)
            {
                tbl.Add(new
                {
                    Rb=Print.Studenti[i].Id,
                    Indeks=Print.Studenti[i].Indeks,
                    Ime=Print.Studenti[i].Ime,
                    Prezime=Print.Studenti[i].Prezime,
                    Spol=Print.Studenti[i].Spol,
                    Godina=Print.Studenti[i].GodinaStudija,
                    Aktivan=Print.Studenti[i].Aktivan?"Da":"Ne"
                });
            }

            rds.Name = "dsPrintaj";
            rds.Value=tbl;

            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.SetParameters(rpc);
            this.reportViewer1.RefreshReport();
        }
        #endregion
    }
}
