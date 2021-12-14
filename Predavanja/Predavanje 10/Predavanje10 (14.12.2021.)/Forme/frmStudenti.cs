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
        private KonekcijaNaBazu _db=new KonekcijaNaBazu();
        public frmStudenti()
        {
            InitializeComponent();
            dgvStudenti.AutoGenerateColumns = false;//Kako ne bi imali sve kolone iz izvora;
        }

        //Metoda koja se poziva na ucitavanje forme:
        private void frmStudenti_Load(object sender, EventArgs e)
        {
            UcitajStudente();
        }

        //Metoda koja ce da ucita u dgv Studente;
        private void UcitajStudente()
        {
            try
            {
                dgvStudenti.DataSource=null;
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
                Spol=cbSpol.Checked
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
             cbSpol.Checked=false;
        }
    }
}
