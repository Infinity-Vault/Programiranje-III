using System;
using System.Linq;
using System.Windows.Forms;
using DataBase;
using Klase;

namespace Predavanje9__07._12._2021._
{
    public partial class frmPogledajPredmete : Form
    {
        private Student student;//Kreiramo lokalni field za studenta;
        public frmPogledajPredmete(Student student)
        {

            InitializeComponent();
            this.student = student;//Prekopiramo vrijednost poslatog studenta;
            UcitajPredmete();
            dgvPolozeniPredmeti.AutoGenerateColumns=false;
            UcitajPolozenePredmete();
        }
        //Metoda koja ce da ucita u comboBox  dostupne predmete;
        private void UcitajPredmete()
        {
            cmbPredmeti.DataSource = InMemoryDataBase.Predmeti;
            cmbPredmeti.DisplayMember = "Naziv";
            cmbPredmeti.ValueMember = "Id";
        }

        //Metoda koja ucita polozene predmete od datog studenta:
        private void UcitajPolozenePredmete()
        {
            dgvPolozeniPredmeti.DataSource=null;
            dgvPolozeniPredmeti.DataSource = student.PolozeniPredmeti;
        }

        //Metoda koja ce da doda predmete trenutnom studentu:
        private void btnDodajPredmet_Click(object sender, EventArgs e)
        {
            var predmetPostoji = CheckIfPostoji();
            if (!predmetPostoji)//Ako predmet postoji;
                MessageBox.Show("Predmet vec postoji!");
            else
            {
                if (ValidirajUnos())
                {
                    //Kreiramo novi polozeni predmet;
                    var predmet = new PolozeniPredmet()
                    {
                        Id = InMemoryDataBase.PolozeniPredmeti.Count + 1,
                        Ocjena = int.Parse(cmbOcjene.SelectedItem.ToString()),
                        DatumPolaganja = dtpPolaganje.Value,
                        Predmet = cmbPredmeti.SelectedItem as Predmet//Preuzmemo predmet;
                    };
                    InMemoryDataBase.PolozeniPredmeti.Add(predmet);//Dodamo u bazu;
                    student.PolozeniPredmeti.Add(predmet);//Dodamo studentu;
                    UcitajPolozenePredmete();//Osvjezimo prikazane predmete;
                }
            }
        }

        //Metoda koja ce da provjeri da li postoji dati predmet:
        private bool CheckIfPostoji()
        {
            //Preuzmemo trenutni predmet;
            var trenutniPredmet = cmbPredmeti.SelectedItem as Predmet;
            //Sa anonimnom metodom prodjemo kroz sve predmete i kreiramo novu listu predmeta ciji se id podudara, te ako je broj elemenata te liste jednak nuli vrati true (predmet nije vec dodan) a ako nije vrati false (taj predmet vec postoji);
            return student.PolozeniPredmeti.Where(predmet => predmet.Predmet.Id == trenutniPredmet.Id).Count()==0;
        }

        //Metoda koja ce da validira unos:
        private bool ValidirajUnos()
        {
            return Validator.Validate(cmbOcjene, errorPolozeniPredmeti, "Unos je obavezan!")
                   && Validator.Validate(cmbPredmeti, errorPolozeniPredmeti, "Unos je obavezan!");
            //DateTime je vec validan;
        }
    }
}
