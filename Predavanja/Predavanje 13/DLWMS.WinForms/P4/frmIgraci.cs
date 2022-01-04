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
    public partial class frmIgraci : Form
    {
        public frmIgraci()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            var igrac1 = txtIgrac1.Text;
            var igrac2 = txtIgrac2.Text;

            if (igrac1 != "" && igrac2 != "")
            {
                var xo = new frmXO(igrac1, igrac2);
                this.Hide();
                xo.ShowDialog();
                this.Show();
                //var _xo = new frmXO();
                //_xo.Igrac1 = igrac1;
                //_xo.Igrac2 = igrac2;
                //_xo.Show();
             }
        }
    }
}
