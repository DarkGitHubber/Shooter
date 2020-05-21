using System;
using Shooter.Core;

namespace Shooter.ConsoleUi
{
    class Program
    {
        static void Main(string[] args)
        {

           var player1 = new Player();
           player1.Name = "Rambo";
           player1.BuyWeapon(new Glock47());

           var player2 = new Player();
           player2.Name = "Bond";
           player2.BuyWeapon(new Glock47());


            while (player1.IsAlive || player2.IsAlive )
            {

                player1.TakeDamage(player2.Shoot());
                Console.WriteLine($"{player2.Name} shoots {player1.Name}");
                Console.WriteLine($"{player1.Name} Health is {player1.Health}");

                if (!player1.IsAlive || !player2.IsAlive)
                    break;

               
                player2.TakeDamage(player1.Shoot()); 
                Console.WriteLine($"{player1.Name} shoots {player2.Name}");
                Console.WriteLine($"{player2.Name} Health is {player2.Health}");

            }




            Console.ReadLine();

        }
    }
}
