using System;
using System.Windows.Forms;
using EnqueteSPA.Entities;

namespace EnqueteSPA
{
    static class Program
    {

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Database db = Database.getInstance();
            Login login = new Login();
            Application.Run(login);
            if (login.Authenticated)
                Application.Run(new MainApp(login.login));
        }

    }
}
