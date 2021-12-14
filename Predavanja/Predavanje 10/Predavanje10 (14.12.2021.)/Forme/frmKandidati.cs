using DB;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Forme
{
    public partial class frmKandidati : Form
    {
        //Kreiramo privatni field koji cemo koristiti za pristup bazi podataka:
        private KonekcijaNaBazu _db=new KonekcijaNaBazu();
        public frmKandidati()
        {
            InitializeComponent();
            dgvKandidati.AutoGenerateColumns=false;//Kako ne bi generisao sve kolone iz izvora po automatizmu;
        }

        //Metoda koja se izvrsava na samo ucitavanje forme:
        private void frmKandidati_Load(object sender, EventArgs e)
        {
            UcitajKandidate();
        }

        private void UcitajKandidate()
        {
            //Dio koda gdje komuniciramo sa bazom bi uvijek trebali stavljati u try catch blok radi potencijalnih Exceptiona;
            try
            {
                dgvKandidati.DataSource=null;
                dgvKandidati.DataSource=_db.Kandidati.ToList();//Uzmemo tabelu iz baze podataka i pretvorimo sve trenutne podatke u njoj u listu,koja ce se poslije prikazati u dgv;
            }
            catch (Exception ex)
            {
                //Ispisemo u cemu je problem (zasto program puca);
                //Property InnerException sluzi da bi dobili detaljnjiji uvid u uzrok Exceptiona koji smo upravo dobili;
                MessageBox.Show($"{ex.Message+Environment.NewLine}{ex.InnerException?.Message}");//Upitamo da li je InnerException null i samo ako nije iscitavamo ga;Inace pada i ovdje program jer pristupamo null propertiju i pokusavamo ga citati;
            }
        }
    }
}
