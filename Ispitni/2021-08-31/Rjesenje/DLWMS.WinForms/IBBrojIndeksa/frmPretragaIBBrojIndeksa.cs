using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DLWMS.WinForms.Entiteti;
using DLWMS.WinForms.Helpers;

namespace DLWMS.WinForms.IBBrojIndeksa
{
    public partial class frmPretragaIBBrojIndeksa : Form
    {
        private KonekcijaNaBazu _db = DLWMSdb.Baza;//Konekcija na DLWMS bazu
        public frmPretragaIBBrojIndeksa()
        {
            InitializeComponent();
        }

        private void frmPretragaIBBrojIndeksa_Load(object sender, EventArgs e)
        {
            dgvStudent.AutoGenerateColumns=false;
            UcitajPolozenePredmete();
            UcitajStudente(_db.Studenti.ToList());
        }

        #region UcitajPodatke
        private void UcitajStudente(List<Student> listaStudenata)//Ucitavanje nase baze iz tabele studenti
        {
            dgvStudent.DataSource = listaStudenata;

            lblProsjek.Text = $"Prosjek prikazanih ocjena: {prosjekPrikazanihOcjena(listaStudenata)}";//trazenje ukupnog prosjeka
            lblNajveciProsjek.Text = $"Najveci prosjek ostvario: {najboljiStudent(listaStudenata)}";//trazenje koje ostvario najveci prosjek

        }

        private void UcitajPolozenePredmete()
        {
            foreach (var student in _db.Studenti.ToList())//uzimamo naseg studenta iz baze Studenti
            {
                foreach (var sp in _db.StudentiPredmeti.ToList())//I odavde uzimamo naseg Studenta a i njegove predmete iz baze StudentiPredemti
                {
                    if (student==sp.Student)//ako su studenti isti, nastavljamo dalje
                    {
                        var polozen = new PolozeniPredmet(sp.Predmet, sp.Ocjena, sp.Datum);//ovde provjeravamo njegov predmet,ocjeny,datum da li je polozio,
                                                                                                                              //ovaj konstruktor PolozeniPredmeti smo napravili u class Predmet
                        student.PolozeniPredmeti.Add(polozen);//ako ima polozen predmet ovde dodajemo i opet vrismo provjeru za tog studenta da provjerimo ima li jos koji predmet da je polozio
                         

                    }
                }
                
                student.Polozen = string.Join(";", student.PolozeniPredmeti);//ovdje dodajemo nase polozene predmete u bazu --Polozen je property kojeg smo napravili u class Student
                student.Prosjek = prosjekPolozenihPredmeta(student.PolozeniPredmeti);//ovdje pozivamo funkciju koja nam racuna prosjek -- Prosjek je property kojeg smo napravili u class Student
            }
        }
        #endregion

        #region RacunajProsjek
        private float prosjekPolozenihPredmeta(List<PolozeniPredmet> polozeni)//ovde smo racunali  prosjek za polozene predmete
        {
            float prosjek = 0.0f;
            foreach (var polozeniPredmet in polozeni)
            {
                prosjek += polozeniPredmet.Ocjena;
            }

            if (polozeni.Count==0)
            {
                return 0.0f;
            }

            return prosjek / polozeni.Count;
        }

        private float prosjekPrikazanihOcjena(List<Student> lista)//ovdje racunamo prosjek prikazanih ocjena tj. saberemo prosjeke od svakog studenta i podjelimo sa brojem studenta
        {
            float prosjek = 0.0f;
            int brojac = 0;

            foreach (var student in lista)
            {
                if (student.PolozeniPredmeti.Count!=0)
                {
                    prosjek += prosjekPolozenihPredmeta(student.PolozeniPredmeti);
                    brojac++;
                }
            }

            if (brojac == 0)
            {
                return prosjek;
            }

            return prosjek / brojac;
        }

        private string najboljiStudent(List<Student> lista)
        {
            if (lista.Count==0)
            {
                return "NOT_SET";// u slucaju da nam je lista prazna kod najboljeg studenta ce se ispita NOT_SET
            }

            Student noviStudent = lista[0];//pravimo novog studenta i dodjela niza
            foreach (var student in lista)
            {
                if (student.Prosjek>noviStudent.Prosjek)//ovdje provjeramo koji student ima veci prosjek
                {
                    noviStudent=student;//vrismo dodjelu novom studentu
                }
            }

            return noviStudent.ImePrezime;//ispis studenta koji ima najveci prosjek
        }
        #endregion

        #region GenerisiInfo
        private async void btnGenerisi_Click(object sender, EventArgs e)
        {
            List<string>_samoglasniciList=new List<string>{"a","e","i","o","u"};
            List<string> _znakoviList = new List<string> {"?","!","<",">","*" };

            var text = txtSadrzaj.Text.ToLower();
            int samoglasnici = 0;
            int suglasnici = 0;
            int znakovi = 0;

            await Task.Run(() =>
            {
                samoglasnici = text.Where(x => _samoglasniciList.Contains(x.ToString())).Count();
                znakovi = text.Where(x => _znakoviList.Contains(x.ToString())).Count();
                suglasnici = text.Length - samoglasnici - znakovi;
            });
            Action akcija = new Action(() =>
            {
                lblSamoglasnici.Text = $"Samoglasnici: {samoglasnici}";
                lblSuglasnici.Text = $"Suglasnici: {suglasnici}";
                lblZnakovi.Text = $"Znakovi: {znakovi}";
            });
            BeginInvoke(akcija);

        }
        #endregion

        #region Pretraga
        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            if (txtPretraga.Text==string.Empty)
            {
                UcitajStudente(_db.Studenti.ToList());
                return;
            }
            var pretrazivac=txtPretraga.Text.ToLower();
            List<Student>novaLista=new List<Student>();
            novaLista = _db.Studenti
                .Where(a => a.Ime.ToLower().Contains(pretrazivac) || a.Prezime.ToLower().Contains(pretrazivac))
                .ToList();
            UcitajStudente(novaLista);
        }
        #endregion

        private void dgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex<0)
            {
                return;
            }
            var kolona=dgvStudent.Columns[e.ColumnIndex];
            if (kolona is DataGridViewButtonColumn)
            {
                var red=dgvStudent.Rows[e.RowIndex].DataBoundItem as Student;
                var scanIspita = new frmScanIspitaIBBrojIndeksa(red);
                Hide();
                scanIspita.ShowDialog();
                Show();
            }
        }
    }
}
