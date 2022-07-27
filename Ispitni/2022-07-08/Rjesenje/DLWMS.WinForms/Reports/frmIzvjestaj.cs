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
        private dtoIzvjestaj dtoIzvjestaj;

        public frmIzvjestaj()
        {
            InitializeComponent();
        }

        public frmIzvjestaj(dtoIzvjestaj dtoIzvjestaj):this()
        {
            this.dtoIzvjestaj = dtoIzvjestaj;
        }

        private void frmIzvjestaj_Load(object sender, EventArgs e)
        {
            var parametar = new ReportParameterCollection();
            parametar.Add(new ReportParameter("Student",dtoIzvjestaj.ImePrezime));

            var tblIzvjestaj = new dsIzvjestaj.IzvjestajDataTable();
            foreach (var sk in dtoIzvjestaj.StudentKonsultacije)
            {
                var red = tblIzvjestaj.NewIzvjestajRow();
                red.Rb = sk.Id.ToString();
                red.Predmet = sk.Predmet.ToString();
                red.Vrijeme = sk.VrijemeOdrzavanja.ToString();
                red.Napomena=sk.Napomena.ToString();
                tblIzvjestaj.AddIzvjestajRow(red);
            }

            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "Izvjestaj";
            reportDataSource.Value = tblIzvjestaj;

            parametar.Add(new ReportParameter("brojZahtjeva",dtoIzvjestaj.StudentKonsultacije.Count.ToString()));

            this.reportViewer1.LocalReport.SetParameters(parametar);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);

            this.reportViewer1.RefreshReport();
        }
    }
}
