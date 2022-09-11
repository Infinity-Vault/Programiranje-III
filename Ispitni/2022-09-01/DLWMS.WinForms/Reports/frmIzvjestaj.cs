using DLWMS.WinForms.DB;
using DLWMS.WinForms.IB200290;
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
        KonekcijaNaBazu bp = DLWMSdb.Baza;
        private Student odabraniStudent;

        public frmIzvjestaj()
        {
            InitializeComponent();
        }

        public frmIzvjestaj(Student odabraniStudent) : this()
        {
            this.odabraniStudent = odabraniStudent;
        }

        private void frmIzvjestaj_Load(object sender, EventArgs e)
        {         
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            var odabranaBaza = bp.StudentiPoruke.Where(x => x.Student.Id == odabraniStudent.Id);
            var Tabela = new DSIzvjestaj.AtributiDataTable();
            foreach (var sp in odabranaBaza)
            {
                var red = Tabela.NewAtributiRow();
                red.Predmet = sp.Predmet.ToString();
                red.Vrijeme = sp.VrijemeKreiranja.Date.ToString();
                red.Sadrzaj = sp.Sadrzaj.ToString();
                red.BrojZnakova = sp.Sadrzaj.Length.ToString();
                red.PosjedujeSliku = (sp.Slika != null ? "DA" : "NE");
                Tabela.AddAtributiRow(red);
            }
            //
            var parametar = new ReportParameterCollection();
            parametar.Add(new ReportParameter("rptStudent", odabraniStudent.ToString()));
            parametar.Add(new ReportParameter("rptUkupno", odabranaBaza.Count().ToString()));
            reportViewer1.LocalReport.SetParameters(parametar);
            //
            var reportDataSource = new ReportDataSource();
            reportDataSource.Name = "infoTabela";
            reportDataSource.Value = Tabela;
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
        }
    }
}