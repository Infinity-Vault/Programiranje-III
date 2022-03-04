using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharpIntroWinForms.P10
{
    public class MboxHelper
    {
        const string greska = "Greška";
        public static void PrikaziGresku(Exception ex)
        {
            MessageBox.Show($"{ex.Message}\n{ex.InnerException?.Message}", 
                greska,
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
    
}
