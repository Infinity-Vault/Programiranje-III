using DLWMS.WinForms.DB;
using DLWMS.WinForms.Helpers;
using DLWMS.WinForms.P5;
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
    public partial class frmSeminarskiIBBrojIndeksa : Form
    {
        private StudentiPredmeti SP;
        private KonekcijaNaBazu _db = DLWMSdb.Baza;
        private int index = 0;
        public frmSeminarskiIBBrojIndeksa()
        {
            InitializeComponent();
        }
        public frmSeminarskiIBBrojIndeksa(StudentiPredmeti noviStudent)
        {
            InitializeComponent();
            SP = noviStudent;
        }
        private void UcitajSlike()
        {
            SP.UcitajSeminarske();
            
            if(SP.listaSeminarski.Count==0)
            {
                return;
            }
            lblStranica.Text = $"Stranica {index + 1}/{SP.listaSeminarski.Count}";
            pbSlika.Image = ImageHelper.FromByteToImage(SP.listaSeminarski[index].Slika);
            lblDatum.Text = SP.listaSeminarski[index].DatumDodavanja.ToString();
            lblOpis.Text = SP.listaSeminarski[index].Opis;
        }

        private void frmSeminarskiIBBrojIndeksa_Load(object sender, EventArgs e)
        {
            lblStudent.Text = SP.Student.ToString();
            lblPredmet.Text = SP.Predmet.ToString();
            UcitajSlike();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (!Validator.ValidirajKontrolu(pbDodaj, errorProvider1, "Morate unijeti sliku") || !Validator.ValidirajKontrolu(txtDodajOpis, errorProvider1, "Morate unijeti upis"))
            {
                return;
            }
            var newSeminarski = new PredmetSeminarski()
            {
                Student = SP.Student,
                Predmet=SP.Predmet,
                Slika=ImageHelper.FromImageToByte(pbDodaj.Image),
                Opis=txtDodajOpis.Text,
                DatumDodavanja=DateTime.Now,
            };
            _db.PredmetSeminarski.Add(newSeminarski);
            _db.SaveChanges();

            pbDodaj.Image = null;
            txtDodajOpis.Text = string.Empty;

            UcitajSlike();
        }

        private void pbDodaj_Click(object sender, EventArgs e)
        {
            if(fileDialog.ShowDialog()==DialogResult.OK)
            {
                pbDodaj.Image = Image.FromFile(fileDialog.FileName);
            }
        }

        private void btnLijevo_Click(object sender, EventArgs e)
        {
            if(index!=0)
            {
                index--;
            }
            UcitajSlike();
        }

        private void btnDesno_Click(object sender, EventArgs e)
        {
            if(index!=SP.listaSeminarski.Count-1)
            {
                index++;
            }
            UcitajSlike();
        }
    }
}
