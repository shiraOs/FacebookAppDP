using System;
using System.Windows.Forms;

// Access modifatior to all the classes and the methods //

namespace C20_Ex02_Shira_311119002_Yair_305789596
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);
            Application.Run(new FormApp());
        }
    }
}
