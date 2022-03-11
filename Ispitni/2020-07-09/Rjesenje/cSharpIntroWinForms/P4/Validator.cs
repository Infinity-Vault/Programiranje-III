using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharpIntroWinForms
{
    class Validator
    {
        public const string porObaveznaVrijednost = "Obavezna vrijednost!";

        public static bool ObaveznoPolje(Control control, ErrorProvider err, string poruka)
        {
            bool validno = true;
            
            if (control is TextBox && string.IsNullOrEmpty((control as TextBox).Text))
                validno = false;

            else if (control is ComboBox && (control as ComboBox).SelectedIndex == -1)
                validno = false;

            if (!validno)
            {
                err.SetError(control, poruka);
                return false;
            }

            err.Clear();
            return true;
        }
        //public static bool ObaveznoPolje(ComboBox comboBox, ErrorProvider err, string poruka)
        //{
        //    if (comboBox.SelectedIndex == -1)
        //    {
        //        err.SetError(comboBox, poruka);
        //        return false;
        //    }
        //    err.Clear();
        //    return true;
        //}
    }
}
