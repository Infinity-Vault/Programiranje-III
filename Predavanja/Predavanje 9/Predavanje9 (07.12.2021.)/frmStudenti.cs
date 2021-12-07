using System;
using System.Windows.Forms;
using DataBase;
using Klase;

namespace Predavanje9__07._12._2021._
{
    public partial class Studenti : Form
    {
        public Studenti()
        {
            InitializeComponent();
        }

        //Metoda koja se izvrsava na load forme:
        private void Studenti_Load(object sender, EventArgs e)
        {
            dgvStudenti.AutoGenerateColumns=false;
            ucitajStudente();
        }
        //Metoda koja ucita grid studenata:
        private void ucitajStudente()
        {
            dgvStudenti.DataSource=null;
            dgvStudenti.DataSource = InMemoryDataBase.Studenti;
        }

        private void btnDodajStudenta_Click(object sender, EventArgs e)
        {
            var dodajStudenta = new frmDodajStudenta();//Dflt ctor, poziv kada kreiramo novog studenta;
            if (dodajStudenta.ShowDialog() == DialogResult.OK)
                ucitajStudente();//Osvjezimo grid kako bi se vidjeli novi studenti;
        }

        private void dgvStudenti_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var student=dgvStudenti.SelectedRows[0].DataBoundItem as Student;
            Form forma=null;//Kreiramo null formu;

            if (student != null)
            {
                if (dgvStudenti.CurrentCell is DataGridViewButtonCell) //Ako je trenutno kliknuta celija nas dugmic
                {
                    forma = new frmPogledajPredmete(student);//Pokreni formu za pregled ocjena;
                    forma.ShowDialog();
                }
                else//Inace, pokreni formu za editovanje studenta;
                {
                    forma= new frmDodajStudenta(student);
                    if (forma.ShowDialog() == DialogResult.OK)
                        ucitajStudente();//Osvjezimo grid;
                }
            }
        }
    }
}
