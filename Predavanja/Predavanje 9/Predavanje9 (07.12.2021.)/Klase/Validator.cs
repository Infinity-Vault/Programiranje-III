using System.Windows.Forms;

namespace Klase
{
    internal class Validator
    {
        public static bool Validate(Control kontrola, ErrorProvider error, string errMsg)
        {
            var validan=true;

            if(kontrola is TextBox && string.IsNullOrWhiteSpace((kontrola as TextBox).Text))
                validan=false;
            if(kontrola is PictureBox && (kontrola as PictureBox).Image==null)
                validan=false;
            if(kontrola is ComboBox && (kontrola as ComboBox).SelectedIndex<0)
                validan=false;

            if (!validan)
            {
                error.SetError(kontrola, errMsg);
                return false;
            }

            error.Clear();
            return true;
        }
    }
}
