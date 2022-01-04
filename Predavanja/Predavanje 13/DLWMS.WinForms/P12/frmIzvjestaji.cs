using DLWMS.WinForms.P9;

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

namespace DLWMS.WinForms.P12
{
    public partial class frmIzvjestaji : Form
    {
        private dtoUvjerenjeOPolozenim dtoUjerenjeOPolozenim;

        public frmIzvjestaji()
        {
            InitializeComponent();
        }

        public frmIzvjestaji(dtoUvjerenjeOPolozenim dtoUjerenjeOPolozenim) : this()
        {
            this.dtoUjerenjeOPolozenim = dtoUjerenjeOPolozenim;
        }

        private void frmIzvjestaji_Load(object sender, EventArgs e)
        {
            var parameteri = new ReportParameterCollection();
            //parameteri.Add(new ReportParameter("Indeks", "IB150051"));
            //parameteri.Add(new ReportParameter("ImePrezime", "Denis Music"));

            parameteri.Add(new ReportParameter("Indeks", dtoUjerenjeOPolozenim.Indeks));
            parameteri.Add(new ReportParameter("ImePrezime", dtoUjerenjeOPolozenim.ImePrezime));


            //var tblPolozeni = new dsDLWMS.PolozeniPredmetiDataTable();
            var rand = new Random();
            float suma = 0;
            //for (int i = 0; i < 5; i++)
            //{
            //    var red = tblPolozeni.NewPolozeniPredmetiRow();
            //    var narednaOcjena = rand.Next(6, 10);
            //    red.Rb = i + 1;
            //    red.Naziv = $"Predmet {i + 1}";
            //    red.Ocjena = narednaOcjena;
            //    red.Datum = DateTime.Now.ToString("dd.MM.yyyy");
            //    tblPolozeni.AddPolozeniPredmetiRow(red);
            //    suma += narednaOcjena;
            //}
            //var tblPolozeni = new List<object>();
            //for (int i = 0; i < 5; i++)
            //{
            //    var narednaOcjena = rand.Next(6, 10);
            //    tblPolozeni.Add(new
            //    {
            //        Rb = i + 1,
            //        Naziv = $"Predmet {i + 1}",
            //        Ocjena = narednaOcjena,
            //        Datum = DateTime.Now.ToString("dd.MM.yyyy")

            //    });
            //    suma += narednaOcjena;
            //}
            var tblPolozeni = new List<object>();
            for (int i = 0; i < dtoUjerenjeOPolozenim.Polozeni.Count; i++)
            {
                var polozeni = dtoUjerenjeOPolozenim.Polozeni[i];
                tblPolozeni.Add(new
                {
                    Rb = i + 1,
                    Naziv = polozeni.Predmet.Naziv,
                    Ocjena = polozeni.Ocjena,
                    Datum = polozeni.DatumPolaganja.ToString("dd.MM.yyyy")

                });
                suma += polozeni.Ocjena;
            }

            parameteri.Add(new ReportParameter("BrojPolozenih", tblPolozeni.Count.ToString()));
            parameteri.Add(new ReportParameter("ProsjecnaOcjena", (suma/tblPolozeni.Count).ToString()));


            ReportDataSource dataSource = new ReportDataSource();
            dataSource.Name = "dsPolozeni";
            dataSource.Value = tblPolozeni;

            this.reportViewer1.LocalReport.DataSources.Add(dataSource);
            this.reportViewer1.LocalReport.SetParameters(parameteri);
            this.reportViewer1.RefreshReport();
        }
    }
}
