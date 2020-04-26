/* Sakarya Üniversitesi
 * Bilgisayar Mühendisliği
 * 2-C Grubu
 * Nesneye Dayalı Programlama Dersi
 * Proje Ödevi
 * 
 * İsim:Kerem Sabırlı
 * Numara:g161210001
 */
using System.Drawing;
using System.Windows.Forms;

namespace ProjectGame
{
    abstract class GameObject
    {
        public abstract void Draw(Graphics g);
        public abstract void Move(KeyEventArgs k);
        public Image Image { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Speed { get; set; }
    }
}
