using System;
using System.Collections.Generic;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Enemy> colide = new List<Enemy>();
            Player player = new Player(5,5);
            Game game = new Game(10, 10, 5);
            string command = string.Empty;
            while (command != "exit") {
                Console.WriteLine($"Enemy's coordinates:");
                foreach (var enemy in game.enemys)
                {
                    if (player.Colide(enemy))
                    {
                        colide.Add(enemy);
                    }
                    Console.WriteLine($"enemy: {enemy.Coordinates};  colide={player.Colide(enemy)};  hp={enemy.health}; alive={enemy.isalive()}");
                }
                Console.WriteLine($"\nyou are at {player.Coordinates}\nyour action(attack, up, down, left, right):");
                command = Console.ReadLine();
                if (command == "attack")
                {
                    foreach (var enemy in colide)
                    {
                        player.attack(enemy);
                        Console.WriteLine("you hitted enemy");
                    }
                }
                else
                {
                    player.Move(command);
                }



            }
            
    
        }
    }
}
