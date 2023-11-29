using System;
using System.Windows.Forms;

namespace Odin
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
            //if (System.DateTime.Now < Convert.ToDateTime("06/07/2019"))
            Application.Run(new Main());
        }
    }
}
