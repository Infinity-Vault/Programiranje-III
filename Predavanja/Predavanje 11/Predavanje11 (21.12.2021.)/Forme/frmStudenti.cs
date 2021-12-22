using DB;
using Entiteti;
using Helpers;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Forme
{
    public partial class frmStudenti : Form
    {
        //Privatni field za konekciju na bazu;
        private KonekcijaNaBazu _db=DLWMS.Baza;

        //Privatno polje koje ce preuzeti vrijednosti kliknutog  studenta:
        private Student student;
        public frmStudenti()
        {
            InitializeComponent();
            dgvStudenti.AutoGenerateColumns = false;//Kako ne bi imali sve kolone iz izvora;
            dgvPolozeniPredmetiStudenta.AutoGenerateColumns = false;
            dgvUlogeStudenta.AutoGenerateColumns=false;
        }

        //Metoda koja se poziva na ucitavanje forme:
        private void frmStudenti_Load(object sender, EventArgs e)
        {
            UcitajStudente();
            UcitajSpolove();
            UcitajPredmete();
            UcitajUloge();
        }

        //Metoda koja ce ucitati uloge trenutnog studenta u dgv uloga:
        private void UcitajUlogeStudenta()
        {
            lblStudent.Text="Student:";
            lblStudent.Text+=student.ToString();//Da ispisemo o kojem studentu se radi;
            dgvUlogeStudenta.DataSource=null;
            dgvUlogeStudenta.DataSource=student.Uloge.ToList();//Pojedinacne uloge studenta;
        }

        //Metoda koja ce da ucita uloge u cmbUloge:
        private void UcitajUloge()
        {
            try
            {
                cmbUloge.DataSource = _db.Uloge.ToList();//Izvor iz tabele Uloge konvertovan u listu;
                cmbUloge.DisplayMember = "Naziv";
                cmbUloge.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message + Environment.NewLine}{ex.InnerException?.Message}");
            }
        }



        //Metoda koja ucitava predmete:
        private void UcitajPredmete()
        {
            try
            {
                cmbPredmeti.DataSource=_db.Predmeti.ToList();
                cmbPredmeti.ValueMember="Id";
                cmbPredmeti.DisplayMember="Naziv";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message + Environment.NewLine}{ex.InnerException?.Message}");
            }
        }

        //Metoda koja ucitava spolove:
        private void UcitajSpolove()
        {
            try
            {
                cmbSpolovi.DataSource=_db.Spolovi.ToList();//Povezemo na izvor tabelu iz baze ali konvertovanu u listu;
                cmbSpolovi.DisplayMember="Naziv";
                cmbSpolovi.ValueMember="Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message + Environment.NewLine}{ex.InnerException?.Message}");
            }
        }

        //Metoda koja ce da ucita u dgv Studente;
        private void UcitajStudente()
        {
            try
            {
                dgvStudenti.DataSource=null;
                //Include("ImePropertija") mozemo koristiti kada zelimo explicitno da navedemo da se za svakog studenta iz tabele Studenti ucita i njegov zasebni entitet Spol;
                //dgvStudenti.DataSource = _db.Studenti.Include("Spol").ToList();//Nad tabelom Studenti u bazi podataka pozovemo metodu da se ona pretvori u listu tih podataka;

                //Donji dio koda mozemo iskoristiti kada stavimo kljucnu rijec virtual u klasi baze podataka pored propertija za tabelu entiteta Spolovi;Ovime se omoguci tzv. lazy loading zasebnih entiteta tj njihovo loadovanje neposredno prije nego su oni potrebni u aplikaciji;
                dgvStudenti.DataSource=_db.Studenti.ToList();//Nad tabelom Studenti u bazi podataka pozovemo metodu da se ona pretvori u listu tih podataka;
            }
            catch ( Exception ex)
            {
                //Ispisemo poruku i samo ako je detaljni opis ne prazan ispisemo i njega;Kako ne bi imali null reference exception u slucaju da je property InnerException null; 
                MessageBox.Show($"{ex.Message+Environment.NewLine}{ex.InnerException?.Message}");
            }
        }

        private void btnUcitajSliku_Click(object sender, EventArgs e)
        {
            if(ofdUcitajSliku.ShowDialog()==DialogResult.OK)
                pbSlika.Image=Image.FromFile(ofdUcitajSliku.FileName);
        }

        //Metoda koja ce dodati studenta:
        private void btnDodajStudenta_Click(object sender, EventArgs e)
        {
            //Ovo je dodavanje i cilj je da se prikaze dodavanje u bazu ne i da se validiraju podaci;

            var student=new Student()
            {
                //Id nema potrebe da mi diramo jer je to sada posao baze podataka;
                Ime=txtBoxIme.Text,
                Prezime=txtBoxPrezime.Text,
                Email=txtBoxEmail.Text,
                Slika=KonverzijaSlike.ImageToByte(pbSlika.Image),
                Aktivan=cbAktivan.Checked,
                Spol=cmbSpolovi.SelectedItem as Spol
            };
            //Try catch jer radimo sa bazom pa moze biti exceptiona:
            try
            {
                _db.Studenti.Add(student);//Dodamo u bazu novi red (novog studenta);
                _db.SaveChanges();//Spasimo promjene jer inace nece biti pisano u bazu;
                UcitajStudente();//Osvjezimo dgv;
                MessageBox.Show("Uspjesno dodan student!","Informacija",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
               MessageBox.Show($"{ex.Message+Environment.NewLine}{ex.InnerException?.Message}");
            }
            ClearPolja();//Da bi pobrisali unose jer zelimo mozda dodati novog studenta;
        }

        private void GenerisiEmail()
        {
            //Generisemo mail;
            txtBoxEmail.Text=txtBoxIme.Text+"@fit.ba";
        }

        private void txtBoxIme_TextChanged(object sender, EventArgs e)
        {
            //Okine se metoda ispod kada se god promjeni unos u polju txtBoxIme;
            GenerisiEmail();
        }
        //Metoda koja ocisti unose;
        private void ClearPolja()
        {
             txtBoxIme.Text=string.Empty;
             txtBoxPrezime.Text = string.Empty;
             txtBoxEmail.Text = string.Empty;
             pbSlika.Image=null;
             cbAktivan.Checked=false;
             cmbSpolovi.SelectedIndex=0;
        }

        //Kliknuti red gledamo kao studenta i prekopiramo u lokalni field njegove vrijednosti;
        private void dgvStudenti_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        { 
            this.student=dgvStudenti.SelectedRows[0].DataBoundItem as Student;
            UcitajUlogeStudenta();//Kako bi dobili u dgv uloge datog studenta;
        }
        //Metoda koja ce dodati novi polozeni predmet studentu a i u bazu:
        private void btnDodajPredmet_Click(object sender, EventArgs e)
        {
            var polozeniPredmet = new PolozeniPredmet()
            {
                //Ovdje ce se vec baza brinuti o Id-u jer se dodaje novi record (zapis);
                Student=this.student,
                Predmet=cmbPredmeti.SelectedItem as Predmet,
                Datum=dtpDatum.Value,
                Ocjena=int.Parse(txtBoxOcjena.Text)
            };
            _db.StudentiPredmeti.Add(polozeniPredmet);//Dodamo u bazu;
            _db.SaveChanges();//Spasimo promjene;
            dgvPolozeniPredmetiStudenta.DataSource=null;//Nuliramo izvor;
            dgvPolozeniPredmetiStudenta.DataSource=student.PolozeniPredmeti;//Displejamo predmete od studenta kojem smo dodali sada novi polozeni predmet;
        }

        private void btnDodajUloguStudentu_Click(object sender, EventArgs e)
        {
            try
            {
                var novaUloga=cmbUloge.SelectedItem as Uloga;//Preuzmemo odabranu ulogu;
                student.Uloge.Add(novaUloga);//Dodamo studentu ulogu, a posto smo izvrsili relaciju u bazi, spaseno ce biti u tabeli sve onako kako je adekvatno; (Sa Student_Id i Uloga_Id);
                _db.SaveChanges();//Spasimo promjene u bazi;
                UcitajUlogeStudenta();//Osvjezimo dgv;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message + Environment.NewLine}{ex.InnerException?.Message}");         
            }
        }
    }
}
