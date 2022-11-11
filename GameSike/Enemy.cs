using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    class Enemy : GameObject
    {
        public Enemy(int x, int y)
        {
            this.x = x;
            this.y = y;
            this.health = 50;
            this.damage = 10;
            this.alive = true;

        }

    }
}
