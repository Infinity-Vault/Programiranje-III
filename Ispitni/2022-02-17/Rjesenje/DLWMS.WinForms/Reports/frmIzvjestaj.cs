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
using DLWMS.WinForms.Helpers;
using DLWMS.WinForms.IBBrojIndeksa;

namespace DLWMS.WinForms.Reports
{
    public partial class frmIzvjestaj : Form
    {
        private List<StudentiKonsultacije> listaKonsultacija = new List<StudentiKonsultacije>();
        public frmIzvjestaj()
        {
            InitializeComponent();
        }

        public frmIzvjestaj(List<StudentiKonsultacije>lista)
        {
            InitializeComponent();
            listaKonsultacija = lista;
        }

        private void frmIzvjestaj_Load(object sender, EventArgs e)
        {
            var rpc = new ReportParameterCollection();
            var rds = new ReportDataSource();//Koristimo za dodavanje jednog ili vise potrebnih izvora podataka u lokalni izvjestaj

            var brojKonsultacija = $"Ukupno evidentirano {listaKonsultacija.Count} zahtjeva za konsultacijama";
            rpc.Add(new ReportParameter("rptUkupno",brojKonsultacija));

            var student = $" za studenta {listaKonsultacija[0].Student}";
            rpc.Add(new ReportParameter("rptStudent",student));

            var tblKonsultacije = new dsKonsultacije.KonsultacijeDataTable();

            foreach (var konsultacijskaLista in listaKonsultacija)
            {
                var row = tblKonsultacije.NewKonsultacijeRow();
                row.Rb = konsultacijskaLista.Id.ToString();
                row.Predmet = konsultacijskaLista.Predmet.ToString();
                row.Vrijeme = konsultacijskaLista.VrijemeOdrzavanja.ToString();
                row.Napomena = konsultacijskaLista.Napomena;
                tblKonsultacije.AddKonsultacijeRow(row);
            }

            rds.Name = "Konsultacije";
            rds.Value = tblKonsultacije;

            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.SetParameters(rpc);

            this.reportViewer1.RefreshReport();
        }
    }
}
