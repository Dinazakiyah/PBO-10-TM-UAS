using System;
using System.Windows.Forms;
using PBO_10_TM;

namespace PBO_10_TM
{
    internal static class Program
    {
        /// <summary>
        /// Titik masuk utama untuk aplikasi.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware); // untuk resolusi tinggi
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1()); // Ganti dengan form utama kamu
        }
    }
}
