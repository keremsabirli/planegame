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
using System.Drawing;
using System.Windows.Forms;

namespace ProjectGame
{
    class Enemy : GameObject
    {

        Random rand = new Random(Guid.NewGuid().GetHashCode());

        public Enemy()
        {
            Image = Image.FromFile("enemy.png");
            X = rand.Next(0, 700);
            Y = rand.Next(0,50);
            Speed = 1;
        }
        public override void Draw(Graphics g)
        {
            g.DrawImage(Image, X, Y, 64, 64);
            
        }

        public override void Move(KeyEventArgs k)
        {

        }
        public void Move()
        {
            Y += Speed;
        }
        public static void IsGameOver(List<Enemy> enemies)
        {
            foreach (Enemy enemy in enemies)
            {
                if (enemy.Y > 560 && enemy.Y < 800)
                {
                    Application.Exit();
                }
            }
        }
    }
}
