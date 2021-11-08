using System;
using System.Windows.Forms;
using StudentService.DateBase;
using StudentService.Entities;
using StudentService.Helpers;

namespace StudentService
{
    public partial class FrmRegistrujPredmet : Form
    {
        public FrmRegistrujPredmet()
        {
            InitializeComponent();
        }

        //Metoda koja ce da doda predmet:
        private void btnDodajPredmet_Click(object sender, EventArgs e)
        {
            if (ValidirajUnos(txtBoxIdProfesora,txtBoxNaziv, txtBoxSemestar))
            {
                foreach (var profesor in InMemoryDataBase.ProfessorRepo.GetAll())//Za svakog profesora;GetAll vrati listu profesora;
                {
                    if (int.Parse(txtBoxIdProfesora.Text) == profesor.Id)//ako je id podudaran, tom profesoru treba dodati predmet;
                    {
                        var predmet = new Predmet()//Kreiramo predmet sa pokupljenim vrijednostima;
                        {
                            Id=InMemoryDataBase.PredmetRepo.IdGenerator++,
                            NazivPredmeta = txtBoxNaziv.Text,
                            Semestar = int.Parse(txtBoxSemestar.Text)
                        };
                        var tempProfesor=InMemoryDataBase.ProfessorRepo.GetById(int.Parse(txtBoxIdProfesora.Text));//Uzmemo profesora sa podudarnim id;
                        tempProfesor.Predmeti.Add(predmet);//Dodamo predmet profesoru;
                        InMemoryDataBase.PredmetRepo.Insert(predmet);//Dodamo predmet u bazu predmeta;
                        MessageBox.Show($"Uspjesno ste dodali predmet {predmet.NazivPredmeta} profesoru {tempProfesor.ImePrezime}");//Obavjestimo korisnika;
                        this.Close();//Zatvorimo formu dodavanja predmeta;
                        return;//Zaustavimo izvrsavanje for each jer je nadjen jedan profesor sa tim id-em;
                    }
                }
            }
        }

        //Metoda za validaciju:
        private bool ValidirajUnos(Control prva, Control druga,Control treca)
        {
            return Validator.ValidateNumberField(prva, errorDodajPredmet, Poruke.IdNeSmijeBitiNula)
                   && Validator.ValidateTextField(druga, errorDodajPredmet, Poruke.OvoPoljeJeObavezno)
                   && Validator.ValidateNumberField(treca, errorDodajPredmet, Poruke.SemestarNeSmijeBitiNula);
        }
    }
}
