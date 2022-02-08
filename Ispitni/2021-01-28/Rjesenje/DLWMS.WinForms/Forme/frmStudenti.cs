using DLWMS.WinForms.Entiteti;
using DLWMS.WinForms.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DLWMS.WinForms.IspitIB123456;
using DLWMS.WinForms.IspitIB123456.Entiteti;

namespace DLWMS.WinForms.Forme
{
    public partial class frmStudenti : Form
    {
        #region Forma
        private KonekcijaNaBazu _db = DLWMSdb.Baza;
        public frmStudenti()
        {
            InitializeComponent();
            dgvStudenti.AutoGenerateColumns = false;
            cmbAktivnost.DataSource = new List<string>() { "Svi", "Aktivni", "Neaktivni" };
            cmbGodine.DataSource = new List<string>() { "Sve", "1", "2", "3" };
        }
        private void frmStudenti_Load(object sender, EventArgs e)
        {
            UcitajPodatkeOStudentima();
        }
        #endregion

        #region Ucitavanje potrebnih podataka
        private void UcitajPodatkeOStudentima(List<Student> studenti = null)
        {
            dgvStudenti.DataSource = null;
            dgvStudenti.DataSource = studenti ?? _db.Studenti.ToList(); 
        }

        private void PrikaziFormu(Form form)
        {
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
        #endregion

        #region Pokretanje forme za pregled polozenih predmeta
        private void dgvStudenti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var student = dgvStudenti.SelectedRows[0].DataBoundItem as Student;
            Form form = null;
            if (student != null)
            {
                if (e.ColumnIndex == 6) 
                    form = new frmStudentiPredmeti(student);
                else
                    form = new frmNoviStudent(student);
                PrikaziFormu(form);

                UcitajPodatkeOStudentima();
            }
        }
        #endregion

        #region Pretraga studenata
        private void Pretraga()
        {
            if (cmbGodine.SelectedItem as string == "Sve" && cmbAktivnost.SelectedItem as string == "Svi")
            {
                var filter = txtBoxImePrezime.Text.ToLower();
                if (!string.IsNullOrWhiteSpace(filter))
                {
                    var lista = _db.Studenti.Where(s =>
                        s.Ime.ToLower().Contains(filter) || s.Prezime.ToLower().Contains(filter)).ToList();
                    UcitajPodatkeOStudentima(lista);
                    lblBrojStudenata.Text = "Broj studenata:";
                    lblBrojStudenata.Text += lista.Count;
                    Prosjek(lista);
                }
                else
                {
                    UcitajPodatkeOStudentima(_db.Studenti.ToList());
                    lblBrojStudenata.Text = "Broj studenata:";
                    lblBrojStudenata.Text += _db.Studenti.ToList().Count;
                    Prosjek(_db.Studenti.ToList());
                }
                return;
            }

            if (ValidirajUnos())
            {
                try
                {
                    
                    var godinaStudija = cmbGodine.SelectedItem as string;
                    var aktivnost = cmbAktivnost.SelectedItem as string;
                    var filter = txtBoxImePrezime.Text.ToLower();
                    var gs = int.Parse(godinaStudija);
                    var aktiv = aktivnost == "Aktivni" ? true : false;

                    var lista = _db.Studenti.Where(s => (s.Ime.ToLower().Contains(filter)
                                                         || s.Prezime.ToLower().Contains(filter)) && s.Aktivan == aktiv
                                                         && s.GodinaStudija == gs).ToList();
                    UcitajPodatkeOStudentima(lista);
                    lblBrojStudenata.Text = "Broj studenata:";
                    lblBrojStudenata.Text += lista.Count;
                    Prosjek(lista);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message + Environment.NewLine}{ex.InnerException?.Message}");
                }
            }
        }

        private void Prosjek(List<Student> lista)
        {
            var prosjek = 0.0f;
            var brojac = 0;
            foreach (var student in lista)
            {
                foreach (var predmet in _db.StudentiPredmeti)
                {
                    if (student.Id == predmet.Student.Id)
                    {
                        prosjek += predmet.Ocjena;
                        brojac++;
                    }
                }
            }
            if(brojac>0)
                prosjek/=brojac;
            lblProsjecnaOcjena.Text = "Prosjecna ocjena:";
            lblProsjecnaOcjena.Text += Math.Round(prosjek, 2);
        }

        private bool ValidirajUnos() => Validator.ValidirajKontrolu(txtBoxImePrezime, error, 
            Poruke.ObaveznaVrijednost);

        private void txtBoxImePrezime_TextChanged(object sender, EventArgs e) => Pretraga();
        private void cmbGodine_SelectedIndexChanged(object sender, EventArgs e) => Pretraga();
        private void cmbAktivnost_SelectedIndexChanged(object sender, EventArgs e) => Pretraga();

        #endregion

        #region Pokreni formu potvrda
        private void btnPotvrde_Click(object sender, EventArgs e) 
            => new frmPotvrdeIB123456().ShowDialog();
        #endregion

        #region Printaj izvjestaj
        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            var printaj = new dtoPrintajIB123456();
            printaj.Studenti = dgvStudenti.DataSource as List<Student>;
            var izvjestaj = new Izvjestaji.frmIzvjestaji(printaj);
            izvjestaj.ShowDialog();
        }
        #endregion
    }
}
