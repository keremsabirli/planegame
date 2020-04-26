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
using System.Collections.Generic;

namespace ProjectGame
{
    class Bullet : GameObject
    {
        public Bullet(int X,int Y)
        {
            Image = Image.FromFile("bullet.png");
            Speed = 1;
            this.X = X;
            this.Y = Y;
        }
        public override void Draw(Graphics g)
        {
            g.DrawImage(Image, X, Y, 10, 10);
        }

        public override void Move(KeyEventArgs k)
        {

        }
        public void Move()
        {
            Y -= 3;
        }
        public static void DoesItHit(List<Enemy> enemies,List<Bullet> bullets)
        {
            foreach (Enemy enemy in enemies)
            {
                foreach (Bullet bullet in bullets)
                {
                    for (int i = 0; i < 64; i++)
                    {
                        if (bullet.X == enemy.X + i && bullet.Y < enemy.Y)
                        {
                            enemy.Y = 1000;
                            bullet.Y = 1000;
                        }
                    }
                }
            }
        }
    }
}
