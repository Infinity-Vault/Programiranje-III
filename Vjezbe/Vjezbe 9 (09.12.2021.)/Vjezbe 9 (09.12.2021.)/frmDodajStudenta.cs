using DataBase;
using Klase;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Vjezbe_9__09._12._2021._
{
    public partial class frmDodajStudenta : Form
    {
        public frmDodajStudenta()
        {
            InitializeComponent();
            cmbGodina.DataSource=new List<int>() { 1,2,3,4};//Popunimo dati comboBox sa data;
        }

        //Metoda gdje cemo da dodamo studenta:
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            var student=new Student()
            {
                Id=InMemoryDB.Studenti.Count+1,//Povecamo za jedan ID;
                Ime=txtBoxIme.Text,
                Prezime=txtBoxPrezime.Text,
                Godina=(int)cmbGodina.SelectedValue//Posto nam je Godina int, vrsimo cast tipa object u integer;
            };
            InMemoryDB.Studenti.Add(student);
            MessageBox.Show("Uspjesno dodan student!");
            this.DialogResult=DialogResult.OK;
            this.Close();//Zatvorimo form;
        }
    }
}
