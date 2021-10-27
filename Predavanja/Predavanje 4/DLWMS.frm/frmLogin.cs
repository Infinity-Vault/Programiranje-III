using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.frm
{
    public partial class frmLogin : Form
    {
        //Rijec partial oznacava da u ovom namespace postoji jos definicija ove klase;

        //Dflt ctor:
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //Logika gdje trebamo da pokrenemo igru:

            if (txtBoxPrvi.Text != "" && txtBoxDrugi.Text !="")//Ako su unesena imena neprazna;
            {
                var xoIgra = new frmXO(txtBoxPrvi.Text,txtBoxDrugi.Text);//Posaljemo imena xo igri;
                xoIgra.ShowDialog();//Prikazemo (pokrenemo) formu;
                //Sama metoda Show() prikaze formu;
                //Dok metoda ShowDialog() pokrene formu ali ne  da nikavu interakciju sa drugim  formama dok se ona
                //ne zatvori;
                //Close() zatvori formu;
                this.Close();//Kad se izadje iz xo dialoskog okvira, Login forma ce se zatvoriti;
            }
        }
    }
}
