using System;
using System.Windows.Forms;
using StudentService.DateBase;
using StudentService.Entities;
using StudentService.Helpers;

namespace StudentService
{
    public partial class FrmRegistrujProfesora : Form
    {
        public FrmRegistrujProfesora()
        {
            InitializeComponent();
        }

        //Metoda koja ce dodati Profesora:
        private void btnRegistrujProfesora_Click(object sender, EventArgs e)
        {
            if(ValidirajUnosNumber(txtBoxIme,txtBoxPrezime,txtBoxSemestar)&& ValidirajUnos(txtBoxKorisnickoIme,txtBoxLozinka))
            {
                var profesor = new Professor()//kreiramo novog profesora sa podacima pokupljenim iz forme;
                {
                    Id=InMemoryDataBase.ProfessorRepo.IdGenerator++,
                    Ime = txtBoxIme.Text,
                    Prezime = txtBoxPrezime.Text,
                    Semestar = int.Parse(txtBoxSemestar.Text),
                    KorisnickoIme = txtBoxKorisnickoIme.Text,
                    Lozinka = txtBoxLozinka.Text,
                    Rodjen = dtPickerDatumRodjenja.Value,
                };
                var predmet=new Predmet();//Kreiramo prazan predmet;
                if (ValidirajUnosPredmeta(txtBoxNaziv,
                    txtBoxSemestarPredmet)) //Ako je unos validan preuzmemo obiljezja;
                {
                    InMemoryDataBase.PredmetRepo.IdGenerator++;
                    predmet.NazivPredmeta = txtBoxNaziv.Text;
                    predmet.Semestar = int.Parse(txtBoxSemestarPredmet.Text);
                }
                else return;//Ako je greska u unosu predmeta stopiramo ovdje kako korisnik ne bi bio dodan sa ne validnim predmetom;
                profesor.Predmeti.Add(predmet);//Dodamo profesoru predmet;
                InMemoryDataBase.ProfessorRepo.Insert(profesor);//Dodamo profesora u bazu;
                InMemoryDataBase.PredmetRepo.Insert(predmet);//Dodamo predmet u bazu predmeta;
                MessageBox.Show($"{profesor.ImePrezime} je registrovan uspjesno!");//Obavijestimo korisnika;
            }
        }
        //Metoda za validaciju predmeta:
        private bool ValidirajUnosPredmeta(Control prva, Control druga)
        {
            return Validator.ValidateTextField(prva, errorRegistrujProfesora, Poruke.OvoPoljeJeObavezno)
                   && Validator.ValidateNumberField(druga, errorRegistrujProfesora, Poruke.SemestarNeSmijeBitiNula);
        }
        //Metoda koja ce provjeriti unos:
        private bool ValidirajUnosNumber(Control prva, Control druga,Control treca)
        {
            return Validator.ValidateTextField(prva, errorRegistrujProfesora, Poruke.OvoPoljeJeObavezno)
                   && Validator.ValidateTextField(druga, errorRegistrujProfesora, Poruke.OvoPoljeJeObavezno)
                   && Validator.ValidateNumberField(treca,errorRegistrujProfesora,Poruke.SemestarNeSmijeBitiNula);
        }
        private bool ValidirajUnos(Control prva, Control druga)
        {
            return Validator.ValidateTextField(prva, errorRegistrujProfesora, Poruke.OvoPoljeJeObavezno)
                   && Validator.ValidateTextField(druga, errorRegistrujProfesora, Poruke.OvoPoljeJeObavezno);
        }

    }
}
