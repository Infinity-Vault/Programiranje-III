using System;
using System.Windows.Forms;
using StudentService.DateBase;
using StudentService.Entities;
using StudentService.Helpers;

namespace StudentService
{
    public partial class FrmWelcome : Form
    {
        public FrmWelcome()
        {
            InitializeComponent();
        }

        //Prijava studenta;
        private void btnPrijavaS_Click(object sender, EventArgs e)
        {
            //Preuzmemo vrijednosti:
            var korisnickoImeS = txtBoxKorisnickoImeS.Text;
            var lozinkaS = txtBoxLozinkaS.Text;

            if (ValidirajUnos(txtBoxKorisnickoImeS, txtBoxLozinkaS))
            {
                foreach (var student in InMemoryDataBase.StudentRepo.Entities)
                {
                    if (student.KorisnickoIme == korisnickoImeS && student.Lozinka == lozinkaS)
                    {
                        MessageBox.Show($"{Poruke.Dobrodosli}{student.ImePrezime}"); //Student nadjen u bazi;
                        return; //Odmah mozemo zavrsiti;
                    }
                }

                MessageBox.Show($"{korisnickoImeS}{Poruke.StudentNePostoji}"); //nema studenta;
                MessageBox.Show($"{Poruke.NeispravniCredentials}");//pogreska u unosu;
            }
        }


        //Metoda koja ce provjeriti unos:
        private bool ValidirajUnos(Control prva, Control druga)
        {
            return Validator.ValidateTextField(prva, errorLogin, Poruke.OvoPoljeJeObavezno)
                   && Validator.ValidateTextField(druga, errorLogin, Poruke.OvoPoljeJeObavezno);
        }

        //Prijava Profesora:
        private void btnPrijavaP_Click(object sender, EventArgs e)
        {
            //Preuzmemo vrijednosti:
            var korisnickoImeP = txtBoxKorisnickoImeP.Text;
            var lozinkaP = txtBoxLozinkaP.Text;

            if (ValidirajUnos(txtBoxKorisnickoImeP, txtBoxLozinkaP))
            {
                foreach (var profesor in InMemoryDataBase.ProfessorRepo.Entities)
                {
                    if (profesor.KorisnickoIme == korisnickoImeP && profesor.Lozinka == lozinkaP)
                    {
                        MessageBox.Show($"{profesor.ImePrezime}{Poruke.Dobrodosli}");//Pronadjen prof u db;
                        return;//zavrsi pretragu;
                    }
                }
                MessageBox.Show($"{korisnickoImeP}{Poruke.ProfesorNePostoji}"); //nema profesora;
                MessageBox.Show($"{Poruke.NeispravniCredentials}");//pogreska u unosu;
            }
        }

        //Metoda za registrovanje Studenta:
        private void linlblRegistracijaS_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var registerForma = new FrmRegistrujStudenta();
            registerForma.ShowDialog();//Prikazemo formu;
        }

        //Metoda za registrovanje Profesora:
        private void linlblRegistracijaP_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var registerForma = new FrmRegistrujProfesora();//kreiramo formu;
            registerForma.ShowDialog();//Pokrenemo kao dijaloski okvir;
        }

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
