using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AzmanSys
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
        //    (new MainForm()).Show(); opens main form, or replace code with (new Loginform()).Show(); to open with login form
            (new Loginform()).Show();
            Application.Run();
         
        }
    }
}
