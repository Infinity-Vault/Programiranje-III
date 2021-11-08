using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentService.DateBase;
using StudentService.Entities;
using StudentService.Helpers;

namespace StudentService
{
    public partial class FrmRegistrujStudenta : Form
    {
        public FrmRegistrujStudenta()
        {
            InitializeComponent();
        }

        //Metoda koja ce provjeriti unos:
        private bool ValidirajUnosNumber(Control prva, Control druga,Control treca)
        {
            return Validator.ValidateTextField(prva, errorRegistracijaStudent, Poruke.OvoPoljeJeObavezno)
                   && Validator.ValidateTextField(druga, errorRegistracijaStudent, Poruke.OvoPoljeJeObavezno)
                   && Validator.ValidateNumberField(treca,errorRegistracijaStudent,Poruke.SemestarNeSmijeBitiNula);
        }
        private bool ValidirajUnos(Control prva, Control druga, Control treca)
        {
            return Validator.ValidateTextField(prva, errorRegistracijaStudent, Poruke.OvoPoljeJeObavezno)
                   && Validator.ValidateTextField(druga, errorRegistracijaStudent, Poruke.OvoPoljeJeObavezno)
                   && Validator.ValidateTextField(treca,errorRegistracijaStudent,Poruke.OvoPoljeJeObavezno);
        }
        //Metoda koja ce da registruje novog studenta;
        private void btnRegistracija_Click(object sender, EventArgs e)
        {
            if (ValidirajUnos(txtBoxIme, txtBoxPrezime, txtBoxIndeks) &&
                ValidirajUnosNumber(txtBoxKorisnickoIme, txtBoxLozinka, txtBoxSemestar))
            {
                var student = new Student()
                {
                    Id=InMemoryDataBase.StudentRepo.IdGenerator++,
                    Ime = txtBoxIme.Text,
                    Prezime = txtBoxPrezime.Text,
                    Semestar = int.Parse(txtBoxSemestar.Text),
                    Indeks = txtBoxIndeks.Text,
                    KorisnickoIme = txtBoxKorisnickoIme.Text,
                    Lozinka = txtBoxLozinka.Text,
                    Rodjen = dtpDatumrodjenja.Value
                };
                InMemoryDataBase.StudentRepo.Insert(student);//Dodamo studenta;
                MessageBox.Show($"{student.ImePrezime} je registrovan uspjesno!");//Obavijestimo korisnika;
                this.Close();//Zatvorimo jer je dodan student;//Moze se onda logirati;
            }
        }
    }
}
