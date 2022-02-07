using DLWMS.WinForms.DB;
using DLWMS.WinForms.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.IBBrojIndeksa
{
    public partial class frmStudentiSlike : Form
    {
        private KonekcijaNaBazu _db = DLWMSdb.Baza;
        private Student student;
        private int index = 0;
        public frmStudentiSlike()
        {
            InitializeComponent();
        }
        public frmStudentiSlike(Student noviStudent)
        {
            InitializeComponent();
            student = noviStudent;
        }

        private void frmStudentiSlike_Load(object sender, EventArgs e)
        {
            student.UcitajSlike();
            UcitajPregled();
        }
        private void btnDodaj_Click(object sender, EventArgs e)
        {
           //if(openFileDialog1.ShowDialog()==DialogResult.OK)
           //{
           //    pcTrenutna.Image = Image.FromFile(openFileDialog1.FileName);
           //}
        
            var noviStudentSlika = new StudentSlike()
            {
                Student=student,
                Slika=ImageHelper.FromImageToByte(pcTrenutna.Image),
                Opis=textBox1.Text,
                DatumDodavanja=DateTime.Now
            };
           

          
            _db.StudentiSlike.Add(noviStudentSlika);
            _db.SaveChanges();

            student.UcitajSlike();
            UcitajPregled();

            textBox1.Text = string.Empty;
            pcTrenutna.Image = null;

        }

        private void pcTrenutna_DoubleClick(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                pcTrenutna.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
        public void UcitajPregled()
        {
            if(index>=0 && index<student.studentSlike.Count)
            {

            pictureBox2.Image = ImageHelper.FromByteToImage(student.studentSlike[index].Slika);
            lblRedniBroj.Text = $"Slika {index + 1}/{student.studentSlike.Count}";
            lblOpisTrenutno.Text = student.studentSlike[index].Opis;
            lblDatum.Text = student.studentSlike[index].DatumDodavanja.ToString();
            }
                
        }

        private void btnLijevo_Click(object sender, EventArgs e)
        {
            if(index!=0)
            {
                index--;

            }
            UcitajPregled();
        }

        private void btnDesno_Click(object sender, EventArgs e)
        {
             if(index!=student.studentSlike.Count-1)
            {
                index++;
            }
            UcitajPregled();
        }

    }
}
