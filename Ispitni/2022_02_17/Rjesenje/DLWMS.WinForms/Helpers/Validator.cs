using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.P5
{
    public class Validator
    {
        public static bool ValidirajKontrolu(Control kontrola, ErrorProvider err, string poruka)
        {
            bool valid = true;
            if (kontrola is TextBox && string.IsNullOrWhiteSpace(kontrola.Text))
                valid = false;
            else if (kontrola is ComboBox && (kontrola as ComboBox).SelectedIndex < 0)
                valid = false;
            else if (kontrola is PictureBox && (kontrola as PictureBox).Image == null)
                valid = false;

            if (valid == false) {  
                err.SetError(kontrola, poruka);
                return false;
            }
            err.Clear();
            return true;
        }
    }
}
