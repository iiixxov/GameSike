using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public abstract class GameObject
    {
        public int x;
        public int y;
        public int health;
        public int damage;
        public bool alive;


        public string Coordinates => $"[{x}, {y}]";


        public void Move(string direction)
        {
            switch (direction)
            {
                case "left":
                    x++;
                    break;
                case "right":
                    x--;
                    break;
                case "up":
                    y++;
                    break;
                case "down":
                    y--;
                    break;
            }
        }
        public bool isalive(){
            return this.health > 0;
        }
        public bool Colide(GameObject gameObject) {
            return gameObject.x == this.x && gameObject.y ==this.y;
        }
        public void attack(GameObject gameObject)
        {
            gameObject.health -= this.damage;
            gameObject.isalive();

                    

        }
    }
}
