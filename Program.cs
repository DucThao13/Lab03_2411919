using System;
using System.Windows.Forms;
using ChuDe3_ThaoTacTapTin.Forms;

namespace ChuDe3_ThaoTacTapTin
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
            Application.Run(new frmSinhVien());
        }
    }
}
