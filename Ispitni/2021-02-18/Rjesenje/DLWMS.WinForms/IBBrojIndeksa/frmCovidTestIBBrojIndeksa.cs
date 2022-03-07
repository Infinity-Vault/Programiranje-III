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
using DLWMS.WinForms.Izvjestaji;

namespace DLWMS.WinForms.IBBrojIndeksa
{
    public partial class frmCovidTestIBBrojIndeksa : Form
    {
        private KonekcijaNaBazu _db = DLWMSdb.Baza;
        public frmCovidTestIBBrojIndeksa()
        {
            InitializeComponent();
            cmbStudent.DataSource = _db.Studenti.ToList();
           
            UcitajTestove();

        }

        private void frmCovidTestIBBrojIndeksa_Load(object sender, EventArgs e)
        {
           // cmbStudent.DataSource = _db.Studenti.ToList();
            dgvTest.AutoGenerateColumns = false;
           // UcitajTestove();
        }

        private void UcitajTestove(List<StudentiCovidTestovi> lista = null)
        {
            if (lista==null || lista.Count==0)
            {
                dgvTest.DataSource = _db.StudentiCovidTestovi.ToList();
                lblBrojTestova.Text = $"Broj testova: {_db.StudentiCovidTestovi.ToList().Count.ToString()}";
            }
            else
            {
                dgvTest.DataSource = lista;
                lblBrojTestova.Text = $"Broj testova: {lista.Count}";

            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                Student izabrani=cmbStudent.SelectedItem as Student;
                foreach (StudentiCovidTestovi test in _db.StudentiCovidTestovi.ToList())
                {
                    if (izabrani==test.Student && test.Datum==dtpDatumTestiranja.Value)
                    {
                        if (izabrani==test.Student && test.Datum.Day==dtpDatumTestiranja.Value.Day)
                        {
                            MessageBox.Show("Za isti datum je dodan test", "Nije moguce dodati", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
               
                StudentiCovidTestovi noviTest = new StudentiCovidTestovi()
                {
                    Datum = dtpDatumTestiranja.Value,
                    NalazDostavljen = cbNalaz.Checked,
                    Rezultat = cmbRezultatTesta.Text,
                    Student = cmbStudent.SelectedItem as Student
                };
                _db.StudentiCovidTestovi.Add(noviTest);
               _db.SaveChanges();
               UcitajTestove();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Exception thrown", MessageBoxButtons.OK);
            }
                
        }

        private async void btnGenerisi_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtGenerisi.Text);
            Random rnd = new Random(Guid.NewGuid().GetHashCode());

            Action a = () =>
            {
                Generisi(n, rnd);
            };
            await Task.Run(a);
            UcitajTestove();
        }
        private Student GetRandomStudent(Random rnd)
        {
            var studentList = _db.Studenti.ToList();
            int randomNumber = rnd.Next(1, studentList.Count);
            foreach (Student student in studentList)
            {
                if (student.Id == randomNumber)
                {
                    return student;
                }
            }

            return studentList[0];
        }
        private void Generisi(int generateCount, Random rnd)
        {
            for (int i = 0; i < generateCount; i++)
            {
                try
                {

                    StudentiCovidTestovi newCovidTest = new StudentiCovidTestovi()
                    {
                        Student = GetRandomStudent(rnd),
                        Datum = DateTime.Now,
                        NalazDostavljen = Convert.ToBoolean(rnd.Next(0, 2)),
                        Rezultat = (string)cmbRezultatTesta.Items[rnd.Next(0, 2)],
                    };
                    _db.StudentiCovidTestovi.Add(newCovidTest);
                    _db.SaveChanges();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Exception thrown", MessageBoxButtons.OK);
                    return;
                }
            }
        }

        private void btnTestove_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Da li zelite obrisati sve testove", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {

                    _db.StudentiCovidTestovi.RemoveRange(_db.StudentiCovidTestovi.ToList());
                    _db.SaveChanges();

                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Exception thrown", MessageBoxButtons.OK);
                return;
            }

            UcitajTestove();
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            Form izvjestaj = new frmIzvjestaji(_db.StudentiCovidTestovi.ToList());
            Hide();
            izvjestaj.ShowDialog();
            Show();
        }
    }
}
