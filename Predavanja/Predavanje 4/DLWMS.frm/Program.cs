using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.frm
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form login = new frmLogin();//Kreiranje login forme odakle ce poceti program;
            Application.Run(login);//Takodje smo mogli Run(new frmLogin);
        }
    }
}
