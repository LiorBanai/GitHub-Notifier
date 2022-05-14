using System;
using System.Windows.Forms;

namespace GitHubNotifier
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetCompatibleTextRenderingDefault(true);
#if NETCOREAPP3_0_OR_GREATER || NET
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
#endif
            Application.EnableVisualStyles();
           
            Application.Run(new MainForm());
        }
    }
}
