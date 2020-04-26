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
using System.Windows.Forms;

namespace ProjectGame
{
    class AnaPencere:Form
    {
        public AnaPencere(int width,int height)
        {
            DoubleBuffered = true;
            BackColor = System.Drawing.Color.LightSkyBlue;
            Height = height;
            Width = width;
            Paint += AnaPencere_Paint;
            KeyDown += AnaPencere_KeyDown;
            player = new Player();
            moveTimer = new Timer();
            spawnTimer = new Timer();
            spawnTimer.Start();
            moveTimer.Start();
            moveTimer.Tick += MoveTimer_Tick;
            spawnTimer.Tick += SpawnTimer_Tick;
            spawnTimer.Interval = 2000;
            moveTimer.Interval = 16;
            enemies = new List<Enemy>();
            bullets = new List<Bullet>();
        }

        private void SpawnTimer_Tick(object sender, EventArgs e)
        {
            enemies.Add(new Enemy());
        }

        private void MoveTimer_Tick(object sender, EventArgs e)
        {
            Player.LeftToRight(player);
            Bullet.DoesItHit(enemies, bullets);
            Enemy.IsGameOver(enemies);
            foreach (Enemy item in enemies)
            {
                if (item.Y > 650)
                {
                    enemies.Remove(item);
                    break;
                }
            }
            foreach (Bullet item in bullets)
            {
                if (item.Y > 650)
                {
                    bullets.Remove(item);
                    break;
                }
            }
            foreach (Enemy item in enemies)
            {
                item.Move();
            }
            foreach (Bullet item in bullets)
            {
                item.Move();
            }

            Invalidate();
        }

        private void AnaPencere_KeyDown(object sender, KeyEventArgs e)
        {
            
            player.Move(e);
            if (e.KeyCode == Keys.Escape)
            {
                moveTimer.Stop();
            }
            if (e.KeyCode == Keys.Enter)
            {
                moveTimer.Start();
            }
            if (e.KeyCode == Keys.Space)
            {
                bullets.Add(new Bullet(player.X+28, player.Y - 5));
            }
        }

        private void AnaPencere_Paint(object sender, PaintEventArgs e)
        {
            player.Draw(e.Graphics);
            foreach (Enemy item in enemies)
            {
                item.Draw(e.Graphics);
            }
           foreach (Bullet item in bullets)
            {
                item.Draw(e.Graphics);
            }
        }
        Player player;
        Timer moveTimer;
        Timer spawnTimer;
        List<Enemy> enemies;
        List<Bullet> bullets;
    }
}
