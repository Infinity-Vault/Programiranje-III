using System;
using System.Drawing;
using System.Windows.Forms;
using Predavanje7.Helpers;
using Predavanje7.DataBase;
using Predavanje7.Klase;

namespace Predavanje7
{
    public partial class frmDodajStudenta : Form
    { 
        
        //Private field koji ce biti student koji se edituje:
        private Student student;
         
        //User def ctor koji ima argument koji je default pa je gledan ujedno kao dflt ctor:
        public frmDodajStudenta(Student student=null)
        {
            InitializeComponent();
            this.student = student ?? new Student();//Ukoliko student nije null dodijeli se fieldu student,dok  ukoliko jeste kreira se novi Student;
        }
        //Meotoda koja se izvrsi kada se forma ucita:
        private void frmDodajStudenta_Load(object sender, EventArgs e)
        {
            UcitajGodine();//Ucitamo godine za combobox;
            if (student.Id == 0)//Ako je id nula znaci da nije kreiran student i za njega zelimo generisati lozinku mail i indeks;
                txtBoxPrezime_TextChanged(txtBoxPrezime, e);
            else
                UcitajPodatkeOStudentu();//Inace znaci da je student postojeci pa samo zelimo njegove podatke da poprimi field student;
        }

        //Metoda koja ucitava podatke iz student field-a u kontrole na formi;
        private void UcitajPodatkeOStudentu()
        {
            //Logika za prikupljanje podataka:
            txtBoxIme.Text = student.Ime;
            txtBoxPrezime.Text = student.Prezime;
            txtBoxIndeks.Text = student.Indeks;
            pbSlikaStudenta.Image = student.Slika;
            dtPickerRodjenje.Value = student.Rodjen;
            cbAktivan.Checked = student.Aktivan;
            cbGodina.SelectedItem=student.Godina;
            txtBoxEmail.Text = student.Email;
            txtBoxLozinka.Text = student.Lozinka;
        }

        //Metoda koja dodaje novog studenta u bazu i koja aktualizira postojeceg:
        private void btnDodajStudenta_Click(object sender, EventArgs e)
        {
            if (ValidirajUnos())//Ako su uneseni podaci ispravni;
            {
                //Ako nije student null mozemo mu mijenjati propertije, editujemo ga:
                student.Ime = txtBoxIme.Text;
                student.Prezime = txtBoxPrezime.Text;
                student.Aktivan = cbAktivan.Checked;
                student.Rodjen = dtPickerRodjenje.Value;
                student.Email = txtBoxEmail.Text;
                student.Lozinka = txtBoxLozinka.Text;
                student.Indeks = txtBoxIndeks.Text;
                student.Slika = pbSlikaStudenta.Image;
                student.Godina = int.Parse(cbGodina.SelectedValue.ToString());//Odabrana vrijednost 

                //Ako student jeste null kreira  se novi objekat:
                if (student.Id == 0)//Ako nema dodjeljen id radi se o novom studentu te mu treba dodati id i staviti ga u bazu;
                {
                    student.Id = InMemoryDatabase.RepoStudenti.Baza.Count + 1; //Povecamo brojac
                    InMemoryDatabase.RepoStudenti.Insert(student);//Dodamo novog studenta;
                    MessageBox.Show($"{student.ImePrezime}{Poruke.UspjesnoDodan}");//Obavijestimo korisnika da se registrovao;
                }
                else 
                    MessageBox.Show($"{student.ImePrezime}{Poruke.EditovanStudent}");//Obavijestimo korisnika da je editovao racun;
                this.DialogResult = DialogResult.OK;//Forsiramo da je dialog zavrsio sa OK;
                this.Close();//Zatvorimo formu jer je kreiran student;
            }
        }

        //Metoda koja validira unos podataka sa forme:
        private bool ValidirajUnos()
        {
            //Moguce je validirati sve inpute jer smo modificirali klasu Validator na nacin da se tamo ispituje sta je poslano kao kontrola;
            return Validator.ValidateInput(txtBoxIme, errorRegistracija, Poruke.ObaveznoPolje)
                   && Validator.ValidateInput(txtBoxPrezime, errorRegistracija, Poruke.ObaveznoPolje)
                   && Validator.ValidateInput(txtBoxEmail, errorRegistracija, Poruke.ObaveznoPolje)
                   && Validator.ValidateInput(txtBoxLozinka, errorRegistracija, Poruke.ObaveznoPolje)
                   && Validator.ValidateInput(pbSlikaStudenta, errorRegistracija, Poruke.SlikaJeObavezna)
                   && Validator.ValidateInput(cbGodina, errorRegistracija, Poruke.ObaveznoPolje);
        }

        //Metoda koja ce da  nam  da mogucnost da ucitamo sliku sa naseg pc:
        private void btnUcitajSliku_Click(object sender, EventArgs e)
        {
            if (ofdUcitajSliku.ShowDialog()== DialogResult.OK)
            {
                pbSlikaStudenta.Image = Image.FromFile(ofdUcitajSliku.FileName);
            }
        }
        //Metoda koja ce da ucita godine u bazu:
        private void UcitajGodine()
        {
            cbGodina.DataSource = InMemoryDatabase.RepoGodine.Baza;//Postavimo izvor na nasu bazu podataka godina;
            cbGodina.DisplayMember = "Opis";//Stavimo da se display poveze sa property Opis u nasem slucaju;
            cbGodina.ValueMember = "Id";//Stavimo da se value poveze sa  property Id u nasem slucaju;
        }

        //Metoda koja ce se okinuti onda kada budemo kucali u polje za prezime;
        private void txtBoxPrezime_TextChanged(object sender, EventArgs e)
        {
            txtBoxLozinka.Text = GenerisiLozinku();//Generisemo lozinku;
            txtBoxIndeks.Text = GenerisiIndeks();//Generisemo indeks;
            txtBoxEmail.Text = $"{txtBoxIme.Text.ToLower()}.{txtBoxPrezime.Text.ToLower()}.edu.fit.ba";//Napravimo ime.prezime@edu.fit.ba;
        }

        //Metoda za generisanje lozinke:
        private string GenerisiLozinku(int size = 8)//Dflt duzina lozinke ce biti 8, ako se ne proslijedi drugacije;
        {
            var lozinka = "";//Pocetni prazni string;
            var pattern = "ndsafisafnaso$%&(*@)";//Random niz sample karaktera;
            var rand = new Random();//Rand objekat;
            for (int i = 0; i < size; i++)
            {
                var indeks = rand.Next(0, pattern.Length);//Kreiramo neku nasumicnu poziciju u rangu duzine naseg pattern niza;
                lozinka += pattern[indeks];//Dodamo karakter sa te pozicije;
            }
            return lozinka;//Vratimo kreiranu lozinku;
        }
        //Metoda koja ce generisati indeks:
        private string GenerisiIndeks()
        {
            return $"IB{(dtPickerRodjenje.Value.Year - 2000) * 1000 + InMemoryDatabase.RepoStudenti.Baza.Count+1}";
            //Imamo fiksni dio IB onda uzmemo godinu minus 2000 da dobijemo 21 onda * 1000 da dobijemo 21000 i onda dodajemo ID iz baze uvecan svaki put za jedan;
        }
    }
}
