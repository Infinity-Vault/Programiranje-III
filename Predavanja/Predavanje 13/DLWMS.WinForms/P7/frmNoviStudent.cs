using DLWMS.WinForms.DB;
using DLWMS.WinForms.Helpers;
using DLWMS.WinForms.P11;
using DLWMS.WinForms.P5;
using DLWMS.WinForms.P9;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.P7
{
    public partial class frmNoviStudent : Form
    {
        private Student student;

        KonekcijaNaBazu db = DLWMSdb.Baza;//new KonekcijaNaBazu();

        public frmNoviStudent(Student student = null)
        {
            InitializeComponent();
            this.student = student ?? new Student();
        }

        private void frmNoviStudent_Load(object sender, EventArgs e)
        {
            UcitajGodineStudija();
            UcitajSpolove();
            UcitajUloge();
            if (student.Id == 0)
            {
                GeneriBrojIndeksa();
                GenerisiLozinku();
            }
            else
                UcitajPodatkeOStudentu();
        }

        //Metoda koja ce da ucita uloge iz baze u clb:
        private void UcitajUloge()
        {
            try
            {
                clbUlogeStudenta.DataSource = db.Uloge.ToList();//Ucitamo iz baze u komandu uloge;
                clbUlogeStudenta.ValueMember = "Id";
                clbUlogeStudenta.DisplayMember = "Naziv";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UcitajSpolove()
        {
            cmbSpolovi.DataSource = db.Spolovi.ToList(); //InMemoryDB.Spolovi;
            cmbSpolovi.ValueMember = "Id";
            cmbSpolovi.DisplayMember = "Naziv";
        }

        private void UcitajPodatkeOStudentu()
        {
            txtIme.Text = student.Ime;
            txtPrezime.Text = student.Prezime;
            dtpDatumRodjenja.Value = student.DatumRodjenja;
            txtEmail.Text = student.Email;
            txtLozinka.Text = student.Lozinka;
            cbAktivan.Checked = student.Aktivan;
            cmbGodinaStudija.SelectedValue = student.GodinaStudija;
            txtIndeks.Text = student.Indeks;
            pbSlika.Image = ImageHelper.FromByteToImage(student.Slika);
            cmbSpolovi.SelectedItem = student.Spol;

            //Potrebno je da se u listu uloga trenutnog studenta prenesu sve uloge koje su oznacene (cheked) u kontroli clb;

            for (int i = 0; i < clbUlogeStudenta.Items.Count; i++)//Prolazimo kroz sve checkbox-ove;
            {
                var uloga=clbUlogeStudenta.Items[i] as Uloga;//Gledamo svaki checkbox kao ulogu;

                if(student.Uloge.ToList().Contains(uloga))//Ukoliko ta trenutna uloga postoji u ulogama studenta;
                    clbUlogeStudenta.SetItemChecked(i,true);//Oznaci je u kontroli kao oznacenu (checked);
            }
        }

        private void GenerisiLozinku()
        {
            txtLozinka.Text = Generator.GenerisLozinku();
        }

        private void GeneriBrojIndeksa()
        {
            //IB210158
            txtIndeks.Text = $"IB{((DateTime.Now.Year - 2000) * 10000) + db.Studenti.Count() + 1}";                                            
        }

        private void UcitajGodineStudija()
        {
            cmbGodinaStudija.DataSource = InMemoryDB.GodineStudija;
            cmbGodinaStudija.ValueMember = "Id";
            cmbGodinaStudija.DisplayMember = "Opis";
        }

        private void btnUcitajSliku_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var putanja = openFileDialog1.FileName;
                pbSlika.Image = Image.FromFile(putanja);
                txtPutanja.Text = putanja;
            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {

            if (ValidirajUnos())
            {
                student.Ime = txtIme.Text;
                student.Prezime = txtPrezime.Text;
                student.DatumRodjenja = dtpDatumRodjenja.Value;
                student.Email = txtEmail.Text;
                student.Lozinka = txtLozinka.Text;
                student.Aktivan = cbAktivan.Checked;
                student.GodinaStudija = int.Parse(cmbGodinaStudija.SelectedValue.ToString());
                student.Indeks = txtIndeks.Text;
                student.Slika = ImageHelper.FromImageToByte(pbSlika.Image);
                student.Spol = cmbSpolovi.SelectedItem as Spol;

                //Potrebno je da oznacene uloge dodijelimo u listu uloga studentu:
                student.Uloge=clbUlogeStudenta.CheckedItems.Cast<Uloga>().ToList();//Sve oznacene checkbox-ove castamo kao Uloga objekte i pretvorimo u listu;

                string poruka = Poruke.StudentUspjesnoModifikovan;
                if (student.Id == 0)
                {
                    //student.Id = InMemoryDB.Korisnici.Count + 1;
                    //InMemoryDB.Studenti.Add(student);
                    db.Studenti.Add(student);
                    poruka = Poruke.StudentUspjesnoDodat;
                }
                else
                    db.Entry(student).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                MessageBox.Show(poruka, "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }

        private bool ValidirajUnos()
        {
            return Validator.ValidirajKontrolu(txtIme, err, Poruke.ObaveznaVrijednost)
                && Validator.ValidirajKontrolu(txtPrezime, err, Poruke.ObaveznaVrijednost)
                && Validator.ValidirajKontrolu(cmbSpolovi, err, Poruke.ObaveznaVrijednost)
                && Validator.ValidirajKontrolu(txtIndeks, err, Poruke.ObaveznaVrijednost)
                && Validator.ValidirajKontrolu(txtEmail, err, Poruke.ObaveznaVrijednost)
                && Validator.ValidirajKontrolu(txtLozinka, err, Poruke.ObaveznaVrijednost)
                && Validator.ValidirajKontrolu(cmbGodinaStudija, err, Poruke.ObaveznaVrijednost)
                && Validator.ValidirajKontrolu(pbSlika, err, Poruke.ObaveznaVrijednost);


        }

        private void txtIme_TextChanged(object sender, EventArgs e)
        {
            GenerisiEmail();
        }

        private void GenerisiEmail()
        {
            txtEmail.Text = $"{txtIme.Text.ToLower()}.{txtPrezime.Text.ToLower()}@edu.fit.ba";
        }

        private void txtPrezime_TextChanged(object sender, EventArgs e)
        {
            GenerisiEmail();
        }
    }
}
