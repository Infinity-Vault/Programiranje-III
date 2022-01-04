using DLWMS.WinForms.P7;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms
{
    public partial class frmGlavna : Form
    {
        public frmGlavna()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.Text = "Nastava iz Programiranja III";
        }

        //Metoda koja prikaze dobrodoslicu:
        private void dobroDosliToolStripMenuItem_Click(object sender, EventArgs e) =>MessageBox.Show("Dobro dosli na nasu aplikaciju!", "DOBRODOSLI",MessageBoxButtons.OK,MessageBoxIcon.Information);

        private void studentiToolStripMenuItem_Click(object sender, EventArgs e)=>PrikaziFormu(new frmStudenti());//Pokrenemo formu za prikaz studenata;
        private void noviStudentToolStripMenuItem_Click(object sender, EventArgs e)=>PrikaziFormu(new frmNoviStudent());//Prikazemo formu za kreiranje novog studenta;

        //Metoda koja ima za zadatak da prikaze formu:
        private void PrikaziFormu(Form forma)
        {
            forma.MdiParent=this;//Postavimo da je proslijedjena forma dijete od frmGlavna, tj. da je frmGlavna roditelj njoj;
            forma.Show();
        }

        private void napustiAplikacijuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Zelite li kompletno izaci iz aplikacije?","Upozorenje",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)//Pitamo korisnika za saglasnost;
                Application.Exit();//Komanda koja terminira sve procese i zatvori kompletan program;
            else
                return;//Samo prekini metodu;
        }
    }

    public partial class Student
    {
        public string ImePrezime { get; set; }
    }
}
