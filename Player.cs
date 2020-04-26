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
    class Player : GameObject
    {
        public Player()
        {
            X = 250;
            Y = 495;
            Image = Image.FromFile("player.png");
            Speed = 7;
        }

        public override void  Draw(Graphics g)
        {
            g.DrawImage(Image, X, Y, 64, 64);
        }
        public override void Move(KeyEventArgs k)
        {
            if (k.KeyCode == Keys.A)
            {
                X -= Speed;
            }
            if (k.KeyCode == Keys.D)
            {
                X += Speed;
            }        
        }
        public static void LeftToRight(Player player)
        {
            if (player.X < -64)
                player.X = 800;
            if (player.X > 800)
                player.X = -64;
        }
    }
}
