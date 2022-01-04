using DLWMS.WinForms.P6;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form startna = new frmGlavna(); //P7.frmStudenti();//Postavimo da se frmGlavna prva otvara;                 
            Application.Run(startna);
        }
    }
}
