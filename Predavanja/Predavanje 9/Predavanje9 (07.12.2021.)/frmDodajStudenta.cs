using System;
using System.Drawing;
using System.Windows.Forms;
using DataBase;
using Klase;

namespace Predavanje9__07._12._2021._
{
    public partial class frmDodajStudenta : Form
    {
        private Student student;//Napravimo privatni field koji ce cuvati vrijednosti;
        public frmDodajStudenta(Student student=null)
        {
            InitializeComponent();
            this.student = student ?? new Student();//Ako je null kreiramo novog studenta, dok ako nije null samo ga prekopiramo u lokalni field;
        }

        //Metoda koja se izvrsava na ucitavanje forme:
        private void frmDodajStudenta_Load(object sender, EventArgs e)
        {
            UcitajGodine();
            UcitajSpolove();
            if (student.Id != 0) //Ako je id nula znaci da je novi student te moramo sve imati loadovano;
            {
               UcitajPodatkeSaForme();
            }
            
        }

        private void UcitajPodatkeSaForme()
        {
            txtBoxIme.Text = student.Ime;
            txtBoxPrezime.Text = student.Prezime;
            txtBoxIndeks.Text = student.Indeks;
            pbSlikaStudenta.Image = student.Slika;
            dtPickerRodjenje.Value = student.DatumRodjenja;
            cbAktivan.Checked = student.Aktivan;
            cmbGodina.SelectedValue = student.Godina;
            txtBoxEmail.Text = student.Email;
            txtBoxLozinka.Text = student.Lozinka;
            cmbSpol.SelectedItem = student.Spol;
        }

        //Metoda koja iz baze ucita u comboBox vrijednosti za spol:
        private void UcitajSpolove()
        {
            cmbSpol.DataSource = InMemoryDataBase.Spolovi;
            cmbSpol.DisplayMember = "Opis";
            cmbSpol.ValueMember = "Id";
        }
        //Metoda koja iz baze ucita u comboBox vrijednosti za godine:
        private void UcitajGodine()
        {
            cmbGodina.DataSource = InMemoryDataBase.Godine;
            cmbGodina.DisplayMember = "Naziv";
            cmbGodina.ValueMember = "Id";
        }

        private void btnUcitajSliku_Click(object sender, EventArgs e)
        {
            if (ofdUcitajSliku.ShowDialog() == DialogResult.OK)
            {
                pbSlikaStudenta.Image = Image.FromFile(ofdUcitajSliku.FileName);
            }
        }
        //Metoda koja ce da doda novog studenta ili da edituje starog:
        private void btnDodajStudenta_Click(object sender, EventArgs e)
        {
            if (ValidirajUnos())
            {
                student.Ime = txtBoxIme.Text;
                student.Prezime = txtBoxPrezime.Text;
                student.Email = txtBoxEmail.Text;
                student.Lozinka = txtBoxLozinka.Text;
                student.Slika = pbSlikaStudenta.Image;
                student.Spol = cmbSpol.SelectedItem as Spol;//Posto SelectedItem vrati object a nama treba Spol, uradimo cast;
                student.Aktivan = cbAktivan.Enabled;
                student.DatumRodjenja = dtPickerRodjenje.Value;
                student.Godina = int.Parse(cmbGodina.SelectedValue.ToString());

                if (student.Id == 0)
                {
                    student.Id = InMemoryDataBase.Studenti.Count + 1;//Dodamo mu id jer ne postoji, vec se kreira;
                    InMemoryDataBase.Studenti.Add(student);//Dodamo studenta;
                    MessageBox.Show($"Student {student.ImePrezime} uspjesno dodan!");
                }
                else
                    MessageBox.Show($"Student {student.ImePrezime} uspjesno uredjen!");
                this.Close();
                this.DialogResult = DialogResult.OK;
            }
        }
        //Metoda koja validira unesene podatke:
        private bool ValidirajUnos()
        {
            return Validator.Validate(txtBoxIme, errorDodajStudenta, "Ne validan unos!")
                   && Validator.Validate(txtBoxPrezime, errorDodajStudenta, "Ne validan unos!")
                   && Validator.Validate(txtBoxIndeks, errorDodajStudenta, "Ne validan unos!")
                   && Validator.Validate(txtBoxLozinka, errorDodajStudenta, "Ne validan unos!")
                   && Validator.Validate(pbSlikaStudenta, errorDodajStudenta, "Ne validan unos!")
                   && Validator.Validate(cmbGodina, errorDodajStudenta, "Ne validan unos!")
                   && Validator.Validate(txtBoxEmail, errorDodajStudenta, "Ne validan unos!")
                   && Validator.Validate(cmbSpol, errorDodajStudenta, "Ne validan unos!");
        }
    }
}   
