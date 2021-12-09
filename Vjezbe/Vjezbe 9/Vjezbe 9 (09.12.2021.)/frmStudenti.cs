using DataBase;
using Klase;
using System;
using System.Windows.Forms;

namespace Vjezbe_9__09._12._2021._
{
    public partial class frmStudenti : Form
    {
        public frmStudenti()
        {
            InitializeComponent();
            //dgvStudenti.AutoGenerateColumns=false;//Kako ne bi generisala sve kolone iz izvora koje postoje;
            UcitajStudente();
        }

        private void UcitajStudente()
        {
            dgvStudenti.DataSource=null;
            dgvStudenti.DataSource=InMemoryDB.Studenti;
        }

        private void btnDodajStudenta_Click(object sender, EventArgs e)
        {
            var dodajForma=new frmDodajStudenta();
            if(dodajForma.ShowDialog()==DialogResult.OK)
                UcitajStudente();//Osvjezimo grid studenata;
        }

        //Metoda koja ce da pokrene formu koja dodaje predmete u bazu podataka:
        private void dodajPredmetToolStripMenuItem_Click(object sender, EventArgs e)=>new fmrDodajPredmetUDB().ShowDialog();//Expression body;

        //Metoda koja ce da studentu na odredjenoj godini dodijeli odredjeni predmet sa te godine:
        private void dodijeliPredmetStudentuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var student in InMemoryDB.Studenti)//Prodjemo kroz sve studente;
            {
                foreach (var predmet in InMemoryDB.Predmeti)//Prodjemo kroz sve predmete;
                {
                    if (!student.Predmeti.Exists(postojeci => postojeci.Naziv == predmet.Naziv))//Samo ako trenutni predemt za dodavanje ne postoji vec u predmetima tog studenta;
                    {
                        //Dodaj taj predmet tom studentu ako su godine i tog predmeta i tog studenta iste:
                        if(student.Godina==predmet.Godina)
                            student.Predmeti.Add(predmet);
                    }
                }
            }
        }
        private void dgvStudenti_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var student = dgvStudenti.SelectedRows[0].DataBoundItem as Student;//Preuzmemo studenta na kojeg se kliknulo;

            dgvPredmetiStudenta.DataSource = null;
            dgvPredmetiStudenta.DataSource = student.Predmeti;//Postavimo izvor na listu predmeta koje odabrani student ima;
        }
    }
}
