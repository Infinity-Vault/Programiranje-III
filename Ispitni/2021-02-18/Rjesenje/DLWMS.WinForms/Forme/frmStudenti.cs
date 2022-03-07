using DLWMS.WinForms.Entiteti;
using DLWMS.WinForms.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DLWMS.WinForms.IBBrojIndeksa;

namespace DLWMS.WinForms.Forme
{
    public partial class frmStudenti : Form
    {
        KonekcijaNaBazu _baza = DLWMSdb.Baza; 

        public frmStudenti()
        {
            InitializeComponent();
            dgvStudenti.AutoGenerateColumns = false;
            foreach (var s in _baza.Studenti.ToList())
            {
                s.UcitajPredmete();
            }
        }

        private void frmStudenti_Load(object sender, EventArgs e)
        {
            UcitajPodatkeOStudentima();
        }

       private void UcitajPodatkeOStudentima(List<Student> studenti = null)
       {
           List<Student> listaStudenata = _baza.Studenti.ToList();
           dgvStudenti.DataSource = studenti ?? _baza.Studenti.ToList();

           if (studenti==null)
           {
               lblBrojStudenata.Text = $"Broj studenata: {listaStudenata.Count}";
               lblProsjecnaOcjena.Text = $"Prosjecna ocjena: {ProsjecnaOcjena(listaStudenata)}";
           }
           else
           {
               lblBrojStudenata.Text = $"Broj studenata: {listaStudenata.Count}";
               lblProsjecnaOcjena.Text = $"Prosjecna ocjena: {ProsjecnaOcjena(listaStudenata)}";
            }
       }

       private float ProsjecnaOcjena(List<Student> students)
       {
           float rezultat = 0.0f;
           float brojac = 0;

           foreach (Student s in students)
           {
               foreach (PolozeniPredmet p in s.PolozeniPredmeti)
               {
                   rezultat += p.Ocjena;
                   brojac++;
               }
           }

           if (students.Count==0)
           {
               return 0.0f;
           }

           return rezultat / brojac;
       }
        private void PrikaziFormu(Form form)
        {
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void cmbPoredjenje_SelectedIndexChanged(object sender, EventArgs e)
        {
            Trazi();
        }

        private void Trazi()
        {
            List<Student> traziStudente = new List<Student>();
            foreach (var student in _baza.Studenti.ToList())
            {
                foreach (var p in student.PolozeniPredmeti)
                {
                    if (p.DatumPolaganja>=dtpOd.Value && p.DatumPolaganja<=dtpDo.Value && !traziStudente.Contains(student))
                    {
                        switch (cmbPoredjenje.Text)
                        {
                            case "=":
                                if (p.Ocjena==int.Parse(cmbOcjena.Text))
                                {
                                    traziStudente.Add(student);
                                }
                                break;
                            case ">":
                                if (p.Ocjena>int.Parse(cmbOcjena.Text))
                                {
                                    traziStudente.Add(student);
                                }
                                break;
                            case ">=":
                                if (p.Ocjena>=int.Parse(cmbOcjena.Text))
                                {
                                    traziStudente.Add(student);
                                }
                                break;
                            case "<":
                                if (p.Ocjena<int.Parse(cmbOcjena.Text))
                                {
                                    traziStudente.Add(student);
                                }
                                break;
                            case "<=":
                                if (p.Ocjena<=int.Parse(cmbOcjena.Text))
                                {
                                    traziStudente.Add(student);
                                }
                                break;
                        }
                    }
                }
            }
            UcitajPodatkeOStudentima(traziStudente);
        }

        private void btnCovid_Click(object sender, EventArgs e)
        {
            Form covid = new frmCovidTestIBBrojIndeksa();
            Hide();
            covid.ShowDialog();
            Show();
        }

        /*   private void dgvStudenti_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
           }*/

    }
}
