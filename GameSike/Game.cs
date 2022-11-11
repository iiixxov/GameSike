using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    class Game
    {
        Random rnd = new Random();
        public List<Enemy> enemys = new List<Enemy>();


        public Game(int x, int y, int enemyColvo = 3)
        {
            for (int i = 0; i < enemyColvo; i++)
            {
                int enemy_x = rnd.Next(0, x);
                int enemy_y = rnd.Next(0, y);
                enemys.Add(new Enemy(enemy_x, enemy_y));

            }
          
        }
       

    }
}
