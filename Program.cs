/* Sakarya Üniversitesi
 * Bilgisayar Mühendisliği
 * 2-C Grubu
 * Nesneye Dayalı Programlama Dersi
 * Proje Ödevi
 * 
 * İsim:Kerem Sabırlı
 * Numara:g161210001
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectGame
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
            Application.Run(new AnaPencere(800,600));
        }
    }
}
