using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Predavanje7.DataBase;
using Predavanje7.Klase;

namespace Predavanje7
{
    public partial class frmStudenti : Form
    {
        public frmStudenti()
        {
            InitializeComponent();
            dgvStudenti.AutoGenerateColumns=false;//Kako ne bi imali automatski sve kolone koje imamo u listi vec samo one koje mi zelimo;
        }

        //Metoda koja se izvrsi kada  se ova forma ucita:
        private void frmStudenti_Load(object sender, EventArgs e)
        {
            UcitajGridStudenata();
        }

        //Metoda koja ucita podatke u nas data grid;
        private void UcitajGridStudenata()
        {
            dgvStudenti.DataSource=null;//Prije ucitavanja nulliramo prijasnji izvor;
            dgvStudenti.DataSource = InMemoryDatabase.RepoStudenti.Baza;//Damo izvor tj nasu listu studenata;
        }

        //Metoda koja ce se pokrenuti kada se klikne dugme dodaj novog studenta;
        private void btnDodajStudenta_Click(object sender, EventArgs e)
        {
            var forma = new frmDodajStudenta();
           //forma.ShowDialog();
           //UcitajGridStudenata();//Kako bi se ponovno refresh grid;
           //Ili ovako:

           if (forma.ShowDialog() == DialogResult.OK)//Posto mi namjerno izadjemo sa OK iz ove forme;
               UcitajGridStudenata();//Mozemo samo tada refreshovati studente;
        }

        //Metoda koja filtrira bazu:
        private void btnFiltriraj_Click(object sender, EventArgs e)
        {
            var filter = txtBoxFilter.Text;//Preuzmemo string;
            var results = new List<Student>();//Napravimo novu filtriranu listu;

            foreach (var student in InMemoryDatabase.RepoStudenti.Baza)
            {
                if (student.Ime.Contains(filter) || student.Prezime.Contains(filter))
                    //Provjeravamo da li je u imenu ili prezimenu sadrzan text iz naseg filtera;
                    results.Add(student);
            }
            dgvStudenti.DataSource = results;//Osvjezimo listu sa rezultatima;
        }

        //Metoda koja treba da edituje studenta (red) jer je jedan red jedan student, na kojeg se dva puta kliknulo;
        private void dgvStudenti_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var student=dgvStudenti.SelectedRows[0].DataBoundItem as Student;//Castamo red na koji se kliknulo is dgv kao studenta, da bi se dole mogao poslati u ctor;

            if (student != null)//Kako bi izbjegli null reference exception ako je taj student prazan;
            {
                //Kreiramo formu isto kao i kad kreiramo novog studenta samo sto se sad u ctor salje student na kojem se trebaju promjene izvrsiti;
                var forma = new frmDodajStudenta(student);
                if (forma.ShowDialog() == DialogResult.OK)//Ponovno cemo eksplicitno navesti da se forma zavrsi sa OK;
                    UcitajGridStudenata();//Refreshamo grid;
            }
        }
    }
}
