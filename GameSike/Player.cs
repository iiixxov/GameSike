
using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    class Player : GameObject
    {
        public Player(int x, int y)
        {
            this.x = x;
            this.y = y;
            this.health = 100;
            this.damage = 20;
            this.alive = true;

        }
       
    }
}
