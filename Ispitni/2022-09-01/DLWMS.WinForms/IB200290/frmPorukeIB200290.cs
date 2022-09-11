using DLWMS.WinForms.DB;
using DLWMS.WinForms.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.EntitySql;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DLWMS.WinForms.Helpers;

namespace DLWMS.WinForms.IB200290
{
    public partial class frmPorukeIB200290 : Form
    {
        KonekcijaNaBazu bp = DLWMSdb.Baza;
        private Student odabraniStudent;

        public frmPorukeIB200290()
        {
            InitializeComponent();
        }

        public frmPorukeIB200290(Student odabraniStudent) : this()
        {
            this.odabraniStudent = odabraniStudent;
        }
        private void UcitajPodatke()
        {
            dataGridView1.DataSource = bp.StudentiPoruke.Where(x => x.Student.Id == odabraniStudent.Id).ToList();
            this.Text = $"Broj poruka: {bp.StudentiPoruke.Where(x => x.Student.Id == odabraniStudent.Id).Count()}";
        }

        private void frmPorukeIB200290_Load(object sender, EventArgs e)
        {
            lblStudent.Text = odabraniStudent.ImePrezime;
            cbPredmet.DataSource = bp.Predmeti.ToList();
            UcitajPodatke();
        }

        private void btnNovaPoruka_Click(object sender, EventArgs e)
        {
            var novaPorukaForma = new frmNovaPorukaIB200290(odabraniStudent);
            Hide();
            novaPorukaForma.ShowDialog();
            Show();
            UcitajPodatke();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var odabranaPoruka = dataGridView1.SelectedRows[0].DataBoundItem as StudentPoruka;
            if(e.ColumnIndex == 4)
            {
                var prikazanPoruka = MessageBox.Show("Da li ste sigurni da zelite obrisati odabranu poruku?", "Brisanje poruke", MessageBoxButtons.YesNo);
                if (prikazanPoruka == DialogResult.Yes)
                {
                    bp.StudentiPoruke.Remove(odabranaPoruka);
                    bp.SaveChanges();
                    MessageBox.Show("Uspjesno ste obrisali poruku!");
                }
            }
            UcitajPodatke();
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            var formaIzvjestaja = new frmIzvjestaj(odabraniStudent);
            Hide();
            formaIzvjestaja.ShowDialog();
            Show();
        }

        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            byte[] slika;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                slika = ImageHelper.FromImageToByte(Image.FromFile(openFileDialog.FileName));
            }
            else
            {
                return;
            }

            var brojPoruka = int.Parse(txtBrojPoruka.Text);
            var odabraniPredmet = cbPredmet.SelectedItem as Predmet;

            for (int i = 0; i < brojPoruka; i++)
            {
                var log = "";
                var sadrzaj = $"Neki_sadrzaj_{i + 1}";

                await Task.Run(() =>
                {
                    try
                    {
                        var novaPoruka = new StudentPoruka()
                        {
                            Student = odabraniStudent,
                            Predmet = odabraniPredmet,
                            Sadrzaj = sadrzaj,
                            VrijemeKreiranja = DateTime.Now,
                            Slika = slika,
                        };

                        bp.StudentiPoruke.Add(novaPoruka);

                        log = $"{novaPoruka.VrijemeKreiranja} -> generisana poruka za {odabraniStudent} na predmetu {odabraniPredmet}";

                        Thread.Sleep(500);
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show($"{exception.Message}{Environment.NewLine}{exception.InnerException}", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        throw;
                    }
                }); 

                txtInfo.Text += log + Environment.NewLine;
            }

            try
            { 
                await bp.SaveChangesAsync();
            }
            catch (Exception exception)
            {
                MessageBox.Show($"{exception.Message}{Environment.NewLine}{exception.InnerException}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

            MessageBox.Show($"Uspjesno dodano {brojPoruka} poruka!", "Uspjeh", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            UcitajPodatke();
        }
    }
}