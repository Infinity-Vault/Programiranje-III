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
        private List<StudentiPredmeti> listaP = new List<StudentiPredmeti>();
        public frmIzvjestaj()
        {
            InitializeComponent();
        }
        public frmIzvjestaj(List<StudentiPredmeti>lista)
        {
            InitializeComponent();
            listaP = lista;
        }
        private void frmIzvjestaj_Load(object sender, EventArgs e)
        {
            var rpc = new ReportParameterCollection();
            var rds = new ReportDataSource();
           var prosjecna = $"Prosjecna ocjena: {listaP.Average(o=>o.Ocjena).ToString()}";
            rpc.Add(new ReportParameter("prmProsjecna", prosjecna));
            var tblPredmeti = new dsPredmeti.PredmetiDataTable();

            foreach (var sP in listaP)
            {
                var row = tblPredmeti.NewPredmetiRow();
                row.Student = sP.Student.ToString();
                row.Predmet = sP.Predmet.ToString();
                row.Datum = sP.DatumPolaganja.ToString();
                row.Ocjena = sP.Ocjena.ToString();
                tblPredmeti.AddPredmetiRow(row);
            }
            rds.Name = "dsPredmeti";
            rds.Value = tblPredmeti;

            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.SetParameters(rpc);
           ;
            this.reportViewer1.RefreshReport();
        }
        
    }
}
